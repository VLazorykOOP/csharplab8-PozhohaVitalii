using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsLab8
{
    public partial class Task4 : Form
    {
        string selectedFile;
        string selectedFile2;
        public Task4()
        {
            InitializeComponent();
        }

        private void ProcessTextFile(string outputFile, int[] numbers)
        {
            // Відкриваємо файл для запису у бінарний режим
            using (BinaryWriter writer = new BinaryWriter(File.Open(outputFile, FileMode.Create)))
            {
                // Записуємо всі додатні числа у файл
                foreach (int number in numbers)
                {
                    if (number > 0)
                    {
                        writer.Write(number);
                    }
                }
            }

            // Виводимо вміст файлу на екран
            using (BinaryReader reader = new BinaryReader(File.Open(outputFile, FileMode.Open)))
            {
                while (reader.BaseStream.Position < reader.BaseStream.Length)
                {
                    int number = reader.ReadInt32();
                    richTextBox2.Text = richTextBox2.Text + number.ToString()+" ";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string inputFile = selectedFile;
            string outputFile = selectedFile2;
            string text = richTextBox1.Text;
            List<int> numbers = new List<int>();
            if ( !selectedFile2.Equals(""))
            {
               
                if (inputFile==null)
                {
                    // Розділяємо текст на окремі рядки
                    string[] lines = text.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                    // Створюємо список для зберігання чисел


                    // Парсимо числа з кожного рядка
                    foreach (string line in lines)
                    {
                        // Розділяємо рядок на слова (числа)
                        string[] words = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                        // Парсимо числа та додаємо їх до списку
                        foreach (string word in words)
                        {
                            if (int.TryParse(word, out int number))
                            {
                                numbers.Add(number);
                            }
                        }
                    }
                }
                else {
                    using (BinaryReader reader = new BinaryReader(File.Open(outputFile, FileMode.Open)))
                    {
                        while (reader.BaseStream.Position < reader.BaseStream.Length)
                        {
                            int number = reader.ReadInt32();
                            numbers.Add(number);
                        }
                    }
                
                }
                // Викликаємо метод обробки текстового файлу
                ProcessTextFile(outputFile, numbers.ToArray());

            }
            else
            {
                MessageBox.Show("Please select both files first");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Встановлюємо властивості OpenFileDialog
            openFileDialog.InitialDirectory = "C:\\Users\\verto\\Desktop\\CHNU\\Cours_3\\Sem_2\\Cross_Platform_Programing\\Lab8"; // Початкова тека
            openFileDialog.Filter = "Text files (*.bin)|*.bin|All files (*.*)|*.*"; // Фільтр файлів
            openFileDialog.FilterIndex = 1; // Індекс вибраного фільтру (тут - *.txt)
            openFileDialog.RestoreDirectory = true; // Повертати теку після закриття діалогового вікна

            // Викликаємо метод ShowDialog для показу діалогового вікна
            DialogResult result = openFileDialog.ShowDialog();

            // Перевіряємо, чи користувач вибрав файл, і чи він натиснув кнопку "OK"
            if (result == DialogResult.OK)
            {
                // Отримуємо шлях до вибраного файлу і відображаємо його у відповідному полі
                selectedFile = openFileDialog.FileName;
                textBox1.Text = selectedFile;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create a new instance of SaveFileDialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            // Set the properties of SaveFileDialog
            saveFileDialog.InitialDirectory = "C:\\Users\\verto\\Desktop\\CHNU\\Cours_3\\Sem_2\\Cross_Platform_Programing\\Lab8"; // Initial directory
            saveFileDialog.Filter = "Text files (*.bin)|*.bin|All files (*.*)|*.*"; // File filter
            saveFileDialog.FilterIndex = 1; // Selected filter index (here - *.txt)
            saveFileDialog.RestoreDirectory = true; // Restore the directory after closing the dialog

            // Show the dialog and check if the user clicked "OK"
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                // Get the selected file path and display it in the appropriate textbox
                selectedFile2 = saveFileDialog.FileName;
                textBox2.Text = selectedFile2;
            }
        }

    }
}

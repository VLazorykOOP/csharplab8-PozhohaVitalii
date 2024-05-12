using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsLab8
{
    public partial class Task2 : Form
    {
        string selectedFile;
        string selectedFile2;
        public Task2()
        {
            InitializeComponent();
        }

        private void Task2_Load(object sender, EventArgs e)
        {

        }
        private void ProcessTextFile(string inputFile, string outputFile)
        {
            // Читаємо вміст вхідного файлу
            string inputText = File.ReadAllText(inputFile);

            // Знаходимо всі слова, які починаються з голосної літери української мови
            string pattern = @"\b[АаЕеЄєИиІіЇїОоУуЮюЯя]\w*\b";
            MatchCollection matches = Regex.Matches(inputText, pattern);

            // Підраховуємо кількість знайдених слів
            int count = matches.Count;

            // Видаляємо слова, які починаються з голосної літери
            string modifiedText = Regex.Replace(inputText, pattern, string.Empty);
            richTextBox1.Text = modifiedText;
            // Записуємо змінений текст у новий файл
            File.WriteAllText(outputFile, modifiedText);

            MessageBox.Show($"Знайдено та видалено {count} слів, які починаються з голосної літери української мови.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!selectedFile.Equals("") && !selectedFile2.Equals(""))
            {
                string inputFile = selectedFile;
                string outputFile = selectedFile2;
                string replaceString = richTextBox1.Text;

                // Викликаємо метод обробки текстового файлу
                ProcessTextFile(inputFile, outputFile);
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
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"; // Фільтр файлів
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
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"; // File filter
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

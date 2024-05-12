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
    public partial class Task5 : Form
    {
        public Task5()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string pathV = @"C:\\temp\\Pozhoha_Vitalii1";
            string pathV1 = @"C:\\temp\\Pozhoha_Vitalii2";

            // Перевіряємо, чи папка не існує, перш ніж створювати її
            if (!Directory.Exists(pathV))
            {
                // Створення нової папки
                Directory.CreateDirectory(pathV);
               richTextBox1.Text = richTextBox1.Text + "\n" + pathV + "     Створенно";
            }
            else
            {

                MessageBox.Show("Папка " + Path.GetFileName(pathV) + " вже існує");
            }

            if (!Directory.Exists(pathV1))
            {
                // Створення нової папки
                Directory.CreateDirectory(pathV1);
                richTextBox1.Text = richTextBox1.Text +"\n"+ pathV1 + "     Створенно";
            }
            else
            {
                MessageBox.Show("Папка " + Path.GetFileName(pathV1) + " вже існує");
            }
            string filePath1 = Path.Combine(pathV, "t1.txt");

            string filePath2 = Path.Combine(pathV, "t2.txt");
           
            File.WriteAllText(filePath1, "<Шевченко Степан Іванович, 2001> року народження, місце проживання <м. Суми>");
            richTextBox1.Text = richTextBox1.Text + "\n" + filePath1 + "     Створенно і записано текст";

            File.WriteAllText(filePath2, "<Комар Сергій Федорович, 2000 > року народження, місце проживання <м. Київ>");
            richTextBox1.Text = richTextBox1.Text + "\n" + filePath2 + "     Створенно і записано текст";

            string filePath3 = Path.Combine(pathV1, "t3.txt");

            string text1 = File.ReadAllText(filePath1);
            string text2 = File.ReadAllText(filePath2);
            File.WriteAllText(filePath3, text1 + Environment.NewLine + text2);
            richTextBox1.Text = richTextBox1.Text + "\n" + filePath3 + "     Успішно створений та заповнений текстом.";

            FileInfo fileInfo1 = new FileInfo(filePath1);
            FileInfo fileInfo2 = new FileInfo(filePath2);
            FileInfo fileInfo3 = new FileInfo(filePath3);

            // Виводимо технічну інформацію про кожен файл

            richTextBox1.Text = richTextBox1.Text + "\n\n" + "     Розміри.";
            richTextBox1.Text = richTextBox1.Text + "\n" + Path.GetFileName(filePath1) + "  " + fileInfo1.Length;
            richTextBox1.Text = richTextBox1.Text + "\n" + Path.GetFileName(filePath2) + "  " + fileInfo2.Length;
            richTextBox1.Text = richTextBox1.Text + "\n" + Path.GetFileName(filePath3) + "  " + fileInfo3.Length;

            richTextBox1.Text = richTextBox1.Text + "\n\n" + "     Дати створення.";
            richTextBox1.Text = richTextBox1.Text + "\n" + Path.GetFileName(filePath1) + "  " + fileInfo1.CreationTime;
            richTextBox1.Text = richTextBox1.Text + "\n" + Path.GetFileName(filePath2) + "  " + fileInfo2.CreationTime;
            richTextBox1.Text = richTextBox1.Text + "\n" + Path.GetFileName(filePath3) + "  " + fileInfo3.CreationTime;

            richTextBox1.Text = richTextBox1.Text + "\n\n" + "     Дата останйої зміни.";
            richTextBox1.Text = richTextBox1.Text + "\n" + Path.GetFileName(filePath1) + "  " + fileInfo1.LastWriteTime;
            richTextBox1.Text = richTextBox1.Text + "\n" + Path.GetFileName(filePath2) + "  " + fileInfo2.LastWriteTime;
            richTextBox1.Text = richTextBox1.Text + "\n" + Path.GetFileName(filePath3) + "  " + fileInfo3.LastWriteTime;

            try
            {
                // Переміщення файлу t2.txt у папку Папка2
                File.Move(filePath2, Path.Combine(pathV1, "t2.txt"));
                MessageBox.Show("Файл t2.txt успішно переміщений у папку" + Path.GetFileName(pathV1));
                richTextBox1.Text = richTextBox1.Text + "\n" + " Файл t2.txt успішно переміщений у папку "+ Path.GetFileName(pathV1);

                // Копіювання файлу t1.txt в папку Папка2
                File.Copy(filePath1, Path.Combine(pathV1, "t1.txt"), true);
                MessageBox.Show("Файл t1.txt успішно скопійований у папку " + Path.GetFileName(pathV1));
                richTextBox1.Text = richTextBox1.Text + "\n" + " Файл t1.txt успішно скопійований у папку" + Path.GetFileName(pathV1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка: transfer/copy " + ex.Message);
            }

            string newDirectory = @"C:\\temp\\ALL";

            try
            {
                // Перейменування папки Папка2 в ALL
                Directory.Move(pathV1, newDirectory);
                MessageBox.Show("Папка " + Path.GetFileName(pathV1) + " успішно перейменована в ALL.");
                richTextBox1.Text = richTextBox1.Text + "\n" + "Папка " + Path.GetFileName(pathV1) + " успішно перейменована в " + Path.GetFileName(newDirectory);
            
                // Видалення папки ALL
                Directory.Delete(pathV,true);
                MessageBox.Show("Папка " + Path.GetFileName(pathV) + " успішно видалена");
                richTextBox1.Text = richTextBox1.Text + "\n" + "Папка " + Path.GetFileName(pathV) + " успішно видалена";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка: " + ex.Message);
            }
            DirectoryInfo AllInfo= new DirectoryInfo(newDirectory);
            richTextBox1.Text = richTextBox1.Text + "\n\n" + "Інформація про папку All";
            

        }
    }
}

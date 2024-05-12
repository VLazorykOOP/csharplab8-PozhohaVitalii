namespace WinFormsLab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task1 newForm1 = new Task1();
            newForm1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Task2 newForm1 = new Task2();
            newForm1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Task3 newForm1 = new Task3();
            newForm1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Task4 newForm1 = new Task4();
            newForm1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Task5 newForm1 = new Task5();
            newForm1.ShowDialog();
        }
    }
}
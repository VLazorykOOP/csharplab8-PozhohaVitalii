namespace WinFormsLab8
{
    partial class Task4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(573, 155);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(202, 27);
            textBox2.TabIndex = 23;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(26, 155);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(191, 27);
            textBox1.TabIndex = 22;
            // 
            // button3
            // 
            button3.Location = new Point(335, 62);
            button3.Name = "button3";
            button3.Size = new Size(136, 120);
            button3.TabIndex = 21;
            button3.Text = "Process";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(639, 17);
            button2.Name = "button2";
            button2.Size = new Size(136, 115);
            button2.TabIndex = 20;
            button2.Text = "Output File";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(26, 17);
            button1.Name = "button1";
            button1.Size = new Size(136, 115);
            button1.TabIndex = 19;
            button1.Text = "Input File";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(26, 214);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(253, 195);
            richTextBox1.TabIndex = 18;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(522, 214);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(253, 195);
            richTextBox2.TabIndex = 24;
            richTextBox2.Text = "";
            // 
            // Task4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Name = "Task4";
            Text = "Task4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private TextBox textBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
    }
}
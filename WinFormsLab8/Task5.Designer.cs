namespace WinFormsLab8
{
    partial class Task5
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
            button3 = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(289, 294);
            button3.Name = "button3";
            button3.Size = new Size(246, 120);
            button3.TabIndex = 26;
            button3.Text = "Transfer";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(282, 67);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(267, 195);
            richTextBox1.TabIndex = 27;
            richTextBox1.Text = "";
            // 
            // Task5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(button3);
            Name = "Task5";
            Text = "Task5";
            ResumeLayout(false);
        }

        #endregion

        private Button button3;
        private RichTextBox richTextBox1;
    }
}
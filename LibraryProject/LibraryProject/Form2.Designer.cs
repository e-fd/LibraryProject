using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LibraryProject
{
    partial class AddBook
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            comboBox2 = new ComboBox();
            label5 = new Label();
            label7 = new Label();
            textBox4 = new TextBox();
            label8 = new Label();
            textBox5 = new TextBox();
            label9 = new Label();
            textBox6 = new TextBox();
            label10 = new Label();
            textBox7 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(505, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 1;
            label1.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 3;
            label2.Text = "Автор";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 85);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(505, 27);
            textBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 115);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 5;
            label3.Text = "Жанр";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(11, 138);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(506, 28);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 438);
            label4.Name = "label4";
            label4.Size = new Size(130, 20);
            label4.TabIndex = 8;
            label4.Text = "Аннотация книги";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(13, 461);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(505, 120);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(424, 587);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(324, 587);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 11;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(11, 192);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(506, 28);
            comboBox2.TabIndex = 13;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 169);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 12;
            label5.Text = "Тип";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 223);
            label7.Name = "label7";
            label7.Size = new Size(185, 20);
            label7.TabIndex = 17;
            label7.Text = "Количество экземпляров";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 246);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(505, 27);
            textBox4.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 276);
            label8.Name = "label8";
            label8.Size = new Size(95, 20);
            label8.TabIndex = 19;
            label8.Text = "Год издания";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(12, 300);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(505, 27);
            textBox5.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 330);
            label9.Name = "label9";
            label9.Size = new Size(103, 20);
            label9.TabIndex = 21;
            label9.Text = "Издательство";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(13, 354);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(505, 27);
            textBox6.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 384);
            label10.Name = "label10";
            label10.Size = new Size(41, 20);
            label10.TabIndex = 23;
            label10.Text = "ISBN";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(13, 408);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(505, 27);
            textBox7.TabIndex = 22;
            // 
            // AddBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 622);
            Controls.Add(label10);
            Controls.Add(textBox7);
            Controls.Add(label9);
            Controls.Add(textBox6);
            Controls.Add(label8);
            Controls.Add(textBox5);
            Controls.Add(label7);
            Controls.Add(textBox4);
            Controls.Add(comboBox2);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddBook";
            Text = "Добавление новой книги";
            Load += AddBook_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private RichTextBox richTextBox1;
        private Button button1;
        private Button button2;
        private ComboBox comboBox2;
        private Label label5;
        private Label label7;
        private TextBox textBox4;
        private Label label8;
        private TextBox textBox5;
        private Label label9;
        private TextBox textBox6;
        private Label label10;
        private TextBox textBox7;
    }
}
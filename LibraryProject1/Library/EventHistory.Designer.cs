﻿namespace Library
{
    partial class EventHistory
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
            textBox3 = new TextBox();
            label3 = new Label();
            button3 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            listBox1 = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(16, 150);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(443, 27);
            textBox3.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 127);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 28;
            label3.Text = "Номер телефона";
            // 
            // button3
            // 
            button3.Location = new Point(225, 218);
            button3.Name = "button3";
            button3.Size = new Size(234, 29);
            button3.TabIndex = 27;
            button3.Text = "Очистить параметры поиска";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(225, 183);
            button2.Name = "button2";
            button2.Size = new Size(234, 29);
            button2.TabIndex = 26;
            button2.Text = "Поиск";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(16, 97);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(443, 27);
            textBox2.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 74);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 24;
            label2.Text = "Логин";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(16, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(443, 27);
            textBox1.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 21);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 22;
            label1.Text = "ФИО";
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(465, 24);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(480, 624);
            listBox1.TabIndex = 21;
            // 
            // button1
            // 
            button1.Location = new Point(349, 476);
            button1.Name = "button1";
            button1.Size = new Size(92, 28);
            button1.TabIndex = 20;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // EventHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 669);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Name = "EventHistory";
            Text = "История пользования";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private Label label3;
        private Button button3;
        private Button button2;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private ListBox listBox1;
        private Button button1;
    }
}
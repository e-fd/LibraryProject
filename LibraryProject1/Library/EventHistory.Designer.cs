namespace Library
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventHistory));
            textBox3 = new TextBox();
            label3 = new Label();
            button3 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            listView1 = new ListView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            panel1 = new Panel();
            label5 = new Label();
            panel2 = new Panel();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            button4 = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            textBox4 = new TextBox();
            textBox7 = new TextBox();
            label11 = new Label();
            label12 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            button5 = new Button();
            imageList1 = new ImageList(components);
            button6 = new Button();
            contextMenuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(0, 149);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(443, 27);
            textBox3.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 126);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 28;
            label3.Text = "Номер телефона";
            // 
            // button3
            // 
            button3.Location = new Point(222, 452);
            button3.Name = "button3";
            button3.Size = new Size(234, 29);
            button3.TabIndex = 27;
            button3.Text = "Очистить параметры поиска";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(222, 417);
            button2.Name = "button2";
            button2.Size = new Size(234, 29);
            button2.TabIndex = 26;
            button2.Text = "Поиск";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(0, 96);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(443, 27);
            textBox2.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 73);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 24;
            label2.Text = "Логин";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(443, 27);
            textBox1.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 20);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 22;
            label1.Text = "ФИО";
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.ContextMenuStrip = contextMenuStrip1;
            listView1.GridLines = true;
            listView1.Location = new Point(465, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(484, 802);
            listView1.TabIndex = 30;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(148, 76);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(147, 24);
            toolStripMenuItem1.Text = "Добавить";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(147, 24);
            toolStripMenuItem2.Text = "Изменить";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(147, 24);
            toolStripMenuItem3.Text = "Удалить";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 31;
            label4.Text = "Дата";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(16, 32);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(443, 27);
            dateTimePicker1.TabIndex = 32;
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(16, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(443, 179);
            panel1.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(178, 20);
            label5.TabIndex = 0;
            label5.Text = "Поиск по пользователю";
            // 
            // panel2
            // 
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(13, 376);
            panel2.MaximumSize = new Size(443, 249);
            panel2.MinimumSize = new Size(443, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(443, 35);
            panel2.TabIndex = 38;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(0, 59);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(443, 28);
            comboBox2.TabIndex = 16;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(0, 112);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(443, 28);
            comboBox1.TabIndex = 15;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(0, 218);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(443, 27);
            textBox6.TabIndex = 14;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(0, 165);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(443, 27);
            textBox5.TabIndex = 14;
            // 
            // button4
            // 
            button4.Location = new Point(3, 4);
            button4.Name = "button4";
            button4.Size = new Size(152, 29);
            button4.TabIndex = 8;
            button4.Text = "Ешё параметры...";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(0, 195);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 13;
            label6.Text = "ISBN";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(0, 142);
            label7.Name = "label7";
            label7.Size = new Size(95, 20);
            label7.TabIndex = 13;
            label7.Text = "Год издания";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(0, 89);
            label8.Name = "label8";
            label8.Size = new Size(35, 20);
            label8.TabIndex = 13;
            label8.Text = "Тип";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(0, 36);
            label9.Name = "label9";
            label9.Size = new Size(48, 20);
            label9.TabIndex = 13;
            label9.Text = "Жанр";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 267);
            label10.Name = "label10";
            label10.Size = new Size(77, 20);
            label10.TabIndex = 34;
            label10.Text = "Название";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(16, 290);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(440, 27);
            textBox4.TabIndex = 35;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(16, 343);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(440, 27);
            textBox7.TabIndex = 37;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(16, 320);
            label11.Name = "label11";
            label11.Size = new Size(51, 20);
            label11.TabIndex = 36;
            label11.Text = "Автор";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(16, 247);
            label12.Name = "label12";
            label12.Size = new Size(117, 20);
            label12.TabIndex = 39;
            label12.Text = "Поиск по книге";
            // 
            // timer1
            // 
            timer1.Interval = 15;
            timer1.Tick += timer1_Tick;
            // 
            // button5
            // 
            button5.ImageIndex = 0;
            button5.ImageList = imageList1;
            button5.Location = new Point(174, 417);
            button5.Name = "button5";
            button5.Size = new Size(42, 42);
            button5.TabIndex = 40;
            button5.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "update.png");
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button6.Location = new Point(16, 784);
            button6.Name = "button6";
            button6.Size = new Size(152, 29);
            button6.TabIndex = 41;
            button6.Text = "Обратно в Меню";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // EventHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 820);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(label12);
            Controls.Add(panel2);
            Controls.Add(label10);
            Controls.Add(textBox4);
            Controls.Add(textBox7);
            Controls.Add(label11);
            Controls.Add(panel1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(listView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EventHistory";
            Text = "История пользования";
            WindowState = FormWindowState.Maximized;
            contextMenuStrip1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private ListView listView1;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Panel panel1;
        private Label label5;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox textBox6;
        private TextBox textBox5;
        private Button button4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox textBox4;
        private TextBox textBox7;
        private Label label11;
        private Label label12;
        private System.Windows.Forms.Timer timer1;
        private Button button5;
        private ImageList imageList1;
        public Panel panel2;
        private Button button6;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
    }
}
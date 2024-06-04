//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library
{
    partial class Books
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Books));
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            button4 = new Button();
            panel1 = new Panel();
            button5 = new Button();
            imageList1 = new ImageList(components);
            button3 = new Button();
            button2 = new Button();
            panel2 = new Panel();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            listView1 = new ListView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            button6 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 0);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 2;
            label1.Text = "Название";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(11, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(440, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(11, 76);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(440, 27);
            textBox2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 53);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 4;
            label2.Text = "Автор";
            // 
            // button4
            // 
            button4.Location = new Point(3, 4);
            button4.Name = "button4";
            button4.Size = new Size(143, 29);
            button4.TabIndex = 8;
            button4.Text = "Ещё параметры...";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-1, 12);
            panel1.MaximumSize = new Size(460, 476);
            panel1.MinimumSize = new Size(460, 265);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 265);
            panel1.TabIndex = 11;
            // 
            // button5
            // 
            button5.ImageIndex = 0;
            button5.ImageList = imageList1;
            button5.Location = new Point(409, 220);
            button5.Name = "button5";
            button5.Size = new Size(42, 42);
            button5.TabIndex = 13;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "update.png");
            // 
            // button3
            // 
            button3.Location = new Point(217, 185);
            button3.Name = "button3";
            button3.Size = new Size(234, 29);
            button3.TabIndex = 18;
            button3.Text = "Очистить параметры поиска";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(217, 150);
            button2.Name = "button2";
            button2.Size = new Size(234, 29);
            button2.TabIndex = 17;
            button2.Text = "Поиск";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(8, 109);
            panel2.MaximumSize = new Size(443, 249);
            panel2.MinimumSize = new Size(443, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(443, 35);
            panel2.TabIndex = 12;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(0, 195);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 13;
            label6.Text = "ISBN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 142);
            label5.Name = "label5";
            label5.Size = new Size(95, 20);
            label5.TabIndex = 13;
            label5.Text = "Год издания";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 89);
            label4.Name = "label4";
            label4.Size = new Size(35, 20);
            label4.TabIndex = 13;
            label4.Text = "Тип";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 36);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 13;
            label3.Text = "Жанр";
            // 
            // timer1
            // 
            timer1.Interval = 15;
            timer1.Tick += timer1_Tick;
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.ContextMenuStrip = contextMenuStrip1;
            listView1.GridLines = true;
            listView1.Location = new Point(465, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(463, 653);
            listView1.TabIndex = 12;
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
            // button6
            // 
            button6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button6.Location = new Point(12, 636);
            button6.Name = "button6";
            button6.Size = new Size(152, 29);
            button6.TabIndex = 42;
            button6.Text = "Обратно в Меню";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Books
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 677);
            Controls.Add(button6);
            Controls.Add(listView1);
            Controls.Add(panel1);
            Name = "Books";
            Text = "Книги";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Button button4;
        private Panel panel1;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private TextBox textBox6;
        private TextBox textBox5;
        private Label label6;
        private Label label5;
        private System.Windows.Forms.Timer timer1;
        private Button button3;
        private Button button2;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private ListView listView1;
        private Button button5;
        private ImageList imageList1;
        private Button button6;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
    }
}
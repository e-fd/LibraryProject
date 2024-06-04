namespace Library
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            button3 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            listView1 = new ListView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            button5 = new Button();
            imageList1 = new ImageList(components);
            button6 = new Button();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(221, 206);
            button3.Name = "button3";
            button3.Size = new Size(234, 29);
            button3.TabIndex = 16;
            button3.Text = "Очистить параметры поиска";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(221, 171);
            button2.Name = "button2";
            button2.Size = new Size(234, 29);
            button2.TabIndex = 15;
            button2.Text = "Поиск";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 85);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(443, 27);
            textBox2.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 13;
            label2.Text = "Логин";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(443, 27);
            textBox1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 11;
            label1.Text = "ФИО";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 138);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(443, 27);
            textBox3.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 115);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 18;
            label3.Text = "Номер телефона";
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.ContextMenuStrip = contextMenuStrip1;
            listView1.GridLines = true;
            listView1.Location = new Point(461, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(476, 651);
            listView1.TabIndex = 20;
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
            // button5
            // 
            button5.ImageIndex = 0;
            button5.ImageList = imageList1;
            button5.Location = new Point(413, 241);
            button5.Name = "button5";
            button5.Size = new Size(42, 42);
            button5.TabIndex = 21;
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
            // button6
            // 
            button6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button6.Location = new Point(12, 634);
            button6.Name = "button6";
            button6.Size = new Size(152, 29);
            button6.TabIndex = 42;
            button6.Text = "Обратно в Меню";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 675);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(listView1);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Users";
            Text = "Пользователи";
            WindowState = FormWindowState.Maximized;
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button3;
        private Button button2;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox3;
        private Label label3;
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
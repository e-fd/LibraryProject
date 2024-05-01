
using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;
using Font = System.Drawing.Font;

namespace LibraryProject
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            редактироватьToolStripMenuItem = new ToolStripMenuItem();
            добавитьКнигуToolStripMenuItem = new ToolStripMenuItem();
            редактироватьКнигуToolStripMenuItem = new ToolStripMenuItem();
            удалитьКнигуToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            toolStripStatusLabel4 = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            label1 = new Label();
            searchByTitle = new Button();
            searchByAuthor = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            searchByGenre = new Button();
            label3 = new Label();
            comboBox1 = new ComboBox();
            clearTextBox = new Button();
            chosenParameterSearch = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label13 = new Label();
            label12 = new Label();
            label10 = new Label();
            label9 = new Label();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            label15 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            label16 = new Label();
            label14 = new Label();
            label8 = new Label();
            tabControl1 = new TabControl();
            Books = new TabPage();
            button1 = new Button();
            label11 = new Label();
            comboBox2 = new ComboBox();
            User = new TabPage();
            tabPage1 = new TabPage();
            label17 = new Label();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tabControl1.SuspendLayout();
            Books.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, редактироватьToolStripMenuItem, оПрограммеToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(913, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьToolStripMenuItem, сохранитьToolStripMenuItem, выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 24);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(166, 26);
            открытьToolStripMenuItem.Text = "Открыть";
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(166, 26);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(166, 26);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // редактироватьToolStripMenuItem
            // 
            редактироватьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { добавитьКнигуToolStripMenuItem, редактироватьКнигуToolStripMenuItem, удалитьКнигуToolStripMenuItem });
            редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            редактироватьToolStripMenuItem.Size = new Size(125, 24);
            редактироватьToolStripMenuItem.Text = "Редактировать";
            // 
            // добавитьКнигуToolStripMenuItem
            // 
            добавитьКнигуToolStripMenuItem.Name = "добавитьКнигуToolStripMenuItem";
            добавитьКнигуToolStripMenuItem.Size = new Size(236, 26);
            добавитьКнигуToolStripMenuItem.Text = "Добавить книгу";
            добавитьКнигуToolStripMenuItem.Click += добавитьКнигуToolStripMenuItem_Click_1;
            // 
            // редактироватьКнигуToolStripMenuItem
            // 
            редактироватьКнигуToolStripMenuItem.Name = "редактироватьКнигуToolStripMenuItem";
            редактироватьКнигуToolStripMenuItem.Size = new Size(236, 26);
            редактироватьКнигуToolStripMenuItem.Text = "Редактировать книгу";
            редактироватьКнигуToolStripMenuItem.Click += редактироватьКнигуToolStripMenuItem_Click;
            // 
            // удалитьКнигуToolStripMenuItem
            // 
            удалитьКнигуToolStripMenuItem.Name = "удалитьКнигуToolStripMenuItem";
            удалитьКнигуToolStripMenuItem.Size = new Size(236, 26);
            удалитьКнигуToolStripMenuItem.Text = "Удалить книгу";
            удалитьКнигуToolStripMenuItem.Click += удалитьКнигуToolStripMenuItem_Click;
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(118, 24);
            оПрограммеToolStripMenuItem.Text = "О программе";
            оПрограммеToolStripMenuItem.Click += оПрограммеToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel3, toolStripStatusLabel4, toolStripStatusLabel1, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 777);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(913, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(92, 20);
            toolStripStatusLabel3.Text = "Элементов: ";
            // 
            // toolStripStatusLabel4
            // 
            toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            toolStripStatusLabel4.Size = new Size(25, 20);
            toolStripStatusLabel4.Text = " |  ";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(135, 20);
            toolStripStatusLabel1.Text = "Выбранная книга:";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(148, 20);
            toolStripStatusLabel2.Text = "Ничего не выбрано";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 18;
            listBox1.Items.AddRange(new object[] { " " });
            listBox1.Location = new Point(451, 9);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(424, 670);
            listBox1.TabIndex = 3;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(322, 24);
            textBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(6, 51);
            label1.Name = "label1";
            label1.Size = new Size(190, 18);
            label1.TabIndex = 5;
            label1.Text = "Введите фамилию автора";
            // 
            // searchByTitle
            // 
            searchByTitle.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchByTitle.Location = new Point(334, 22);
            searchByTitle.Name = "searchByTitle";
            searchByTitle.Size = new Size(110, 29);
            searchByTitle.TabIndex = 6;
            searchByTitle.Text = "Поиск";
            searchByTitle.UseVisualStyleBackColor = true;
            searchByTitle.Click += button1_Click;
            // 
            // searchByAuthor
            // 
            searchByAuthor.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchByAuthor.Location = new Point(334, 70);
            searchByAuthor.Name = "searchByAuthor";
            searchByAuthor.Size = new Size(110, 29);
            searchByAuthor.TabIndex = 9;
            searchByAuthor.Text = "Поиск";
            searchByAuthor.UseVisualStyleBackColor = true;
            searchByAuthor.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(186, 18);
            label2.TabIndex = 8;
            label2.Text = "Введите заголовок книги";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 72);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(322, 24);
            textBox2.TabIndex = 7;
            // 
            // searchByGenre
            // 
            searchByGenre.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchByGenre.Location = new Point(335, 118);
            searchByGenre.Name = "searchByGenre";
            searchByGenre.Size = new Size(110, 29);
            searchByGenre.TabIndex = 12;
            searchByGenre.Text = "Поиск";
            searchByGenre.UseVisualStyleBackColor = true;
            searchByGenre.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(3, 99);
            label3.Name = "label3";
            label3.Size = new Size(116, 18);
            label3.TabIndex = 11;
            label3.Text = "Выберите жанр";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(6, 120);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(323, 26);
            comboBox1.TabIndex = 13;
            // 
            // clearTextBox
            // 
            clearTextBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            clearTextBox.Location = new Point(208, 203);
            clearTextBox.Name = "clearTextBox";
            clearTextBox.Size = new Size(237, 29);
            clearTextBox.TabIndex = 14;
            clearTextBox.Text = "Очистить параметры поиска";
            clearTextBox.UseVisualStyleBackColor = true;
            clearTextBox.Click += clearTextBox_Click;
            // 
            // chosenParameterSearch
            // 
            chosenParameterSearch.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            chosenParameterSearch.Location = new Point(208, 238);
            chosenParameterSearch.Name = "chosenParameterSearch";
            chosenParameterSearch.Size = new Size(237, 29);
            chosenParameterSearch.TabIndex = 15;
            chosenParameterSearch.Text = "Поиск по всем параметрам";
            chosenParameterSearch.UseVisualStyleBackColor = true;
            chosenParameterSearch.Click += chosenParameterSearch_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.95146F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.04854F));
            tableLayoutPanel1.Controls.Add(label17, 1, 0);
            tableLayoutPanel1.Controls.Add(label13, 0, 6);
            tableLayoutPanel1.Controls.Add(label12, 0, 5);
            tableLayoutPanel1.Controls.Add(label10, 1, 2);
            tableLayoutPanel1.Controls.Add(label9, 1, 1);
            tableLayoutPanel1.Controls.Add(label5, 0, 1);
            tableLayoutPanel1.Controls.Add(label6, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 0);
            tableLayoutPanel1.Controls.Add(label15, 0, 7);
            tableLayoutPanel1.Controls.Add(textBox3, 1, 8);
            tableLayoutPanel1.Controls.Add(label7, 0, 8);
            tableLayoutPanel1.Controls.Add(label16, 0, 4);
            tableLayoutPanel1.Controls.Add(label14, 0, 3);
            tableLayoutPanel1.Location = new Point(6, 273);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(439, 406);
            tableLayoutPanel1.TabIndex = 16;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label13.Location = new Point(4, 147);
            label13.Name = "label13";
            label13.Size = new Size(146, 20);
            label13.TabIndex = 20;
            label13.Text = "Издательство";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label12.Location = new Point(4, 126);
            label12.Name = "label12";
            label12.Size = new Size(146, 20);
            label12.TabIndex = 8;
            label12.Text = "Год издания";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label10.Location = new Point(157, 43);
            label10.Name = "label10";
            label10.Size = new Size(278, 20);
            label10.TabIndex = 6;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label9.Location = new Point(157, 22);
            label9.Name = "label9";
            label9.Size = new Size(278, 20);
            label9.TabIndex = 5;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(4, 22);
            label5.Name = "label5";
            label5.Size = new Size(146, 20);
            label5.TabIndex = 1;
            label5.Text = "Автор";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(4, 43);
            label6.Name = "label6";
            label6.Size = new Size(146, 20);
            label6.TabIndex = 2;
            label6.Text = "Жанр";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(4, 1);
            label4.Name = "label4";
            label4.Size = new Size(146, 20);
            label4.TabIndex = 0;
            label4.Text = "Заголовок";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label15.Location = new Point(4, 168);
            label15.Name = "label15";
            label15.Size = new Size(146, 20);
            label15.TabIndex = 22;
            label15.Text = "ISBN";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox3.Location = new Point(157, 192);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.ScrollBars = ScrollBars.Both;
            textBox3.Size = new Size(278, 210);
            textBox3.TabIndex = 7;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(4, 189);
            label7.Name = "label7";
            label7.Padding = new Padding(0, 10, 0, 0);
            label7.Size = new Size(146, 30);
            label7.TabIndex = 3;
            label7.Text = "Аннотация";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label16.Location = new Point(4, 85);
            label16.Name = "label16";
            label16.Size = new Size(146, 40);
            label16.TabIndex = 23;
            label16.Text = "Количество экземпляров";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label14.Location = new Point(4, 64);
            label14.Name = "label14";
            label14.Size = new Size(146, 20);
            label14.TabIndex = 21;
            label14.Text = "Тип";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(168, 366);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 4;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(Books);
            tabControl1.Controls.Add(User);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(12, 31);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(889, 723);
            tabControl1.TabIndex = 17;
            // 
            // Books
            // 
            Books.Controls.Add(button1);
            Books.Controls.Add(label11);
            Books.Controls.Add(comboBox2);
            Books.Controls.Add(label2);
            Books.Controls.Add(listBox1);
            Books.Controls.Add(tableLayoutPanel1);
            Books.Controls.Add(textBox1);
            Books.Controls.Add(chosenParameterSearch);
            Books.Controls.Add(searchByTitle);
            Books.Controls.Add(label8);
            Books.Controls.Add(clearTextBox);
            Books.Controls.Add(label1);
            Books.Controls.Add(searchByGenre);
            Books.Controls.Add(comboBox1);
            Books.Controls.Add(textBox2);
            Books.Controls.Add(searchByAuthor);
            Books.Controls.Add(label3);
            Books.Location = new Point(4, 27);
            Books.Name = "Books";
            Books.Padding = new Padding(3);
            Books.Size = new Size(881, 692);
            Books.TabIndex = 0;
            Books.Text = "Книги";
            Books.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(335, 168);
            button1.Name = "button1";
            button1.Size = new Size(110, 29);
            button1.TabIndex = 19;
            button1.Text = "Поиск";
            button1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label11.Location = new Point(6, 149);
            label11.Name = "label11";
            label11.Size = new Size(104, 18);
            label11.TabIndex = 18;
            label11.Text = "Выберите тип";
            label11.TextAlign = ContentAlignment.TopCenter;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(6, 170);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(323, 26);
            comboBox2.TabIndex = 17;
            // 
            // User
            // 
            User.Location = new Point(4, 29);
            User.Name = "User";
            User.Padding = new Padding(3);
            User.Size = new Size(881, 690);
            User.TabIndex = 1;
            User.Text = "Читатель";
            User.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(881, 690);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label17.Location = new Point(157, 1);
            label17.Name = "label17";
            label17.Size = new Size(278, 20);
            label17.TabIndex = 24;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 803);
            Controls.Add(tabControl1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Информационная система библиотеки";
            WindowState = FormWindowState.Maximized;
            FormClosing += Form1_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            Books.ResumeLayout(false);
            Books.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void добавитьКнигуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьКнигуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьКнигуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьКнигуToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private ListBox listBox1;
        private TextBox textBox1;
        private Label label1;
        private Button searchByTitle;
        private Button searchByAuthor;
        private Label label2;
        private TextBox textBox2;
        private Button searchByGenre;
        private Label label3;
        private ComboBox comboBox1;
        private Button clearTextBox;
        private Button chosenParameterSearch;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox textBox3;
        private TabControl tabControl1;
        private TabPage Books;
        private TabPage User;
        private TabPage tabPage1;
        private Button button1;
        private Label label11;
        private ComboBox comboBox2;
        private Label label12;
        private Label label14;
        private Label label15;
        private Label label13;
        private Label label16;
        private Label label17;
    }
}

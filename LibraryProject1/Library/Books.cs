﻿using System.Data.SqlClient;

namespace Library
{
    public partial class Books : Form
    {
        SqlConnection string_con = new SqlConnection();
        SqlCommand sql_command = new SqlCommand();
        SqlDataReader reader;
        private bool isCollapsed;
        static string temp;
        public Books()
        {
            InitializeComponent();
            comboBox1.Items.Clear(); // очистка списка типов книг
            comboBox1.Items.Add("");                           // добавление типов книг
            comboBox1.Items.Add("Художественная литература");
            comboBox1.Items.Add("Документальная проза");
            comboBox1.Items.Add("Мемуарная литература");
            comboBox1.Items.Add("Научная и научно-популярная литература");
            comboBox1.Items.Add("Справочная литература");
            comboBox1.Items.Add("Учебная литература");
            comboBox1.SelectedIndex = 0;    // индекс изначально выбранного элемента
            comboBox2.Items.Clear(); // очистка списка жанров книг
            comboBox2.Items.Add("");                           // добавление жанров книг
            comboBox2.Items.Add("Роман-эпопея");               //
            comboBox2.Items.Add("Роман");                      //
            comboBox2.Items.Add("Повесть");                    //
            comboBox2.Items.Add("Рассказ");                    //
            comboBox2.Items.Add("Притча");                     //
            comboBox2.Items.Add("Лирическое стихотворение");   //
            comboBox2.Items.Add("Элегия");                     //
            comboBox2.Items.Add("Послание");                   //
            comboBox2.Items.Add("Эпиграмма");                  //
            comboBox2.Items.Add("Ода");                        //
            comboBox2.Items.Add("Сонет");                      //
            comboBox2.Items.Add("Комедия");                    //
            comboBox2.Items.Add("Трагедия");                   //
            comboBox2.Items.Add("Драма");                      //
            comboBox2.Items.Add("Поэма");                      //
            comboBox2.Items.Add("Баллада");                    //
            comboBox2.SelectedIndex = 0;    // индекс изначально выбранного элемента
            
            listView1.Columns.Clear();
            listView1.Columns.Add("№", 70);
            listView1.Columns.Add("Название", 140);             // добавление колонок в таблицу
            listView1.Columns.Add("Автор", 140);
            listView1.Columns.Add("Жанр", 140);
            listView1.Columns.Add("Тип", 140);
            listView1.Columns.Add("Год", 70);
            listView1.Columns.Add("Издатель", 140);
            listView1.Columns.Add("Количество", 100);
            listView1.Columns.Add("ISBN", 140);
            listView1.Columns.Add("Аннотация", 200);
            using (string_con = new SqlConnection("Server=X923;Database=LibraryProject1;Trusted_Connection=True;"))
            {
                string_con.Open();
                updateBookListView();
                string_con.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e) // доп параметры поиска
        {
            if (isCollapsed)
            {
                panel2.Height += 10;
                if (panel2.Size == panel2.MaximumSize)
                {
                    panel1.Size = panel1.MaximumSize;
                    timer1.Stop();
                    isCollapsed = false;
                }
                button2.Location = new Point(217, 360);
                button3.Location = new Point(217, 395);
                button5.Location = new Point(409, 430);
            }
            else
            {
                panel2.Height -= 10;
                if (panel2.Size == panel2.MinimumSize)
                {
                    panel1.Size = panel1.MinimumSize;
                    timer1.Stop();
                    isCollapsed = true;
                }
                button2.Location = new Point(217, 150);
                button3.Location = new Point(217, 185);
                button5.Location = new Point(409, 220);
            }
        }

        private void button4_Click(object sender, EventArgs e) // доп параметры поиска
        {
            timer1.Start();
        }

        private void button5_Click(object sender, EventArgs e) // обновление таблицы
        {
            listView1.Columns.Clear();
            listView1.Columns.Add("№", 70);
            listView1.Columns.Add("Название", 140);
            listView1.Columns.Add("Автор", 140);
            listView1.Columns.Add("Жанр", 140);
            listView1.Columns.Add("Тип", 140);
            listView1.Columns.Add("Год", 70);
            listView1.Columns.Add("Издатель", 140);
            listView1.Columns.Add("Количество", 100);
            listView1.Columns.Add("ISBN", 140);
            listView1.Columns.Add("Аннотация", 200);
            using (string_con = new SqlConnection("Server=X923;Database=LibraryProject1;Trusted_Connection=True;"))
            {
                string_con.Open();
                updateBookListView();
                string_con.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e) // обратно в меню
        {
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e) // добавление
        {
            AddBook form10 = new AddBook();
            DialogResult form10Closed = form10.ShowDialog();
            if (form10Closed != DialogResult.None)
            {
                using (string_con = new SqlConnection("Server=X923;Database=LibraryProject1;Trusted_Connection=True;"))
                {
                    string_con.Open();
                    updateBookListView();
                    string_con.Close();
                }
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e) // изменение
        {
            try
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                EditBook form11 = new EditBook(selectedItem.Text);
                DialogResult form11Closed = form11.ShowDialog();
                if (form11Closed != DialogResult.None)
                {
                    using (string_con = new SqlConnection("Server=X923;Database=LibraryProject1;Trusted_Connection=True;"))
                    {
                        string_con.Open();
                        updateBookListView();
                        string_con.Close();
                    }
                }
            }
            catch { }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e) // удаление
        {
            using (string_con = new SqlConnection("Server=X923;Database=LibraryProject1;Trusted_Connection=True;"))
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    ListViewItem selectedItem = listView1.SelectedItems[0];
                    using (sql_command = new SqlCommand($"select BookID from Books where BookID={selectedItem.Text}", string_con))
                    {
                        string_con.Open();
                        using (reader = sql_command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                temp = reader.GetString(0);
                            }
                        }
                        string_con.Close();
                    }
                    using (sql_command = new SqlCommand($"delete from EventHistory where Book_ID={temp}", string_con))
                    {
                        string_con.Open();
                        sql_command.ExecuteNonQuery();
                        string_con.Close();
                    }
                    using (sql_command = new SqlCommand($"delete from Books where BookID={temp}", string_con))
                    {
                        string_con.Open();
                        sql_command.ExecuteNonQuery();
                        string_con.Close();
                    }
                }
                string_con.Open();
                updateBookListView();
                string_con.Close();
            }
        }

        public void updateBookListView() // обновление таблицы книг
        {
            using (sql_command = new SqlCommand("select * from Books order by case when ISNUMERIC(BookID) = 1 then 0 else 1 end, case when isnumeric(BookID) = 1 then cast(BookID as int) else 0 end, BookID", string_con))
            {
                using (reader = sql_command.ExecuteReader())
                {
                    ListViewItem tmp;
                    listView1.Items.Clear();
                    while (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            tmp = listView1.Items.Add(reader[0].ToString());
                            for (int i = 1; i < 10; i++)
                            {
                                tmp.SubItems.Add(reader[i].ToString());
                            }
                        }
                        reader.NextResult();
                    }
                }
            }
            listView1.View = View.Details;
        }

        public void readQueryResult() // чтение результата запроса
        {
            using (reader = sql_command.ExecuteReader())
            {
                ListViewItem tmp;
                listView1.Items.Clear();
                while (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        tmp = listView1.Items.Add(reader[0].ToString());
                        for (int i = 1; i < 10; i++)
                        {
                            tmp.SubItems.Add(reader[i].ToString());
                        }
                    }
                    reader.NextResult();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) // поиск
        {
            using (string_con = new SqlConnection("Server=X923;Database=LibraryProject1;Trusted_Connection=True;"))
            {
                string_con.Open();
                if (textBox1.Text.Length > 0)
                {
                    using (sql_command = new SqlCommand($"select * from Books where cast (Title as nvarchar(100)) like '%{textBox1.Text}%' order by case when ISNUMERIC(BookID) = 1 then 0 else 1 end, case when isnumeric(BookID) = 1 then cast(BookID as int) else 0 end, BookID", string_con))
                    {
                        readQueryResult();
                    }
                }
                if (textBox2.Text.Length > 0)
                {
                    using (sql_command = new SqlCommand($"select * from Books where cast (Author as nvarchar(100)) like '%{textBox2.Text}%' order by case when ISNUMERIC(BookID) = 1 then 0 else 1 end, case when isnumeric(BookID) = 1 then cast(BookID as int) else 0 end, BookID", string_con))
                    {
                        readQueryResult();
                    }
                }
                if (comboBox1.Text.Length > 0)
                {
                    using (sql_command = new SqlCommand($"select * from Books where cast (Type as nvarchar(100)) = '{comboBox1.Text}' order by case when ISNUMERIC(BookID) = 1 then 0 else 1 end, case when isnumeric(BookID) = 1 then cast(BookID as int) else 0 end, BookID", string_con))
                    {
                        readQueryResult();
                    }
                }
                if (comboBox2.Text.Length > 0)
                {
                    using (sql_command = new SqlCommand($"select * from Books where cast (Genre as nvarchar(100)) = '{comboBox2.Text}' order by case when ISNUMERIC(BookID) = 1 then 0 else 1 end, case when isnumeric(BookID) = 1 then cast(BookID as int) else 0 end, BookID", string_con))
                    {
                        readQueryResult();
                    }
                }
                if (textBox5.Text.Length > 0)
                {
                    using (sql_command = new SqlCommand($"select * from Books where cast (Year as nvarchar(100)) = '{textBox5.Text}' order by case when ISNUMERIC(BookID) = 1 then 0 else 1 end, case when isnumeric(BookID) = 1 then cast(BookID as int) else 0 end, BookID", string_con))
                    {
                        readQueryResult();
                    }
                }
                if (textBox6.Text.Length > 0)
                {
                    using (sql_command = new SqlCommand($"select * from Books where cast (ISBN as nvarchar(100)) = '{textBox6.Text}' order by case when ISNUMERIC(BookID) = 1 then 0 else 1 end, case when isnumeric(BookID) = 1 then cast(BookID as int) else 0 end, BookID", string_con))
                    {
                        readQueryResult();
                    }
                }
                string_con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e) // очистка параметров поиска
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            using (string_con = new SqlConnection("Server=X923;Database=LibraryProject1;Trusted_Connection=True;"))
            {
                string_con.Open();
                updateBookListView();
                string_con.Close();
            }
        }
    }
}

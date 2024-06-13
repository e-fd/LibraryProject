using System.Data.SqlClient;

namespace Library
{
    public partial class EventHistory : Form
    {
        SqlConnection string_con = new SqlConnection();
        SqlCommand sql_command = new SqlCommand();
        SqlDataReader reader;
        private bool isCollapsed;
        static string temp;
        public EventHistory()
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
            dateTimePicker1.Value = dateTimePicker1.MinDate;
            listView1.Columns.Clear();
            listView1.Columns.Add("№", 60);
            listView1.Columns.Add("Название", 100);
            listView1.Columns.Add("Автор", 100);
            listView1.Columns.Add("ФИО", 140);
            listView1.Columns.Add("Логин", 100);
            listView1.Columns.Add("Номер телефона", 100);
            listView1.Columns.Add("Дата", 140);
            using (string_con = new SqlConnection("Server=X923;Database=LibraryProject1;Trusted_Connection=True;"))
            {
                string_con.Open();
                updateEventListView();
                string_con.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e) // доп параметры поиска
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e) // доп параметры поиска
        {
            if (isCollapsed)
            {
                panel2.Height += 10;
                if (panel2.Size == panel2.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
                button2.Location = new Point(222, 631);
                button3.Location = new Point(222, 666);
                button5.Location = new Point(174, 631);
            }
            else
            {
                panel2.Height -= 10;
                if (panel2.Size == panel2.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
                button2.Location = new Point(222, 417);
                button3.Location = new Point(222, 452);
                button5.Location = new Point(174, 417);
            }

        }

        private void button6_Click(object sender, EventArgs e) // обратно в меню
        {
            this.Close();
        }

        public void updateEventListView() // обновление таблицы событий
        {
            using (sql_command = new SqlCommand("select EventID, Title, Author, Name, Login, Phone, Date from EventHistory left join Books on EventHistory.Book_ID=Books.BookID left join Users on EventHistory.User_ID=Users.UserID order by case when ISNUMERIC(EventID) = 1 then 0 else 1 end, case when isnumeric(EventID) = 1 then cast(EventID as int) else 0 end, EventID", string_con))
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
                            for (int i = 1; i < 7; i++)
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
                        for (int i = 1; i < 7; i++)
                        {
                            tmp.SubItems.Add(reader[i].ToString());
                        }
                    }
                    reader.NextResult();
                }
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e) // добавление
        {
            AddEvent form9 = new AddEvent();
            DialogResult form9Closed = form9.ShowDialog();
            if (form9Closed != DialogResult.None)
            {
                using (string_con = new SqlConnection("Server=X923;Database=LibraryProject1;Trusted_Connection=True;"))
                {
                    string_con.Open();
                    updateEventListView();
                    string_con.Close();
                }
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e) // изменение
        {
            try
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                EditEvent form13 = new EditEvent(selectedItem.Text);
                DialogResult form13Closed = form13.ShowDialog();
                if (form13Closed != DialogResult.None)
                {
                    using (string_con = new SqlConnection("Server=X923;Database=LibraryProject1;Trusted_Connection=True;"))
                    {
                        string_con.Open();
                        updateEventListView();
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
                    /*int temp = listView1.SelectedItems[0].Index;
                    int temp = listView1.Items.IndexOf(listView1.SelectedItems[0]);
                    sql_command = new SqlCommand($"delete from EventHistory where EventID={temp + 1}", string_con);
                    string_con.Open();
                    sql_command.ExecuteNonQuery();
                    string_con.Close();
                    using (sql_command = new SqlCommand($"select EventID from EventHistory where EventID={selectedItem.Text}", string_con))
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
                    }*/
                    ListViewItem selectedItem = listView1.SelectedItems[0];
                    using (sql_command = new SqlCommand($"delete from EventHistory where Book_ID={selectedItem.Text}", string_con))
                    {
                        string_con.Open();
                        sql_command.ExecuteNonQuery();
                        string_con.Close();
                    }
                }
                string_con.Open();
                updateEventListView();
                string_con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e) // поиск
        {
            using (string_con = new SqlConnection("Server=X923;Database=LibraryProject1;Trusted_Connection=True;"))
            {
                string_con.Open();
                if (textBox1.Text.Length > 0)
                {
                    using (sql_command = new SqlCommand($"select EventID, Title, Author, Name, Login, Phone, Date from EventHistory left join Books on EventHistory.Book_ID=Books.BookID left join Users on EventHistory.User_ID=Users.UserID where cast (Name as nvarchar(100)) like '%{textBox1.Text}%' order by case when ISNUMERIC(EventID) = 1 then 0 else 1 end, case when isnumeric(EventID) = 1 then cast(EventID as int) else 0 end, EventID", string_con))
                    {
                        readQueryResult();
                    }
                }
                if (textBox2.Text.Length > 0)
                {
                    using (sql_command = new SqlCommand($"select EventID, Title, Author, Name, Login, Phone, Date from EventHistory left join Books on EventHistory.Book_ID=Books.BookID left join Users on EventHistory.User_ID=Users.UserID where cast (Login as nvarchar(100)) like '%{textBox2.Text}%' order by case when ISNUMERIC(EventID) = 1 then 0 else 1 end, case when isnumeric(EventID) = 1 then cast(EventID as int) else 0 end, EventID", string_con))
                    {
                        readQueryResult();
                    }
                }
                if (textBox3.Text.Length > 0)
                {
                    using (sql_command = new SqlCommand($"select EventID, Title, Author, Name, Login, Phone, Date from EventHistory left join Books on EventHistory.Book_ID=Books.BookID left join Users on EventHistory.User_ID=Users.UserID where cast (Phone as nvarchar(100)) = '{textBox3.Text}' order by case when ISNUMERIC(EventID) = 1 then 0 else 1 end, case when isnumeric(EventID) = 1 then cast(EventID as int) else 0 end, EventID", string_con))
                    {
                        readQueryResult();
                    }
                }
                if (textBox4.Text.Length > 0)
                {
                    using (sql_command = new SqlCommand($"select EventID, Title, Author, Name, Login, Phone, Date from EventHistory left join Books on EventHistory.Book_ID=Books.BookID left join Users on EventHistory.User_ID=Users.UserID where cast (Title as nvarchar(100)) like '%{textBox4.Text}%' order by case when ISNUMERIC(EventID) = 1 then 0 else 1 end, case when isnumeric(EventID) = 1 then cast(EventID as int) else 0 end, EventID", string_con))
                    {
                        readQueryResult();
                    }
                }
                if (textBox5.Text.Length > 0)
                {
                    using (sql_command = new SqlCommand($"select EventID, Title, Author, Name, Login, Phone, Date from EventHistory left join Books on EventHistory.Book_ID=Books.BookID left join Users on EventHistory.User_ID=Users.UserID where cast (Year as nvarchar(100)) = '{textBox5.Text}' order by case when ISNUMERIC(EventID) = 1 then 0 else 1 end, case when isnumeric(EventID) = 1 then cast(EventID as int) else 0 end, EventID", string_con))
                    {
                        readQueryResult();
                    }
                }
                if (textBox6.Text.Length > 0)
                {
                    using (sql_command = new SqlCommand($"select EventID, Title, Author, Name, Login, Phone, Date from EventHistory left join Books on EventHistory.Book_ID=Books.BookID left join Users on EventHistory.User_ID=Users.UserID where cast (ISBN as nvarchar(100)) = '{textBox6.Text}' order by case when ISNUMERIC(EventID) = 1 then 0 else 1 end, case when isnumeric(EventID) = 1 then cast(EventID as int) else 0 end, EventID", string_con))
                    {
                        readQueryResult();
                    }
                }
                if (textBox7.Text.Length > 0)
                {
                    using (sql_command = new SqlCommand($"select EventID, Title, Author, Name, Login, Phone, Date from EventHistory left join Books on EventHistory.Book_ID=Books.BookID left join Users on EventHistory.User_ID=Users.UserID where cast (Author as nvarchar(100)) like '%{textBox7.Text}%' order by case when ISNUMERIC(EventID) = 1 then 0 else 1 end, case when isnumeric(EventID) = 1 then cast(EventID as int) else 0 end, EventID", string_con))
                    {
                        readQueryResult();
                    }
                }
                if (comboBox1.Text.Length > 0)
                {
                    using (sql_command = new SqlCommand($"select EventID, Title, Author, Name, Login, Phone, Date from EventHistory left join Books on EventHistory.Book_ID=Books.BookID left join Users on EventHistory.User_ID=Users.UserID where cast (Type as nvarchar(100)) = '{comboBox1.Text}' order by case when ISNUMERIC(EventID) = 1 then 0 else 1 end, case when isnumeric(EventID) = 1 then cast(EventID as int) else 0 end, EventID", string_con))
                    {
                        readQueryResult();
                    }
                }
                if (comboBox2.Text.Length > 0)
                {
                    using (sql_command = new SqlCommand($"select EventID, Title, Author, Name, Login, Phone, Date from EventHistory left join Books on EventHistory.Book_ID=Books.BookID left join Users on EventHistory.User_ID=Users.UserID where cast (Genre as nvarchar(100)) = '{comboBox2.Text}' order by case when ISNUMERIC(EventID) = 1 then 0 else 1 end, case when isnumeric(EventID) = 1 then cast(EventID as int) else 0 end, EventID", string_con))
                    {
                        readQueryResult();
                    }
                }
                if (dateTimePicker1.Value != dateTimePicker1.MinDate)
                {
                    using (sql_command = new SqlCommand($"select EventID, Title, Author, Name, Login, Phone, Date from EventHistory left join Books on EventHistory.Book_ID=Books.BookID left join Users on EventHistory.User_ID=Users.UserID where cast (Date as nvarchar(100)) = '{dateTimePicker1.Text}' order by case when ISNUMERIC(EventID) = 1 then 0 else 1 end, case when isnumeric(EventID) = 1 then cast(EventID as int) else 0 end, EventID", string_con))
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
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            dateTimePicker1.Value = dateTimePicker1.MinDate;
            using (string_con = new SqlConnection("Server=X923;Database=LibraryProject1;Trusted_Connection=True;"))
            {
                string_con.Open();
                updateEventListView();
                string_con.Close();
            }
        }
    }
}
using System.Data.SqlClient;

namespace Library
{
    public partial class AddEvent : Form
    {
        SqlConnection string_con = new SqlConnection();
        SqlCommand sql_command = new SqlCommand();
        SqlCommand sql_command1 = new SqlCommand();
        SqlDataReader reader;
        static string strBookIDe;
        static string strUserIDe;
        static string strEventID;
        public AddEvent()
        {
            InitializeComponent();
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Сдана");
            comboBox1.Items.Add("Выдана");
        }

        public void readBookResult() // чтение результата запроса таблица книги
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

        public void readUserResult() // чтение результата запроса таблица пользователи
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
                        for (int i = 1; i < 5; i++)
                        {
                            tmp.SubItems.Add(reader[i].ToString());
                        }
                    }
                    reader.NextResult();
                }
            }
        }

        public void updateUserListView() // обновление таблицы пользователей
        {
            using (sql_command = new SqlCommand("select UserID,Login,Name,Phone,Address from Users order by case when ISNUMERIC(UserID) = 1 then 0 else 1 end, case when isnumeric(UserID) = 1 then cast(UserID as int) else 0 end, UserID", string_con))
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
                            for (int i = 1; i < 5; i++)
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

        private void button2_Click(object sender, EventArgs e) // отмена
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) // сохранение
        {
            string sql;
            int EventID;
            try
            {
                using (string_con = new SqlConnection("Server=X923;Database=LibraryProject1;Trusted_Connection=True;"))
                {
                    string_con.Open();
                    using (sql_command = new SqlCommand("select max(convert(int, convert(nvarchar(30), EventID))) from EventHistory", string_con))
                    {
                        using (reader = sql_command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                EventID = reader.GetInt32(0) + 1;
                                strEventID = EventID.ToString();
                            }
                        }
                        sql = "INSERT INTO EventHistory " + "(EventID,Book_ID,User_ID,Date,Action) " +
                        "VALUES('" + strEventID + "','" + strBookIDe + "','" + strUserIDe +
                        "','" + dateTimePicker1.Text + "','" + comboBox1.Text + "');";
                    }
                    using (sql_command1 = new SqlCommand(sql, string_con))
                    {
                        sql_command1.ExecuteNonQuery();
                    }
                    string_con.Close();
                }
            }
            catch (Exception ex) //catch exeption
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e) // поиск по пользователю
        {
            listView1.Columns.Clear();
            listView1.Columns.Add("№", 70);
            listView1.Columns.Add("Логин", 140);
            listView1.Columns.Add("ФИО", 200);
            listView1.Columns.Add("Телефон", 140);
            listView1.Columns.Add("Адрес", 300);
            using (string_con = new SqlConnection("Server=X923;Database=LibraryProject1;Trusted_Connection=True;"))
            {
                string_con.Open();
                updateUserListView();
                string_con.Close();
            }
            using (string_con = new SqlConnection("Server=X923;Database=LibraryProject1;Trusted_Connection=True;"))
            {
                string_con.Open();
                if (textBox1.Text.Length > 0)
                {
                    using (sql_command = new SqlCommand($"select UserID,Login,Name,Phone,Address from Users where cast (Name as nvarchar(100)) = '{textBox1.Text}' order by case when ISNUMERIC(UserID) = 1 then 0 else 1 end, case when isnumeric(UserID) = 1 then cast(UserID as int) else 0 end, UserID", string_con))
                    {
                        readUserResult();
                    }
                }
                if (textBox2.Text.Length > 0)
                {
                    using (sql_command = new SqlCommand($"select UserID,Login,Name,Phone,Address from Users where cast (Login as nvarchar(100)) = '{textBox2.Text}' order by case when ISNUMERIC(UserID) = 1 then 0 else 1 end, case when isnumeric(UserID) = 1 then cast(UserID as int) else 0 end, UserID", string_con))
                    {
                        readUserResult();
                    }
                }
                if (textBox3.Text.Length > 0)
                {
                    using (sql_command = new SqlCommand($"select UserID,Login,Name,Phone,Address from Users where cast (Phone as nvarchar(100)) = '{textBox3.Text}' order by case when ISNUMERIC(UserID) = 1 then 0 else 1 end, case when isnumeric(UserID) = 1 then cast(UserID as int) else 0 end, UserID", string_con))
                    {
                        readUserResult();
                    }
                }
                string_con.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e) // поиск по книге
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
            using (string_con = new SqlConnection("Server=X923;Database=LibraryProject1;Trusted_Connection=True;"))
            {
                string_con.Open();
                if (textBox4.Text.Length > 0)
                {
                    using (sql_command = new SqlCommand($"select * from Books where cast (Title as nvarchar(100)) = '{textBox4.Text}' order by case when ISNUMERIC(BookID) = 1 then 0 else 1 end, case when isnumeric(BookID) = 1 then cast(BookID as int) else 0 end, BookID", string_con))
                    {
                        readBookResult();
                    }
                }
                if (textBox5.Text.Length > 0)
                {
                    using (sql_command = new SqlCommand($"select * from Books where cast (Author as nvarchar(100)) = '{textBox5.Text}' order by case when ISNUMERIC(BookID) = 1 then 0 else 1 end, case when isnumeric(BookID) = 1 then cast(BookID as int) else 0 end, BookID", string_con))
                    {
                        readBookResult();
                    }
                }
                string_con.Close();
            }
        }

        private void listView1_Click(object sender, EventArgs e) // выбор элемента таблицы
        {
            object tmp;
            if (listView1.Columns.Count == 5) // пользователи
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    ListViewItem selectedItem = listView1.SelectedItems[0];
                    strUserIDe = selectedItem.Text;
                    using (string_con = new SqlConnection("Server=X923;Database=LibraryProject1;Trusted_Connection=True;"))
                    {
                        string_con.Open();
                        using (sql_command = new SqlCommand($"select Login,Name,Phone from Users where UserID={selectedItem.Text}", string_con))
                        {
                            using (reader = sql_command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    if ((tmp = reader.GetValue(0)) != null)
                                    {
                                        textBox1.Text = tmp.ToString();
                                    }
                                    if ((tmp = reader.GetValue(1)) != null)
                                    {
                                        textBox2.Text = tmp.ToString();
                                    }
                                    if ((tmp = reader.GetValue(2)) != null)
                                    {
                                        textBox3.Text = tmp.ToString();
                                    }
                                }
                            }
                        }
                        string_con.Close();
                    }
                }
            }
            if (listView1.Columns.Count == 10) // книги
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    ListViewItem selectedItem = listView1.SelectedItems[0];
                    strBookIDe = selectedItem.Text;
                    using (string_con = new SqlConnection("Server=X923;Database=LibraryProject1;Trusted_Connection=True;"))
                    {
                        string_con.Open();
                        using (sql_command = new SqlCommand($"select Title,Author from Books where BookID={selectedItem.Text}", string_con))
                        {
                            using (reader = sql_command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    if ((tmp = reader.GetValue(0)) != null)
                                    {
                                        textBox4.Text = tmp.ToString();
                                    }
                                    if ((tmp = reader.GetValue(1)) != null)
                                    {
                                        textBox5.Text = tmp.ToString();
                                    }
                                }
                            }
                        }
                        string_con.Close();
                    }
                }
            }
        }
    }
}
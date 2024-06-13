
using System.Data.SqlClient;

namespace Library
{
    public partial class EditEvent : Form
    {
        SqlConnection string_con = new SqlConnection();
        SqlCommand sql_command = new SqlCommand();
        SqlCommand sql_command1 = new SqlCommand();
        SqlDataReader reader;
        string sql;
        string index;
        static string strBookIDe;
        static string strUserIDe;
        static string strEventID;
        public EditEvent(string dbIndex)
        {
            InitializeComponent();
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Сдана");
            comboBox1.Items.Add("Выдана");
            index = dbIndex;
            object tmp;
            /////////// заполнение полей
            using (string_con = new SqlConnection("Server=X923;Database=LibraryProject1;Trusted_Connection=True;"))
            {
                string_con.Open();
                using (sql_command = new SqlCommand($"select EventID, Title, Author, Name, Login, Phone, Date from EventHistory left join Books on EventHistory.Book_ID=Books.BookID left join Users on EventHistory.User_ID=Users.UserID where EventID={dbIndex} order by case when ISNUMERIC(EventID) = 1 then 0 else 1 end, case when isnumeric(EventID) = 1 then cast(EventID as int) else 0 end, EventID", string_con))
                {
                    using (reader = sql_command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if ((tmp = reader.GetValue(1)) != null)
                            {
                                textBox4.Text = tmp.ToString();
                            }
                            if ((tmp = reader.GetValue(2)) != null)
                            {
                                textBox5.Text = tmp.ToString();
                            }
                            if ((tmp = reader.GetValue(3)) != null)
                            {
                                textBox1.Text = tmp.ToString();
                            }
                            if ((tmp = reader.GetValue(4)) != null)
                            {
                                textBox2.Text = tmp.ToString();
                            }
                            if ((tmp = reader.GetValue(5)) != null)
                            {
                                textBox3.Text = tmp.ToString();
                            }
                            if ((tmp = reader.GetValue(6)) != null)
                            {
                                dateTimePicker1.Text = tmp.ToString();
                            }
                        }
                    }
                }
                string_con.Close();
            }
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

        public void updateUserListView()  // обновление таблицы пользователей
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

        /*private void button1_Click(object sender, EventArgs e)
        {
            string sql;
            int EventID;
            try
            {
                using (string_con = new SqlConnection("Server=X923;Database=LibraryProject1;Trusted_Connection=True;"))
                {
                    string_con.Open();
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

        }*/

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

        private void listView1_Click(object sender, EventArgs e) // поиск
        {
            object tmp;
            if (listView1.Columns.Count == 5) // по пользователю
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
            if (listView1.Columns.Count == 10) // по книге
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
        private void button1_Click(object sender, EventArgs e) // сохранение
        {
            //int EventID;
            //strUserIDe = 
            sql = "UPDATE EventHistory " +
            "SET Book_ID = '" + strBookIDe + "', User_ID = '" + strUserIDe + "', Date = '"
            + dateTimePicker1.Text + "', Action = '" + comboBox1.Text + "' WHERE EventID='" + index + "';";
            using (string_con = new SqlConnection("Server=X923;Database=LibraryProject1;Trusted_Connection=True;"))
            {
                string_con.Open();
                /*using (sql_command = new SqlCommand("select top (1) [EventID] FROM [LibraryProject1].[dbo].[EventHistory] order by [EventID] desc", string_con))
                {
                    using (reader = sql_command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EventID = Int32.Parse(reader.GetString(0)) + 1;
                            strEventID = EventID.ToString();
                        }
                    }
                }*/
                using (sql_command = new SqlCommand(sql, string_con))
                {
                    sql_command.ExecuteNonQuery();
                }
                string_con.Close();
            }
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)// поиск по пользователю
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

        private void button4_Click_1(object sender, EventArgs e)// поиск по книге
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

        private void listView1_Click_1(object sender, EventArgs e)
        {
            object tmp;
            if (listView1.Columns.Count == 5) // по пользователю
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    ListViewItem selectedItem = listView1.SelectedItems[0];
                    strUserIDe = selectedItem.Text;
                    using (string_con = new SqlConnection("Server=X923;Database=LibraryProject1;Trusted_Connection=True;"))
                    {
                        string_con.Open();
                        using (sql_command = new SqlCommand($"select Name,Login,Phone from Users where UserID={selectedItem.Text}", string_con))
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
            if (listView1.Columns.Count == 10) // по книге
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
/*
SqlConnection string_con = new SqlConnection();
SqlCommand sql_command = new SqlCommand();
SqlDataReader reader;
 */

/*
using (string_con = new SqlConnection("Server=X923;Database=LibraryProject1;Trusted_Connection=True;"))
{
    string_con.Open();
    using (sql_command = new SqlCommand("", string_con))
    {
        using (reader = sql_command.ExecuteReader())
        {
            
        }
    }
    string_con.Close();
}
*/

/*
using (string_con = new SqlConnection("Server=X923;Database=LibraryProject1;Trusted_Connection=True;"))
{
    string_con.Open();
    updateUserListView();
    string_con.Close();
}
*/
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

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void updateEventListView()
        {
            using (sql_command = new SqlCommand("select EventID, Title, Author, Name, Login, Phone, Date from EventHistory left join Books on EventHistory.Book_ID=Books.BookID left join Users on EventHistory.User_ID=Users.UserID", string_con))
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

        public void readQueryResult()
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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
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

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            using (string_con = new SqlConnection("Server=X923;Database=LibraryProject1;Trusted_Connection=True;"))
            {
                string_con.Open();
                if (textBox1.Text.Length > 0)
                {
                    using (sql_command = new SqlCommand($"select EventID, Title, Author, Name, Login, Phone, Date from EventHistory left join Books on EventHistory.Book_ID=Books.BookID left join Users on EventHistory.User_ID=Users.UserID where cast (Name as nvarchar(100)) = '{textBox1.Text}'", string_con))
                    {
                        readQueryResult();
                    }
                }
                if (textBox2.Text.Length > 0)
                {
                    using (sql_command = new SqlCommand($"select EventID, Title, Author, Name, Login, Phone, Date from EventHistory left join Books on EventHistory.Book_ID=Books.BookID left join Users on EventHistory.User_ID=Users.UserID where cast (Login as nvarchar(100)) = '{textBox2.Text}'", string_con))
                    {
                        readQueryResult();
                    }
                }
                if (textBox3.Text.Length > 0)
                {
                    using (sql_command = new SqlCommand($"select EventID, Title, Author, Name, Login, Phone, Date from EventHistory left join Books on EventHistory.Book_ID=Books.BookID left join Users on EventHistory.User_ID=Users.UserID where cast (Phone as nvarchar(100)) = '{textBox3.Text}'", string_con))
                    {
                        readQueryResult();
                    }
                }
                if (textBox4.Text.Length > 0)
                {
                    using (sql_command = new SqlCommand($"select EventID, Title, Author, Name, Login, Phone, Date from EventHistory left join Books on EventHistory.Book_ID=Books.BookID left join Users on EventHistory.User_ID=Users.UserID where cast (Title as nvarchar(100)) = '{textBox4.Text}'", string_con))
                    {
                        readQueryResult();
                    }
                }
                if (textBox5.Text.Length > 0)
                {
                    using (sql_command = new SqlCommand($"select EventID, Title, Author, Name, Login, Phone, Date from EventHistory left join Books on EventHistory.Book_ID=Books.BookID left join Users on EventHistory.User_ID=Users.UserID where cast (Year as nvarchar(100)) = '{textBox5.Text}'", string_con))
                    {
                        readQueryResult();
                    }
                }
                if (textBox6.Text.Length > 0)
                {
                    using (sql_command = new SqlCommand($"select EventID, Title, Author, Name, Login, Phone, Date from EventHistory left join Books on EventHistory.Book_ID=Books.BookID left join Users on EventHistory.User_ID=Users.UserID where cast (ISBN as nvarchar(100)) = '{textBox6.Text}'", string_con))
                    {
                        readQueryResult();
                    }
                }
                if (textBox7.Text.Length > 0)
                {
                    using (sql_command = new SqlCommand($"select EventID, Title, Author, Name, Login, Phone, Date from EventHistory left join Books on EventHistory.Book_ID=Books.BookID left join Users on EventHistory.User_ID=Users.UserID where cast (Author as nvarchar(100)) = '{textBox7.Text}'", string_con))
                    {
                        readQueryResult();
                    }
                }
                if (comboBox1.Text.Length > 0)
                {
                    using (sql_command = new SqlCommand($"select EventID, Title, Author, Name, Login, Phone, Date from EventHistory left join Books on EventHistory.Book_ID=Books.BookID left join Users on EventHistory.User_ID=Users.UserID where cast (Type as nvarchar(100)) = '{comboBox1.Text}'", string_con))
                    {
                        readQueryResult();
                    }
                }
                if (comboBox2.Text.Length > 0)
                {
                    using (sql_command = new SqlCommand($"select EventID, Title, Author, Name, Login, Phone, Date from EventHistory left join Books on EventHistory.Book_ID=Books.BookID left join Users on EventHistory.User_ID=Users.UserID where cast (Genre as nvarchar(100)) = '{comboBox2.Text}'", string_con))
                    {
                        readQueryResult();
                    }
                }
                if (dateTimePicker1.Value != dateTimePicker1.MinDate)
                {
                    using (sql_command = new SqlCommand($"select EventID, Title, Author, Name, Login, Phone, Date from EventHistory left join Books on EventHistory.Book_ID=Books.BookID left join Users on EventHistory.User_ID=Users.UserID where cast (Date as nvarchar(100)) = '{dateTimePicker1.Text}'", string_con))
                    {
                        readQueryResult();
                    }
                }
                string_con.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
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
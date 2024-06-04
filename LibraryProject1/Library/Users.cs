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
    public partial class Users : Form
    {
        SqlConnection string_con = new SqlConnection();
        SqlCommand sql_command = new SqlCommand();
        SqlDataReader reader;
        public Users()
        {
            InitializeComponent();
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
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddUser form5 = new AddUser();
            DialogResult form5Closed = form5.ShowDialog();
            if (form5Closed != DialogResult.None)
            {
                using (string_con = new SqlConnection("Server=X923;Database=LibraryProject1;Trusted_Connection=True;"))
                {
                    string_con.Open();
                    updateUserListView();
                    string_con.Close();
                }
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                EditUser form12 = new EditUser(selectedItem.Text);
                DialogResult form12Closed = form12.ShowDialog();
                if (form12Closed != DialogResult.None)
                {
                    using (string_con = new SqlConnection("Server=X923;Database=LibraryProject1;Trusted_Connection=True;"))
                    {
                        string_con.Open();
                        updateUserListView();
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
                    //int temp = listView1.SelectedItems[0].Index;
                    int temp = listView1.Items.IndexOf(listView1.SelectedItems[0]);
                    sql_command = new SqlCommand($"delete from Users where UserID={temp + 1}", string_con);
                    string_con.Open();
                    sql_command.ExecuteNonQuery();
                    string_con.Close();
                }
                string_con.Open();
                updateUserListView();
                string_con.Close();
            }

        }

        public void updateUserListView()
        {
            using (sql_command = new SqlCommand("select * from Users", string_con))
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
                        for (int i = 1; i < 5; i++)
                        {
                            tmp.SubItems.Add(reader[i].ToString());
                        }
                    }
                    reader.NextResult();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (string_con = new SqlConnection("Server=X923;Database=LibraryProject1;Trusted_Connection=True;"))
            {
                string_con.Open();
                if (textBox1.Text.Length > 0)
                {
                    using (sql_command = new SqlCommand($"select * from Users where cast (Name as nvarchar(100)) = '{textBox1.Text}'", string_con))
                    {
                        readQueryResult();
                    }
                }
                if (textBox2.Text.Length > 0)
                {
                    using (sql_command = new SqlCommand($"select * from Users where cast (Login as nvarchar(100)) = '{textBox2.Text}'", string_con))
                    {
                        readQueryResult();
                    }
                }
                if (textBox3.Text.Length > 0)
                {
                    using (sql_command = new SqlCommand($"select * from Users where cast (Phone as nvarchar(100)) = '{textBox3.Text}'", string_con))
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
            using (string_con = new SqlConnection("Server=X923;Database=LibraryProject1;Trusted_Connection=True;"))
            {
                string_con.Open();
                updateUserListView();
                string_con.Close();
            }

        }
    }
}

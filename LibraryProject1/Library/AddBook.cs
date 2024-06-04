using System.Data.SqlClient;

namespace Library
{
    public partial class AddBook : Form
    {
        SqlConnection string_con = new SqlConnection();
        SqlCommand sql_command = new SqlCommand();
        SqlCommand sql_command1 = new SqlCommand();
        SqlDataReader reader;
        static string strBookID;
        public AddBook()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int BookID;
            string sql;
            try
            {
                using (string_con = new SqlConnection("Server=X923;Database=LibraryProject1;Trusted_Connection=True;"))
                {
                    string_con.Open();
                    using (sql_command = new SqlCommand("select top (1) [BookID] FROM [LibraryProject1].[dbo].[Books] order by [BookID] desc", string_con))
                    {
                        using (reader = sql_command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                BookID = Int32.Parse(reader.GetString(0)) + 1;
                                strBookID = BookID.ToString();
                            }
                        }
                        sql = "INSERT INTO Books " +
                        "(BookID,Title,Author,Genre,Type,Count,Year,Publisher,ISBN,Summary) " +
                        "VALUES ('" + strBookID + "','"
                        + textBox1.Text + "','" + textBox2.Text +
                        "','" + comboBox1.Text + "','" + comboBox2.Text +
                        "','" + textBox5.Text + "','" + textBox6.Text +
                        "','" + textBox7.Text + "','" + textBox8.Text +
                        "','" + richTextBox1.Text + "');";
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

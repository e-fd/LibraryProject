using System.Data.SqlClient;

namespace Library
{
    public partial class AddBook : Form
    {
        SqlConnection string_con = new SqlConnection();
        SqlCommand sql_command = new SqlCommand();
        public AddBook()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string_con = new SqlConnection("Server=X923;Database=LibraryProject1;Trusted_Connection=True;");
                sql_command = new SqlCommand("select top (1) [BookID] FROM [LibraryProject1].[dbo].[Books] order by [BookID] desc", string_con);
                string_con.Open();
                SqlDataReader reader = sql_command.ExecuteReader();
                int BookID = Int32.Parse(reader.GetString(0)) + 1;
                string sql = "INSERT INTO Books " +
                "(BookID,Title,Author,Genre,Type,Count,Year,Publisher,ISBN,Summary) " +
                "VALUES ('" + BookID.ToString() + "','"
                //"(@BookID,@Title,@Author,@Genre,@Type,@Count,@Year," +
                //"@Publisher,@ISBN,@Summary);";
                + textBox1.Text + "','" + textBox2.Text +
                "','" + comboBox1.Text + "','" + comboBox2.Text +
                "','" + textBox5.Text + "','" + textBox6.Text +
                "','" + textBox7.Text + "','" + textBox8.Text +
                "','" + richTextBox1.Text + "');";
                string sql1 = "insert into Books(BookID,Title) values ('" + BookID.ToString() + "','" + textBox1.Text + "')";

                //using (SqlCommand cmd = new SqlCommand(sql, string_con))
                //{
                //    int BookID = 1;
                //    cmd.Parameters.Add("@BookID", SqlDbType.VarChar).Value = BookID.ToString();
                //    cmd.Parameters.Add("@Title", SqlDbType.VarChar).Value = textBox1.Text;
                //    cmd.Parameters.Add("@Author", SqlDbType.VarChar).Value = textBox2.Text;
                //    cmd.Parameters.Add("@Genre", SqlDbType.VarChar).Value = comboBox1.Text;
                //    cmd.Parameters.Add("@Type", SqlDbType.VarChar).Value = comboBox2.Text;
                //    cmd.Parameters.Add("@Count", SqlDbType.VarChar).Value = textBox5.Text;
                //    cmd.Parameters.Add("@Year", SqlDbType.VarChar).Value = textBox6.Text;
                //    cmd.Parameters.Add("@Publisher", SqlDbType.VarChar).Value = textBox7.Text;
                //    cmd.Parameters.Add("@ISBN", SqlDbType.VarChar).Value = textBox8.Text;
                //    cmd.Parameters.Add("@Summary", SqlDbType.VarChar).Value = richTextBox1.Text;

                //}
                sql_command = new SqlCommand(sql1, string_con);
                sql_command.ExecuteNonQuery();
                string_con.Close();

            }
            catch (Exception ex) //catch exeption
            {
                MessageBox.Show(ex.Message);
            }
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}


using System.Data.SqlClient;

namespace Library
{
    public partial class EditEvent : Form
    {
        SqlConnection string_con = new SqlConnection();
        SqlCommand sql_command = new SqlCommand();
        SqlDataReader reader;
        string sql;
        string index;
        public EditEvent(string dbIndex)
        {
            InitializeComponent();
            index = dbIndex;
            object tmp;
            using (string_con = new SqlConnection("Server=X923;Database=LibraryProject1;Trusted_Connection=True;"))
            {
                string_con.Open();
                using (sql_command = new SqlCommand($"select Login,Name,Phone,Address from Users where UserID={dbIndex}", string_con))
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
                                textBox4.Text = tmp.ToString();
                            }
                            if ((tmp = reader.GetValue(3)) != null)
                            {
                                textBox5.Text = tmp.ToString();
                            }
                        }
                    }
                }
                string_con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sql = "UPDATE Users " +
            "SET Login = '" + textBox1.Text + "', Name = '" + textBox2.Text + "', Phone = '"
            + textBox4.Text + "', Address = '" + textBox5.Text + "' WHERE UserID=" + index + ";";
            using (string_con = new SqlConnection("Server=X923;Database=LibraryProject1;Trusted_Connection=True;"))
            {
                string_con.Open();
                using (sql_command = new SqlCommand(sql, string_con))
                {
                    sql_command.ExecuteNonQuery();
                }
                string_con.Close();
            }
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System.Data.SqlClient;

namespace Library
{
    public partial class AddEvent : Form
    {
        SqlConnection string_con = new SqlConnection();
        SqlCommand sql_command = new SqlCommand();
        SqlCommand sql_command1 = new SqlCommand();
        SqlDataReader reader;
        static string strEventID;
        public AddEvent()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql;
            int EventID;
            try
            {
                using (string_con = new SqlConnection("Server=X923;Database=LibraryProject1;Trusted_Connection=True;"))
                {
                    string_con.Open();
                    using (sql_command = new SqlCommand("select top (1) [EventID] FROM [LibraryProject1].[dbo].[EventHistory] order by [EventID] desc", string_con))
                    {
                        using (reader = sql_command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                EventID = Int32.Parse(reader.GetString(0)) + 1;
                                strEventID = EventID.ToString();
                            }
                        }
                        sql = "INSERT INTO Users " + "(UserID,Login,Name,Phone,Address) " +
                        "VALUES('" + strEventID + "','" + textBox1.Text + "','" + textBox2.Text +
                        "','" + textBox4.Text + "','" + textBox5.Text + "');";
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
    }
}

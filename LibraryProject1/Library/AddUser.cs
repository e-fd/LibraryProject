using System.Data.SqlClient;
using System.Net;

namespace Library
{
    public partial class AddUser : Form
    {
        SqlConnection string_con = new SqlConnection();
        SqlCommand sql_command = new SqlCommand();
        SqlCommand sql_command1 = new SqlCommand();
        SqlDataReader reader;
        static string strUserID;
        public AddUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql;
            int UserID;
            try
            {
                using (string_con = new SqlConnection("Server=X923;Database=LibraryProject1;Trusted_Connection=True;"))
                {
                    string_con.Open();
                    using (sql_command = new SqlCommand("select top (1) [UserID] FROM [LibraryProject1].[dbo].[Users] order by [UserID] desc", string_con))
                    {
                        using (reader = sql_command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                UserID = Int32.Parse(reader.GetString(0)) + 1;
                                strUserID = UserID.ToString();
                            }
                        }
                        sql = "INSERT INTO Users " + "(UserID,Login,Name,Phone,Address) " +
                        "VALUES('" + strUserID + "','" + textBox1.Text + "','" + textBox2.Text +
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

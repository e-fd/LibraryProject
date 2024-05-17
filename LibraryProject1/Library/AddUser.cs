using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library
{
    public partial class AddUser : Form
    {
        SqlConnection string_con = new SqlConnection();
        SqlCommand sql_command = new SqlCommand();
        public AddUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string_con.ConnectionString = "Server=X923;Database=LibraryProject;Trusted_Connection=True;";
                string_con.Open();
                string sql = "INSERT INTO Users " +
                "(Login,Name,Phone,Address) " +
                "VALUES('" + textBox1.Text + "','" + textBox2.Text +
                "','" + textBox4.Text + "','" + textBox5.Text + "');";
                sql_command = new SqlCommand(sql, string_con);
                sql_command.ExecuteNonQuery();
                string_con.Close();

            }
            catch (Exception ex) //catch exeption
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
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
                string_con.ConnectionString = "Server=X923;Database=LibraryProject;Trusted_Connection=True;";
                //opening connection
                string_con.Open();
                //create an insert query;
                string sql = "INSERT INTO Books " +
                "(Title,Author,Genre,Type,Count,Year,Publisher,ISBN,Summary) " +
                "VALUES('" + textBox1.Text + "','" + textBox2.Text +
                "','" + comboBox1.Text + "','" + comboBox2.Text +
                "','" + textBox5.Text + "','" + textBox6.Text +
                "','" + textBox7.Text + "','" + textBox8.Text +
                "','" + richTextBox1.Text + "');";
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

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
    public partial class Form3 : Form
    {
        SqlConnection string_con = new SqlConnection();
        SqlCommand sql_command = new SqlCommand();
        public Form3()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string_con.ConnectionString = "Server=X923;Database=LibraryProject1;Trusted_Connection=True;";
                //opening connection
                string_con.Open();
                //create an insert query;
                string sql = "INSERT INTO Books " +
                "(Title,Author,Genre,Type,Copies,Year,Publisher,ISBN,Summary) " +
                "VALUES('" + textBox1.Text + "','" + textBox2.Text +
                "','" + textBox3.Text + "','" + textBox4.Text +
                "','" + textBox5.Text + "','" + textBox6.Text +
                "','" + textBox7.Text + "','" + textBox8.Text +
                "','" + richTextBox1.Text + "');";
                //initialize a new instance of sqlcommand
                sql_command = new SqlCommand(sql, string_con);
                sql_command.ExecuteNonQuery();
                //set a connection used by this instance of sqlcommand
                //sql_command.Connection = string_con;
                //set the sql statement to execute at the data source
                //sql_command.CommandText = sql;
                //execute the data.
                /*
                int result = sql_command.ExecuteNonQuery();
                //validate the result of the executed query.
                if (result > 0)
                {
                    MessageBox.Show("Data has been saved in the SQL database");
                }
                else
                {
                    MessageBox.Show("SQL QUERY ERROR");
                }
                */

                //closing connection
                string_con.Close();

            }
            catch (Exception ex) //catch exeption
            {
                //displaying errors message.
                MessageBox.Show(ex.Message);
            }

        }
    }
}

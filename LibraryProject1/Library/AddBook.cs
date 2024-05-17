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
using System.Collections;

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
                int ID = 3;
                string_con.ConnectionString = "Server=X923;Database=LibraryProject1;Trusted_Connection=True;";
                //opening connection
                string_con.Open();
                //create an insert query;
                string sql = "INSERT INTO Books " +
                "(BookID,Title,Author,Genre,Type,Count,Year,Publisher,ISBN,Summary) " +
                "VALUES ('" + ID.ToString() + "','" +
                //"(@BookID,@Title,@Author,@Genre,@Type,@Count,@Year," +
                //"@Publisher,@ISBN,@Summary);";
                textBox1.Text + "','" + textBox2.Text +
                "','" + comboBox1.Text + "','" + comboBox2.Text +
                "','" + textBox5.Text + "','" + textBox6.Text +
                "','" + textBox7.Text + "','" + textBox8.Text +
                "','" + richTextBox1.Text + "');";
                string sql1 = "insert into Books(BookID,Title) values ('" + ID.ToString() +"','" + textBox1.Text + "')";

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

                //    //rest of the code
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
    }
}

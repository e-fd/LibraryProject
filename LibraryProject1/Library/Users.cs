using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Users : Form
    {
        SqlConnection string_con = new SqlConnection();
        SqlCommand sql_command = new SqlCommand();
        public Users()
        {
            InitializeComponent();
            string_con = new SqlConnection("Server=X923;Database=LibraryProject1;Trusted_Connection=True;");
            sql_command = new SqlCommand("select * from Books", string_con);
            listView1.Columns.Clear();
            listView1.Columns.Add("№", 70);
            listView1.Columns.Add("ФИО", 200);
            listView1.Columns.Add("Логин", 140);
            listView1.Columns.Add("Телефон", 140);
            listView1.Columns.Add("Адрес", 300);
            listView1.View = View.Details;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddUser form5 = new AddUser();
            form5.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var focusedItem = listView1.FocusedItem;
                if (focusedItem != null && focusedItem.Bounds.Contains(e.Location))
                {
                    contextMenuStrip1.Show(Cursor.Position);
                    toolStripMenuItem2.Visible = true;
                }
                else if (focusedItem == null)
                {
                    contextMenuStrip1.Show(Cursor.Position);
                    toolStripMenuItem2.Visible = false;
                }
            }
        }

        private void listView1_MouseHover(object sender, EventArgs e)
        {
            var focusedItem = listView1.FocusedItem;
            if (focusedItem != null)
            {
                contextMenuStrip1.Show(Cursor.Position);
                toolStripMenuItem2.Visible = true;
            }
            else
            {
                contextMenuStrip1.Show(Cursor.Position);
                toolStripMenuItem2.Visible = false;
            }

        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

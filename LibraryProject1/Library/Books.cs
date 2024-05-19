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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Common;

namespace Library
{
    public partial class Books : Form
    {
        SqlConnection string_con = new SqlConnection();
        SqlCommand sql_command;
        DataAdapter adapter;
        DataSet set;
        DataTable table;
        private bool mHasException;
        private Exception mLastException;
        private bool isCollapsed;
        public Books()
        {
            InitializeComponent();
            string_con.ConnectionString = "Server=X923;Database=LibraryProject1;Trusted_Connection=True;";
            listView1.Columns.Add("BookID", 70);
            listView1.Columns.Add("TItle", 70);
            listView1.Columns.Add("Author", 70);
            listView1.Columns.Add("Genre", 70);
            listView1.Columns.Add("Type", 70);
            listView1.Columns.Add("Year", 70, HorizontalAlignment.Right);
            listView1.Columns.Add("Publisher", 70);
            listView1.Columns.Add("Count", 70, HorizontalAlignment.Right);
            listView1.Columns.Add("ISBN", 70);
            listView1.Columns.Add("Summary", 70);
            listView1.View = View.Details;
            string_con.Open();
            sql_command = new SqlCommand("select * from Books");
            adapter = new SqlDataAdapter(sql_command);
            set = new DataSet();
            adapter.Fill(set);
            string_con.Close();
            table = set.Tables["table1"];
            listView1.Items.Clear();
            int i;
            int x = table.Rows.Count;
            for (i = 0, i <= x - 1, i++)
            {
                listView1.Items.Add(table.Rows[i].ItemArray[0].ToString());
                listView1.Items[i].SubItems.Add(table.Rows[i].ItemArray[1].ToString());
                listView1.Items[i].SubItems.Add(table.Rows[i].ItemArray[2].ToString());
                listView1.Items[i].SubItems.Add(table.Rows[i].ItemArray[3].ToString());
                listView1.Items[i].SubItems.Add(table.Rows[i].ItemArray[4].ToString());
                listView1.Items[i].SubItems.Add(table.Rows[i].ItemArray[5].ToString());
                listView1.Items[i].SubItems.Add(table.Rows[i].ItemArray[6].ToString());
                listView1.Items[i].SubItems.Add(table.Rows[i].ItemArray[7].ToString());
                listView1.Items[i].SubItems.Add(table.Rows[i].ItemArray[8].ToString());
                listView1.Items[i].SubItems.Add(table.Rows[i].ItemArray[9].ToString());
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddBook form3 = new AddBook();
            form3.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panel2.Height += 10;
                if (panel2.Size == panel2.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
                button2.Location = new Point(217, 360);
                button3.Location = new Point(217, 395);
            }
            else
            {
                panel2.Height -= 10;
                if (panel2.Size == panel2.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
                button2.Location = new Point(217, 150);
                button3.Location = new Point(217, 185);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        public List<Book> GetBooks()
        {
            mHasException = false;
            var bookInfo = new List<Book>();

            var selectStatement =
                @"SELECT BookID,Title,Author,Genre,Type,Year,Publisher," +
                "Count,ISBN,Summary FROM Books";
            using
            (
                var cn = new SqlConnection()
                {
                    ConnectionString = "Server=X923;Database=LibraryProject1;Trusted_Connection=True;"
                }
            )
            {
                using (var cmd = new SqlCommand() { Connection = cn })
                {
                    try
                    {
                        cn.Open();
                        cmd.CommandText = selectStatement;
                        var reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            bookInfo.Add(new Book()
                            {
                                Id = reader.GetInt32(0),
                                Title = reader.GetString(1),
                                Author = reader.GetString(2),
                                Genre = reader.GetString(3),
                                Type = reader.GetString(4),
                                Year = reader.GetString(5),
                                Publisher = reader.GetString(6),
                                Count = reader.GetString(7),
                                ISBN = reader.GetString(8),
                                Summary = reader.GetString(9)
                            });
                        }

                    }
                    catch (Exception e)
                    {
                        mHasException = true;
                        mLastException = e;
                    }
                }
            }
            return bookInfo;
        }

        private void Books_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            listView1.Columns.Add("BookID", 70);
            listView1.Columns.Add("TItle", 70);
            listView1.Columns.Add("Author", 70);
            listView1.Columns.Add("Genre", 70);
            listView1.Columns.Add("Type", 70);
            listView1.Columns.Add("Year", 70, HorizontalAlignment.Right);
            listView1.Columns.Add("Publisher", 70);
            listView1.Columns.Add("Count", 70, HorizontalAlignment.Right);
            listView1.Columns.Add("ISBN", 70);
            listView1.Columns.Add("Summary", 70);
            listView1.View = View.Details;

        }
    }
}

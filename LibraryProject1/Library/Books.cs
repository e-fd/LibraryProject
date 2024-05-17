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
    public partial class Books : Form
    {
        private bool isCollapsed;
        public Books()
        {
            InitializeComponent();
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
                    ConnectionString = "Server=X923;Database=LibraryProject;Trusted_Connection=True;"
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
    }
}

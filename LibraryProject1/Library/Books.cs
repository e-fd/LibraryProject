using System.Data.SqlClient;

namespace Library
{
    public partial class Books : Form
    {
        SqlConnection string_con = new SqlConnection();
        SqlCommand sql_command = new SqlCommand();

        //private bool mHasException;
        //private Exception mLastException;
        private bool isCollapsed;
        public Books()
        {
            InitializeComponent();
            string_con = new SqlConnection("Server=X923;Database=LibraryProject1;Trusted_Connection=True;");
            sql_command = new SqlCommand("select * from Books", string_con);
            listView1.Columns.Clear();
            listView1.Columns.Add("№", 70);
            listView1.Columns.Add("Название", 140);
            listView1.Columns.Add("Автор", 140);
            listView1.Columns.Add("Жанр", 140);
            listView1.Columns.Add("Тип", 140);
            listView1.Columns.Add("Год", 70);
            listView1.Columns.Add("Издатель", 140);
            listView1.Columns.Add("Количество", 100);
            listView1.Columns.Add("ISBN", 140);
            listView1.Columns.Add("Аннотация", 200);
            listView1.View = View.Details;

            listView1.Items.Clear();
            int i = 0;

            string_con.Open();
            SqlDataReader reader = sql_command.ExecuteReader();
            object tmp;

            while (reader.HasRows)
            {
                while (reader.Read())
                {
                    if ((tmp = reader.GetValue(0)) != null)
                    {
                        listView1.Items.Add(tmp.ToString());
                    }
                    if ((tmp = reader.GetValue(1)) != null)
                    {
                        //for (int j = 0; j < 10; j++)
                        listView1.Items[i].SubItems.Add(tmp.ToString());
                    }
                    i++;
                }
                reader.NextResult();
            }
            string_con.Close();

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
                    panel1.Size = panel1.MaximumSize;
                    timer1.Stop();
                    isCollapsed = false;
                }
                button2.Location = new Point(217, 360);
                button3.Location = new Point(217, 395);
                button5.Location = new Point(409, 430);
            }
            else
            {
                panel2.Height -= 10;
                if (panel2.Size == panel2.MinimumSize)
                {
                    panel1.Size = panel1.MinimumSize;
                    timer1.Stop();
                    isCollapsed = true;
                }
                button2.Location = new Point(217, 150);
                button3.Location = new Point(217, 185);
                button5.Location = new Point(409, 220);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        public List<Book> GetBooks()
        {
            //mHasException = false;
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
                        //mHasException = true;
                        //mLastException = e;
                    }
                }
            }
            return bookInfo;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listView1.Columns.Clear();
            listView1.Columns.Add("№", 70);
            listView1.Columns.Add("Название", 140);
            listView1.Columns.Add("Автор", 140);
            listView1.Columns.Add("Жанр", 140);
            listView1.Columns.Add("Тип", 140);
            listView1.Columns.Add("Год", 70);
            listView1.Columns.Add("Издатель", 140);
            listView1.Columns.Add("Количество", 100);
            listView1.Columns.Add("ISBN", 140);
            listView1.Columns.Add("Аннотация", 200);
            listView1.View = View.Details;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}

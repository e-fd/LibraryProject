using System.Data.SqlClient;

namespace Library
{
    public partial class AddBook : Form
    {
        SqlConnection string_con = new SqlConnection();
        SqlCommand sql_command = new SqlCommand();
        SqlCommand sql_command1 = new SqlCommand();
        SqlDataReader reader;
        static string strBookID;
        public AddBook()
        {
            InitializeComponent();
            comboBox1.Items.Clear(); // очистка списка жанров книг
            comboBox1.Items.Add("");                           // добавление жанров книг
            comboBox1.Items.Add("Роман-эпопея");               //
            comboBox1.Items.Add("Роман");                      //
            comboBox1.Items.Add("Повесть");                    //
            comboBox1.Items.Add("Рассказ");                    //
            comboBox1.Items.Add("Притча");                     //
            comboBox1.Items.Add("Лирическое стихотворение");   //
            comboBox1.Items.Add("Элегия");                     //
            comboBox1.Items.Add("Послание");                   //
            comboBox1.Items.Add("Эпиграмма");                  //
            comboBox1.Items.Add("Ода");                        //
            comboBox1.Items.Add("Сонет");                      //
            comboBox1.Items.Add("Комедия");                    //
            comboBox1.Items.Add("Трагедия");                   //
            comboBox1.Items.Add("Драма");                      //
            comboBox1.Items.Add("Поэма");                      //
            comboBox1.Items.Add("Баллада");                    //
            comboBox1.SelectedIndex = 0; // индекс изначально выбранного элемента
            comboBox2.Items.Clear(); // очистка списка жанров книг
            comboBox2.Items.Add("");                           // добавление типов книг
            comboBox2.Items.Add("Художественная литература");
            comboBox2.Items.Add("Документальная проза");
            comboBox2.Items.Add("Мемуарная литература");
            comboBox2.Items.Add("Научная и научно-популярная литература");
            comboBox2.Items.Add("Справочная литература");
            comboBox2.Items.Add("Учебная литература");
            comboBox2.SelectedIndex = 0;    // индекс изначально выбранного элемента

        }
        private void button1_Click(object sender, EventArgs e) // добавление
        {
            int BookID;
            string sql;
            try
            {
                using (string_con = new SqlConnection("Server=X923;Database=LibraryProject1;Trusted_Connection=True;"))
                {
                    string_con.Open();
                    using (sql_command = new SqlCommand("select max(convert(int, convert(nvarchar(30), BookID))) from Books", string_con))
                    {
                        using (reader = sql_command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                BookID = reader.GetInt32(0) + 1;
                                strBookID = BookID.ToString();
                            }
                        sql = "INSERT INTO Books " +
                        "(BookID,Title,Author,Genre,Type,Count,Year,Publisher,ISBN,Summary) " +
                        "VALUES ('" + strBookID + "','"
                        + textBox1.Text + "','" + textBox2.Text +
                        "','" + comboBox1.Text + "','" + comboBox2.Text +
                        "','" + textBox5.Text + "','" + textBox6.Text +
                        "','" + textBox7.Text + "','" + textBox8.Text +
                        "','" + richTextBox1.Text + "');";
                        }
                    }
                    /*using (sql_command = new SqlCommand("select top (1) BookID FROM Books order by BookID asc", string_con))
                    {
                        using (reader = sql_command.ExecuteReader())
                        {
                        }
                    }*/
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

        private void button2_Click(object sender, EventArgs e) // отмена
        {
            this.Close();
        }
    }
}

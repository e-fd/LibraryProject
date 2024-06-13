using System.Data.SqlClient;

namespace Library
{
    public partial class EditBook : Form
    {
        SqlConnection string_con = new SqlConnection();
        SqlCommand sql_command = new SqlCommand();
        SqlDataReader reader;
        string index;
        string sql;
        public EditBook(string dbIndex)
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
            comboBox2.Items.Clear(); // очистка списка жанров книг
            comboBox2.Items.Add("");                           // добавление жанров книг
            comboBox2.Items.Add("Художественная литература");               //
            comboBox2.Items.Add("Документальная проза");               //
            comboBox2.Items.Add("Мемуарная литература ");               //
            comboBox2.Items.Add("Научная и научно-популярная литература");               //
            comboBox2.Items.Add("Справочная литература");               //
            comboBox2.Items.Add("Учебная литература");               //
            comboBox2.SelectedIndex = 0;    // индекс изначально выбранного элемента

            index = dbIndex;
            object tmp;
            using (string_con = new SqlConnection("Server=X923;Database=LibraryProject1;Trusted_Connection=True;"))
            {
                string_con.Open();
                using (sql_command = new SqlCommand($"select Title,Author,Genre,Type,Count,Year,Publisher,ISBN,Summary from Books where BookID={dbIndex}", string_con))
                {
                    using (reader = sql_command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if ((tmp = reader.GetValue(0)) != null)
                            {
                                textBox1.Text = tmp.ToString();
                            }
                            if ((tmp = reader.GetValue(1)) != null)
                            {
                                textBox2.Text = tmp.ToString();
                            }
                            if ((tmp = reader.GetValue(2)) != null)
                            {
                                comboBox1.Text = tmp.ToString();
                            }
                            if ((tmp = reader.GetValue(3)) != null)
                            {
                                comboBox2.Text = tmp.ToString();
                            }
                            if ((tmp = reader.GetValue(4)) != null)
                            {
                                textBox5.Text = tmp.ToString();
                            }
                            if ((tmp = reader.GetValue(5)) != null)
                            {
                                textBox6.Text = tmp.ToString();
                            }
                            if ((tmp = reader.GetValue(6)) != null)
                            {
                                textBox7.Text = tmp.ToString();
                            }
                            if ((tmp = reader.GetValue(7)) != null)
                            {
                                textBox8.Text = tmp.ToString();
                            }
                            if ((tmp = reader.GetValue(8)) != null)
                            {
                                richTextBox1.Text = tmp.ToString();
                            }
                        }
                    }
                }
                string_con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sql = "UPDATE Books " +
            "SET Title = '" + textBox1.Text + "', Author = '" + textBox2.Text + "', Genre = '" 
            + comboBox1.Text + "', Type = '" + comboBox2.Text + "', Count = '" + textBox5.Text 
            + "', Year = '" + textBox6.Text + "', Publisher = '" + textBox7.Text + "', ISBN = '" 
            + textBox8.Text + "', Summary = '" + richTextBox1.Text + "' WHERE BookID=" + index + ";";
            using (string_con = new SqlConnection("Server=X923;Database=LibraryProject1;Trusted_Connection=True;"))
            {
                string_con.Open();
                using (sql_command = new SqlCommand(sql, string_con))
                {
                    sql_command.ExecuteNonQuery();
                }   
                string_con.Close();
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

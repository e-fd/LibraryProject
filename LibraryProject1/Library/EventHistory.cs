namespace Library
{
    public partial class EventHistory : Form
    {
        private bool isCollapsed;
        public EventHistory()
        {
            InitializeComponent();
            listView1.Columns.Clear();
            listView1.Columns.Add("№", 60);
            listView1.Columns.Add("Название", 100);
            listView1.Columns.Add("Автор", 100);
            listView1.Columns.Add("ФИО", 140);
            listView1.Columns.Add("Логин", 100);
            listView1.Columns.Add("Номер телефона", 100);
            listView1.Columns.Add("Дата", 140);
            listView1.View = View.Details;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Start();
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
                button2.Location = new Point(222, 631);
                button3.Location = new Point(222, 666);
                button5.Location = new Point(174, 631);
            }
            else
            {
                panel2.Height -= 10;
                if (panel2.Size == panel2.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
                button2.Location = new Point(222, 417);
                button3.Location = new Point(222, 452);
                button5.Location = new Point(174, 417);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddEvent form9 = new AddEvent();
            form9.ShowDialog();
        }
    }
}

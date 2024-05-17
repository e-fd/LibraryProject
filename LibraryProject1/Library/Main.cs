namespace Library
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Books form2 = new Books();
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Users form4 = new Users();
            form4.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EventHistory form6 = new EventHistory();
            form6.ShowDialog();
        }
    }
}

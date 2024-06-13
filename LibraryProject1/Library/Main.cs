namespace Library
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // окно книг
        {
            Books form2 = new Books();
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) // окно пользователей
        {
            Users form4 = new Users();
            form4.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e) // окно событий
        {
            EventHistory form6 = new EventHistory();
            form6.ShowDialog();
        }
    }
}

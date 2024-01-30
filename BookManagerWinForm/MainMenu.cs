namespace BookManagerWinForm
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void ButtonLogOut_Click(object sender, EventArgs e)
        {
            // show Home
            Home home = new Home();
            this.Close();
        }
    }
}

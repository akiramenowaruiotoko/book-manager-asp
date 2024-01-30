namespace BookManagerWinForm
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void ButtonLogIn_Click(object sender, EventArgs e)
        {
            string empNum = "0000";
            string empPass = "";

            // check account information
            if ((textBoxEmpNum.Text == empNum.ToString()) && (textBoxEmpPass.Text == empPass))
            {
                // show MainMenu
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
            }
            else
            {
                // differ message
                MessageBox.Show("different empNum or empPass.");
            }
        }
    }
}

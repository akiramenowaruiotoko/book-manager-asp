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
            home.Show();
            this.Close();
        }

        private void ButtonListDisplay_Click(object sender, EventArgs e)
        {
            ListDisplay listDisplay = new ListDisplay();
            listDisplay.Show();
        }

        private void buttonPurchase_Click(object sender, EventArgs e)
        {
            Purchase purchase = new Purchase();
            purchase.Show();
        }
    }
}
namespace BookManagerWinForm
{
    public partial class MainMenu : Form
    {
        private int employeeNumber;
        private bool isEditor;

        public MainMenu(int employeeNumber, bool isEditor)
        {
            InitializeComponent();
            this.employeeNumber = employeeNumber;
            this.isEditor = isEditor;
        }

        // ログアウトボタンのクリックイベントの例
        private void ButtonLogOut_Click(object sender, EventArgs e)
        {
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
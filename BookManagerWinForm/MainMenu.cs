namespace BookManagerWinForm
{
    public partial class MainMenu : Form
    {
        private int empNum;
        private bool isEditor;
        private Home homeForm; // Homeクラスのインスタンスを保持するフィールド

        public MainMenu(int empNum, bool isEditor, Home home)
        {
            InitializeComponent();
            this.empNum = empNum;
            this.isEditor = isEditor;
            homeForm = home; // MainMenuにHomeクラスのインスタンスを渡す
        }

        private void ButtonListDisplay_Click(object sender, EventArgs e)
        {
            ListDisplay listDisplay = new ListDisplay(empNum, isEditor, this);
            listDisplay.Show();
            this.Hide();
        }

        private void buttonPurchase_Click(object sender, EventArgs e)
        {
            Purchase purchase = new Purchase(empNum, isEditor, this);
            purchase.Show();
            this.Hide();
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit(empNum, isEditor, this);
            edit.Show();
            this.Hide();
        }

        // ログアウトボタンのクリックイベントの例
        private void ButtonLogOut_Click(object sender, EventArgs e)
        {
            empNum = 0;
            isEditor = false;
            homeForm.Show(); // MainMenuに保持されたHomeクラスのインスタンスを表示
            this.Close();
        }
    }
}

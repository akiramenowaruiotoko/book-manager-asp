namespace BookManagerWinForm
{
    public partial class MainMenu : Form
    {
        private int empNum;
        private bool isEditor;
        private readonly Home homeForm; // Homeクラスのインスタンスを保持するフィールド

        public MainMenu(int empNum, bool isEditor, Home home)
        {
            InitializeComponent();
            this.empNum = empNum;
            this.isEditor = isEditor;
            homeForm = home; // MainMenuにHomeクラスのインスタンスを渡す
        }

        private void ButtonListDisplay_Click(object sender, EventArgs e)
        {
            ListDisplay form = new(empNum, isEditor, this);
            form.Show();
            this.Hide();
        }

        private void ButtonPurchase_Click(object sender, EventArgs e)
        {
            Purchase form = new(empNum, isEditor, this);
            form.Show();
            this.Hide();
        }
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            Edit form = new(empNum, isEditor, this);
            form.Show();
            this.Hide();
        }

        // ログアウトボタンのクリックイベント
        private void ButtonLogOut_Click(object sender, EventArgs e)
        {
            empNum = 0;
            isEditor = false;
            homeForm.Show(); // MainMenuに保持されたHomeクラスのインスタンスを表示
            this.Close();
        }
    }
}

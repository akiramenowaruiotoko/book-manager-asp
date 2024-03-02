namespace BookManagerWinForm
{
    public partial class Home : Form
    {
        private int empNum = 0;
        private bool isEditor = false;
        private readonly DatabaseManager dbManager;

        public Home()
        {
            InitializeComponent();
            // データベースマネージャーの初期化
            dbManager = new DatabaseManager();
        }

        private void ButtonLogIn_Click(object sender, EventArgs e)
        {
            // ユーザーが入力した従業員番号とパスワードを取得
            empNum = int.Parse(textBoxEmpNum.Text);
            string empPass = textBoxEmpPass.Text;

            // データベースとの比較を行う
            if (dbManager.CheckCredentials(empNum, empPass, out isEditor))
            {
                // 認証成功時はメインメニュー画面を表示
                MainMenu form = new MainMenu(empNum, isEditor, this);
                form.Show();
                // ログイン画面を非表示
                this.Hide();
            }
            else
            {
                // 認証失敗時はエラーメッセージを表示
                MessageBox.Show("ユーザー番号またはパスワードが正しくありません。");
            }
        }
    }
}

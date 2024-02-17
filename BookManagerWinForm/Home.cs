namespace BookManagerWinForm
{
    public partial class Home : Form
    {
        private int? employeeNumber;
        private bool isEditor;

        private DatabaseManager dbManager;

        public Home()
        {
            InitializeComponent();
            // データベースマネージャーの初期化
            dbManager = new DatabaseManager();
        }

        private void ButtonLogIn_Click(object sender, EventArgs e)
        {
            // ユーザーが入力した従業員番号とパスワードを取得
            string empNum = textBoxEmpNum.Text;
            string empPass = textBoxEmpPass.Text;

            // データベースとの比較を行う
            if (dbManager.CheckCredentials(empNum, empPass))
            {
                int employeeNumberValue = employeeNumber.HasValue ? employeeNumber.Value : 0; // Nullable<int> から int への変換
                                                                                              // 認証成功時はメインメニュー画面を表示
                MainMenu mainMenu = new MainMenu(employeeNumberValue, isEditor); // 引数を渡す
                mainMenu.Show();
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

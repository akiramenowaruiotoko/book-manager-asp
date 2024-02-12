using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace BookManagerWinForm
{
    public partial class Home : Form
    {
        private string connectionString;

        public Home()
        {
            InitializeComponent();
            // データベース接続文字列を取得
            connectionString = ConfigurationManager.ConnectionStrings["sqlsvr"].ConnectionString;
        }

        private void ButtonLogIn_Click(object sender, EventArgs e)
        {
            // ユーザーが入力した従業員番号とパスワードを取得
            string empNum = textBoxEmpNum.Text;
            string empPass = textBoxEmpPass.Text;

            // データベースとの比較を行う
            if (CheckCredentials(empNum, empPass))
            {
                // 認証成功時はメインメニュー画面を表示
                MainMenu mainMenu = new MainMenu();
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

        private bool CheckCredentials(string empNum, string empPass)
        {
            // データベースとの接続
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // クエリの作成
                string query = "SELECT COUNT(*) FROM View_employees WHERE employee_number = @EmpNum AND employee_password = @EmpPass";

                // SqlCommand の作成
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // パラメータの設定
                    command.Parameters.AddWithValue("@EmpNum", empNum);
                    command.Parameters.AddWithValue("@EmpPass", empPass);

                    // コネクションのオープン
                    connection.Open();
                    // クエリの実行
                    int count = (int)command.ExecuteScalar();
                    // ユーザーが見つかったかどうかを返す
                    return count > 0;
                }
            }
        }
    }
}

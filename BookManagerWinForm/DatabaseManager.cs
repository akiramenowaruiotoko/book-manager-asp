using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BookManagerWinForm
{
    public class DatabaseManager
    {
        private string connectionString;

        public DatabaseManager()
        {
            // データベース接続文字列を取得
            connectionString = ConfigurationManager.ConnectionStrings["sqlsvr"].ConnectionString;
        }

        // 指定したビューからデータを取得するメソッド
        public DataTable GetDataFromView(string viewName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            // ストアドプロシージャのコマンドを作成
            using (SqlCommand command = new SqlCommand("GetDataFromView", connection))
            {
                // コマンドのタイプをストアドプロシージャに設定
                command.CommandType = CommandType.StoredProcedure;
                // パラメータを追加
                command.Parameters.AddWithValue("@ViewName", viewName);

                // アダプタを使用してデータをフェッチ
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    return dataTable;
                }
            }
        }

        // 従業員の認証を行うメソッド
        public bool CheckCredentials(int empNum, string empPass)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            // ストアドプロシージャのコマンドを作成
            using (SqlCommand command = new SqlCommand("CheckCredentials", connection))
            {
                // コマンドのタイプをストアドプロシージャに設定
                command.CommandType = CommandType.StoredProcedure;
                // パラメータを追加
                command.Parameters.AddWithValue("@EmpNum", empNum);
                command.Parameters.AddWithValue("@EmpPass", empPass);

                // 接続を開く
                connection.Open();
                // スカラー値を取得して認証を行う
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }
    }
}

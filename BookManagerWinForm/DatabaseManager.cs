using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BookManagerWinForm
{
    /// <summary>
    /// データベース関連の操作を提供するクラスです。
    /// </summary>
    public class DatabaseManager
    {
        private string connectionString;

        /// <summary>
        /// DatabaseManager クラスの新しいインスタンスを初期化します。
        /// </summary>
        public DatabaseManager()
        {
            // データベース接続文字列を取得
            connectionString = ConfigurationManager.ConnectionStrings["sqlsvr"].ConnectionString;
        }

        /// <summary>
        /// 指定したビューからデータを取得します。
        /// </summary>
        /// <param name="viewName">取得するビューの名前。</param>
        /// <returns>ビューから取得したデータ。</returns>
        public DataTable GetDataFromView(string viewName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // SQLクエリの作成
                string query = $"SELECT * FROM {viewName}";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        return dataTable;
                    }
                }
            }
        }

        /// <summary>
        /// 従業員の認証を行います。
        /// </summary>
        /// <param name="empNum">従業員番号。</param>
        /// <param name="empPass">パスワード。</param>
        /// <returns>認証結果。認証成功時は true、それ以外は false。</returns>
        public bool CheckCredentials(string empNum, string empPass)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // SQLクエリの作成
                string query = "SELECT COUNT(*) FROM View_employees WHERE employee_number = @EmpNum AND employee_password = @EmpPass";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // パラメータの設定
                    command.Parameters.AddWithValue("@EmpNum", empNum);
                    command.Parameters.AddWithValue("@EmpPass", empPass);

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

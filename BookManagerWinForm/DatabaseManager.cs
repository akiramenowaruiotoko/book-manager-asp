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
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL文を作成
                    string sql = $"SELECT * FROM {viewName}";

                    // コマンドを作成
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        // アダプタを使用してデータをフェッチ
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // 例外処理
                Console.WriteLine($"データの取得中にエラーが発生しました: {ex.Message}");
            }

            return dataTable;
        }

        // 従業員の認証を行うメソッド
        public bool CheckCredentials(int empNum, string empPass, out bool isEditor)
        {
            // SqlConnectionのインスタンスを作成
            using (SqlConnection connection = new SqlConnection(connectionString))
            // SqlCommandのインスタンスを作成し、ストアドプロシージャを指定
            using (SqlCommand command = new SqlCommand("CheckCredentials", connection))
            {
                // コマンドのタイプをストアドプロシージャに設定
                command.CommandType = CommandType.StoredProcedure;

                // パラメータを追加
                command.Parameters.AddWithValue("@EmpNum", empNum);
                command.Parameters.AddWithValue("@EmpPass", empPass);

                // OUTPUTパラメータを設定
                SqlParameter outputParam = new SqlParameter("@IsEditor", SqlDbType.Bit);
                outputParam.Direction = ParameterDirection.Output;
                command.Parameters.Add(outputParam);

                // @return_valueパラメータを設定
                SqlParameter returnParam = command.Parameters.Add("@return_value", SqlDbType.Int);
                returnParam.Direction = ParameterDirection.ReturnValue;

                try
                {
                    // 接続を開く
                    connection.Open();

                    // ストアードプロシージャ実行して認証を行う
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // 例外処理
                    Console.WriteLine($"データの取得中にエラーが発生しました: {ex.Message}");
                }

                // OUTPUT値取得
                isEditor = (bool)outputParam.Value;

                // 戻り値取得、認証結果を返す
                return ((int)returnParam.Value) == 1 ? true : false;
            }
        }

    }
}

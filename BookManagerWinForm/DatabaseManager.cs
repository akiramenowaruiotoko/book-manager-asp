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
        public bool CheckCredentials(int empNum, string empPass, out bool isEditor)
        {
            bool isAuthenticated = false;
            isEditor = false;

            // SqlConnectionのインスタンスを作成
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
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

                    // @return_valueを取得
                    SqlParameter returnParam = command.Parameters.Add("@return_value", SqlDbType.Int);
                    returnParam.Direction = ParameterDirection.ReturnValue;

                    // 接続を開く
                    connection.Open();

                    // ストアードプロシージャ実行して認証を行う
                    command.ExecuteNonQuery();

                    // OUTPUT値取得
                    isEditor = (bool)outputParam.Value;

                    // 戻り値取得
                    int returnValue = (int)returnParam.Value;
                    if (returnValue == 1)
                    {
                        isAuthenticated = true;
                    }
                }
            }
            return isAuthenticated;
        }

    }
}

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

                    // SQL 文を作成してパラメータ化
                    string sql = "SELECT * FROM " + viewName;
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                // 例外処理：ユーザーにエラーメッセージを表示する
                Console.WriteLine($"データの取得中にエラーが発生しました: {ex.Message}");
            }

            return dataTable;
        }

        // 従業員の認証を行うメソッド
        public bool CheckCredentials(int empNum, string empPass, out bool isEditor)
        {
            isEditor = false; // デフォルト値を設定

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand("CheckCredentials", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@EmpNum", empNum);
                    command.Parameters.AddWithValue("@EmpPass", empPass);

                    SqlParameter outputParam = new SqlParameter("@IsEditor", SqlDbType.Bit);
                    outputParam.Direction = ParameterDirection.Output;
                    command.Parameters.Add(outputParam);

                    SqlParameter returnParam = command.Parameters.Add("@return_value", SqlDbType.Int);
                    returnParam.Direction = ParameterDirection.ReturnValue;

                    connection.Open();
                    command.ExecuteNonQuery();

                    isEditor = (bool)outputParam.Value;
                    return (int)returnParam.Value == 1;
                }
            }
            catch (Exception ex)
            {
                // 例外処理：ユーザーにエラーメッセージを表示する
                Console.WriteLine($"データの取得中にエラーが発生しました: {ex.Message}");
                return false;
            }
        }

        // 購入申請処理
        public bool RequestBookPurchase(string bookId, string bookName, int employeeNumber, int statusNum)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("RequestBookPurchase", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@BookId", bookId);
                command.Parameters.AddWithValue("@BookName", bookName);
                command.Parameters.AddWithValue("@EmployeeNumber", employeeNumber);
                command.Parameters.AddWithValue("@StatusNum", statusNum);

                SqlParameter returnParam = command.Parameters.Add("@return_value", SqlDbType.Int);
                returnParam.Direction = ParameterDirection.ReturnValue;

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    return (int)returnParam.Value == 1;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"申請中にエラーが発生しました: {ex.Message}");
                    return false;
                }
            }
        }

    }
}

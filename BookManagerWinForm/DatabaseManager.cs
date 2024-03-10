using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Net;

namespace BookManagerWinForm
{
    public class DatabaseManager
    {
        private readonly string connectionString;

        public DatabaseManager()
        {
            // データベース接続文字列を取得
            connectionString = ConfigurationManager.ConnectionStrings["sqlsvr"].ConnectionString;
        }

        // 指定したビューからデータを取得するメソッド
        public DataTable GetDataFromView(string viewName)
        {
            DataTable dataTable = new();

            try
            {
                using (SqlConnection connection = new(connectionString))
                {
                    connection.Open();

                    // SQL 文を作成してパラメータ化
                    string sql = "SELECT * FROM " + viewName;
                    using SqlCommand command = new(sql, connection);
                    using SqlDataAdapter adapter = new(command);
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                // 例外処理：ユーザーにエラーメッセージを表示する
                Console.WriteLine($"データの取得中にエラーが発生しました: {ex.Message}");
            }

            return dataTable;
        }

        // ビューと行を指定してデータを取得するメソッド
        public DataTable GetDataFromRowView(string viewName, string bookId)
        {
            DataTable dataTable = new();

            try
            {
                using (SqlConnection connection = new(connectionString))
                {
                    connection.Open();

                    // SQL 文を作成してパラメータ化
                    string sql = "SELECT * FROM " + viewName + " where book_id = " + bookId;
                    using SqlCommand command = new(sql, connection);
                    using SqlDataAdapter adapter = new(command);
                    adapter.Fill(dataTable);
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
                using SqlConnection connection = new(connectionString);
                using SqlCommand command = new("CheckCredentials", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@EmpNum", empNum);
                command.Parameters.AddWithValue("@EmpPass", empPass);

                SqlParameter outputParam = new("@IsEditor", SqlDbType.Bit);
                outputParam.Direction = ParameterDirection.Output;
                command.Parameters.Add(outputParam);

                SqlParameter returnParam = command.Parameters.Add("@return_value", SqlDbType.Int);
                returnParam.Direction = ParameterDirection.ReturnValue;

                connection.Open();
                command.ExecuteNonQuery();

                isEditor = (bool)outputParam.Value;
                // 認証が成功(0)した場合TRUE, 失敗(-1)した場合FALSE
                return (int)returnParam.Value == 0;
            }
            catch (Exception ex)
            {
                // 例外処理：ユーザーにエラーメッセージを表示する
                Console.WriteLine($"データの取得中にエラーが発生しました: {ex.Message}");
                return false;
            }
        }

        // 書籍の申請を行うメソッド
        public bool PurchaseRequest(string bookId, string bookName, int employeeNumber, int statusNum)
        {
            try
            {
                using (SqlConnection connection = new(connectionString))
                using (SqlCommand command = new("PurchaseRequest", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@BookId", bookId);
                    command.Parameters.AddWithValue("@BookName", bookName);
                    command.Parameters.AddWithValue("@EmployeeNumber", employeeNumber);
                    command.Parameters.AddWithValue("@StatusNum", statusNum);

                    SqlParameter returnParam = command.Parameters.Add("@return_value", SqlDbType.Int);
                    returnParam.Direction = ParameterDirection.ReturnValue;

                    connection.Open();
                    command.ExecuteNonQuery();
                    int returnValue = (int)returnParam.Value;
                    // 申請が成功(0)した場合 TRUE, 失敗(-1)した場合FALSE
                    return (int)returnParam.Value == 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"申請中にエラーが発生しました: {ex.Message}");
                return false;
            }
        }

        // 購入完了を行うメソッド
        public bool PurchaseComplete(string bookId, int employeeNumber, int statusNum)
        {
            try
            {
                using (SqlConnection connection = new(connectionString))
                using (SqlCommand command = new("PurchaseComplete", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@BookId", bookId);
                    command.Parameters.AddWithValue("@EmployeeNumber", employeeNumber);
                    command.Parameters.AddWithValue("@StatusNum", statusNum);

                    SqlParameter returnParam = command.Parameters.Add("@return_value", SqlDbType.Int);
                    returnParam.Direction = ParameterDirection.ReturnValue;

                    connection.Open();
                    command.ExecuteNonQuery();
                    int returnValue = (int)returnParam.Value;
                    // 申請が成功(0)した場合 TRUE, 失敗(-1)した場合FALSE
                    return (int)returnParam.Value == 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"申請中にエラーが発生しました: {ex.Message}");
                return false;
            }
        }
    }
}

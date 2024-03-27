using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Net;

namespace BookManagerWinForm
{
    public class DatabaseManager
    {
        #region 初期設定
        private readonly string connectionString;

        public DatabaseManager()
        {
            // データベース接続文字列を取得
            connectionString = ConfigurationManager.ConnectionStrings["sqlsvr"].ConnectionString;
        }
        #endregion

        #region 指定したビューからデータを取得するメソッド
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
        #endregion

        #region 指定した従業員情報をビューから取得するメソッド
        public DataTable GetEmployeeRecordFromView(string viewName, int targetEmployeeNumber)
        {
            DataTable dataTable = new();

            try
            {
                using (SqlConnection connection = new(connectionString))
                {
                    connection.Open();

                    // SQL 文を作成してパラメータ化
                    string sql = "SELECT * FROM " + viewName + " Where employee_number = " + targetEmployeeNumber;
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
        #endregion

        #region 指定した書籍情報をビューから取得するメソッド
        public DataTable GetBookRecordFromView(string viewName, string targetBookId)
        {
            DataTable dataTable = new();

            try
            {
                using (SqlConnection connection = new(connectionString))
                {
                    connection.Open();

                    // SQL 文を作成してパラメータ化
                    string sql = "SELECT * FROM " + viewName + " Where book_id = " + targetBookId;
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
        #endregion

        #region ビューと行を指定してデータを取得するメソッド
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
        #endregion

        #region 従業員の認証を行うメソッド
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
        #endregion

        #region 書籍追加
        public bool AddBook(string bookId, string bookName, int employeeNumber, int statusNum)
        {
            try
            {
                using (SqlConnection connection = new(connectionString))
                using (SqlCommand command = new("AddBook", connection))
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
        #endregion

        #region 書籍情報編集
        public bool EditBook(string targetBookId, string bookId, string bookName)
        {
            try
            {
                using (SqlConnection connection = new(connectionString))
                using (SqlCommand command = new("EditBook", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@TargetBookId", targetBookId);
                    command.Parameters.AddWithValue("@BookId", bookId);
                    command.Parameters.AddWithValue("@BookName", bookName);
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
        #endregion

        #region 書籍削除
        public bool DeleteBook(string targetBookId)
        {
            try
            {
                using (SqlConnection connection = new(connectionString))
                using (SqlCommand command = new("DeleteBook", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@TargetBookId", targetBookId);
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
                Console.WriteLine($"処理中にエラーが発生しました: {ex.Message}");
                return false;
            }
        }
        #endregion

        #region 社員追加
        public bool AddEmployee(int employeeNumber, string employeePassword, string firstName, bool editor)
        {
            try
            {
                using (SqlConnection connection = new(connectionString))
                using (SqlCommand command = new("AddEmployee", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@EmployeeNumber", employeeNumber);
                    command.Parameters.AddWithValue("@EmployeePassword", employeePassword);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@Editor", editor);
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
        #endregion

        #region 社員情報編集
        public bool EditEmployee(int targetEmployeeNumber, int employeeNumber, string employeePassword, string firstName, bool editor)
        {
            try
            {
                using (SqlConnection connection = new(connectionString))
                using (SqlCommand command = new("EditEmployee", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@TargetEmployeeNumber", targetEmployeeNumber);
                    command.Parameters.AddWithValue("@EmployeeNumber", employeeNumber);
                    command.Parameters.AddWithValue("@EmployeePassword", employeePassword);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@Editor", editor);
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
        #endregion

        #region 従業員削除
        public bool DeleteEmployee(int targetEmployeeNumber)
        {
            try
            {
                using (SqlConnection connection = new(connectionString))
                using (SqlCommand command = new("DeleteEmployee", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@TargetEmployeeNumber", targetEmployeeNumber);
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
                Console.WriteLine($"処理中にエラーが発生しました: {ex.Message}");
                return false;
            }
        }
        #endregion
        #region 書籍の申請を行うメソッド
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
        #endregion

        #region 購入依頼に関する返答（ステータス更新）を行うメソッド
        public bool PurchaseManagement(string bookId, int employeeNumber, int statusNum)
        {
            try
            {
                using (SqlConnection connection = new(connectionString))
                using (SqlCommand command = new("PurchaseManagement", connection))
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
        #endregion

        #region 貸出依頼に関する返答（ステータス更新）を行うメソッド
        public bool RentalRequest(string bookId, int employeeNumber, int statusNum, DateTime rentalDate, DateTime returnDate)
        {
            try
            {
                using (SqlConnection connection = new(connectionString))
                using (SqlCommand command = new("RentalRequest", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@BookId", bookId);
                    command.Parameters.AddWithValue("@EmployeeNumber", employeeNumber);
                    command.Parameters.AddWithValue("@StatusNum", statusNum);
                    command.Parameters.AddWithValue("@RentalDate", rentalDate);
                    command.Parameters.AddWithValue("@ReturnDate", returnDate);
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
        #endregion

        #region 貸出管理
        public bool RentalManagement(string bookId, int employeeNumber, int statusNum, DateTime? rentalDate, DateTime? returnDate)
        {
            try
            {
                using (SqlConnection connection = new(connectionString))
                using (SqlCommand command = new("RentalManagement", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@BookId", bookId);
                    command.Parameters.AddWithValue("@EmployeeNumber", employeeNumber);
                    command.Parameters.AddWithValue("@StatusNum", statusNum);
                    command.Parameters.AddWithValue("@RentalDate", (object)rentalDate ?? DBNull.Value);
                    command.Parameters.AddWithValue("@ReturnDate", (object)returnDate ?? DBNull.Value);
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
        #endregion
    }
}

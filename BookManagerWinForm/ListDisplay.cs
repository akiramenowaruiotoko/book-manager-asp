using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace BookManagerWinForm
{
    public partial class ListDisplay : Form
    {
        private string connectionString;
        private string viewName;

        public ListDisplay()
        {
            InitializeComponent();
            // データベースマネージャーの初期化
            connectionString = ConfigurationManager.ConnectionStrings["sqlsvr"].ConnectionString;
            viewName = "View_all";
        }

        private void ListDisplay_Load(object sender, EventArgs e)
        {
            // フォームがロードされた時点でデータを表示
            LoadDataFromView();
        }


        // データベースからデータを読み込み、DataGridViewに表示するメソッド
        private void LoadDataFromView()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"SELECT * FROM {viewName}";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // データをDataGridViewにバインド
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
        }

        // 戻るボタンがクリックされた時の処理
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            // フォームを閉じる
            this.Close();
        }
    }
}

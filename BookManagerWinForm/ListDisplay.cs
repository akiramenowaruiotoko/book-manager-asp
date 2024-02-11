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
            LoadDataFromView();
        }

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
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

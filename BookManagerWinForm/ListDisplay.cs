using System;
using System.Data;
using System.Windows.Forms;

namespace BookManagerWinForm
{
    public partial class ListDisplay : Form
    {
        private DatabaseManager dbManager;
        private string viewName;

        public ListDisplay()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
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
            DataTable dataTable = dbManager.GetDataFromView(viewName);
            dataGridView1.DataSource = dataTable;
        }

        // 戻るボタンがクリックされた時の処理
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            // フォームを閉じる
            this.Close();
        }
    }
}

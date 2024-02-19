using System.Data;

namespace BookManagerWinForm
{
    public partial class ListDisplay : Form
    {
        private int empNum;
        private bool isEditor;
        private MainMenu mainMenuForm;
        private DatabaseManager dbManager;
        private string viewName;

        public ListDisplay(int empNum, bool isEditor, MainMenu mainMenuForm)
        {
            InitializeComponent();
            this.empNum = empNum;
            this.isEditor = isEditor;
            this.mainMenuForm = mainMenuForm;
            dbManager = new DatabaseManager();
            viewName = "View_all";
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
            mainMenuForm.Show();
            // フォームを閉じる
            this.Close();
        }
    }
}

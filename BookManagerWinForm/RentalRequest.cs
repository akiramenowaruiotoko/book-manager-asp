using System.Data;

namespace BookManagerWinForm
{
    public partial class RentalRequest : Form
    {
        private int empNum;
        private bool isEditor;
        private string book_id;
        private ListDisplay listDisplayFrom;
        private DatabaseManager dbManager;
        private string viewName = "View_books";

        public RentalRequest(int empNum, bool isEditor, string book_id, ListDisplay listDisplay)
        {
            InitializeComponent();
            this.empNum = empNum;
            this.isEditor = isEditor;
            this.book_id = book_id;
            this.listDisplayFrom = listDisplay;
            dbManager = new DatabaseManager();
            // 指定した book_id の行データを取得する
            DataTable data = dbManager.GetDataFromRowView(viewName, book_id);
            // 行ヘッダーを非表示にして左の編集列を非表示にする
            dataGridView1.RowHeadersVisible = false;
            // DataGridViewにデータをロード
            dataGridView1.DataSource = data;
        }

        private void buttonBackList_Click(object sender, EventArgs e)
        {
            listDisplayFrom.Show();
            this.Close();
        }
    }
}

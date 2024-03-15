using System.Data;

namespace BookManagerWinForm
{
    public partial class RentalRequest : Form
    {
        private readonly int empNum;
        private readonly bool isEditor;
        private readonly string book_id;
        private readonly ListDisplay listDisplayFrom;
        private readonly DatabaseManager dbManager;
        private readonly string viewName = "View_books";

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

        private void ButtonBackList_Click(object sender, EventArgs e)
        {
            listDisplayFrom.Show();
            this.Close();
        }

        private void ButtonRentalRequest_Click(object sender, EventArgs e)
        {
            //修正予定
            // ステータス番号を貸出可(1)に設定
            int statusNum = 1;

            // 購入承認を行い、結果を表示
            if (dbManager.PurchaseComplete(book_id, empNum, statusNum))
            {
                MessageBox.Show("購入完了処理が完了しました。");
            }
            else
            {
                MessageBox.Show("購入依頼なし。または書籍購入済みです。申請を中止します。");
            }
        }
    }
}

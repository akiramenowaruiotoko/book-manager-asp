using System.Data;

namespace BookManagerWinForm
{
    public partial class PurchaseManagement : Form
    {
        private readonly int empNum;
        private readonly bool isEditor;
        private readonly string book_id;
        private readonly ListDisplay listDisplayFrom;
        private readonly DatabaseManager dbManager;
        private readonly string viewName = "view_all";

        public PurchaseManagement(int empNum, bool isEditor, string book_id, ListDisplay listDisplay)
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

        private void ButtonPurchaseApproval_Click(object sender, EventArgs e)
        {
            // ステータス番号を購入承認済み(1)に設定
            int statusNum = 1;
            // 購入承認処理を行い、結果を表示
            if (dbManager.PurchaseManagement(book_id, empNum, statusNum))
            {
                MessageBox.Show("購入承認処理が完了しました。");
                listDisplayFrom.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("購入依頼なし。申請を中止します。");
            }
        }
        private void ButtonPurchaseDisapproved_Click(object sender, EventArgs e)
        {
            // ステータス番号を購入不承認(2)に設定
            int statusNum = 2;
            // 購入不承認処理を行い、結果を表示
            if (dbManager.PurchaseManagement(book_id, empNum, statusNum))
            {
                MessageBox.Show("購入不承認処理が完了しました。");
                listDisplayFrom.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("購入依頼なし。申請を中止します。");
            }
        }

        private void ButtonPurchaseComplete_Click(object sender, EventArgs e)
        {
            // ステータス番号を貸出可能(3)に設定
            int statusNum = 3;
            // 購入完了処理を行い、結果を表示
            if (dbManager.PurchaseManagement(book_id, empNum, statusNum))
            {
                MessageBox.Show("購入完了認処理が完了しました。");
                listDisplayFrom.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("購入依頼なし、または購入済み。申請を中止します。");
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            listDisplayFrom.Show();
            this.Close();
        }

    }
}

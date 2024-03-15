namespace BookManagerWinForm
{
    public partial class PurchaseRequest : Form
    {
        private readonly int empNum;
        private readonly bool isEditor;
        private readonly MainMenu mainMenuForm;
        private readonly DatabaseManager dbManager;

        public PurchaseRequest(int empNum, bool isEditor, MainMenu mainMenuForm)
        {
            InitializeComponent();
            this.empNum = empNum;
            this.isEditor = isEditor;
            this.mainMenuForm = mainMenuForm;
            dbManager = new DatabaseManager();
        }

        private void ButtonBackPurchase_Click(object sender, EventArgs e)
        {
            mainMenuForm.Show();
            this.Close();
        }

        private void ButtonApplication_Click(object sender, EventArgs e)
        {
            // ステータス番号を0で初期化
            int statusNum = 0;
            // 入力された書籍情報を取得
            string bookId = textBoxBookId.Text.Trim();
            string bookName = textBoxBookName.Text.Trim();

            // 書籍申請を行い、結果を直接条件式で使用
            if (dbManager.PurchaseRequest(bookId, bookName, empNum, statusNum))
            {
                MessageBox.Show("申請が完了しました。");
            }
            else
            {
                MessageBox.Show("書籍が既に存在しています。申請を中止します。");
            }
        }
    }
}

using System.Data;

namespace BookManagerWinForm
{
    public partial class EditBook : Form
    {
        private readonly int empNum;
        private readonly bool isEditor;
        private readonly ListDisplay listDisplayForm;
        private readonly DatabaseManager dbManager;
        private string targetBookId;
        private readonly string viewName = "view_books";


        public EditBook(int empNum, bool isEditor, string targetBookId, ListDisplay listDisplayForm)
        {
            InitializeComponent();
            this.empNum = empNum;
            this.isEditor = isEditor;
            this.targetBookId = targetBookId;
            this.listDisplayForm = listDisplayForm;
            dbManager = new DatabaseManager();
            DataTable data = dbManager.GetBookRecordFromView(viewName, targetBookId);
            textBoxBookId.Text = data.Rows[0]["book_id"].ToString();
            textBoxBookName.Text = data.Rows[0]["book_name"].ToString();
        }

        private void buttonEditBook_Click(object sender, EventArgs e)
        {
            string bookId = textBoxBookId.Text;
            string bookName = textBoxBookName.Text;
            if (dbManager.EditBook(targetBookId, bookId, bookName))
            {
                MessageBox.Show("処理が完了しました。");
                listDisplayForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("編集後のbook_idは既に存在しています。\n申請を中止します。");
            }
        }

        private void buttonDeleteBook_Click(object sender, EventArgs e)
        {
            if (dbManager.DeleteBook(targetBookId))
            {
                MessageBox.Show("処理が完了しました。");
                listDisplayForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("削除対象が存在しません。\n申請を中止します。");
            }
        }
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            listDisplayForm.Show();
            this.Close();
        }
    }
}
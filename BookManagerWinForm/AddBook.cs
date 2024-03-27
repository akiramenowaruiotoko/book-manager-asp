using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagerWinForm
{
    public partial class AddBook : Form
    {
        private int empNum;
        private bool isEditor;
        private Edit editForm;
        private DatabaseManager dbManager;

        public AddBook(int empNum, bool isEditor, Edit editForm)
        {
            this.empNum = empNum;
            this.isEditor = isEditor;
            this.editForm = editForm;
            dbManager = new DatabaseManager();
            InitializeComponent();
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            string bookId = textBoxBookId.Text;
            string bookName = textBoxBookName.Text;
            int statusNum = 3; // ステータスを貸出可能に設定
            // 書籍申請を行い、結果を直接条件式で使用
            if (dbManager.AddBook(bookId, bookName, empNum, statusNum))
            {
                MessageBox.Show("処理が完了しました。");
            }
            else
            {
                MessageBox.Show("既に存在しています。申請を中止します。");
            }

        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            editForm.Show();
            this.Close();
        }
    }
}

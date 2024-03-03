using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagerWinForm
{
    public partial class PurchaseCheck : Form
    {
        private int empNum;
        private bool isEditor;
        private string book_id;
        private ListDisplay listDisplayFrom;
        private DatabaseManager dbManager;
        private string viewName = "view_all";

        public PurchaseCheck(int empNum, bool isEditor, string book_id, ListDisplay listDisplay)
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
        private void buttonBackPurchaseCheck_Click(object sender, EventArgs e)
        {
            listDisplayFrom.Show();
            this.Close();
        }

        private void buttonPurchaseApplication_Click(object sender, EventArgs e)
        {

        }
    }
}

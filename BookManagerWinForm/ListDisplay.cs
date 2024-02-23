using System;
using System.Data;
using System.Windows.Forms;

namespace BookManagerWinForm
{
    public partial class ListDisplay : Form
    {
        private int empNum;
        private bool isEditor;
        private MainMenu mainMenuForm;
        private DatabaseManager dbManager;
        private string viewName = "view_all"; // ビュー名を正確に指定する

        public ListDisplay(int empNum, bool isEditor, MainMenu mainMenuForm)
        {
            InitializeComponent();
            this.empNum = empNum;
            this.isEditor = isEditor;
            this.mainMenuForm = mainMenuForm;
            dbManager = new DatabaseManager(); // DatabaseManagerクラスのインスタンス化
            LoadDataFromView();
        }

        private void LoadDataFromView()
        {
            // データを取得する処理
            DataTable data = dbManager.GetDataFromView(viewName);

            // ボタン列を作成し、DataGridViewの一番左に追加
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "ボタン列";
            buttonColumn.Text = "ボタン"; // ボタンのデフォルトテキスト
            buttonColumn.UseColumnTextForButtonValue = true; // ボタン列にテキストを表示するための設定
            dataGridView1.Columns.Insert(0, buttonColumn);

            // DataGridViewにデータをロード
            dataGridView1.DataSource = data;

            // DataGridViewの最初の列を非表示にする
            dataGridView1.RowHeadersVisible = false;
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            mainMenuForm.Show();
            this.Close();
        }
    }
}

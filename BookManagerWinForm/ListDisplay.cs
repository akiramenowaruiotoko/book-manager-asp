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
            // NO列をボタン列に変更する
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "TEST";
            buttonColumn.Name = "テスト";
            buttonColumn.FlatStyle = FlatStyle.Popup;
            buttonColumn.DataPropertyName = "Button";
            this.dataGridView1.Columns.Add(buttonColumn);

            // データを取得する処理
            DataTable data = dbManager.GetDataFromView(viewName);

            // NO列を追加し、ボタンを設定する
            var button = new DataColumn("Button");
            button.DataType = typeof(string);
            data.Columns.Add(button);

            for (int i = 0; i < data.Rows.Count; i++)
            {
                data.Rows[i]["Button"] = "Click Here"+i;
            }

            // DataGridViewにデータをロード
            dataGridView1.DataSource = data;

            // セルの編集を可能にする
            dataGridView1.ReadOnly = false;
            // 編集モードを設定する（EditOnEnterやEditOnKeystrokeOrF2など）
            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;

            // 行ヘッダーを表示して行番号を表示する
            dataGridView1.RowHeadersVisible = true;
            dataGridView1.Visible = true;
        }


        private void ButtonBack_Click(object sender, EventArgs e)
        {
            mainMenuForm.Show();
            this.Close();
        }
    }
}

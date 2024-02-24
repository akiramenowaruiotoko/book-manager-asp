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
//            dbManager = new DatabaseManager(); // DatabaseManagerクラスのインスタンス化
 //           LoadDataFromView();

            DataTable table = new DataTable();

            DataColumn column1 = new DataColumn();
            column1.ColumnName = "Field1";
            column1.DataType = Type.GetType("System.Int64");
            table.Columns.Add(column1);

            DataColumn column2 = new DataColumn();
            column2.ColumnName = "Field2";
            column2.DataType = Type.GetType("System.String");
            table.Columns.Add(column2);

            dataGridView1.DataSource = table;

            string[] str = { "ち", "は", "や", "ふ", "る" };

            foreach (string t in str)
            {
                DataRow row = table.NewRow();
                row[1] = t;
                table.Rows.Add(row);
            }
        }

        private void LoadDataFromView()
        {
            // データを取得する処理
            DataTable data = dbManager.GetDataFromView(viewName);

            // NO列を追加
            DataGridViewTextBoxColumn noColumn = new DataGridViewTextBoxColumn();
            noColumn.Name = "NO";
            noColumn.HeaderText = "NO";
            dataGridView1.Columns.Insert(0, noColumn);

            // NO列に連番を表示するために、DataTableに列を追加し、連番を代入する
            DataColumn noDataColumn = new DataColumn("NO", typeof(int));
            data.Columns.Add(noDataColumn);
            for (int i = 0; i < data.Rows.Count; i++)
            {
                data.Rows[i]["NO"] = i + 1;
            }

            // DataGridViewにデータをロード
            dataGridView1.DataSource = data;

            // セルの編集を可能にする
            dataGridView1.ReadOnly = false;
            // 編集モードを設定する（EditOnEnterやEditOnKeystrokeOrF2など）
            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;

            // 行ヘッダーを表示して行番号を表示する
            dataGridView1.RowHeadersVisible = true;

            // NO列と行番号に連番を表示する
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            mainMenuForm.Show();
            this.Close();
        }
    }
}

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
            buttonColumn.HeaderText = "ActionButton";
            buttonColumn.Name = "アクションボタン";
            buttonColumn.FlatStyle = FlatStyle.Flat; // FlatStyleをFlatに設定する
            buttonColumn.DataPropertyName = "Button";

            // ボタンの外観をカスタマイズする
            buttonColumn.DefaultCellStyle.BackColor = System.Drawing.Color.LightGray; // 薄い青
            buttonColumn.DefaultCellStyle.ForeColor = System.Drawing.Color.Black; // テキストカラーを黒に設定
            buttonColumn.FlatStyle = FlatStyle.Popup;

            this.dataGridView1.Columns.Add(buttonColumn);

            // データを取得する処理
            DataTable data = dbManager.GetDataFromView(viewName);

            // TEST列を追加し、ボタンを設定する
            var button = new DataColumn("Button");
            button.DataType = typeof(string);
            data.Columns.Add(button);

            for (int i = 0; i < data.Rows.Count; i++)
            {
                // s.status_numの値に応じてボタンのテキストを設定する
                int statusNum = Convert.ToInt32(data.Rows[i]["status_num"]);
                if (statusNum == 0)
                {
                    data.Rows[i]["Button"] = "購入確認";
                }
                else if (statusNum == 1)
                {
                    data.Rows[i]["Button"] = "貸出申請";
                }
                else
                {
                    // 他の状態に応じた処理を追加する
                    // data.Rows[i]["Button"] = "他の状態のテキスト";
                }
            }

            // DataGridViewにデータをロード
            dataGridView1.DataSource = data;

            // セルの編集を不可にする
            dataGridView1.ReadOnly = true;

            // 行ヘッダーを非表示にして左の編集列を非表示にする
            dataGridView1.RowHeadersVisible = false;

            // 最初の編集列を非表示にする
            dataGridView1.Columns[0].Visible = false;
        }


        private void ButtonBack_Click(object sender, EventArgs e)
        {
            mainMenuForm.Show();
            this.Close();
        }
    }
}

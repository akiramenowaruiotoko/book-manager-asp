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
        private string viewName = "view_all";

        enum ActionNum
        {
            purchaseCheck = 0,
            rentalRequest = 1
        }

        public ListDisplay(int empNum, bool isEditor, MainMenu mainMenu)
        {
            InitializeComponent();
            this.empNum = empNum;
            this.isEditor = isEditor;
            this.mainMenuForm = mainMenu;
            dbManager = new DatabaseManager(); // DatabaseManagerクラスのインスタンス化

            // DataGridView の CellContentClick イベントハンドラを設定
            dataGridView1.CellContentClick += DataGridView1_CellContentClick;

            // DataGridView の KeyDown イベントハンドラを設定
            dataGridView1.KeyDown += DataGridView1_KeyDown;

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
            buttonColumn.DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            buttonColumn.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            buttonColumn.FlatStyle = FlatStyle.Popup;

            this.dataGridView1.Columns.Add(buttonColumn);

            // データを取得する処理
            DataTable data = dbManager.GetDataFromView(viewName);

            // ActionButton列を追加し、ボタンを設定する
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

            // 行ヘッダーを非表示にして左の編集列を非表示にする
            dataGridView1.RowHeadersVisible = false;
        }

        // DataGridView のセルがクリックされたときの処理
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            HandleAction(e.RowIndex);
        }

        // DataGridView のセルがキーダウンされたときの処理
        private void DataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                HandleAction(rowIndex);
            }
        }

        // アクションを処理するメソッド
        private void HandleAction(int rowIndex)
        {
            // ボタンがクリックされたことを確認する
            if (rowIndex >= 0 && rowIndex < dataGridView1.Rows.Count &&
                dataGridView1.Rows[rowIndex].Cells["アクションボタン"].Selected)
            {

                // クリックされた行の book_id の値を取得
                string book_id = dataGridView1.Rows[rowIndex].Cells["book_id"].Value.ToString();

                // クリックされた行の status_num の値を取得
                ActionNum actionNum = (ActionNum)Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["status_num"].Value);

                // actionNumの値で分岐
                switch (actionNum)
                {
                    case ActionNum.purchaseCheck:
                        // purchaseCheckに対する処理
                        PurchaseCheck purchaseCheck = new(empNum, isEditor, book_id, this);
                        purchaseCheck.Show();
                        this.Hide();
                        break;

                    case ActionNum.rentalRequest:
                        // rentalRequestに対する処理
                        RentalRequest rentalRequest = new(empNum, isEditor, book_id, this);
                        rentalRequest.Show();
                        this.Hide();
                        break;

                    default: break;
                }
            }
        }

        // 戻るボタンがクリックされたときの処理
        private void ButtonBackListDisplay_Click(object sender, EventArgs e)
        {
            mainMenuForm.Show();
            this.Close();
        }
    }
}

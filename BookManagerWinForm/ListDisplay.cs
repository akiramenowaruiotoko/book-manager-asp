using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BookManagerWinForm
{
    public partial class ListDisplay : Form
    {
        #region define
        private readonly int empNum;
        private readonly bool isEditor;
        private readonly MainMenu mainMenuForm;
        private readonly DatabaseManager dbManager;
        private ViewNum viewNum;
        private string viewName;

        enum ViewNum
        {
            view_all = 0,
            view_books = 1,
            view_employees = 2,
            view_statuses = 3
        }
        enum StatusNum
        {
            Applying_Purchase = 0, //購入申請中
            Purchase_Approved = 1, //購入承認済み 購入待ち
            Purchase_Disapproved = 2, //購入不承認
            Available_Rental = 3, //貸出可能
            Applying_Rental = 4, //貸出申請中
            Approved_Rental = 5, //貸出承認済み
            Unavailable_Rental = 6, //貸出不可
            Currently_Rental = 7, //貸出中 期日何日
            Currently_Rental_Past = 8 //貸出中 期日超過
        }
        #endregion

        #region Initialize
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
        }
        #endregion

        #region フォームデータ読み込み
        // フォームが表示されたらdataをロード
        private void ListDisplay_VisibleChanged(object sender, EventArgs e)
        {
            viewSet();
        }
        // コンボボックスが変更されたらdataをロード
        private void comboBoxList_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewSet();
        }
        // コンボボックスの値を取得し、viewをセット
        private void viewSet()
        {
            viewNum = (ViewNum)comboBoxList.SelectedIndex;
            switch (viewNum)
            {
                case ViewNum.view_all:
                    viewName = "view_all";
                    LoadDataFromView();
                    break;
                case ViewNum.view_books:
                    viewName = "view_books";
                    LoadDataFromView();
                    break;
                case ViewNum.view_employees:
                    viewName = "view_employees";
                    LoadDataFromView();
                    break;
                case ViewNum.view_statuses:
                    viewName = "view_statuses";
                    LoadDataFromView();
                    break;
            }
        }

        // viewのデータを読み込み、データグリッドビューに表示
        private void LoadDataFromView()
        {
            // データグリッドビューの列をクリアする
            dataGridView1.Columns.Clear();
            // 行ヘッダーを非表示にして左の編集列を非表示にする
            dataGridView1.RowHeadersVisible = false;

            // DBデータを取得する処理
            DataTable data = dbManager.GetDataFromView(viewName);

            // viewNumごとに列を設定
            switch (viewNum)
            {
                case ViewNum.view_all:
                    data = addActionButton(data);
                    data = addStatusColumn(data);
                    data = setActionButton(data);
                    data = setStatusColumn(data);
                    break;
                case ViewNum.view_books:
                    data = addActionButton(data);
                    data = setEditButton(data);
                    break;
                case ViewNum.view_employees:
                    data = addActionButton(data);
                    data = setEditButton(data);
                    break;
                case ViewNum.view_statuses:
                    data = addStatusColumn(data);
                    data = setStatusColumn(data);
                    break;
            }

            // DataGridViewにデータをロード
            dataGridView1.DataSource = data;
        }
        #endregion

        #region 列追加
        private DataTable addActionButton(DataTable data)
        {
            // アクションボタン列を追加する
            DataGridViewButtonColumn buttonColumn = new()
            {
                HeaderText = "ActionButton",
                Name = "アクションボタン",
                FlatStyle = FlatStyle.Flat,
                DataPropertyName = "Button"
            };
            // アクションボタンの外観をカスタマイズする
            buttonColumn.DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            buttonColumn.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            buttonColumn.FlatStyle = FlatStyle.Popup;
            this.dataGridView1.Columns.Add(buttonColumn);
            DataColumn button = new("Button")
            {
                DataType = typeof(string)
            };
            data.Columns.Add(button);
            return data;

        }

        private DataTable addStatusColumn(DataTable data)
        {
            // ステータス列を追加する
            DataGridViewTextBoxColumn statusColumn = new()
            {
                HeaderText = "ステータス",
                Name = "ステータス",
                DataPropertyName = "Status"
            };
            this.dataGridView1.Columns.Add(statusColumn);
            DataColumn status = new("Status")
            {
                DataType = typeof(string)
            };
            data.Columns.Add(status);
            return data;
        }
        #endregion

        #region 追加した列のテキストをセット
        private DataTable setActionButton(DataTable data)
        {
            for (int i = 0; i < data.Rows.Count; i++)
            {
                // s.status_numの値に応じてテキストを設定する
                StatusNum statusNum = (StatusNum)Convert.ToInt32(data.Rows[i]["status_num"]);
                switch (statusNum)
                {
                    case StatusNum.Applying_Purchase: //購入申請中
                        data.Rows[i]["Button"] = "購入確認";
                        break;
                    case StatusNum.Purchase_Approved: //購入承認済み 購入待ち
                        data.Rows[i]["Button"] = "購入完了処理";
                        break;
                    case StatusNum.Purchase_Disapproved: //購入不承認
                        data.Rows[i]["Button"] = "購入不承認変更";
                        break;
                    case StatusNum.Available_Rental: //貸出可能
                        data.Rows[i]["Button"] = "貸出申請";
                        break;
                    case StatusNum.Applying_Rental: //貸出申請中
                        data.Rows[i]["Button"] = "貸出確認";
                        break;
                    case StatusNum.Approved_Rental: //貸出承認済み
                        data.Rows[i]["Button"] = "貸出完了処理";
                        break;
                    case StatusNum.Unavailable_Rental: //貸出不可
                        data.Rows[i]["Button"] = "貸出不可変更";
                        break;
                    case StatusNum.Currently_Rental: //貸出中 期日何日
                    case StatusNum.Currently_Rental_Past: //貸出中 期日超過
                        data.Rows[i]["Button"] = "返却完了処理";
                        break;
                    default:
                        data.Rows[i]["Button"] = "-";
                        break;
                }
            }
            return data;
        }
        private DataTable setStatusColumn(DataTable data)
        {
            for (int i = 0; i < data.Rows.Count; i++)
            {
                // s.status_numの値に応じてテキストを設定する
                StatusNum statusNum = (StatusNum)Convert.ToInt32(data.Rows[i]["status_num"]);
                switch (statusNum)
                {
                    case StatusNum.Applying_Purchase: //購入申請中
                        data.Rows[i]["Status"] = "購入申請中";
                        break;
                    case StatusNum.Purchase_Approved: //購入承認済み 購入待ち
                        data.Rows[i]["Status"] = "購入承認済み 購入待ち";
                        break;
                    case StatusNum.Purchase_Disapproved: //購入不承認
                        data.Rows[i]["Status"] = "購入不承認";
                        break;
                    case StatusNum.Available_Rental: //貸出可能
                        data.Rows[i]["Status"] = "貸出可能";
                        break;
                    case StatusNum.Applying_Rental: //貸出申請中
                        data.Rows[i]["Status"] = "貸出申請中";
                        break;
                    case StatusNum.Approved_Rental: //貸出承認済み
                        data.Rows[i]["Status"] = "貸出承認済み";
                        break;
                    case StatusNum.Unavailable_Rental: //貸出不可
                        data.Rows[i]["Status"] = "貸出不可";
                        break;
                    case StatusNum.Currently_Rental: //貸出中 期日何日
                    case StatusNum.Currently_Rental_Past: //貸出中 期日超過
                        data.Rows[i]["Status"] = "貸出中";
                        break;
                    default:
                        data.Rows[i]["Status"] = "不明";
                        break;
                }
            }
            return data;
        }

        private DataTable setEditButton(DataTable data)
        {
            for (int i = 0; i < data.Rows.Count; i++)
            {
                data.Rows[i]["Button"] = "編集";
            }
            return data;
        }

        #endregion
        #region アクションを処理するメソッド
            // DataGridView のセルがクリックされたときの処理
            private void DataGridView1_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            HandleAction(e.RowIndex);
        }

        // DataGridView のセルがキーダウンされたときの処理
        private void DataGridView1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                HandleAction(rowIndex);
            }
        }
        private void HandleAction(int rowIndex)
        {
            // ボタンがクリックされたことを確認する
            if (rowIndex >= 0 && rowIndex < dataGridView1.Rows.Count &&
                dataGridView1.Rows[rowIndex].Cells["アクションボタン"].Selected)
            {

                // クリックされた行の book_id の値を取得し、null の場合はデフォルト値を設定する
                string book_id = dataGridView1.Rows[rowIndex].Cells["book_id"].Value.ToString() ?? string.Empty;

                // クリックされた行の status_num の値を取得
                StatusNum statusNum = (StatusNum)Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["status_num"].Value);

                // statusNumの値で分岐
                switch (statusNum)
                {
                    case StatusNum.Applying_Purchase: // 購入申請中 0
                    case StatusNum.Purchase_Approved: // 購入承認 1
                    case StatusNum.Purchase_Disapproved: // 購入不承認 2
                        PurchaseManagement purchaseManagement = new(empNum, isEditor, book_id, this);
                        purchaseManagement.Show();
                        this.Hide();
                        break;
                    case StatusNum.Available_Rental: // 貸出可能 3
                        RentalRequest rentalRequest = new(empNum, isEditor, book_id, this);
                        rentalRequest.Show();
                        this.Hide();
                        break;
                    case StatusNum.Applying_Rental: // 貸出申請中 4
                    case StatusNum.Approved_Rental: // 貸出承認済み 5
                    case StatusNum.Unavailable_Rental: // 貸出不可 6
                    case StatusNum.Currently_Rental: // 貸出中 期日何日 7
                    case StatusNum.Currently_Rental_Past: //貸出中 期日超過 8
                        RentalManagement rentalManagement = new(empNum, isEditor, book_id, this);
                        rentalManagement.Show();
                        this.Hide();
                        break;
                    default: break;
                }
            }
        }
        #endregion

        #region 戻るボタン
        // 戻るボタンがクリックされたときの処理
        private void ButtonBackListDisplay_Click(object? sender, EventArgs e)
        {
            mainMenuForm.Show();
            this.Close();
        }
        #endregion
    }
}

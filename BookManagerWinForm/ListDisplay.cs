﻿using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace BookManagerWinForm
{
    public partial class ListDisplay : Form
    {
        #region define
        private readonly int empNum;
        private readonly bool isEditor;
        private readonly MainMenu mainMenuForm;
        private readonly DatabaseManager dbManager;
        private readonly string viewName = "view_all";

        enum StatusNum
        {
            Applying_Purchase = 0, //購入申請中
            Purchase_Approved = 1, //購入承認済み 購入待ち
            Purchase_Disapproved = 2, //購入不承認
            Available_Rent = 3, //貸出可能
            Applying_Loan = 4, //貸出申請中
            Approved_Loan = 5, //貸出承認済み
            Currently_Loan = 7, //貸出中 期日何日
            Currently_loan_past_date = 8 //貸出中 期日超過
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

        // フォームが表示されたらdataをロード
        private void ListDisplay_VisibleChanged(object sender, EventArgs e)
        {
            LoadDataFromView();
        }

        private void LoadDataFromView()
        {
            // データグリッドビューの列をクリアする
            dataGridView1.Columns.Clear();

            // NO列をボタン列に変更する
            DataGridViewButtonColumn buttonColumn = new()
            {
                HeaderText = "ActionButton",
                Name = "アクションボタン",
                FlatStyle = FlatStyle.Flat, // FlatStyleをFlatに設定する
                DataPropertyName = "Button"
            };

            // ボタンの外観をカスタマイズする
            buttonColumn.DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            buttonColumn.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            buttonColumn.FlatStyle = FlatStyle.Popup;

            // ステータス列を追加する
            DataGridViewTextBoxColumn statusColumn = new()
            {
                HeaderText = "ステータス",
                Name = "ステータス",
                DataPropertyName = "Status"
            };

            this.dataGridView1.Columns.Add(buttonColumn);
            this.dataGridView1.Columns.Add(statusColumn);

            // 行ヘッダーを非表示にして左の編集列を非表示にする
            dataGridView1.RowHeadersVisible = false;

            // データを取得する処理
            DataTable data = dbManager.GetDataFromView(viewName);

            // ActionButton列を追加し、ボタンを設定する
            DataColumn button = new("Button")
            {
                DataType = typeof(string)
            };
            data.Columns.Add(button);

            // Status列を追加し、ステータスを設定する
            DataColumn status = new("Status")
            {
                DataType = typeof(string)
            };
            data.Columns.Add(status);

            for (int i = 0; i < data.Rows.Count; i++)
            {
                // s.status_numの値に応じてボタンのテキストを設定する
                StatusNum statusNum = (StatusNum)Convert.ToInt32(data.Rows[i]["status_num"]);
                switch (statusNum)
                {
                    case StatusNum.Applying_Purchase: //購入申請中
                        data.Rows[i]["Button"] = "購入確認";
                        data.Rows[i]["Status"] = "購入申請中";
                        break;
                    case StatusNum.Purchase_Approved: //購入承認済み 購入待ち
                        data.Rows[i]["Button"] = "購入完了処理";
                        data.Rows[i]["Status"] = "購入承認済み 購入待ち";
                        break;
                    case StatusNum.Purchase_Disapproved: //購入不承認
                        data.Rows[i]["Button"] = "購入不承認変更";
                        data.Rows[i]["Status"] = "購入不承認";
                        break;
                    case StatusNum.Available_Rent: //貸出可能
                        data.Rows[i]["Button"] = "貸出申請";
                        data.Rows[i]["Status"] = "貸出可能";
                        break;
                    case StatusNum.Applying_Loan: //貸出申請中
                        data.Rows[i]["Button"] = "貸出確認";
                        data.Rows[i]["Status"] = "貸出申請中";
                        break;
                    case StatusNum.Approved_Loan: //貸出承認済み
                        data.Rows[i]["Button"] = "貸出完了処理";
                        data.Rows[i]["Status"] = "貸出承認済み";
                        break;
                    case StatusNum.Currently_Loan: //貸出中 期日何日
                    case StatusNum.Currently_loan_past_date: //貸出中 期日超過
                        data.Rows[i]["Button"] = "返却完了処理";
                        data.Rows[i]["Status"] = "貸出中";
                        break;
                    default:
                        data.Rows[i]["Button"] = "-";
                        data.Rows[i]["Status"] = "不明";
                        break;
                }
            }
            // DataGridViewにデータをロード
            dataGridView1.DataSource = data;
        }


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

        // アクションを処理するメソッド
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
                    case StatusNum.Applying_Purchase: // 購入依頼
                    case StatusNum.Purchase_Approved: // 購入承認
                    case StatusNum.Purchase_Disapproved: // 購入不承認

                        PurchaseResponse purchaseResponse = new(empNum, isEditor, book_id, this);
                        purchaseResponse.Show();
                        this.Hide();
                        break;
                    case StatusNum.Available_Rent: // rentalRequestに対する処理
                        RentalRequest rentalRequest = new(empNum, isEditor, book_id, this);
                        rentalRequest.Show();
                        this.Hide();
                        break;
                    default: break;
                        /*
             Applying_Purchase = 0, //購入申請中
             Purchase_Approved = 1, //購入承認済み 購入待ち
             Purchase_Disapproved = 2, //購入不承認
             Available_Rent = 3, //貸出可能
             Applying_Loan = 4, //貸出申請中
             Approved_Loan = 5, //貸出承認済み
             Currently_Loan = 7, //貸出中 期日何日
             Currently_loan_past_date = 8 //貸出中 期日超過
                         */
                }
            }
        }

        // 戻るボタンがクリックされたときの処理
        private void ButtonBackListDisplay_Click(object? sender, EventArgs e)
        {
            mainMenuForm.Show();
            this.Close();
        }
    }
}

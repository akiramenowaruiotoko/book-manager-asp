﻿using System;
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

        public ListDisplay(int empNum, bool isEditor, MainMenu mainMenuForm)
        {
            InitializeComponent();
            this.empNum = empNum;
            this.isEditor = isEditor;
            this.mainMenuForm = mainMenuForm;
            dbManager = new DatabaseManager(); // DatabaseManagerクラスのインスタンス化

            // DataGridView の CellContentClick イベントハンドラを設定
            dataGridView1.CellContentClick += DataGridView1_CellContentClick;

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

            // セルの編集を不可にする
            dataGridView1.ReadOnly = true;

            // 行ヘッダーを非表示にして左の編集列を非表示にする
            dataGridView1.RowHeadersVisible = false;

            // 最初の編集列を非表示にする
            dataGridView1.Columns[0].Visible = false;
        }

        // DataGridView のセルがクリックされたときの処理
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // ボタンがクリックされたことを確認する
            if (e.ColumnIndex == dataGridView1.Columns["アクションボタン"].Index && e.RowIndex != -1)
            {
                // クリックされた行の status_num の値を取得
                int statusNum = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["status_num"].Value);

                // status_num の値をポップアップで表示
                MessageBox.Show($"Status Num: {statusNum}", "Status Num", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // 戻るボタンがクリックされたときの処理
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            mainMenuForm.Show();
            this.Close();
        }
    }
}

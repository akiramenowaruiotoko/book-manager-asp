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
        private string viewName = "View_all";

        public ListDisplay(int empNum, bool isEditor, MainMenu mainMenuForm)
        {
            InitializeComponent();
            this.empNum = empNum;
            this.isEditor = isEditor;
            this.mainMenuForm = mainMenuForm;
            dbManager = new DatabaseManager();
            LoadDataFromView();
        }

        private void LoadDataFromView()
        {
            DataTable dataTable = dbManager.GetDataFromView(viewName);

            // カスタムボタン列を追加
            DataGridViewColumn buttonColumn = new DataGridViewColumn(new DataGridViewButtonCell());
            buttonColumn.HeaderText = "ボタン";
            buttonColumn.Name = "customButtonColumn"; // 列の名前を設定
            dataGridView1.Columns.Insert(0, buttonColumn); // 0番目の位置に挿入

            // データをバインド
            dataGridView1.DataSource = dataTable;

            // 各行のボタンのテキストをstatus_numに応じて設定
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["status_num"].Value != null)
                {
                    int statusNum = Convert.ToInt32(row.Cells["status_num"].Value);
                    switch (statusNum)
                    {
                        case 0:
                            (row.Cells["customButtonColumn"] as DataGridViewButtonCell).Value = "A";
                            break;
                        case 1:
                            (row.Cells["customButtonColumn"] as DataGridViewButtonCell).Value = "B";
                            break;
                        default:
                            (row.Cells["customButtonColumn"] as DataGridViewButtonCell).Value = "Other";
                            break;
                    }
                }
            }
        }


        private void ButtonBack_Click(object sender, EventArgs e)
        {
            mainMenuForm.Show();
            this.Close();
        }
    }
}

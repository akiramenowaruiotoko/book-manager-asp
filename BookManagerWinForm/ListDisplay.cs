using System.Data;
using DataGridViewAutoFilter;

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
        private string viewName = "view_all";

        enum ViewNum
        {
            view_all = 0,
            view_books = 1,
            view_employees = 2,
            view_statuses = 3
        }

        enum StatusNum
        {
            Applying_Purchase = 0,
            Purchase_Approved = 1,
            Purchase_Disapproved = 2,
            Available_Rental = 3,
            Applying_Rental = 4,
            Approved_Rental = 5,
            Unavailable_Rental = 6,
            Currently_Rental = 7,
            Currently_Rental_Past = 8
        }
        #endregion

        #region constructor
        public ListDisplay(int empNum, bool isEditor, MainMenu mainMenu)
        {
            InitializeComponent();
            this.empNum = empNum;
            this.isEditor = isEditor;
            this.mainMenuForm = mainMenu;
            dbManager = new DatabaseManager();

            // add event handler
            dataGridView1.CellContentClick += DataGridView1_CellContentClick;
            dataGridView1.KeyDown += DataGridView1_KeyDown;
        }
        #endregion

        #region eventhandler
        private void ListDisplay_VisibleChanged(object sender, EventArgs e)
        {
            viewSet();
        }

        private void comboBoxList_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewSet();
        }


        private void DataGridView1_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count && dataGridView1.Rows[e.RowIndex].Cells["アクションボタン"].Selected)
            {
                HandleAction(e.RowIndex);
            }
        }

        private void DataGridView1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                HandleAction(rowIndex);
            }
        }

        private void ButtonBackListDisplay_Click(object? sender, EventArgs e)
        {
            mainMenuForm.Show();
            this.Close();
        }
        #endregion

        #region load data from view and resize form
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

        private void LoadDataFromView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.RowHeadersVisible = false;

            DataTable data = dbManager.GetDataFromView(viewName);

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

            // データをバインドする
            var bindSrc = new BindingSource();
            bindSrc.DataSource = data;
            dataGridView1.DataSource = bindSrc;
            if (dataGridView1.DataSource == null)
            {
                return;
            }

            // 各列にフィルタを設定する
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.HeaderCell = new
                    DataGridViewAutoFilterColumnHeaderCell(col.HeaderCell);
            }
            dataGridView1.AutoResizeColumns();
            ResizeDataGridViewAndForm();
        }

        private void ResizeDataGridViewAndForm()
        {
            int totalWidth = 0;
            int rowCount = dataGridView1.Rows.Count;

            int dataGridViewHeight = Math.Min(rowCount * dataGridView1.Rows[0].Height + 80, 1200); 
            dataGridView1.ClientSize = new Size(dataGridView1.ClientSize.Width, dataGridViewHeight);

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                totalWidth += col.Width;
            }

            int dataGridViewWidth = totalWidth + 40;
            dataGridView1.ClientSize = new Size(dataGridViewWidth, dataGridView1.ClientSize.Height);

            int formWidth = dataGridViewWidth + 64;
            int formHeight = dataGridViewHeight + 200;
            this.ClientSize = new Size(formWidth, Math.Min(formHeight, 1700));
        }
        #endregion

        #region add column and button in data grid view
        private DataTable addActionButton(DataTable data)
        {
            DataGridViewButtonColumn buttonColumn = new()
            {
                HeaderText = "ActionButton",
                Name = "アクションボタン",
                FlatStyle = FlatStyle.Flat,
                DataPropertyName = "Button"
            };

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

        #region set text to button and column
        private DataTable setActionButton(DataTable data)
        {
            for (int i = 0; i < data.Rows.Count; i++)
            {
                StatusNum statusNum = (StatusNum)Convert.ToInt32(data.Rows[i]["status_num"]);
                switch (statusNum)
                {
                    case StatusNum.Applying_Purchase:
                        data.Rows[i]["Button"] = "購入確認";
                        break;
                    case StatusNum.Purchase_Approved:
                        data.Rows[i]["Button"] = "購入完了処理";
                        break;
                    case StatusNum.Purchase_Disapproved:
                        data.Rows[i]["Button"] = "購入不承認変更";
                        break;
                    case StatusNum.Available_Rental:
                        data.Rows[i]["Button"] = "貸出申請";
                        break;
                    case StatusNum.Applying_Rental:
                        data.Rows[i]["Button"] = "貸出確認";
                        break;
                    case StatusNum.Approved_Rental:
                        data.Rows[i]["Button"] = "貸出完了処理";
                        break;
                    case StatusNum.Unavailable_Rental:
                        data.Rows[i]["Button"] = "貸出不可変更";
                        break;
                    case StatusNum.Currently_Rental:
                    case StatusNum.Currently_Rental_Past:
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
                StatusNum statusNum = (StatusNum)Convert.ToInt32(data.Rows[i]["status_num"]);
                switch (statusNum)
                {
                    case StatusNum.Applying_Purchase:
                        data.Rows[i]["Status"] = "購入申請中";
                        break;
                    case StatusNum.Purchase_Approved:
                        data.Rows[i]["Status"] = "購入承認済み 購入待ち";
                        break;
                    case StatusNum.Purchase_Disapproved:
                        data.Rows[i]["Status"] = "購入不承認";
                        break;
                    case StatusNum.Available_Rental:
                        data.Rows[i]["Status"] = "貸出可能";
                        break;
                    case StatusNum.Applying_Rental:
                        data.Rows[i]["Status"] = "貸出申請中";
                        break;
                    case StatusNum.Approved_Rental:
                        data.Rows[i]["Status"] = "貸出承認済み";
                        break;
                    case StatusNum.Unavailable_Rental:
                        data.Rows[i]["Status"] = "貸出不可";
                        break;
                    case StatusNum.Currently_Rental:
                    case StatusNum.Currently_Rental_Past:
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

        #region handle action button
        private void HandleAction(int rowIndex)
        {
            if (viewNum == ViewNum.view_all)
            {
                string book_id = dataGridView1.Rows[rowIndex].Cells["book_id"].Value.ToString() ?? string.Empty;
                StatusNum statusNum = (StatusNum)Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["status_num"].Value);

                switch (statusNum)
                {
                    case StatusNum.Applying_Purchase:
                    case StatusNum.Purchase_Approved:
                    case StatusNum.Purchase_Disapproved:
                        PurchaseManagement purchaseManagement = new(empNum, isEditor, book_id, this);
                        purchaseManagement.Show();
                        this.Hide();
                        break;
                    case StatusNum.Available_Rental:
                        RentalRequest rentalRequest = new(empNum, isEditor, book_id, this);
                        rentalRequest.Show();
                        this.Hide();
                        break;
                    case StatusNum.Applying_Rental:
                    case StatusNum.Approved_Rental:
                    case StatusNum.Unavailable_Rental:
                    case StatusNum.Currently_Rental:
                    case StatusNum.Currently_Rental_Past:
                        RentalManagement rentalManagement = new(empNum, isEditor, book_id, this);
                        rentalManagement.Show();
                        this.Hide();
                        break;
                    default: break;
                }
            }
            else if (viewNum == ViewNum.view_books)
            {
                string book_id = dataGridView1.Rows[rowIndex].Cells["book_id"].Value.ToString() ?? string.Empty;
                EditBook editBook = new(empNum, isEditor, book_id, this);
                editBook.Show();
                this.Hide();
            }
            else if (viewNum == ViewNum.view_employees)
            {
                int targetEmployeeNumber = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["employee_number"].Value);
                EditEmployee editEmployee = new(empNum, isEditor, targetEmployeeNumber, this);
                editEmployee.Show();
                this.Hide();
            }
        }
        #endregion
    }
}


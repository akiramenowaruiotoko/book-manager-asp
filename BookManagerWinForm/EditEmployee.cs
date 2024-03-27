using System.Data;

namespace BookManagerWinForm
{
    public partial class EditEmployee : Form
    {
        private readonly int empNum;
        private readonly bool isEditor;
        private readonly ListDisplay listDisplayForm;
        private readonly DatabaseManager dbManager;
        private int targetEmployeeNumber;
        private readonly string viewName = "view_employees";


        public EditEmployee(int empNum, bool isEditor, int targetEmployeeNumber, ListDisplay listDisplayForm)
        {
            InitializeComponent();
            this.empNum = empNum;
            this.isEditor = isEditor;
            this.targetEmployeeNumber = targetEmployeeNumber;
            this.listDisplayForm = listDisplayForm;
            dbManager = new DatabaseManager();
            DataTable data = dbManager.GetEmployeeRecordFromView(viewName, targetEmployeeNumber);
            textBoxEmployeeNumber.Text = data.Rows[0]["employee_number"].ToString();
            textBoxEmployeePassword.Text = data.Rows[0]["employee_password"].ToString();
            textBoxFirstName.Text = data.Rows[0]["first_name"].ToString();
            checkBoxEditor.Checked = Convert.ToBoolean(data.Rows[0]["editor"]);
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            listDisplayForm.Show();
            this.Close();
        }

        private void ButtonEdditEmployee_Click(object sender, EventArgs e)
        {
            int employeeNumber = int.Parse(textBoxEmployeeNumber.Text);
            string employeePassword = textBoxEmployeePassword.Text;
            string firstName = textBoxFirstName.Text;
            bool editor = checkBoxEditor.Checked;
            // 書籍申請を行い、結果を直接条件式で使用
            if (dbManager.EditEmployee(targetEmployeeNumber, employeeNumber, employeePassword, firstName, editor))
            {
                MessageBox.Show("処理が完了しました。");
                listDisplayForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("編集後の従業員番号は既に存在しています。\n申請を中止します。");
            }
        }

        private void buttonDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (dbManager.DeleteEmployee(targetEmployeeNumber))
            {
                MessageBox.Show("処理が完了しました。");
                listDisplayForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("削除対象が存在しません。\n申請を中止します。");
            }

        }
    }
}
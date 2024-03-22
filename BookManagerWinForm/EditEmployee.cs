using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagerWinForm
{
    public partial class EditEmployee : Form
    {
        private readonly int empNum;
        private readonly bool isEditor;
        private readonly Edit editForm;
        private readonly DatabaseManager dbManager;
        private int targetEmployeeNumber = 0;
        private readonly string viewName = "view_employees";


        public EditEmployee(int empNum, bool isEditor, Edit editForm)
        {
            InitializeComponent();
            this.empNum = empNum;
            this.isEditor = isEditor;
            this.editForm = editForm;
            dbManager = new DatabaseManager();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            editForm.Show();
            this.Close();
        }

        private void ButtonEdditEmployee_Click(object sender, EventArgs e)
        {
            if (targetEmployeeNumber == 0)
            {
                MessageBox.Show("編集する従業員番号を設定してください");
                return;
            }

            int employeeNumber = int.Parse(textBoxEmployeeNumber.Text);
            string employeePassword = textBoxEmployeePassword.Text;
            string firstName = textBoxFirstName.Text;
            bool editor = checkBoxEditor.Checked;
            // 書籍申請を行い、結果を直接条件式で使用
            if (dbManager.EditEmployee(targetEmployeeNumber, employeeNumber, employeePassword, firstName, editor))
            {
                MessageBox.Show("処理が完了しました。");
            }
            else
            {
                MessageBox.Show("編集後の従業員番号は既に存在しています。\n申請を中止します。");
            }

        }

        #region　編集　従業員情報　表示
        private void ButtonTargetDisplay_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxTargetEmployeeNumber.Text, out targetEmployeeNumber))
            {
                MessageBox.Show("従業員番号を整数で入力してください。");
                return;
            }

            DataTable data = dbManager.GetRecordDataFromView(viewName, targetEmployeeNumber);
            if (data.Rows.Count == 0)
            {
                MessageBox.Show("データが見つかりませんでした。");
                return;
            }

            textBoxEmployeeNumber.Text = data.Rows[0]["employee_number"].ToString();
            textBoxEmployeePassword.Text = data.Rows[0]["employee_password"].ToString();
            textBoxFirstName.Text = data.Rows[0]["first_name"].ToString();
            checkBoxEditor.Checked = Convert.ToBoolean(data.Rows[0]["editor"]);
        }
        #endregion
    }
}
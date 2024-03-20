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
    public partial class AddEmployee : Form
    {
        private int empNum;
        private bool isEditor;
        private Edit editForm;
        private DatabaseManager dbManager;

        public AddEmployee(int empNum, bool isEditor, Edit editForm)
        {
            this.empNum = empNum;
            this.isEditor = isEditor;
            this.editForm = editForm;
            dbManager = new DatabaseManager();
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            editForm.Show();
            this.Close();
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            int employeeNumber = int.Parse(textBoxEmployeeNumber.Text);
            string employeePassword = textBoxEmployeePassword.Text;
            string firstName = textBoxFirstName.Text;
            bool editor = checkBoxEditor.Checked;
            // 書籍申請を行い、結果を直接条件式で使用
            if (dbManager.AddEmployee(employeeNumber, employeePassword, firstName, editor))
            {
                MessageBox.Show("処理が完了しました。");
            }
            else
            {
                MessageBox.Show("既に存在しています。申請を中止します。");
            }

        }
    }
}

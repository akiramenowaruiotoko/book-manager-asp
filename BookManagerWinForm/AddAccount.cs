using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagerWinForm
{
    public partial class AddAccount : Form
    {
        private int empNum;
        private bool isEditor;
        private Edit editForm;
        private DatabaseManager dbManager;

        public AddAccount(int empNum, bool isEditor, Edit editForm)
        {
            this.empNum = empNum;
            this.isEditor = isEditor;
            this.editForm = editForm;
            dbManager = new DatabaseManager();
            InitializeComponent();
        }

        private void buttonBackAddAcocunt_Click(object sender, EventArgs e)
        {
            editForm.Show();
            this.Close();
        }
    }
}

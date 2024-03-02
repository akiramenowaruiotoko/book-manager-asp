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
    public partial class PurchaseCheck : Form
    {
        private int empNum;
        private bool isEditor;
        private ListDisplay listDisplayFrom;
        private DatabaseManager dbManager;

        public PurchaseCheck(int empNum, bool isEditor, ListDisplay listDisplay)
        {
            InitializeComponent();
            this.empNum = empNum;
            this.isEditor = isEditor;
            this.listDisplayFrom = listDisplay;
            dbManager = new DatabaseManager();
        }
        private void buttonBackPurchaseCheck_Click(object sender, EventArgs e)
        {
            listDisplayFrom.Show();
            this.Close();
        }
    }
}

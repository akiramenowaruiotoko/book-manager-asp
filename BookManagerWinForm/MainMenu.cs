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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void ButtonLogOut_Click(object sender, EventArgs e)
        {
            // show Home
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void ButtonListDisplay_Click(object sender, EventArgs e)
        {
            ListDisplay listDisplay = new ListDisplay();
            listDisplay.Show();
        }
    }
}

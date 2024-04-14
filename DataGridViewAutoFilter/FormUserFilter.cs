using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewAutoFilter
{
    public partial class FormUserFilter : Form
    {
        /// <summary>
        /// filter condition
        /// </summary>
        private string[] filterCategory = new string[]
        {
            "",
            "equal to",
            "not equal to",
            "greater than",
            "greater than or equal to",
            "less than",
            "less than or equal to",
            "begins with",
            "does not begin with",
            "ends with",
            "dose not end with",
            "contains",
            "does not contain"
        };

        // control array
        private const int RAD_ZERO = 0;
        private const int RAD_ONE = 1;
        private const int RAD_BUTTON_NUM = 2;
        private RadioButton[] radSelect = new RadioButton[RAD_BUTTON_NUM];

        // target data
        private OrderedDictionary filters = new OrderedDictionary();

        // search condition
        private SearchInfo sInfo; // search condition
        private string column; // search column name
        private string searchStr; // search string

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="Filters"></param>
        /// <param name="SInfo"></param>
        /// <param name="Column"></param>
        public FormUserFilter(OrderedDictionary Filters, SearchInfo SInfo, string Column)
        {
            InitializeComponent();

            filters = Filters;
            sInfo = SInfo;
            column = Column;
            searchStr = "";
        }

        /// <summary>
        /// form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void formUserFilter_Load(object sender, EventArgs e)
        {
            SetCmbFilter();
            SetCmbSelect();
            SetControlArray();
            SetSearchInfo();
        }

        /// <summary>
        /// Previous Search Information Setting
        /// </summary>
        private void SetSearchInfo()
        {
            try
            {
                comboBoxSelect1.Text = sInfo.search1;
                comboBoxSelect2.Text = sInfo.search2;

                comboBoxFilter1.SelectedIndex = sInfo.filter1;
                comboBoxFilter2.SelectedIndex = sInfo.filter2;

                radSelect[RAD_ZERO].Checked = true;
            }
            catch (Exception e)
            {
            }
        }

        /// <summary>
        /// set control array
        /// </summary>
        private void SetControlArray()
        {
            radSelect[RAD_ZERO] = radioButtonAnd;
            radSelect[RAD_ONE] = radioButtonOr;

            radSelect[RAD_ZERO].Checked = true;
        }

        /// <summary>
        /// set combo box condition
        /// </summary>
        private void SetCmbFilter()
        {
            comboBoxSelect1.BeginUpdate();
            comboBoxSelect2.BeginUpdate();

            comboBoxSelect1.Items.Add("");
            comboBoxSelect2.Items.Add("");

            foreach (string val in filters.Values)
            {
                if (val != null)
                {
                    comboBoxSelect1.Items.Add (val);
                    comboBoxSelect2.Items.Add (val);
                }
            }

            comboBoxSelect1.EndUpdate();
            comboBoxSelect2.EndUpdate();
        }

        /// <summary>
        /// set combo box filter
        /// </summary>
        private void SetCmbSelect()
        {
            comboBoxFilter1.Items.AddRange(filterCategory);
            comboBoxFilter1.SelectedIndex = 1;

            comboBoxFilter2.Items.AddRange(filterCategory);
        }

        /// <summary>
        /// serch string setting process
        /// </summary>
        /// <param name="str"></param>
        /// <param name="indx"></param>
        /// <returns></returns>
        private string SetFilterCondition(string str, int indx)
        {
            string target = "";
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            sb.Append(column);
            sb.Append(']');

            target = str.Replace("'", "''");

            switch (indx)
            {
                case 1: // "equal to",
                    sb.Append("=");
                    sb.Append("'");
                    sb.Append(target);
                    sb.Append("'");
                    break;
                case 2: // "not equal to",
                    sb.Append("<>");
                    sb.Append("'");
                    sb.Append(target);
                    sb.Append("'");
                    break;
                case 3: // "greater than",
                    sb.Append(">");
                    sb.Append("'");
                    sb.Append(target);
                    sb.Append("'");
                    break;
                case 4: // "greater than or equal to",
                    sb.Append(">=");
                    sb.Append("'");
                    sb.Append(target);
                    sb.Append("'");
                    break;
                case 5: // "less than",
                    sb.Append("<");
                    sb.Append("'");
                    sb.Append(target);
                    sb.Append("'");
                    break;
                case 6: // "less than or equal to",
                    sb.Append("<=");
                    sb.Append("'");
                    sb.Append(target);
                    sb.Append("'");
                    break;
                case 7: // "begins with",
                    sb.Append("LIKE '");
                    sb.Append(target);
                    sb.Append("%'");
                    break;
                case 8: // "does not begin with",
                    sb.Append("NOT LIKE '");
                    sb.Append(target);
                    sb.Append("%'");
                    break;
                case 9: // "ends with",
                    sb.Append("LIKE ");
                    sb.Append("'");
                    sb.Append(target);
                    sb.Append("%'");
                    break;
                case 10: // "dose not end with",
                    sb.Append("NOT LIKE ");
                    sb.Append("'%");
                    sb.Append(target);
                    sb.Append("'");
                    break;
                case 11: // "contains",
                    sb.Append("LIKE '%");
                    sb.Append(target);
                    sb.Append("%'");
                    break;
                case 12: // "does not contain"
                    sb.Append("NOT LIKE '%");
                    sb.Append(target);
                    sb.Append("%'");
                    break;
                default:
                    break;
            }

            // setting of current search information
            sInfo.search1 = comboBoxSelect1.Text;
            sInfo.search2 = comboBoxSelect2.Text;
            sInfo.filter1 = comboBoxFilter1.SelectedIndex;
            sInfo.filter2 = comboBoxFilter2.SelectedIndex;

            for(int i = 0; i < radSelect.Length; i++)
            {
                if (radSelect[i].Checked)
                {
                    sInfo.sel = i;
                }
            }

            return sb.ToString();
        }

        /// <summary>
        /// OK button press processing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

            if (comboBoxFilter1.Text != "")
            {
                searchStr = SetFilterCondition(comboBoxSelect1.Text, comboBoxFilter1.SelectedIndex);
            }

            if (comboBoxFilter2.Text != "")
            {
                // if there are two or more conditions, enclose them in parentheses ()
                searchStr = "(" + searchStr;
                if (radSelect[RAD_ZERO].Checked)
                {
                    searchStr += "AND";
                }
                else if (radSelect[RAD_ONE].Checked)
                {
                    searchStr += "OR";
                }
                searchStr += SetFilterCondition(comboBoxSelect2.Text, comboBoxFilter2.SelectedIndex);
                searchStr += ")";
            }

            Close();
        }

        /// <summary>
        /// Cancel button press processing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// get search string processing
        /// </summary>
        /// <returns></returns>
        public string GetSearchString()
        {
            return searchStr;
        }

        /// <summary>
        /// search information
        /// </summary>
        /// <returns></returns>
        public SearchInfo GetSearchInfo()
        {
            return sInfo;
        }
    }
}

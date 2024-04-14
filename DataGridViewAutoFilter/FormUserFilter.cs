using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataGridViewAutoFilter
{
    public partial class formUserFilter : Form
    {
        /// <summary>
        /// フィルタ条件
        /// </summary>
        private string[] filterCategory = new string[13] {
            "",
            "と等しい",
            "と等しくない",
            "より大きい",
            "以上",
            "より小さい",
            "以下",
            "で始まる",
            "で始まらない",
            "で終わる",
            "で終わらない",
            "を含む",
            "を含まない"
        };

        // コントロール配列(AND・OR ラジオボタン)
        private const int RAD_ZERO = 0;
        private const int RAD_ONE = 1;
        private const int RAD_BUTTON_NUM = 2;
        private RadioButton[] radSelect = new RadioButton[RAD_BUTTON_NUM];

        // 対象データ
        private System.Collections.Specialized.OrderedDictionary filters = new System.Collections.Specialized.OrderedDictionary();

        // 検索条件
        private SearchInfo sInfo;       // 検索条件
        private string column;          // 検索カラム名
        private string searchStr;       // 検索文字列

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="Filters">対象データ</param>
        /// <param name="SearcInfo">検索条件</param>
        /// <param name="Column">対象カラム</param>
        public formUserFilter(System.Collections.Specialized.OrderedDictionary Filters,
                                SearchInfo SInfo,
                                string Column)
        {
            InitializeComponent();

            filters = Filters;
            sInfo = SInfo;
            column = Column;
            searchStr = "";
        }

        /// <summary>
        /// フォームロード
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
        /// 前回検索情報設定
        /// </summary>
        private void SetSearchInfo()
        {
            try
            {
                cmbSelect1.Text = sInfo.search1;
                cmbSelect2.Text = sInfo.search2;

                cmbFilter1.SelectedIndex = sInfo.filter1;
                cmbFilter2.SelectedIndex = sInfo.filter2;

                radSelect[sInfo.sel].Checked = true;
            }
            catch (Exception e)
            {
            }
        }

        /// <summary>
        /// コントロール配列設定
        /// </summary>
        private void SetControlArray()
        {
            radSelect[RAD_ZERO] = radAnd;
            radSelect[RAD_ONE] = radOr;

            radSelect[RAD_ZERO].Checked = true;
        }

        /// <summary>
        /// コンボボックス(条件)設定
        /// </summary>
        private void SetCmbFilter()
        {
            cmbSelect1.BeginUpdate();
            cmbSelect2.BeginUpdate();

            cmbSelect1.Items.Add("");
            cmbSelect2.Items.Add("");

            foreach (string val in filters.Values)
            {
                if (val != null)
                {
                    cmbSelect1.Items.Add(val);
                    cmbSelect2.Items.Add(val);
                }
            }

            cmbSelect1.EndUpdate();
            cmbSelect2.EndUpdate();
        }

        /// <summary>
        /// コンボボックス(フィルタ)設定
        /// </summary>
        private void SetCmbSelect()
        {
            cmbFilter1.Items.AddRange(filterCategory);
            cmbFilter1.SelectedIndex = 1;

            cmbFilter2.Items.AddRange(filterCategory);
        }

        /// <summary>
        /// 検索文字列設定処理
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
            sb.Append("]");

            target = str.Replace("'", "''");

            switch (indx)
            {
                case 1:     // と等しい
                    sb.Append("=");
                    sb.Append("'");
                    sb.Append(target);
                    sb.Append("'");
                    break;
                case 2:     // と等しくない
                    sb.Append("<>");
                    sb.Append("'");
                    sb.Append(target);
                    sb.Append("'");
                    break;
                case 3:     // より大きい
                    sb.Append(">");
                    sb.Append("'");
                    sb.Append(target);
                    sb.Append("'");
                    break;
                case 4:     // 以上
                    sb.Append(">=");
                    sb.Append("'");
                    sb.Append(target);
                    sb.Append("'");
                    break;
                case 5:     // より小さい
                    sb.Append("<");
                    sb.Append("'");
                    sb.Append(target);
                    sb.Append("'");
                    break;
                case 6:     // 以下
                    sb.Append("<=");
                    sb.Append("'");
                    sb.Append(target);
                    sb.Append("'");
                    break;
                case 7:     // で始まる
                    sb.Append("LIKE '");
                    sb.Append(target);
                    sb.Append("%'");
                    break;
                case 8:     // で始まらない
                    sb.Append("NOT LIKE '");
                    sb.Append(target);
                    sb.Append("%'");
                    break;
                case 9:     // で終わる
                    sb.Append("LIKE ");
                    sb.Append("'");
                    sb.Append(target);
                    sb.Append("%'");
                    break;
                case 10:     // で終わらない
                    sb.Append("NOT LIKE ");
                    sb.Append("'%");
                    sb.Append(target);
                    sb.Append("'");
                    break;
                case 11:    // を含む
                    sb.Append("LIKE '%");
                    sb.Append(target);
                    sb.Append("%'");
                    break;
                case 12:    // を含まない
                    sb.Append("NOT LIKE '%");
                    sb.Append(target);
                    sb.Append("%'");
                    break;
                default:
                    break;
            }

            // 今回検索情報の設定
            sInfo.search1 = cmbSelect1.Text;
            sInfo.search2 = cmbSelect2.Text;
            sInfo.filter1 = cmbFilter1.SelectedIndex;
            sInfo.filter2 = cmbFilter2.SelectedIndex;

            for (int i = 0; i < radSelect.Length; i++)
            {
                if (radSelect[i].Checked)
                {
                    sInfo.sel = i;
                }
            }

            return sb.ToString();
        }

        /// <summary>
        /// OKボタン押下処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

            if (cmbFilter1.Text != "")
            {
                searchStr = SetFilterCondition(cmbSelect1.Text, cmbFilter1.SelectedIndex);
            }

            if (cmbFilter2.Text != "")
            {
                // 条件が2つ以上の場合は、カッコ( )で囲む
                searchStr = "(" + searchStr;
                if (radSelect[RAD_ZERO].Checked)
                {
                    searchStr += " AND ";
                }
                else if (radSelect[RAD_ONE].Checked)
                {
                    searchStr += " OR ";
                }
                searchStr += SetFilterCondition(cmbSelect2.Text, cmbFilter2.SelectedIndex);
                searchStr += ")";
            }

            Close();
        }

        /// <summary>
        /// キャンセルボタン押下処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// 検索文字列取得処理
        /// </summary>
        /// <returns></returns>
        public string GetSearchString()
        {
            return searchStr;
        }

        /// <summary>
        /// 検索情報
        /// </summary>
        /// <returns></returns>
        public SearchInfo GetSearchInfo()
        {
            return sInfo;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridViewAutoFilter
{
    /// <summary>
    /// 検索データ
    /// </summary>
    public class SearchInfo
    {
        public string search1;      //検索文字列1
        public string search2;      //検索文字列2
        public int filter1;         //検索フィルタ1
        public int filter2;         //検索フィルタ2
        public int sel;             //And Or選択

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public SearchInfo()
        {
            filter1 = 1;
            filter2 = 0;
            sel = 0;
        }
    }
}

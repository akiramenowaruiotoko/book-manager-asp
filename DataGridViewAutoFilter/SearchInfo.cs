using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridViewAutoFilter
{
    /// <summary>
    /// search data
    /// </summary>
    public class SearchInfo
    {
        public string search1;
        public string search2;
        public int filter1;
        public int filter2;
        public int sel; // And Or select

        /// <summary>
        /// constructor
        /// </summary>
        public SearchInfo()
        {
            filter1 = 1;
            filter2 = 0;
            sel = 0;
        }
    }
}

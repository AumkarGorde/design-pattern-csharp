using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StratergyPattern
{
    public class SortService
    {
        private ISortStratergy _sortStratergy;
        private List<string> _sortList;
        public SortService(ISortStratergy sortStratergy)
        {
            _sortStratergy = sortStratergy;
            _sortList = new List<string>();
        }

        public void Add(string s)
        {
            _sortList.Add(s);
        }

        public void Sort()
        {
            _sortStratergy.Sort();
        }
    }
}

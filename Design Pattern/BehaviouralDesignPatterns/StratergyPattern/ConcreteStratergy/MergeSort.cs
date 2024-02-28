using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StratergyPattern
{
    public class MergeSort : ISortStratergy
    {
        public void Sort()
        {
            Console.WriteLine("Sorted by merge sort");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StratergyPattern
{
    public class BubbleSort : ISortStratergy
    {
        public void Sort()
        {
            Console.WriteLine("Sorted by Bubble Sort");
        }
    }
}

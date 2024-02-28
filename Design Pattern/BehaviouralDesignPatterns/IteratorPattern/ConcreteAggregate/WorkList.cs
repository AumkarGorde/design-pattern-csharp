using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class WorkList : IAggregate<Work>
    {
        private readonly List<Work> _works = new List<Work>();
        public void AddWork(Work work)
        {
            _works.Add(work);
        }

        public IIterator<Work> GetIterator()
        {
            return new WorkIterator(_works);
        }
    }
}

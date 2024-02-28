using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class WorkIterator : IIterator<Work>
    {
        private readonly List<Work> _works;
        private int _index = 0;

        public WorkIterator(List<Work> works)
        {
            _works = works;
        }
        public bool HasNext()
        {
            return _index < _works.Count;
        }

        public Work Next()
        {
            if (HasNext())
            {
                Work work = _works[_index];
                _index++;
                return work;
            }
            else
            {
                throw new InvalidOperationException("End of work list reached.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class Work
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public Work(string title, string description)
        {
            Title = title;
            Description = description;
        }
    }
}

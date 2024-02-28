using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class File : IFileSystemItem
    {
        private string _fileName;
        public File(string name)
        {
            _fileName = name;
        }
        public void Display()
        {
            Console.WriteLine($"    File : {_fileName}");
        }
    }
}

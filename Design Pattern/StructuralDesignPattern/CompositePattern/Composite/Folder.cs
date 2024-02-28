using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CompositePattern
{
    public class Folder : IFileSystemItem
    {
        string _folderName;
        private List<IFileSystemItem> items = new List<IFileSystemItem>();
        public Folder(string name)
        {
            _folderName = name;
        }
        public void AddItem(IFileSystemItem item)
        {
            items.Add(item);
        }

        public void RemoveItem(IFileSystemItem item)
        {
            items.Remove(item);
        }
        public void Display()
        {
            Console.WriteLine($"{_folderName}");
            foreach (var item in items)
            {
                item.Display();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class HighResolution : IImage
    {
        private string filePath;
        public HighResolution(string filePath)
        {
            this.filePath = filePath;
            LoadImageFromDisk();
        }
        public void Display()
        {
            Console.WriteLine($"Displaying high resolution image: {filePath}");
        }
        private void LoadImageFromDisk()
        {
            Console.WriteLine($"Loading image from disk: {filePath}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class ImageProxy : IImage
    {
        private string filePath;
        private HighResolution image;
        private bool _renderHigherResolution; 
        public ImageProxy(string filePath, bool renderHigherResolution = false)
        {
            this.filePath = filePath;
            _renderHigherResolution = renderHigherResolution;
        }
        public void Display()
        {
            if(_renderHigherResolution)
            {
                if(image == null) 
                {
                    image = new HighResolution(filePath);
                }
                image.Display();
            }
            else
            {
                Console.WriteLine($"Displaying low resolution image: {filePath}");
            }
        }
    }
}

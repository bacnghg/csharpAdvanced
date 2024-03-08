using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class PhotoFilters
    {
        public PhotoFilters() { }
        public void ApplyBrighness(Photo photo) 
        {
            Console.WriteLine("Apply brightness");
        }
        public void ApplyContrast(Photo photo) 
        {
            Console.WriteLine("Apply Constrast");
        }
        public void Resize(Photo photo) 
        {
            Console.WriteLine("Resize Photo");
        }
    }
}

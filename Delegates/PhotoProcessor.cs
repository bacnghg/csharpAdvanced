using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class PhotoProcessor
    {
        public delegate void PhotoFilterHandler(Photo photo);
        public void Process(string path, Action<Photo> filterHandler)
        //public void Process(string path)
        {
            var photo = Photo.Load(path);
            //var filters = new PhotoFilters();
            //filters.ApplyBrighness(photo);
            //filters.ApplyContrast(photo);
            //filters.Resize(photo);

            filterHandler(photo);

            photo.Save();
        }
    }
}

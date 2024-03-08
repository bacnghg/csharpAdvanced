using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class YoutubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                throw new Exception("Oops some low level Youtube error.");
            }
            catch (Exception ex) {
                throw new YoutubeException("Could not fetch the videos from Youtube.", ex);
            }

            return new List<Video>();
        }
    }
}

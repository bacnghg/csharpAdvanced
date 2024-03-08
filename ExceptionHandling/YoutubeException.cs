using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class YoutubeException : Exception
    {
        public YoutubeException(string mes, Exception innerException) : base(mes, innerException)
        { 

        }
    }
}

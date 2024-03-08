using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs eventArgs)
        {
            Console.WriteLine("MailServices: Sending an email..." + eventArgs.Video.Title);
        }
    }
}

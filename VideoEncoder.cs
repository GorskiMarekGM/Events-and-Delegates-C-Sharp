using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System;


namespace Delegates_and_Events
{
    class VideoEncoder
    {
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);
        }
    }
}

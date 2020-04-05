using System;
using System.Collections.Generic;
using System.Text;

namespace lab2._2
{
    class Listener
    {
        public void GetNotified(string sInfo)
        {
            Console.WriteLine("I got notified with the following information {0}", sInfo);
        }
        public static void GetNotifiedAgain(string sInfo) { Console.WriteLine("I got notified with the following information:{0}", sInfo); }
    }
}

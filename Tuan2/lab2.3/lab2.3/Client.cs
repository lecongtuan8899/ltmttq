using System;

namespace lab2._3
{
    class Client
    {
        private delegate void NotifyMe(string s1);
        static void Main(string[] args)
        {
            NotifyMe d = new NotifyMe(Listener.GetNotifiedAgain);
            InvokeDelegate(d);
            Listener lsnr = new Listener();
            NotifyMe d2 = new NotifyMe(lsnr.GetNotified);
            InvokeDelegate(d2);
            Console.ReadKey();
        }
        static void InvokeDelegate(NotifyMe d) 
        {
            d("You are late paying your bills!"); 
        }

    }
}

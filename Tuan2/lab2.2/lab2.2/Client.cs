using System;
using lab2._2;

namespace lab2._2
{
    class Client
    {
        private delegate void NotifyMe(string s1);
        static void Main(string[] args)
        {
           
            IHuman h; Theodore t; h = new Theodore();
            t = (Theodore)h;
            t.Name = "Fred";
            t.Speak("I like public implementations!");
            h.Name = "Teddy";
            h.Speak("I like VB!");
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

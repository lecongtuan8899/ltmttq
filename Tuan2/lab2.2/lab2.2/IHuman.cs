using System;
using System.Collections.Generic;
using System.Text;

namespace lab2._2
{
    interface IHuman
    {
        string Name { get; set; }

        public interface IHuman { void Speak(string Message); string Name { get; set; } }

        void Speak(string v);
    }
}

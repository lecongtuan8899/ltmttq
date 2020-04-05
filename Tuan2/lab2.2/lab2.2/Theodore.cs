using System;
using System.Collections.Generic;
using System.Text;

namespace lab2._2
{
    public class Theodore : IHuman
    {
        private string m_Name;
        public void Speak(string Message) { Console.WriteLine("Hi my name is {0}.\n" + Message, m_Name); }
        public string Name { get { return m_Name; } set { m_Name = value; } }
    }
}

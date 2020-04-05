using System;
using System.Collections.Generic;
using System.Text;

namespace lab2._1._2
{
    class Base
    {
        public Base() { Console.WriteLine("In Base Constructor!"); }
        public virtual void Method1() { Console.WriteLine("In Base.Method1"); }
        public void Method2() { Console.WriteLine("In Base.Method2"); }
    }
}

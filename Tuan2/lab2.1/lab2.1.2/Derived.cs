using System;
using System.Collections.Generic;
using System.Text;

namespace lab2._1._2
{
    class Derived:Base
    {
        public Derived(string var)
        {
            Console.WriteLine("In Derived constructor. Constructor parameter value:{0}", var);

        }
        public override void Method1() { Console.WriteLine("In Base.Method1"); }
        public new void Method2() { Console.WriteLine("In Derived.Method2"); }

    }
}

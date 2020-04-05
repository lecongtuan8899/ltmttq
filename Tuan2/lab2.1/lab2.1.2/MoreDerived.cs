using System;
using System.Collections.Generic;
using System.Text;

namespace lab2._1._2
{
    class MoreDerived : Derived
    {
            public MoreDerived() : base("DEFAULT")
        {
            Console.WriteLine("In MoreDerived Constructor!");

        }
    }
}

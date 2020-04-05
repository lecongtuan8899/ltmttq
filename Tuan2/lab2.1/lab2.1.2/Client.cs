using System;

namespace lab2._1._2
{
    class Client
    {
        static void Main(string[] args)
        {
            Base b; Derived d;     //create an instance of Derived     
            d = new Derived("test");    
            b = d;  
            b.Method2();//does this go to Derived implementation or Base?    
            d.Method2();//what about this call? 
        }
    }
}

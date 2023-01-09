using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
      public class Program2
    {

        public virtual void method(string a)
        {
            Console.WriteLine("class program 2 method call:"+a);
        }
  
    }

    public class Program3 : Program2
    {
        public override void method(string a)
        {
            Console.WriteLine("class Program 3  method call:" + a);
        }

    }
}

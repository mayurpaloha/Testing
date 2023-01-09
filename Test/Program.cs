using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        { 

            var str = "Revied15Error".ToCharArray().Where(x => !(x >= '0' && x <= '9')).ToArray();


            Math m = new Math();

            m.animalSound(); 

            Console.ReadLine();

 
        }
    }


    interface IMath
    {
        int Sum(int a, int b);
        double Sum(double a, double b);
    }


    public class Math : Animal 
    {
        public override void animalSound()
        {
            Console.WriteLine("animalSound");
        }
         

    }


    public abstract class Animal
    { 
        public abstract void animalSound(); 

        public Animal()
        {
            Console.WriteLine("constructor call");
        }
    }
}

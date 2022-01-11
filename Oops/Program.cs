using Oops.Inheritance;
using Oops.Polymorphism.MethodOverloading;
using Oops.Polymorphism.MethodOverriding;
using System;

namespace Oops
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            //Console.WriteLine("Inheritance"); 
            /*  Car c = new Car();
              Console.WriteLine(c.brand);
              c.start();

              Bike b = new Bike();
              Console.WriteLine("from child1"+b.brand);
              b.start();
              Console.Read();*/

            // Console.WriteLine("MethodOverloading");
            /*Add a = new Add();
            a.SumOFNumbers(10, 20);
            a.SumOFNumbers(20,40,40);
            a.SumOFNumbers(3, 4.55555f);
            Console.Read();*/

            // Console.WriteLine("MethodOverriding");
            Lion l = new Lion();
            l.AnimalSounds();
            Console.ReadLine();
        }
    }
}

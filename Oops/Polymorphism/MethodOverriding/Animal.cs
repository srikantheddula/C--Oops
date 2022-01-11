using System;
using System.Collections.Generic;
using System.Text;

namespace Oops.Polymorphism.MethodOverriding
{
    public class Animal
    {
        public void Run()
        {
            Console.WriteLine("Animal Runs");
        }
        public void AnimalSounds()
        {
            Console.WriteLine("Animal makes sound");
        }
    }
}

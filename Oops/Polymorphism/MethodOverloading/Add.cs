using System;
using System.Collections.Generic;
using System.Text;

namespace Oops.Polymorphism.MethodOverloading
{
    public class Add
    {
        public void SumOFNumbers(int x,int y)
        {
            int z = x + y;
            Console.WriteLine("metho1 Result:"+z);
        }
        public void SumOFNumbers(int x, float y)
        {
            float z = x + y;
            Console.WriteLine("method2 Result:" + z);
        }
        public void SumOFNumbers(int x, int y,int a)
        {
            int z = x + y+a;
            Console.WriteLine("method3 Result:" + z);
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsAppForTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("give first value:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("a = {0}", a);

            Console.WriteLine("give second value:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("b = {0}", b);

            if(a<b)
            {
                Console.WriteLine("{0} < {1}", a,b);
            }
            else
            {
                Console.WriteLine("{0} > {1}", a, b);
            }
            Console.ReadKey();
        }
    }
}

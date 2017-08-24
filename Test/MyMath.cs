using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class MyMath
    {

        public static String WiekszeMniejsze(int a, int b)
        {
            String AA = a.ToString();
            String BB = b.ToString();
            if (a < b)
            {
                return AA + "<" + BB;
            }
            else
            {
                return AA + ">" + BB;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 55;

            MyMath.WiekszeMniejsze(a, b);
            Console.ReadKey();
        }
    }
}

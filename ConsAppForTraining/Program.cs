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
            #region Class Sum
            //Console.WriteLine("give first value:");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("a = {0}", a);

            //Console.WriteLine("give second value:");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine("b = {0}", b);

            //int mniejsza, wieksza;
            //if (a > b)
            //{
            //    mniejsza = b;
            //    wieksza = a;
            //} else
            //{
            //    mniejsza = a;
            //    wieksza = b;
            //}

            //Console.WriteLine("liczba mniejsza = {0}; liczba wieksza = {1}", mniejsza, wieksza);
            //int suma = 0;
            //for (int i= mniejsza; i<= wieksza; i++)
            //{
            //    suma = suma + i;
            //}
            //Console.WriteLine("suma liczb miedzy {0} a {1} wynosi {2}", mniejsza, wieksza, suma);
            //Console.WriteLine();
            //Sum ss = new Sum();
            //Console.WriteLine("suma liczb miedzy {0} a {1} wynosi {2}", mniejsza, wieksza, ss.GenSum(mniejsza, wieksza));
            #endregion

            #region mine field

            int[,] map = new int[,] { { 1, 0, 3 }, { 0, 0, 0 }, { 0, 0, 111 } };

            Console.WriteLine(map[2, 2]);
            //int aa = Convert.ToInt32(Math.Sqrt(map.Length));
            for (int j = 0; j <= map.GetLength(1) ; j++)
            {
                for (int i = 0; i < map.GetLength(j); i++)
                {
                    Console.WriteLine("element {0}; j = {1}; i = {2}", map[j, i],j,i);

                    if (map[j,i] != 0)
                    {
                        Console.WriteLine("element [{0},{1}] jest rozny od zera", j,i);
                    }
                }
            }

            //Console.WriteLine("polozenie miny = " + MineField.MineLocation(map));

            #endregion
            Console.ReadKey();
        }
    }
}

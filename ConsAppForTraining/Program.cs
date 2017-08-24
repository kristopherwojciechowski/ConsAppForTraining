using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test;

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

            //int[,] map = new int[,] { { 1, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };

            //Console.WriteLine(map[2, 2]);


            //for(int i = 0; i< map.GetLength(0); i++)
            //{
            //    for(int j=0; j<map.GetLength(0); j++)
            //    {
            //        if (map[i, j] != 0)
            //        {
            //            Console.WriteLine("element [{0},{1}] jest rozny od zera", i, j);
            //        }
            //    }
            //}

            //Console.WriteLine("Metoda MineLocation => " + MineField.MineLocation(map));

            #endregion

            #region 3D field with random numbers of elements

            Random rr = new Random();

            //int numberOfElements = rr.Next(2,10);
            //Console.WriteLine("random num = " + numberOfElements);
            //int[,,] map3D = new int[numberOfElements, numberOfElements, numberOfElements];

            //for (int i=0; i<map3D.GetLength(0); i++)
            //{
            //    for (int ii=0; ii<map3D.GetLength(0); ii++)
            //    {
            //        for (int iii = 0; iii < map3D.GetLength(0); iii++)
            //        {
            //            map3D[i, ii, iii] = rr.Next(2);
            //            Console.WriteLine("element = {0}; x = {1}; y = {2}; z = {3}", map3D[i, ii, iii], i, ii, iii);
            //        }
            //    }
            //}
            //int iloscElementow = 0;
            //for (int i = 0; i < map3D.GetLength(0); i++)
            //{
            //    for (int ii = 0; ii < map3D.GetLength(0); ii++)
            //    {
            //        for (int iii = 0; iii < map3D.GetLength(0); iii++)
            //        {
            //            if (map3D[i, ii, iii] != 0)
            //            {
            //                Console.WriteLine("element [{0},{1},{2}] jest rozny od zera", i, ii, iii);
            //                iloscElementow++;
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("random num = " + numberOfElements);
            //Console.WriteLine();
            //Console.WriteLine("ilosc elementów rożnych od zera: {0}", iloscElementow);

            //foreach(int[] element in MineField.MineLocationList(map3D))
            //{
            //    Console.WriteLine("współrzędne elementu różnego od zera: {0}", element);

            //}

            #endregion

            #region
            int elementpoczatkowy = 0;
            int elementInt;
            string elementString;
            string start = elementpoczatkowy.ToString();
            string ciag;
            ciag = start;
            int n = rr.Next(999, 9999);
            int dlugoscStringa = ciag.Length;

            for (int i = 1; i < 15; i++)
            {
                //Console.WriteLine("iteracja: {0}", i);
                if (i % 2 == 1)
                {
                    for (int k = 0; k < dlugoscStringa; k++)
                    {
                        //Console.WriteLine("iteracjaB: {0}", k);

                        elementInt = Int16.Parse(ciag.Substring(k, 1));
                        //Console.WriteLine("element before : {0}", element);

                        int a;
                        if (elementInt == 0)
                        {
                            a = 1;
                        }
                        else
                        {
                            a = 0;
                        }
                        //Console.WriteLine("element after : {0}", a);
                        string cyfra = a.ToString();
                        ciag += cyfra;
                    }
                }
                else
                {
                    for (int m = dlugoscStringa - 1; m >= 0; m--)
                    {
                        elementString = ciag.Substring(m, 1);
                        ciag += elementString;
                    }
                }
                dlugoscStringa = ciag.Length;

                //Console.WriteLine("finalny ciag: {0}", ciag);
                //Console.WriteLine("ilosc elemntow w ciagu finalnym: {0}", ciag.Count());

                //Console.WriteLine();
            }

            //Console.WriteLine("wynik koncowy: " + ciag);
            String rozwiazanieA = ciag.Substring(0, n);

            Console.WriteLine("wylosowana liczba : " + n);

            Console.WriteLine("rozwiazanie A: " + rozwiazanieA);
            Console.WriteLine("rozwiazanie B: " + Morse.ThueMorse(n));

            Console.WriteLine("ilosc elementow w stringu: " + Morse.ThueMorse(n).Length);

            Console.WriteLine("ilosc elementow w stringu: " + rozwiazanieA.Length);

            #endregion

            #region
            //int elementpoczatkowy = 0;
            //int element;
            //string start = elementpoczatkowy.ToString();
            //string ciag;
            //string nowyCiag;
            //ciag = start;
            //int n = rr.Next(999, 9999);

            //for (int i = 0; i < 15; i++)
            //{
            //    //Console.WriteLine("iteracja: {0}", i);
            //    nowyCiag = "";

            //    for (int k = 0; k < ciag.Length; k++)
            //    {
            //        //Console.WriteLine("iteracjaB: {0}", k);

            //        element = Int16.Parse(ciag.Substring(k, 1));
            //        //Console.WriteLine("element before : {0}", element);

            //        int a;
            //        if (element == 0)
            //        {
            //            a = 1;
            //        }
            //        else
            //        {
            //            a = 0;
            //        }
            //        //Console.WriteLine("element after : {0}", a);
            //        string cyfra = a.ToString();
            //        nowyCiag = nowyCiag + cyfra;

            //        //Console.WriteLine("nowy ciag: {0}", nowyCiag);
            //    }
            //    int dlugoscStringa = ciag.Length;
            //    ciag = ciag + nowyCiag;

            //    //Console.WriteLine("finalny ciag: {0}", ciag);
            //    //Console.WriteLine("ilosc elemntow w ciagu finalnym: {0}", ciag.Count());

            //    //Console.WriteLine();

            //}

            //Console.WriteLine("wynik koncowy: " + ciag);
            ////int koniec = rr.Next(4444,9999);
            //String rozwiazanieA = ciag.Substring(0, n);

            //Console.WriteLine("wylosowana liczba : " + n);

            //Console.WriteLine("rozwiazanie A: " + rozwiazanieA);
            ////Console.WriteLine("rozwiazanie B: " + Morse.ThueMorse(koniec));

            ////Console.WriteLine("ilosc elementow w stringu: " + Morse.ThueMorse(koniec).Length);

            //Console.WriteLine("ilosc elementow w stringu: " + rozwiazanieA.Length);

            #endregion

            Console.ReadKey();
        }
    }
}

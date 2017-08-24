using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsAppForTraining
{
    class Morse
    {
        public static string MorseStringGen()
        {
            int element, a;
            string ciag = "0";
            int dlugoscStringa = ciag.Length;

            for (int i = 0; i < 14; i++)
            {
                for (int k = 0; k < dlugoscStringa; k++)
                {
                    element = Int16.Parse(ciag.Substring(k, 1));
                    if (element == 0)
                    {
                        a = 1;
                    }
                    else
                    {
                        a = 0;
                    }
                    string cyfra = a.ToString();
                    ciag = ciag + cyfra;
                }
                dlugoscStringa = ciag.Length;
            }
            return ciag;
        }

        public static string ThueMorse(int n)
        {
            string ciag = MorseStringGen();
            String rozwiazanie = ciag.Substring(0, n);
            return rozwiazanie;
        }
    }
}

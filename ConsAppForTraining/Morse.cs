using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsAppForTraining
{
    class Mors
    {
        public static string ThueMors(int n)
        {
            int elementInt, a;
            string ciag = "0";
            string elementString;
            int dlugoscStringa = ciag.Length;

            for (int i = 1; i < 15; i++)
            {
                if (i % 2 == 1)
                {
                    for (int k = 0; k < dlugoscStringa; k++)
                    {
                        elementInt = Int16.Parse(ciag.Substring(k, 1));
                        if (elementInt == 0)
                        {
                            a = 1;
                        }
                        else
                        {
                            a = 0;
                        }
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
            }
            //dlugoscStringa = ciag.Length;
            String rozwiazanie = ciag.Substring(0, n);
            return rozwiazanie;
        }
    }
}

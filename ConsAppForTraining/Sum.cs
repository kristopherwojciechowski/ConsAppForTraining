using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsAppForTraining
{
    class Sum
    {
        public int sum;

        public int GenSum(int a, int b)
        {
            int mniejsza, wieksza;
            if (a > b)
            {
                mniejsza = b;
                wieksza = a;
            }
            else
            {
                mniejsza = a;
                wieksza = b;
            }

            int suma = 0;
            for (int i = mniejsza; i <= wieksza; i++)
            {
                suma = suma + i;
            }
            return suma;
        }
    }
}

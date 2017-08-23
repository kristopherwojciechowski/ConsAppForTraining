using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsAppForTraining
{
    class MineField
    {
        public static Tuple<int,int> MineLocation(int[,] field)
        {
            int a = 0, b = 0;
            for (int j = 0; j < field.GetLength(0); j++)
            {
                for (int i = 0; i < field.GetLength(j); i++)
                {
                    if (field[j, i] != 0)
                    {
                        a = j;
                        b = i;
                    }
                }
            }
            return new Tuple<int, int>(a, b);
        }
    }
}

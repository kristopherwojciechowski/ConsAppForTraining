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
                for (int i = 0; i < field.GetLength(0); i++)
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
        public static List<int[]> MineLocationList(int[,,] field)
        {
            List<int[]> elemtsList = new List<int[]>();

            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int ii = 0; ii < field.GetLength(0); ii++)
                {
                    for (int iii = 0; iii < field.GetLength(0); iii++)
                    {
                        if (field[i, ii, iii] != 0)
                        {
                            int[] pozycja = new int[3] { i, ii, iii };
                            elemtsList.Add(pozycja);
                        }
        
                    }
                }
            }
            return new List<int[]>(elemtsList);
        }
    }
}

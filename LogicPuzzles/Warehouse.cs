using System;
using System.Collections.Generic;
using System.Linq;

namespace LogicPuzzles
{
    public static class Warehouse
    {
         /*
         * Task:
         * Complete the 'numPaths' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts 2D_INTEGER_ARRAY warehouse as parameter.
         */
        public static int numPaths(List<List<int>> warehouse)
        {
            int mod = (int)(Math.Pow(10, 9) + 7);
            int[,] path = new int[warehouse.Count(), warehouse[0].Count()];
            path[0, 0] = warehouse[0][0];

            for (int i = 1; i < path.GetLength(1); i++)
            {
                if (path[0, i - 1] == 1 && warehouse[0][i] == 1)
                {
                    path[0, i] = 1;
                }
            }

            for (int i = 1; i < path.GetLength(0); i++)
            {
                if (path[i - 1, 0] == 1 && warehouse[i][0] == 1)
                {
                    path[i, 0] = 1;
                }
            }

            for (int i = 1; i < path.GetLength(0); i++)
            {
                for (int j = 1; j < path.GetLength(1); j++)
                {
                    if (warehouse[i][j] == 1)
                    {
                        path[i, j] = (path[i - 1, j] + path[i, j - 1]) % mod;
                    }
                }
            }

            return path[path.GetLength(0) - 1, path.GetLength(1) - 1];
        }
    }
}

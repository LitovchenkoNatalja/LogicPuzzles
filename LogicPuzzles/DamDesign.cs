using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicPuzzles
{

    public static class DamDesign
    {
        /*
         * Complete the 'maxHeight' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY wallPositions
         *  2. INTEGER_ARRAY wallHeights
         */
        public static int maxHeight(List<int> wallPositions, List<int> wallHeights)
        {
            var result = 0;

            for (var i = 0; i < wallPositions.Count - 1; i++)
            {
                if (wallPositions[i] < (wallPositions[i + 1] - 1))
                {
                    var wallsHeightDiff = Math.Abs(wallHeights[i + 1] - wallHeights[i]);
                    var lenBetweenWalls = wallPositions[i + 1] - wallPositions[i] - 1;

                    if (lenBetweenWalls < wallsHeightDiff)
                    {
                        result = Math.Max(Math.Min(wallHeights[i + 1], wallHeights[i]) + lenBetweenWalls, result);
                        continue;
                    }

                    int maxWallHeight = Math.Max(wallHeights[i + 1], wallHeights[i]);
                    int gap = lenBetweenWalls - wallsHeightDiff - 1;
                    decimal mudHeight = Math.Floor((decimal)(maxWallHeight + 1) + (gap / 2));
                    result = (int)Math.Max(mudHeight, result);
                }
            }

            return result;
        }
    }
}

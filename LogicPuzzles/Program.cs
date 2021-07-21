using System;
using System.Collections.Generic;
using System.Linq;

namespace LogicPuzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            //Path in WareHouse
            Console.WriteLine("Task 1: Path in WareHouse");
            Console.Write ("Number of rows: ");
            int warehouseRows = Convert.ToInt32(Console.ReadLine().Trim());
            Console.Write("Number of columns: ");
            int warehouseColumns = Convert.ToInt32(Console.ReadLine().Trim());

            Console.WriteLine("Matrix:" +
                " ");
            List<List<int>> warehouse = new List<List<int>>();

            for (int i = 0; i < warehouseRows; i++)
            {
                warehouse.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(warehouseTemp => Convert.ToInt32(warehouseTemp)).ToList());
            }

            int warehouseResult = Warehouse.numPaths(warehouse);

            Console.WriteLine("The number of paths through the matrix: {0}", warehouseResult);
            Console.ReadLine();

            //Dam Design
            Console.WriteLine("Task 2: Dam Design");
            Console.Write("Number of walls: ");
            int wallPositionsCount = Convert.ToInt32(Console.ReadLine().Trim());

            Console.Write("Walls positions: ");
            List<int> wallPositions = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(wallPositionsItem => Convert.ToInt32(wallPositionsItem)).ToList();

            Console.Write("Number of elements in \"wallHeight\": ");
            int wallHeightsCount = Convert.ToInt32(Console.ReadLine().Trim());

            Console.Write("Wall heights: ");
            List<int> wallHeightsItem = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(wallPositionsItem => Convert.ToInt32(wallPositionsItem)).ToList();

            int damDesignResult = DamDesign.maxHeight(wallPositions, wallHeightsItem);

            Console.WriteLine("Max height mag sigment that can be build: {0}", damDesignResult);
            Console.ReadLine();
        }
    }
}

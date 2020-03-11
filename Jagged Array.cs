using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Row Size :");
            int rows = int.Parse(Console.ReadLine());
            int[][] myArray = new int[rows][];
            for(int row=0;row<myArray.Length;row++)
            {
                Console.Write("Enter Column Size For Row {0} =",row);
                myArray[row] = new int[int.Parse(Console.ReadLine())];
            }
            for (int row = 0; row < myArray.Length; row++)
            {
                for (int col = 0; col < myArray[row].Length; col++)
                {
                    Console.Write("Enter Array Elements [{0} {1}] =", row, col);
                    myArray[row][col] = int.Parse(Console.ReadLine());
                }
            }
            for (int row = 0; row < myArray.Length; row++)
            {
                for (int col = 0; col < myArray[row].Length; col++)
                {
                    Console.Write(" " + myArray[row][col]);
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}

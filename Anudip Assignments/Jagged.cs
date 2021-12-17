using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
          int[][] arr = new int[][]
         {
          new int[] { 5, 6},
          new int[] { 15, 17 },
          new int[] { 117, 122, 188, 111 }
 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    System.Console.Write(arr[i][j] + " ");
                }
                System.Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
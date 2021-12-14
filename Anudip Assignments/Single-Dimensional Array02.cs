using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[] { "c++", "java", "c#" };
            foreach(string a in arr)
            {
                Console.WriteLine(a);

            }
            Console.ReadLine();
        }
    }
}

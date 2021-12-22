using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    using System;
    class Test
    {
        static void Main(string[] args)
        {
            string a = "Codes";
            string b = "Dope";
            int x = String.Compare(a, b);
            int y = String.Compare(b, a);
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
}

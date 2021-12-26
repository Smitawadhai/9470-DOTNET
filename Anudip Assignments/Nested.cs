using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2

{
    using System;
    struct student
    {
        public String name, last;
    }
    struct Marks //Nested Structure
    {
        public student s;
        public int math, sci;
    }
    class nest
    {
        public static void Main()
        {
            Marks m;
            m.s.name = "smita";
            m.s.last = "wadhai";
            m.math = 80;
            m.sci = 90;
            Console.WriteLine("Name = " + m.s.name);
            Console.WriteLine("Last Name = " + m.s.last);
            Console.WriteLine("Math Marks = " + m.math);
            Console.WriteLine("Science = " + m.sci);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    using System;
    struct student
    {
        public String Firstname, Lastname, Address;
    }
    struct Marks
    {
        public student s;
        public int math, sci, eng, physics, hindi;
    }
    class nest
    {
        public static void Main()
        {
            Marks m;
            m.s.Firstname = "Smita";
            m.s.Lastname = "Wadhai";
            m.s.Address = "New Daheli";
            m.math = 85;
            m.sci = 70;
            m.eng = 80;
            m.physics = 84;
            m.hindi = 75;
            Console.WriteLine("First Name = " + m.s.Firstname);
            Console.WriteLine("Last Name = " + m.s.Lastname);
            Console.WriteLine("Address=" + m.s.Address);
            Console.WriteLine("Math Marks = " + m.math);
            Console.WriteLine("Science Marks= " + m.sci);
            Console.WriteLine("eng Marks = " + m.eng);
            Console.WriteLine("physics Marks = " + m.physics);
            Console.WriteLine("hindi Marks = " + m.hindi);
           

        }
    }
}

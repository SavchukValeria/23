using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Three
{
    internal class First: Person
    {
        public First(string N, int A)
        {
            Name = N;
            Age = A;
        }

        public void Print()
        {
            Console.WriteLine("First class");
            Console.WriteLine($"Name = {Name}");
            Console.WriteLine($"Age = {Age}");
        }
    }
}

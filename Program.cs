using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int a = 5 , b = 2;  // comment 1 line
            /* comment
             2 line */
            Console.WriteLine($"a + b = {a + b}");
            string[] cars = new string[3];
            cars[0] = "Volvo";
            cars[1] = "BMW";
            cars[2] = "Ford";
            Console.WriteLine($"First car: {cars[0]}");
            Console.WriteLine($"Second car: {cars[1]}");
            Console.WriteLine($"Third car: {cars[2]}");
        }
    }
}

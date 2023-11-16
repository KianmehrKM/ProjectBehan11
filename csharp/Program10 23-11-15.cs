using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication52
{
    class Program
    {
        static void Main(string[] args)
        {
            float i, n, mul = 1;

            Console.Write("Enter a number: ");
            n = float.Parse(Console.ReadLine());

            i = 1;

            while (i <= n)
            {
                mul *= i;
                i++;
            }

            Console.WriteLine("MUL is: " + mul);
            Console.ReadKey();
        }
    }
}

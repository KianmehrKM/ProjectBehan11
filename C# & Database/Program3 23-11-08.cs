using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            float fact = 1;

            Console.Write("Enter your number: ");
            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                fact = fact * i;
            }

            Console.WriteLine("Your FACTORIAL is: " + fact);
            Console.ReadKey();
        }
    }
}

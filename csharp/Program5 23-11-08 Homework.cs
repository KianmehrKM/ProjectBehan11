using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, i, ii; //ii is for the 2nd ring.
            float fact = 1;
            float sum = 0;

            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());

            for (i = 1; i <= number; i++)
            {
                for (ii = 1; ii <= i; ii++)
                {
                    fact = fact * ii;
                }
                sum = sum + fact;
            }

            Console.WriteLine("Your result for FACTORIAL is: " + fact);
            Console.WriteLine("Your result for SUM is: " + sum);
            Console.ReadKey();
        }
    }
}

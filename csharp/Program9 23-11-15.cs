using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication51
{
    class Program
    {
        static void Main(string[] args)
        {
            float i, n, sum = 0;

            Console.Write("Enter a number: ");
            n = float.Parse(Console.ReadLine());

            i = 1;

            while (i <= n)
            {
                sum += i;
                i++;
            }

            Console.WriteLine("SUM is: " + sum);
            Console.ReadKey();
        }
    }
}

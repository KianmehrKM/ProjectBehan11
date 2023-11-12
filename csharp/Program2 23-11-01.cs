using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, a;
            float sum = 0, avg;

            Console.Write("How many numbers you want to input? ");
            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                Console.WriteLine("Number " + i + " :");
                a = int.Parse(Console.ReadLine());
                sum = sum + a;
            }

            avg = sum / n;

            Console.WriteLine("Your AVERAGE is: " + avg);
            Console.WriteLine("Your SUM is: " + sum);

            Console.ReadKey();
        }
    }
}

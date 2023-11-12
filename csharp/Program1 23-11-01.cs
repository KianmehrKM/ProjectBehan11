using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            float sum = 0;
            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                sum += i;
            }

            Console.WriteLine("Your SUM is: " + sum);
            Console.ReadKey();
        }
    }
}

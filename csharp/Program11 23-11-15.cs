using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication53
{
    class Program
    {
        static void Main(string[] args)
        {
            float n, i, sum = 2, p, j;

            Console.Write("Enter a number: ");
            n = float.Parse(Console.ReadLine());

            i = 3;

            while (i <= n - 1)
            {
                p = 0;
                j = 2;
                while (j <= i - 1)
                {
                    if (i % j == 0)
                        p = 1;
                    j++;
                }
                if (p == 0)
                    sum += i;
                i++;
            }

            Console.WriteLine("SUM for Prime Numbers are: " + sum);
            Console.ReadKey();
        }
    }
}

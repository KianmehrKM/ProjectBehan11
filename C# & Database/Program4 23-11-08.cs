using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            float sumz = 0;
            float sumf = 0;

            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    sumz = sumz + i;
                }
                else
                {
                    sumf = sumf + i;
                }
            }

            Console.WriteLine("Result for your SUMF is: " + sumf);
            Console.WriteLine("Result for your SUMZ is: " + sumz);

            if (sumf > sumz)
            {
                Console.WriteLine("SUMF is bigger.");
            }

            else if (sumf < sumz)
            {
                Console.WriteLine("SUMZ is bigger.");
            }

            else
            {
                Console.WriteLine("Somehow, both are equal.");
            }

            Console.ReadKey();
        }
    }
}

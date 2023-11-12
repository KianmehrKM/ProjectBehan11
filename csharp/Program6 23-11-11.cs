using System;

namespace ConsoleApp69
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, sum = 2, p, j;

            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());

            for (i = 3; i <= n - 1; i++)
            {
                p = 0;
                for (j = 2; j <= i - 1; j++)
                {
                    if (i % j == 0)
                        p = 1;
                }
                if (p == 0)
                    sum += i;
            }

            Console.WriteLine("The SUM is: " + sum);
            Console.ReadKey();
        }
    }
}

using System;

namespace ConsoleApp71
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, i, sum;

            Console.Write("Enter the first number: ");
            a = float.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            b = float.Parse(Console.ReadLine());

            sum = a;

            for (i = 1; i < b - 1; i++)
            {
                sum += a;
                // This command means: sum = sum + a;
            }

            Console.WriteLine("SUM is: " + sum);
            Console.ReadKey();
        }
    }
}

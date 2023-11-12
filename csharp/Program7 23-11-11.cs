using System;

namespace ConsoleApp70
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, i, mul, b;

            Console.Write("Enter the first number: ");
            a = float.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            b = int.Parse(Console.ReadLine());

            mul = a;

            for (i = 1; i < b - 1; i++)
            {
                mul *= a;
                // The command above means: mul = mul * a;
            }

            Console.WriteLine("MUL is: " + mul);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication54
{
    class Program
    {
        static void Main(string[] args)
        {
            float i=0, n, sum = 0, avg;

            Console.Write("Enter a number: ");
            n = float.Parse(Console.ReadLine());

            sum = n;
            avg = 1;

            while (n > 0)
            {
                Console.Write("Enter a number again: ");
                n = float.Parse(Console.ReadLine());

                sum += n;
                i++;
            }

            avg = sum / i;
            sum = sum - n; // If there's a negative number, it tries to not add in the number.

            Console.WriteLine("AVERAGE is: " + avg);
            Console.WriteLine("SUM is: " + sum);

            Console.ReadKey();
        }
    }
}

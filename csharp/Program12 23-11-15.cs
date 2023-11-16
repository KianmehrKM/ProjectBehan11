using System;

namespace ConsoleApp72
{
    class Program
    {
        static void Main(string[] args)
        {
            float i = 0, n, sum = 0, avg;

            /* i is 0 because when there's a negative number in the loop, the average (avg) will not be wrong.
             * Since we're not calculating the negative number and as the question that the teacher gave us says:
             * "...till the inputted number is not negative..."
             * I've decided to use 0 for i, since the negative number will also trigger i++ in the loop.
             * For removing the effects of the negative number after the SUM has been calculated,
             * from math logics, if a negative number is subtracted, it creates a positive number.
             * With that said, I inserted "sum = sum - n;" so that we do not have that negative number in effect.
             * Other than that, we can have a correct answer for our average (avg).
             * You can also trace and debug the code further for your understanding.
             * The end
             */

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

            sum = sum - n;
            // If there's a negative number, it tries to not add in the number. Explained further in the comment above!!!
            avg = sum / i;

            Console.WriteLine("AVERAGE is: " + avg);
            Console.WriteLine("SUM is: " + sum);

            Console.ReadKey();
        }
    }
}

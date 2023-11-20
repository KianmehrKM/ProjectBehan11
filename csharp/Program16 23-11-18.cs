using System;

class Program
{
    static void Main()
    {
        int number;

        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());

        int i = 1;
        while (i <= number)
        {
            int j = 1;
            while (j <= number - i + 1)
            {
                Console.Write(j);
                j++;
            }
            Console.WriteLine();
            i++;
        }

        Console.ReadKey();
    }
}

/* This is the code for the following output:
 * Number: 9 (as an example)
 * Output:
 * 123456789
 * 12345678
 * 1234567
 * 123456
 * 12345
 * 1234
 * 123
 * 12
 * 1
 */

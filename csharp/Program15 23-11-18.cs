using System;

class Program
{
    static void Main()
    {
        int i = 1;
        while (i <= 5)
        {
            int j = 5;
            while (j >= i)
            {
                Console.Write(j);
                j--;
            }
            Console.WriteLine();
            i++;
        }

        Console.ReadKey();
    }
}

/* This is the code for the following output:
 * 54321
 * 5432
 * 543
 * 54
 * 5
 */

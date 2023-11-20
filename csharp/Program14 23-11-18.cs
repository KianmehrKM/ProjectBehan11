using System;

class Program
{
    static void Main()
    {
        int i = 1;
        while (i <= 5)
        {
            int j = i;
            while (j <= 5)
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
 * 12345
 * 2345
 * 345
 * 45
 * 5
 */

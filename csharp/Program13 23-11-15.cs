using System;

class Program
{
    static void Main()
    {
        int number;
        number = 1001;

        while (number <= 9999)
        {
            int originalNumber = number;
            int reverseNumber = 0;

            int tempNumber = number;
            while (tempNumber > 0)
            {
                int remainder;
                remainder = tempNumber % 10;
                reverseNumber = reverseNumber * 10 + remainder;
                tempNumber /= 10;
            }

            if (originalNumber == reverseNumber)
            {
                Console.WriteLine(originalNumber);
            }

            number++;
        }
    }
}

/* The following code outputs palindromic numbers:
 * 1001
 * till 9999
 */

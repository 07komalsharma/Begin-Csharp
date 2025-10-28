using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a year: ");
        int year = int.Parse(Console.ReadLine());

        // Leap year logic
        if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
        {
            Console.WriteLine($"{year} is a leap year.");
        }
        else
        {
            Console.WriteLine($"{year} is not a leap year.");
        }
    }
}
/* eg:  
1900	Divisible by 4 and 100 but not 400
2100	Same reason
2000	Divisible by 400 → leap year
2024	Divisible by 4 but not 100

A year divisible by 4 but not a leap year →
➡ Divisible by 100 but not by 400.

Examples: 1700, 1800, 1900, 2100, 2200

*/

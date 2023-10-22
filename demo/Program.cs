using System;

class Program
{
    // Function to check if a number is prime
    static bool IsPrime(int num)
    {
        if (num <= 1)
            return false;

        if (num <= 3)
            return true;

        if (num % 2 == 0 || num % 3 == 0)
            return false;

        for (int i = 5; i * i <= num; i += 6)
        {
            if (num % i == 0 || num % (i + 2) == 0)
                return false;
        }

        return true;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the start of the range: ");
        int start = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the end of the range: ");
        int end = int.Parse(Console.ReadLine());

        Console.WriteLine("Prime numbers in the range from " + start + " to " + end + ":");

        for (int num = start; num <= end; num++)
        {
            if (IsPrime(num))
            {
                Console.Write(num + " ");
            }
        }

        Console.WriteLine();
    }
}


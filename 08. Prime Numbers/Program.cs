//•	Reads two integer numbers: start of the range and end of the range
//•	Print all prime numbers in given range
//Hint: A prime number is a positive integer greater than 1 that has exactly two distinct positive divisors: 1 and itself.

int startRange = int.Parse(Console.ReadLine());
int endRange = int.Parse(Console.ReadLine());
for (int i = startRange; i < endRange; i++)
{
    bool isPrime = true;
    int divider = 2;
    while (divider < endRange)
    {
        if (i == divider)
        {
            divider += 1;
            continue;
        }
        if (i % divider == 0)
        {
            isPrime = false;
            break;
        }
        divider += 1;
    }
    if (isPrime)
    {
        Console.Write($"{i} ");
    }
}
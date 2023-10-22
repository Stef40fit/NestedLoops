//•	Reads an integer number n from the console 
//•	Prints a pyramid of numbers as shown in the examples

int n = int.Parse(Console.ReadLine());
int counter = 1;
for (int row = 1; row <= n; row++)
{
    for (int col = 1; col <= row; col++)
    {
        Console.Write($"{counter} ");
        counter += 1;
        if (counter > n)
        {
            break;
        }
    }
    Console.WriteLine();
    if (counter > n)
    {
        break;
    }
    
}
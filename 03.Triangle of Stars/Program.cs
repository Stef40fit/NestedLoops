//•	Read the size (integer number) of a triangle from the console
//•	Print a triangle of stars
int number = int.Parse(Console.ReadLine()); 

for  (int row = 1; row <= number; row++)
{
    for (int nStars = 1; nStars <= row; nStars++)
    {
        Console.Write( "*" );
    }
    Console.WriteLine(  );
}
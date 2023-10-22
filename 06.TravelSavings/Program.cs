using System;

//Write a program that calculate the money collection for multiple travel destinations:
//•	Read a destination (string) and needed budget (floating-point number) for the destination
//•	Read many times amounts of collected money, until they are enough for the destination (starting from 0)
//o   Print: 
//"Collected: {sum}" where sum is formatted to 2nd digit
//    or
// "Going to {destination}"
//•	Read another destination and budget and collect money again
//•	A destination "End" ends the program

string destination = Console.ReadLine();

while (destination != "End")
{
    double needSum= double.Parse(Console.ReadLine());
    double collectedSum = 0;
    while (collectedSum < needSum)
    {
        double addSum = double.Parse(Console.ReadLine());   
        collectedSum += addSum;
        Console.WriteLine($"Collected: {collectedSum:f2}");
    }
    Console.WriteLine($"Going to {destination}!");
    destination = Console.ReadLine();   

}


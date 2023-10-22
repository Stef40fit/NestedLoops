//•	Continuously read integers until "End" is entered from the console
//o	Print the sum of digits for each integer, use the following format: 
//"Sum of digits = {sum}"
//•	Finally, print "Goodbye"

string n = Console.ReadLine();
while (n != "End")
{
    int current = int.Parse(n);
    int sum = 0;
    while (current> 0)
    {
        int digit = current % 10;
        sum += digit;
        current /= 10;
    }
    Console.WriteLine($"Sum of digits = {sum}");
n = Console.ReadLine();
}
Console.WriteLine("Goodbye");
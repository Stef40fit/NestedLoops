//•	Reads an integer number n from the console 
//•	Prints on the console the number two on even powers in the range [0; n]
//2 ≤ 2n: 20, 22, 24, 26, …, 2n.

int n = int.Parse(Console.ReadLine());

for (int i = 0; i <= n; i+= 2)
{
   double powerOf2 = Math.Pow(2, i);
    Console.WriteLine(powerOf2);
}
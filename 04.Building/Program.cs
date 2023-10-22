

//Write a program to print a table, representing a building:
//•	Reads two integer numbers from the console: floors count and estates count per floor
//•	Identifiers consist of: { type}{ floor}{ number}, e.g.L65, A12, O24
//•	Odd floors hold apartments (type A), e.g.A10, A11, A12, …
//•	Even floors hold offices (type O), e.g.O20, O21, O22, …
//•	The last floor holds large apartments (type L), e.g.L60, L61, L62

int floorsCount = int.Parse(Console.ReadLine());
int estatesCount = int.Parse(Console.ReadLine());

for  (int floor = floorsCount; floor >=1; floor-=1)
{
    for (int room = 0; room < estatesCount; room+=1)
    {
        if(floor == floorsCount)
        {
            Console.Write($"L{floor}{room} ");
        }  
       else if(floor % 2 == 0)
        {
            Console.Write($"O{floor}{room} ");
        }
        else
        {
            Console.Write($"A{floor}{room} ");
        }
    }
    Console.WriteLine();
}

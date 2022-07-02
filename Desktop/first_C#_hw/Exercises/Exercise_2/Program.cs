Console.Write("Enter the first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second number: ");
int b = Convert.ToInt32(Console.ReadLine());
int max = b;
int min = a;

if (a>b)
{
    max = a;
    min = b;
} 
    
Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.Write(min);
    

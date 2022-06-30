Console.Write("Enter the first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the third number: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;
if (b>max) max = b;
if (c>max) max = c;

Console.Write("max = ");
Console.WriteLine(max);

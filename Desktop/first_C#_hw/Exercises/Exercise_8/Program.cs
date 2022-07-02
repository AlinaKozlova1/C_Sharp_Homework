Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number%2 != 0)
{
    number = number -1;
}
while (number>1)
{
    Console.Write(number);
    if (number!=2)
    {
        Console.Write(",");
    }
    number = number - 2;
}
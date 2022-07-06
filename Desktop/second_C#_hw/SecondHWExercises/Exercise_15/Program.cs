Console.WriteLine("---------------------");
Console.Write("Please, enter a weekday number: ");
int numberA = Convert.ToInt32(Console.ReadLine());

if (numberA<1|numberA>7)
{
    Console.WriteLine("Enter the number from 1 to 7");
} 
else
{
    if (numberA>5)
    {
        Console.Write(numberA + " - day off");
    }
    else
    {
        Console.Write(numberA + " - working day");
    }
}
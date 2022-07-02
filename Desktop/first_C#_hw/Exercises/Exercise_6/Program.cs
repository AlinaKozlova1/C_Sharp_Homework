Console.Write("Enter the number. This program'll determine is your number even or not: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number%2 == 0)
{
    Console.WriteLine(number +  " - Yes, it's even");
}
else
{
    Console.WriteLine(number + " - Nope, it's not even");
}

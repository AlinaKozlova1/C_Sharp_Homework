Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int sum (int Num)
{
    int i = 0;
    int amount = 0;
    while (i<=Num)
    {
        amount = amount+i;
        i++;
    }
    Console.WriteLine(amount);
    return amount;
}

sum(number);

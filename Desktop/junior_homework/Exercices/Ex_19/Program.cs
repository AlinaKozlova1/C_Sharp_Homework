Console.WriteLine("Enter a five-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

void Palindrome(int number)
{
    int digit1 = number/10000;
    int digit2 = (number/1000)%10;
    int digit4 = (number%100)/10;
    int digit5 = number%10;
    if (digit1==digit5 && digit2==digit4)
    {
        Console.WriteLine(number + " - palindrome!");
    }
    else
    {
        Console.WriteLine(number + " - not palindrome~");
    }
}


if (num>9999 && num<100000)
{
    Palindrome(num);
}   

else 
{
     Console.WriteLine("Your number is not five-digit");
}








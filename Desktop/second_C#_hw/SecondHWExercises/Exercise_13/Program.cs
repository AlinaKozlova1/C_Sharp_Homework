Console.WriteLine("---------------------");
Console.Write("Please, enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number<100)
{
    Console.WriteLine("There is no the third digit~");
}
else
{
    void FindTheThirdDigit(int ThreeDigitNumber)
{
        ThreeDigitNumber = ThreeDigitNumber%10;
        Console.WriteLine("The third digit of your numer is " + ThreeDigitNumber);
}

    void CutNumber (int Number)
{
        while (Number>999)
{
            int balace = Number%10;
            Number = (Number - balace)/10;
}  
        FindTheThirdDigit(Number);
}

    CutNumber(number);
}



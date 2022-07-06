Console.WriteLine("---------------------");
Console.Write("Please, enter three-digit number: ");
int numberA = Convert.ToInt32(Console.ReadLine());
if (999<numberA)                     //проверяем является ли число 3х-значным
{
    Console.WriteLine("Your number is too large");
}
if (numberA<100)
{
    Console.WriteLine("Your number is too small");
}
else
{
    int balance = numberA%100;                                 //отсекаем остаток
    int SecondNumber = balance/10;                             //находим среднюю цифру
    Console.WriteLine("The second digit is " + SecondNumber);
}

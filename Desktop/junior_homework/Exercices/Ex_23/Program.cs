Console.Write("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());


int[] Cube( int number)
{
    int[] a = new int [number];
    for (int i=1; i<=number; i++)
    {
        a[i-1] = i*i*i;
        Console.WriteLine(a[i-1]);
    }
    return a;
}

Cube(num);
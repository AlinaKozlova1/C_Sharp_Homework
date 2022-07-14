Console.WriteLine("What array length do you want?");
int length = Convert.ToInt32(Console.ReadLine()); 

int[] array = new int[length];

void evenNumber(int[] arr2)
{
    int even = 0;
    for (int j = 0; j < arr2.Length; j++)
    {
        if (arr2[j] % 2 == 0) even++;
    }
    Console.Write("This array has " + even + " even number(s)");
}


void randomArray(int[] arr)
{    
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
    evenNumber(arr);
}

randomArray(array);

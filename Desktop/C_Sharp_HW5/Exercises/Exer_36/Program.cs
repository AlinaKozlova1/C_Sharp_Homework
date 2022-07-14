Console.WriteLine("What array length do you want?");
int length = Convert.ToInt32(Console.ReadLine()); 

int[] array = new int[length];

void oddNumSum(int[] arr2)
{
    int sum = 0;
    for (int j = 0; j < arr2.Length; j++)
    {
        if (j % 2 == 1) sum+=arr2[j];
    }
    Console.WriteLine("The odd numbers sum is equal to " + sum);
}

void randomArray(int[] arr)
{    
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-100, 101);
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
    oddNumSum(arr);
}

randomArray(array);
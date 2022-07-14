Console.WriteLine("What array length do you want?");
int length = Convert.ToInt32(Console.ReadLine()); 

int[] array = new int[length];

void gap (int[] arr2)
{
    int j = 0;
    int min = arr2[j];
    int max = arr2[j];
    while (j < arr2.Length)
    {
        if (arr2[j] > max) max = arr2[j];
        else if (arr2[j] < min) min = arr2[j];
        j++;
    }
    int difference = max - min;
    Console.WriteLine("max = " + max + ", min = " + min);
    Console.WriteLine("diffrence = " + difference);

}


void randomArray(int[] arr)
{    
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-100, 101);
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
    gap(arr);
}

randomArray(array);
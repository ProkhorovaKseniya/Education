void ZeroEvenElements(int[] arr)
{
    for (int i=0; i<arr.Length; i++)
    {
        if (arr[i]%2==0)
        {
            arr[i]=0;
        }
        
    }
}

void PrintArray(int[] array)
{
    foreach(int e in array)
    {
        Console.Write($"{e} ");
    }
}

int[] array = {1,2,4,5,6,7,8,9};
ZeroEvenElements(array);
PrintArray(array);
int[] CreateArray (int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i=0; i< array.Length; i++)
    {
        array[i]=rnd.Next(1,100);
    }
    return array;
}

bool IsPrime(int n)
{
    for (int i=2; i<n; i++)
    {
        if (n%i==0)
        {
            return false;
        }
    }
    return true;
}
int GetPrimeQuantity (int[] arr)
{
    int quantity=0;
    foreach (int e in arr)
    {
        bool res=IsPrime(e);
        if (res==true)
        {
            quantity++;
        }
    }
    return quantity;
}
void PrintArrayElements(int[] arr)
{
    Console.Write("Массив:");
    foreach (int e in arr)
    {
        Console.Write($"{e} ");
    }
}
Console.Write("Введите размер массива:");
int n=Convert.ToInt32(Console.ReadLine());
int[] arr = CreateArray(n);
int result = GetPrimeQuantity(arr);
PrintArrayElements(arr);
Console.WriteLine($"Количество натуральных чисел в массиве {result}");





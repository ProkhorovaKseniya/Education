
int[] CreateArray (int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i=0; i< array.Length; i++)
    {
        array[i]=rnd.Next(1,10);
    }
    return array;
}
void PrintArrayElements(int[] arr)
{
    Console.Write("Массив:");
    foreach (int e in arr)
    {
        Console.Write($"{e} ");
    }
}
double TransformArrayToDigit(int[] array)
{
    double result = array[0];
    for (int i=1; i<array.Length;i++)
    {
        result=result*10+array[i];
    }

    return result;
}

Console.Write("Введите размер массива (до 8):");
int n=Convert.ToInt32(Console.ReadLine());
int[] arr = CreateArray(n);
PrintArrayElements(arr);
double result = TransformArrayToDigit(arr);
Console.WriteLine(result);

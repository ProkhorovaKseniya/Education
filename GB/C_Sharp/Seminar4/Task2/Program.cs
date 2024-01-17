// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.

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
void PrintArrayElements(int[] arr)
{
    Console.Write("Массив:");
    foreach (int e in arr)
    {
        Console.Write($"{e} ");
    }
}
int FindNumberAccordingCondition(int[] array)
{
    int quantity =0;
    foreach (int e in array)
    {
        if (e%10==1 && e%7==0)
        {
            quantity++;
        }
    }
    return quantity;
}

Console.Write("Введите размер массива:");
int n=Convert.ToInt32(Console.ReadLine());
int[] arr = CreateArray(n);
PrintArrayElements(arr);
int quantity=FindNumberAccordingCondition(arr);
Console.WriteLine($"В массиве {quantity} чисел, которые оканчиваются на 1 и делятся нацело на 7 ");


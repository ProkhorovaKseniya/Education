// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(99, 1000);
    }
    return array;
}
int CountEvenQuantity(int[] arr)
{
    int quantity = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
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
Console.WriteLine("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateArray(size);
PrintArrayElements(arr);
int quantityOfEven = CountEvenQuantity(arr);
Console.WriteLine($"Количество четных чисел в массиве - {quantityOfEven}");
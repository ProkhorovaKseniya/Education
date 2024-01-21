// Задача 3: Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)
int[] CreateArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 10);
    }
    return array;
}
void ReversArrayElements(int[] arr)
{
    int bufer = 0;
    int j = arr.Length - 1; //индекс начинается с 0, а длина массива считается с 1
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < j) //заменять эл-ты нужно только до момента "встречи" индексов, иначе в массиве заменятся еще раз уже замененные ранее элементы и массив выведется как на входе в функцию
        {
            j = arr.Length - 1 - i;
            bufer = arr[j];
            arr[j] = arr[i];
            arr[i] = bufer;
            //Console.WriteLine(bufer+" i:"+i+" j:"+j); // можно понаблюдать встречу индексов на Эльбе
        }
    }
    Console.Write("  Развернули ");
    PrintArrayElements(arr);
}
void PrintArrayElements(int[] arr)
{
    Console.Write("массив:");
    foreach (int e in arr)
    {
        Console.Write($"{e} ");
    }
}
Console.WriteLine("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateArray(size);
PrintArrayElements(arr);
ReversArrayElements(arr);
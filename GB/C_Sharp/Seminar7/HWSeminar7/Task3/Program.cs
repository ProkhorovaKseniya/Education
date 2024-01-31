﻿// Задача 3: Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

int ShowReverseArray(int[] arr, int i)
{
    if (i == 0)
    {
        Console.Write(arr[i]);
        return arr[i];
    }
    Console.Write($"{arr[i]} ");
    ShowReverseArray(arr, (i - 1));
    return arr[i];
}

int[] array = { 1, 12, 3, 5, 10, 40, 70, 100 };
ShowReverseArray(array, array.Length - 1);
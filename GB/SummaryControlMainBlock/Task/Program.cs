// Задача: Написать программу, которая из имеющегося массива строк формирует
//  новый массив из строк, длина которых меньше, либо равна 3 символам. 
//  Первоначальный массив можно ввести с клавиатуры, либо задать на старте
//   выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//   лучше обойтись исключительно массивами.

int GetQty(string[] arr, int maxLength)
{
    int a = 0;
    foreach (string e in arr)
    {
        if (e.Length <= maxLength)
        {
            a++;
        }
    }
    return a;
}

string[] GetShortArray(string[] arr, int maxLength)
{
    string[] result = new string[GetQty(arr, maxLength)];
    int j = 0;
    foreach (string e in arr)
    {
        if (e.Length <= maxLength)
        {
            result[j] = e;
            //Console.Write(result[j] + ", ");
            j++;
        }
    }
    return result;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    foreach (string e in arr)
    {
        Console.Write($"{e} ");
    }
    Console.Write("]");
}

string[] str_arr = { "Hell0", "lor", "2", "wor", "ld", "23" };
int maxLength = 3;
string[] result = GetShortArray(str_arr, maxLength);
PrintArray(result);

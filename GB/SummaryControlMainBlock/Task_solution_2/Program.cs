// Задача: Написать программу, которая из имеющегося массива строк формирует
//  новый массив из строк, длина которых меньше, либо равна 3 символам. 
//  Первоначальный массив можно ввести с клавиатуры, либо задать на старте
//   выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//   лучше обойтись исключительно массивами.

//+++++++ Решение №2
string[] GetShortArray(string[] arr, int maxLength)
{
    int count = 0;
    string[] temp;
    string[] result = new string[count + 1];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= maxLength)
        {
            count++;
            temp = new string[count];
            for (int j = 0; j < temp.Length - 1; j++)
            {
                temp[j] = result[j];
            }
            temp[count - 1] = arr[i];
            result = temp;
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

string[] str_arr = { "Hello", "or", "l2", "wor", "hd", "230" };
int maxLength = 3;
string[] result = GetShortArray(str_arr, maxLength);
PrintArray(result);
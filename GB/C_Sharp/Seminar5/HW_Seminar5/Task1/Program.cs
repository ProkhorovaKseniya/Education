// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет:
// "Позиция по рядам выходит за пределы массива"
// или
// "Позиция по колонкам выходит за пределы массива"
// Позиции в массиве считать от единицы.
// В коде, начальные условия:

// int[,] numbers = new int[,] {
//     {1, 2, 3, 4},
//     {5, 6, 7, 8},
//     {9, 10, 11, 12}
// };

// int x = 2;
// int y = 2;

using System;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{ 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Поиск элемента по позициям
    public static int FindElementByPosition(int[,] array, int x, int y)
    {
        //Напишите свое решение здесь
        x=x-1;
        y=y-1;
        int element = array[x,y];
        return element;
    }

// Проверка позиций на вхождение в массив
    public static bool ValidatePosition(int[,] array, int x, int y)
    {
        //Напишите свое решение здесь
        bool flag=false;
        //x=x-1;
        //y=y-1;
        if (x<=array.GetLength(1) && x>0 && y>=0 && y<=array.GetLength(0))
        {
           // Console.Write(array.GetLength(0)+" "+array.GetLength(1)+"yes");
            flag= true;
        }
        else
        {
            flag= false;
        }
        return flag;
    }

    public static void PrintResult(int[,] numbers, int x, int y)
    {
        //Напишите свое решение здесь
        bool flag=ValidatePosition(numbers, x, y);
        if (flag==true)
        {
            Console.WriteLine(FindElementByPosition(numbers,x,y));
        }
        else
        {
            if (x>=numbers.GetLength(1))
            {
                Console.WriteLine("Позиция по колонкам выходит за пределы массива");
            }
            if (y>=numbers.GetLength(0))
            {
                Console.WriteLine("Позиция по рядам выходит за пределы массива");
            }
        }
    }
}

//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {   
        int[,] array;

        int x, y;

        if (args.Length >= 3)
        {
            // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
            string[] rows = args[0].Split(',');

            int rowCount = rows.Length;
            int colCount = rows[0].Trim().Split(' ').Length;

            array = new int[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                string[] rowElements = rows[i].Trim().Split(' ');

                for (int j = 0; j < colCount; j++)
                {
                    if (int.TryParse(rowElements[j], out int result))
                    {
                        array[i, j] = result;
                    }
                    else
                    {
                        Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
                        return;
                    }
                }
            }

            // Парсинг x и y из аргументов
            if (int.TryParse(args[1], out x) && int.TryParse(args[2], out y))
            {
                // Теперь у вас есть двумерный массив "array" и координаты x и y
                UserInputToCompileForTest.PrintResult(array, x, y);
            }
            else
            {
                Console.WriteLine("Error parsing x or y to an integer.");
            }
        }
        else
        {
           
            // Если аргументов на входе нет, используем примерный массив
            array = new int[,]
            {
                {10, 20, 30, 40},
                {50, 60, 7, 8},
                {9, 10, 11, 12}
            };
            x = 1;
            y = 1;
            
            UserInputToCompileForTest.PrintResult(array, x, y);

        }                
    }
}
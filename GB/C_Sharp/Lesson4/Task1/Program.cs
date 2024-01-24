//Задача №1
//Создать двумерный массив с размерами
//3 x 5, состоящий из целых чисел
//Вывести его элементы на экран




int[,] CreateMatrix(int rowCount, int columnCount)
{

    int[,] matrix = new int[rowCount, columnCount];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) //проход по строкам
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //проход по элементам внутри строки
        {
            matrix[i, j] = rnd.Next(1, 11);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    //вывод строк массива
    for (int i = 0; i < matrix.GetLength(0); i++) //проход по строкам
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //проход по элементам внутри строки
        {
            Console.Write($"{matrix[i, j]} "); // интерполяция строк
        }
        Console.WriteLine();
    }
}

int[,] matrix=CreateMatrix(4,5);
PrintMatrix(matrix);
// Задача №2
// • Назовём число «интересным» если его сумма
// цифр чётная
// • Создать двумерный массив, состоящий из
// целых чисел. Вывести на экран «интересные»
// элементы массива


int[,] CreateMatrix(int rowCount, int columnCount)
{

    int[,] matrix = new int[rowCount, columnCount];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) //проход по строкам
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //проход по элементам внутри строки
        {
            matrix[i, j] = rnd.Next(10, 100);
        }
    }
    return matrix;
}

int GetSumOfDigits(int value)
{
    int sum=0;
    while (value>0)
    {
        sum=sum+value%10;
        value=value/10;
    }
    return sum;
}

bool IsInteresting(int element)
{
    
    int sum=GetSumOfDigits(element);

    bool flag=false;
    // sum=(element%10)+(element-(element%10))/10;
    if (sum%2==0)
    {
        flag= true;
    }
    return flag;
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
foreach (int e in matrix)
{
    if (IsInteresting(e)==true)
    {
        Console.Write($"{e} "); // интерполяция строк
    }
}

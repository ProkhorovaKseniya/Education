int GetSumMainDiag(int[,] table)
{
    int sum=0;
    for (int i=0; i<table.GetLength(0); i++) // число столбцов
    {
        for (int j=0; j<table.GetLength(1); j++) // число строк
        {
            if (i==j)
            {
                sum = sum+table[i,j];//сложение с накоплением
            }
        }
    }
    return sum;
}
void PrintTable (int[,] table)
{
    // foreach (int e in table)
    // {
    //     Console.WriteLine(e+ " ");

    // }
    for (int i=0; i<table.GetLength(0); i++) // число столбцов
    {
        for (int j=0; j<table.GetLength(1); j++) // число строк
        {
           
            Console.Write(table[i,j]+ " "); // i и j четные?
            
        }
        Console.WriteLine();
    }
}

int[,] matrix=
{
{ 1,2,3,9},
{ 4,5,6,10},
{ 7,8,9,11}
};
PrintTable(matrix);

int sum=GetSumMainDiag(matrix);

Console.WriteLine(sum);
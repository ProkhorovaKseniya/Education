void FindReplaceToSquare(int[,] table)
{
    for (int i=0; i<table.GetLength(0); i++) // число столбцов
    {
        for (int j=0; j<table.GetLength(1); j++) // число строк
        {
            if (i%2==0 && j%2==0)
            {
                table[i,j]*=table[i,j]; // i и j четные?
            }
        }
    }
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
            if (i%2==0 && j%2==0)
            {
                Console.Write(table[i,j]+ " "); // i и j четные?
            }
        }
        Console.WriteLine();
    }
}

int[,] matrix =
{
{ 1,2,3,9},
{ 4,5,6,10},
{ 7,8,9,11}
};
PrintTable(matrix);

FindReplaceToSquare(matrix);

PrintTable(matrix);
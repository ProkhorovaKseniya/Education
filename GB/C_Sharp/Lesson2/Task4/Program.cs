int n = 5;
int[] array = { 2, 4, 7, 3, 1 };
int max = array[0];
//решение с циклом while
int i = 0;
while (i < n)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    i = i + 1;
}
Console.Write($"max={max}");

// счётный цикл for
max = array[0];
for (int j=0; j<n; j++)
{
    if (array[j] > max)
    {
        max = array[j];
    }
}
Console.Write($"max={max}");
// цикл foreach
max = array[0];
foreach (int e in array)
{
    if (e > max)
    {
        max = e;
    }
}
Console.Write($"max={max}");
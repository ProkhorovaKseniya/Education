int[] array = [1, 3, 4, 19, 3];
int target = 14;
bool flag = false;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == target)
    {
        flag = true;
    }
}
if (flag == true)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}

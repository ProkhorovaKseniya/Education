// Задайте значения M и N. Напишите программу, которая выведет
// все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы

int ShowNaturalNumber(int m, int n)
{
    if (m == n)
    {
        Console.Write($"{n}");
        return m;
    }
    Console.Write($"{m}, ");
    if (m < n)
    {
        m++;
    }
    else
    {
        m--;
    }
    return ShowNaturalNumber(m, n);
}

Console.Write("Введите M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N:");
int n = Convert.ToInt32(Console.ReadLine());
//Console.Write("Все натуральные числа в промежутке от M до N: ");
ShowNaturalNumber(m, n);

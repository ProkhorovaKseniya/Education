// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n.

int GetAсkermanFunction(int m, int n)
{
    if (m == 0)
    {
        n++;
        return n;
    }
    if (n == 0)
    {
        m--;
        return GetAсkermanFunction(m, 1);
    }
    if (m > 0 && n > 0)
    {
        n--;
        return GetAсkermanFunction((m - 1), GetAсkermanFunction(m, n));
    }
    return n;

}

Console.Write("Введите неотрицательное число M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите неотрицательное число N:");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($" A(m,n) = {GetAсkermanFunction(m, n)}");

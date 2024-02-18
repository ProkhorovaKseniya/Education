// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// N=5 => 1 2 3 4 5


int ShowNaturalNumber(int n)
{
   
    if (n==1)
    {
        Console.Write(" {0}", n);
        return 1;
    }
    
    int res = ShowNaturalNumber(n-1);    
    Console.Write(" "+ n);
    return res;
}

Console.Write("Enter N:");
int n= Convert.ToInt32(Console.ReadLine()!);
ShowNaturalNumber(n);
// Console.Write(" {0}", n);
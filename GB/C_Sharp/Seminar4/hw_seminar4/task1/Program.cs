//Напишите программу, которая бесконечно запрашивает целые 
//числа с консоли. Программа завершается при вводе символа ‘q’ 
//или при вводе числа, сумма цифр которого чётная.

//функция с циклом запроса ввода целых чисел с консоли
void QueryInput()
{
    int digit = 0;
    bool even = false;
    string input = String.Empty;
    while (true)
    {
        Console.WriteLine("Введите целое число или q: ");
        input = Console.ReadLine(); // в этом месте ошибка "warning CS8600: Преобразование литерала,.. "(не знаю как решить), но программа продолжает работать
        if (input == "q")
        {
            return;
        }
        else
        {
            digit = Convert.ToInt32(input);
            even = CheckSumEven(digit);
            if (even == true)
            {
                return;
            }

        }
    }
}

//функция проверки на чётность суммы цифр
bool CheckSumEven(int number)
{
    int sum = 0;
    bool flag = false;
    if (number > 0 && number < 100)
    {
        sum = number % 10 + (number / 10) % 10;
    }

    if (sum % 2 == 0)
    {
        flag = true;
        Console.WriteLine($"Сумма цифр числа {number} равна {sum} - четная");
    }

    return flag;
}


QueryInput();
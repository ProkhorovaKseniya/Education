//Напишите программу, которая бесконечно запрашивает целые 
//числа с консоли. Программа завершается при вводе символа ‘q’ 
//или при вводе числа, сумма цифр которого чётная.

//функция с циклом запроса ввода целых чисел с консоли
void QueryInput()
{
    int digit=0;
    string symbol='';
    while (true)
    {
        Console.Write("Введите целое число или q: ");
        symbol=Console.ReadLine();
        if (symbol!='q')
        {
        digit = Convert.ToInt32(symbol);

        }
        else
        {
            return;
        }
    }
}

//функция проверки на чётность суммы цифр
int CheckSumEven(int number)
{
    
    int sum=0;
    for (int i=10;i<5;i*=10)
    {
        sum=sum+(number%i);
    }
    //if 
}

QueryInput();
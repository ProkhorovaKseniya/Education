//Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

string CheckIsPalindrom(string input)
{
    string str = input;
    string palindrom = "";
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == str[input.Length - 1 - i])
        {
            palindrom += input[i];
        }
        else
        {
            return "No palindrom";
        }
    }

    return palindrom + " is palindrom";

}
Console.WriteLine("Введите строку (на латинице):");
string str = Console.ReadLine()!;
Console.WriteLine(CheckIsPalindrom(str));

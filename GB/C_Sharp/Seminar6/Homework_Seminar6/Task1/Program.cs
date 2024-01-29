//Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

void ShowStringFromAchar[] StringToCharArray(string str)
{
    char[] chars = new char[str.Length];
for (int i = 0; i < str.Length; i++)
{
    chars[i] = str[i];
}
return chars;
}rray(char[] array)
{
    string result = "";
    foreach (char e in array)
    {
        result += e;
    }
    Console.Write(result);
}
Console.Write("Введите строку:");
string str = Console.ReadLine()!;
char[] chars = StringToCharArray(str);
ShowStringFromArray(chars);


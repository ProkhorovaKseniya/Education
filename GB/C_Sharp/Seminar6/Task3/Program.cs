

//("Hello, World!");
int GetVoveIsCount(string str)
{
    string vovels="aeiouy";
    int counter=0;

    foreach (char c in str)
    {
        if (vovels.Contains(c))
        {
            counter++;
        }
    }
    return counter;
}
string str=Console.ReadLine()!; //надо обрабатывать пользовательский ввод. !-это значит, что я прошу проигнорить предупреждение
int countVovels=GetVoveIsCount(str);
Console.WriteLine(countVovels);

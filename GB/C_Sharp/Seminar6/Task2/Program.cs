char [] StringToCharArray(string str)
{
    char[] chars=new char[str.Length];
    for (int i=0; i<str.Length;i++)
    {
        chars[i]=str[i];
    }
    return chars;
}
string str = "Hello World!";
char[] chars= StringToCharArray(str);
foreach (char e in chars)
{
    Console.Write(e+" ");
}
string GetStringFromArray(char[] array)
{
    string str="";
    foreach (char c in array)
    {
        str +=c;
    }
    return str;
}

char [] chars={'1','2','a','b','c'};
string str =GetStringFromArray(chars);
Console.WriteLine(str);
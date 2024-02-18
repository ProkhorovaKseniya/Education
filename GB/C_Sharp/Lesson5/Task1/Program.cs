int Fact(int n)
{
    int fact = 0;
    if (n == 1 || n == 0)
    {
        Console.WriteLine($"Stop: {n}");
        return 1;
    }
    Console.WriteLine(n);
     fact = n * Fact(n - 1);
    Console.WriteLine(n+", "+fact+" ");
    return fact;

}
Console.Write(Fact(5));
//
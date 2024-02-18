int SumOfDigits(int num)
{
    if (num == 0)
    {
        return 0;
    }
    int sum = num %10 ;
    int temp= SumOfDigits(num/10);
    Console.WriteLine(temp);
    sum+=temp;
    return sum;
}
int res = SumOfDigits(345);
Console.WriteLine(res);

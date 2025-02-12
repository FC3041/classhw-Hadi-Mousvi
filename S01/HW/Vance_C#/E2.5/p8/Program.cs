void Avg_of_squares1(double n)
{
    double result = 0;
    for(double i=1;i<=n;i++)
    {
        result += i*i;
    }
    result = result/n;
    Console.Write(result);
}
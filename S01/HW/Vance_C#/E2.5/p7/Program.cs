void Avg_of_squares0(double n)
{
    double result = 0;
    for(double i=0;i<n;i++)
    {
        result += i*i;
    }
    result = result/n;
    Console.Write(result);
}
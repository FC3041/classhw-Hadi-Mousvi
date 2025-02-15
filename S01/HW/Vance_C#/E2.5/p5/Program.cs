void power(double a, int b)
{
    double result=1;
    for(int i=0;i<b;i++)
    {
        result *= a;
    }
    Console.Write(result);
}
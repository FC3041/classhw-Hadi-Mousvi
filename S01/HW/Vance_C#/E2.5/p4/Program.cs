void factorial(int n)
{
    int result=1;
    for(int a=1;a<=n;a++)
    {
        for(int i=1;i<=a;i++)
        {
            result *= i;
        }
        Console.WriteLine("factorial of " + a + " is " + result);
        result = 1;
    }
}

void Triangle(int n,char c)
{
    for(int i=1;i<=n;i++)
    {
        for(int k=0;k<n-i;k++)
        {
            Console.Write(" ");
        }
        for(int j=0;j<i;j++)
        {
            Console.Write(c);
        }
        Console.Write("\n");
    }
}

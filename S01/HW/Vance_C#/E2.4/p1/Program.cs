void Triangle(int stars)
{
    for(int i=1;i<=stars;i++)
    {
        for(int space=0;space<stars;space++)
        {
            Console.Write(" ");
        }
        for(int j=0;j<i;j++)
        {
            Console.Write("*");
        }
        Console.Write("\n");
    }
    for(int i=0;i<stars;i++)
    {
        Console.Write("\"");
    }
}
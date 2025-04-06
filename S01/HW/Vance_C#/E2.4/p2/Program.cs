void Triangle(int c , char character)
{
    for(int i=1;i<=c;i++)
    {
        for(int space=0;space<c;space++)
        {
            Console.Write(" ");
        }
        for(int j=0;j<i;j++)
        {
            Console.Write(character);
        }
        Console.Write("\n");
    }
    for(int i=0;i<c;i++)
    {
        Console.Write("\"");
    }
}

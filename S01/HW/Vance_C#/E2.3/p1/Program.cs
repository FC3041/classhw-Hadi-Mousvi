void head()
{
    Console.WriteLine("    ^    ");
    Console.WriteLine("   /|\\   ");
    Console.WriteLine("  //|\\\\  ");
    Console.WriteLine(" ///|\\\\\\ ");
}

void line()
{
    Console.WriteLine("+-------+");    
}

void body(int n)
{
    for(int i=0;i<n;i++)
    {
        for(int j=0;j<6;j++)
        {
            Console.WriteLine("+*******+");
        }
        line();
    }
}

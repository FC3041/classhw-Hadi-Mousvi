void left_triangle(int lines)
{
    for(int line=1;line<=lines;line++)
    {
        if(line%2==1)
        {
            for(int i=0;i<line;i++)
            {
                Console.Write("%");
            }
            Console.Write("\n");
        }
        else
        {
            for(int i=0;i<line;i++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
        }
    }
}


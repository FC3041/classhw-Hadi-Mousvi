

void is_leap_year(int year)
{
    if(year%4!=0)
        Console.Write("False");
    else if(year%100==0)
    {
        year = year/100;
        if(year%4!=0)
            Console.Write("False");
        else
            Console.Write("True");
    }
    else
        Console.Write("True");
}
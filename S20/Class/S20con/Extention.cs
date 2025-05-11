public static class EXT
{
    public static string TitleCase(this string str)
    {
        if(str == null)
            return str;    
        return char.ToUpper(str[0]) + str.Substring(1);
    }

    public static int NumsCount(this string str)
    {
        int count = 0;
        for(int i = 0 ; i < str.Length ; i++)
        {
            if(char.IsDigit(str[i]))
                count++;
        }
        return count;
    }

    // public static string Encoder(this string str)
    // {
        
    //     for(int i = 0 ; i < str.Length ; i++)
    //     {

    //     }
    // }

    //TODO 1 Encoder Sezar
    //TODO 2 Decoder 
}
public static class Exeption
{
    public static string SEncoder(this string str)
    {
        string newstr ="";
        char x = (char) 3;
        for(int i=0 ; i<str.Length ; i++)
        {
            str[i] += (char)3;
        }
    }
}
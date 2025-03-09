namespace HW;

class Program
{
    public static void RevWordsLetters(string s , out string srev)
    {
        srev = "";
        for(int i=0; i<s.Length ; i++)
        {
            srev = s[i] + srev;
        }
    }

    public static void RevWords(string s , out string srev)
    {
        int word_length = 0;
        srev = "";
        for(int i=s.Length-1 ; i >= 0 ;i--)
        {
            if(s[i]==' ')
            {
                for(int j=0 ; j < word_length+1 ; j++)
                    srev += s[i+j];
                srev += ' ';
                word_length = 0; 
            }
            else if(i==0)
            {
                for(int j=0 ; j < word_length+1 ; j++)
                    srev += s[i+j];
            }
            else
                word_length++;
        }
    }

    static void Main(string[] args)
    {
        string s = "Hadi Asghar moulavu Mousavi";
        string srev;
        RevWords(s , out srev);
        Console.WriteLine(srev);
    }
}

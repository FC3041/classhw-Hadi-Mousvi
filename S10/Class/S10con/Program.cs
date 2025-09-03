namespace S10con;

class Program
{
    static void Main(string[] args)
    {
        // string[] lines = File.ReadAllLines("text1.txt");
        // File.WriteAllLines("text2.txt" , lines);
        if(args.Length != 2)
        {
            return;
        }
        int linecount = 0;
        int charcount = 0;
        int wordcount = 0;
        using(StreamReader reader = new StreamReader(args[1]))
        {
            string line;
            while( null != (line = reader.ReadLine()))
            {
                linecount++;
                charcount += line.Length;
                foreach(string s in line.Split(' ', StringSplitOptions.RemoveEmptyEntries ))
                {
                    wordcount++;
                    if(wordcount > 10)
                    {
                        reader.Dispose();
                        return;
                    }
                }
            }
        }   
        System.Console.WriteLine($"{linecount} {wordcount} {charcount}");
    }
}

using System.Security.Cryptography.X509Certificates;

namespace S8con;

public class Program
{

    public static void reverse(string s , out string srev)
    {
        srev = "";
        foreach(char c in s)
        {
            srev = c + srev;
        }
    }

    static void Main(string[] args)
    {
        string name = "Hadi";
        string srev;
        reverse(name , out srev);
        Console.WriteLine(srev);
    }

    static void Main1(string[] args)
    {
        int sum = 0;
        while(true)
        {
            Console.WriteLine("Nums ?");
            string s = Console.ReadLine();
            if(string.IsNullOrEmpty(s))
                break;
            int n;
            if(! int.TryParse(s, out n))
            {
                Console.WriteLine("Wrong! Try again.");
                continue;
            }
            sum += n;
                
            string sout;
            prepend_user(s ,out sout);
            Console.WriteLine(sout);
        }
        Console.WriteLine(sum);
        // for(int i=0 ; i < args.Length ; i++)
        //     Console.WriteLine($"args{i} : {args[i]}");
    }

    public static void prepend_user(string s , out string sout)
    {
        sout = "user: "+s;
    }

    public static int add(int a , int b)
    {
        return a+b;
    }
}

public class Program2
{
    public static void Do1(object obj)
    {
        System.ConsoleColor c = (System.ConsoleColor) obj;
        while(true)
        {
            System.ConsoleColor pc = Console.ForegroundColor;
            Console.ForegroundColor = c;
            System.Console.WriteLine(c.ToString());
            Console.ForegroundColor = pc;
            Thread.Sleep(500);
        }
    }

    public static void Main(string[] args)
    {
        Thread t = new Thread(Do1);
        // t.Start("Do1"); // it gives Do1 the input "Do1" as obj
        t.Start(System.ConsoleColor.Yellow);
        Thread t1 = new Thread(Do1);
        // t1.Start("Do2"); // it gives Do1 the input "Do2" as obj
        t1.Start(System.ConsoleColor.Cyan);
        while(true)
        {
            System.Console.WriteLine("Main");
            Thread.Sleep(500);
        }
    }
}
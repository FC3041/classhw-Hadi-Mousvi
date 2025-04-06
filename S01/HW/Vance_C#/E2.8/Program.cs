namespace e28
{
    public class E28
    {
        public static int p1(int n)
        {
            int sum=0;
            for(int i=1;i<=n;i++)
                sum += i;
            return sum;
        }
        static void Main()
        {
            Console.WriteLine("N             p1");
            Console.WriteLine("----------------");
            for(int i=9;i>0;i--)
                Console.WriteLine(i+"              "+p1(i));
        }   
    }
}
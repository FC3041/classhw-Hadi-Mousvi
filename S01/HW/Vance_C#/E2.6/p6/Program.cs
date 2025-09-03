namespace p6
{
    class P6
    {
        public static void Changes(int n)
        {
            int sn = n;
            int quarters;
            int dimes;
            int nickels;
            int pennies;
            quarters = sn/25;
            sn = sn%25;
            dimes = sn/10;
            sn = sn%10;
            nickels = sn/5;
            pennies = sn%5;
            Console.Write("the change for "+ n +" is "+ quarters +" quarters, "+ dimes +" dimes, "+ nickels +" nickels and "+ pennies +" pennies");
        }
        static void Main()
        {
            
        }
    }
}
namespace e10
{
    public class E10
    {
        public static double power(double a,double b)
        {
            double result=1;
            for(int i=0;i<b;i++)
                result *= a;
            return result;
        }
        public static double factorial(double n)
        {
            double result=1;
            for(int i=1;i<=n;i++)
                result *= i;
            return result;
        }
        public static double p1(int precision)
        {
            double result=2;
            int p=0;
            double counter=2; 
            while(p<=precision)
            {
                result += 1 * (1.0/factorial(counter));
                if(p==precision)
                    result = Math.Round(result , p);
                p++;
                counter++;
            }
            return result;
        }

        public static double p2(double x,int precision)
        {
            double result=1;
            int p=-1;
            double counter=1; 
            while(p<=precision)
            {
                result += 1 * (power(x,counter)/factorial(counter));
                if(p==precision)
                    result = Math.Round(result , p);
                p++;
                counter++;
            }
            return result;
        }
        static void Main()
        {
            Console.Write(p1(5));
        }
    }
}
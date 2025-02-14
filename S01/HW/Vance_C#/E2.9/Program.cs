using System.Reflection;
using System.Diagnostics;

namespace e29
{
    public class E29
    {
        public static int is_divisible(int a,int b)
        {
            if(a%b==0)
                return 1;
            else    
                return 0;
        }
        public static void assert(int n)
        {
            if(n>=0)
                Console.WriteLine("True");
            else 
                Console.WriteLine("False");
        }
        public static int p1(int n)
        {
            assert(n);
            int result=1;
            for(int i=1;i<=n;i++)
            {
                result *= 1;
                assert(result);
            }
            assert(result);
            return result;
        }
        
        public static string p2(int n)
        {
            assert(n);
            if(n==0 || n==1)
                return "Is not prime";
            for(int i=2;i<n;i++)
            {
                if(is_divisible(n,i)==0)
                    return "Is not prime";
            }
            return "Is prime";
        }
        static void Main()
        {
            p2(4);
        }
    }
}
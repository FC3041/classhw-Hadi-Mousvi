using System.Runtime.CompilerServices;

namespace E27
{
    public class Parts
    {
        public static int is_leap(int year)
        {
            if(year%400==0 || (year%100!=0 && year%4==0))
                return 1;
            else
                return 0;
        }
        public static double p1(double n)
        {
            if(n<0)
                n = -n;
            return n;
        }

        public static int p2(int n)
        {
            int result=1;
            for(int i=1;i<=n;i++)
                result *= i;
            return result;
        }

        public static string p3(int a,int b)
        {
            if(a%b==0)
                return "True";
            else
                return "False";
        }

        public static string p4(int n)
        {
            if(n==1 || n<=0)
                return "False";
            else if(n==2)
                return "True";
            for(int i=2;i<n;i++)
            {
                if(p3(n,i)=="True")
                    return "False";
            }
            return "True";
        }

        public static int p5(int n)
        {
            int n1=1;
            int n2=1;
            int cn;
            for(int i=2;i<n;i++)
            {
                cn = n2;
                n2 += n1;
                n1 = cn;
            }  
            return n2;
        }

        public static int p6(int month)
        {
            int days;
            if(month==2)
                days = 28;
            else if(month==4 || month==6 || month==11 || month==9)
                days = 30;
            else
                days = 31;
            return days;
        }

        public static int p7(int year, int month)
        {
            int days;
            if(month==2)
            {
                if(is_leap(year)==1)
                    days = 29;
                else
                    days = 28;
            }
            else if(month==4 || month==6 || month==11 || month==9)
                days = 30;
            else
                days = 31;
            return days;
        }

        public static int p8(int year,int month,int day)
        {
            int days_before=0;
            int days_in_month;
            for(int i=1;i<month;i++)
            {
                days_in_month = p7(year,i);
                days_before += days_in_month;
            }
            days_before += day-1;
            return days_before;
        }

        public static int p9(int year,int month,int day)
        {
            int days = p8(year,month,day);
            return days%7;
        }
        static void Main()
        {
            
        }
    }
}
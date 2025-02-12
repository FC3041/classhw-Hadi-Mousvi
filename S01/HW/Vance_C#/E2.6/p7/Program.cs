namespace p
{
    class P
    {
        public static int power(int a,int b)
        {
            int result=1;
            for(int i=0;i<b;i++)
            {
                result *= a;
            }
            return result;
        }

        public static void Ptriples()
        {
            for(int a=0;a<100;a++)
            {
                for(int b=0;b<100;b++)
                {
                    for(int c=0;c<100;c++)
                    {
                        if((power(a,2) + power(b,2)==power(c,2))&&(c!=b)&&(a!=b)&&(c!=a))
                            Console.WriteLine(a + " , " + b + " -> "+ c);
                    }
                }
            }
        }
        static void Main()
        {
            
        }
    }
}
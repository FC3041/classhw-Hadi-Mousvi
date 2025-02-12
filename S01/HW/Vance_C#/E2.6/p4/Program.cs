namespace p4
{
    class P4
    {
        public static void MakeCone1_to_9()
        {
            int widths = 9;
            for(int width=1;width<=widths;width += 2)
            {   
                int util = width/2;
                for(int i=0;i<util;i++)
                    Console.Write(" ");
                Console.WriteLine("^");
                for(int i=1;i<=util;i++)
                {
                    for(int j=0;j<util-i;j++)
                        Console.Write(" ");
                    for(int a=0;a<i;a++)
                        Console.Write("/");
                    Console.Write("|");
                    for(int a=0;a<i;a++)
                        Console.Write("\\");
                    Console.Write("\n");
                }
            }
        }
           static void Main()
        {
            MakeCone1_to_9();
        }
    }
}
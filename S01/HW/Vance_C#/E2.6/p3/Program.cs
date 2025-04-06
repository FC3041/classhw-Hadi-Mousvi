using System;
using System.Xml.Serialization;
namespace p3
{
    public class P3
    {
        public static void MakeCone(int width)
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
        public static void Line(int width)
        {
            Console.Write("+");
            for(int i=0;i<width-2;i++)
                Console.Write("-");
            Console.Write("+\n");
        }

        public static void MakeBody(int width ,int height , int bn)
        {
            for(int i=0;i<bn;i++)
            {
                for(int l=0;l<height;l++)
                {
                    Console.Write("+");
                    for(int j=0;j<width-2;j++)
                        Console.Write("*");
                    Console.WriteLine("+");
                }
                Line(width);
            }
        }
        public static void MakeRocket(int width ,int height , int bn)
        {
            if(width%2==0)
                Console.WriteLine("error");
            else
            {
                MakeCone(width);
                Line(width);
                MakeBody(width , height , bn);
                MakeCone(width);
            }
        }
        static void Main()
        {
            
        }
    }
}
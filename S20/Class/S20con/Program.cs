using System.Linq.Expressions;
using System.Numerics;

namespace S20con;

class Program
{
    public static (int,int,double) RTuple(int[] nums)
    {
        int min = nums.Min();
        int max = nums.Max();
        // int sum = 0;
        double average = nums.Average();
        // foreach(int a in nums)
        // {
        //     if(a < min)
        //     {
        //         min = a;
        //     }
        //     if(a > max)
        //         max = a;
        //     sum += a;
        // }
        // average = sum / nums.Length;
    
        return (min, max, Math.Round(average , 2));
    }

    static void Main(string[] args)
    {
        //Tuple
        Tuple<string,int> t1 = new Tuple<string, int>("Ali" , 12);
        Console.WriteLine(t1.ToString());

        var t2 = new Tuple<string,int,int>("Zahra",12,4142);
        Console.WriteLine(t2.ToString());
    
        var t3 = Tuple.Create<string,int>("hoda" , 123);
        Console.WriteLine(t3.ToString());
        MyTuple<string,int> mt1 = new MyTuple<string,int>("Reza" , 13);

        ValueTuple<string,int> t5 = new ValueTuple<string,int>("Hosna",34); //its value not reference
        Console.WriteLine(t5.ToString());
    }
    static void Main2(string[] args)
    {
        string name = "computer";
        string name2 = name.TitleCase();
        System.Console.WriteLine(name2);

        string n = "da9123";
        int x = n.NumsCount();
        Console.WriteLine(x);
    }
    static void Main1(string[] args)
    {
        int x = 5;
        double y = 6.8;

        // x = y;raises error because int doesnt have enough space for double
        y =x; //implicit
        x = (int)y; // explicit

        ComplexNumber cn1 = new ComplexNumber(2, 6);
        ComplexNumber cn2 = new ComplexNumber(1, 9);

        y = cn1;
        cn2 = y;
        cn2.PrintCN();
    }
    static void Main0(string[] args)
    {
        ComplexNumber cn1 = new ComplexNumber(2, 6);
        ComplexNumber cn2 = new ComplexNumber(1, 9);
        ComplexNumber cn3 = cn1 + cn2;
        Console.WriteLine(cn3[0]);
        Console.WriteLine(cn3[true]);
        cn3.PrintCN();
    }
}

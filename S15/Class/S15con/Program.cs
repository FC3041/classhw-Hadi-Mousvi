using System.Numerics;

namespace S15con;

class Program
{
    static void Swap<T>(ref T a ,ref T b)
    {
        T tmp = a;
        a = b;
        b = tmp;
    }

    static T Max<T>(T a , T b) 
        where T:IComparable<T>
    {
        if(a.CompareTo(b) < 0)
            return b;
        return b;
    }
    static Student Max(Student a , Student b) 
    {
        if(b > a)
            return b;
        return b;
    }

    static T Sum<T>(T a , T b)
        where T:INumber<T> // Declares that T is a Number like Integers or doubles
    {
        return  a + b; 
    }

    //TODO: Sum Array of Numbers

    static T sum<T>(T[] nums) where T : INumber<T>
    {
        T x = T.Zero; // gives error for T x = 0
        for(int i = 0 ; i< nums.Length ; i++)
        {
            x += nums[i];
        }
        return x;
    }


    static void PrintItems<T>(IEnumerable<T> Items)
    {
        foreach(T i in Items)
        {
            System.Console.WriteLine(i);
        }
    }

    static void PrintItemsMe<T>(IEnumerable<T> Items)
    {
        IEnumerator<T> eor = Items.GetEnumerator();
        // var eor1 = Items.GetEnumerator();
        while(eor.MoveNext())
        {
            Console.WriteLine(eor.Current);
        }
    }

    static T sum<T>(IEnumerable<T> Items) where T:INumber<T>
    {
        T x = T.Zero;
        foreach(T i in Items)
        {
            x += i;
        }
        return x;
    }

    static void Main(string[] args)
    {
        int[] nums = {3,4,5,6};
        double[] numsd = {3,1,4.2 , 5.3 , 6.4};

        int sum = sum<int>(nums);
        Console.WriteLine(sum);

        double dsum = sum<double>(numsd);

        List<int> numsl = new List<int>();
        numsl.Add(1);
        numsl.Add(5);
        numsl.Add(9);

        Stack<int> numsstack = new Stack<int>();
        numsstack.Push(4);
        numsstack.Push(2);
        numsstack.Push(8);
        Queue<int> qnums = new Queue<int>();
        qnums.Enqueue(1);
        qnums.Enqueue(3);
        qnums.Enqueue(2);

        Console.WriteLine("queue");
        PrintItemsMe(qnums);
        Console.WriteLine("stack");
        PrintItemsMe(numsstack);
        Console.WriteLine("list");
        PrintItemsMe(numsl);

        int h = sum<int>(qnums);
        Console.WriteLine(h);


        IEnumerable<int> ax = new List<int>(); // != new IEnumrable<int>() ===> because its interface

        
        
        // foreach(var v in numsstack)
        // {
        //     Console.WriteLine(v);
        // }
    }


    static void Main2(string[] args)
    {
        int a= 5;
        int b = 6;

        string sa = "ali";
        string sz = "Zali";

        Student ssa = null, ssb = null;

        Student c = Max<Student>(ssa , ssb);
        Console.WriteLine(c);

        // Swap<int>(ref a ,ref b);
        // Console.WriteLine($"{a} , {b}");
    }
}

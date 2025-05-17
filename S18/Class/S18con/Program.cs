using System.Data.SqlTypes;
using Microsoft.VisualBasic;

namespace S18con;

class AddClossure
{
    private int Remainder;
    public AddClossure(int remainder)
    {
        this.Remainder = remainder;
    }
    public int add(int a , int b)
    {
        return (a + b) % Remainder;
    }
}

class Program
{
    // static void PrintStudent(Student? s)
    // {
    //     if(s != null)
    //     {
    //         System.Console.WriteLine($"{s.fristname}");
    //         if(s.id.HasValue)
    //             System.Console.WriteLine(s.id.Value);
    //     }
        
    // }

    // static void Main1(string[] args)
    // {
    //     Student? s = null;
    //     PrintStudent(s);
    // }

    delegate T fnp_int_2int<T>(T a , T b); //Function pointer

    // static void apply<T>(T[]nums1 , T[]nums2 , T[] result , fnp_int_2int<T> fn)
    // {
    //     for(int i = 0 ; i < nums1.Length ; i++)
    //     {
    //         result[i] = fn(nums1[i] , nums2[i]);
    //     }
    // }
    static void apply<T>(T[]nums1 , T[]nums2 , T[] result , Func<T ,T ,T> fn) //without delegate we defined top of the code 
    {
        for(int i = 0 ; i < nums1.Length ; i++)
        {
            result[i] = fn(nums1[i] , nums2[i]);
        }
    }

    static int add(int a , int b){return a+b;}
    static int mul(int a , int b){return a*b;}

    static void DoDo<T>(T[] values , Action<T> a)
    {
        foreach(var v in values)
        {
            a(v);
        }
    }

    static void w2f<T>(T Value)
    {
        string filename = "a.txt";
        if(Value != null)
            File.AppendAllText(filename , Value.ToString() + "\n");
    }

    // Func always have return
    //Action doesnt have return
    static void Main(string[] args)
    {
        // Func<int , int> f;
        // Action<int> f1;
        int[] n1 = new int[3] {1,2,3};
        int[] n2 = new int[3] {-1,-2,-3};
        int[] r = new int[3];

        for(int i =0 ; i<10 ; i++)
        {
            apply(n1,n2,r,(a,b)=> (a+b)%i);
        }

        int remainder = 5;
        apply(n1,n2,r,(a,b)=> (a+b)%remainder);



        // AddClossure a = new AddClossure(5);
        // apply(n1,n2,r, a.add);
        // DoDo(r , System.Console.WriteLine);
        // Func<int , int , int> f = (int a , int b) => a*b+a-2; // Inline Funciton ,, lambda expretion
        Func<int , int , int> f2 = (a ,b) => a*b+a-2; // because we said a and b are ints
        var f = (int a ,int b) => a*b+a-2; // we have to say they are ints
        
        // apply(n1 , n2 , r , f);
        // apply(n1 , n2 , r , (a ,b) => a*b+a-2);
        // apply(n1 , n2 , r , mul);
        // foreach (var item in r)
        // {
        //     System.Console.WriteLine($"{item}");
        // }
        // DoDo(r , System.Console.WriteLine);
        // DoDo(r , w2f);
    }

}

// class Student 
// {
//     public Student()
//     {
//         this.fristname = string.Empty;
//     }
//     public string? fristname;
//     public Nullable<int> id;
// }
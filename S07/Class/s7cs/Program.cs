using System.Data;

namespace s7cs;

class Program
{
    static void update(int[] nums)
    {
        for(int i = 0 ; i < nums.Length ; i++)
            nums[i]++;
    }

    static void Main(string[] args)
    {
        int [] num = new int [10] {1,3,45,6,7,4,3,2,1,5};
        update(num);

        for(int i = 0; i<num.Length ; i++)
            Console.WriteLine(num[i]);

        // for(int i = 0; i<100000 ; i++)
        // {
        //     int[] nums = new int[1000*1000];
        //     Thread.Sleep(1);
        // }

        Console.WriteLine("Hello, World!");
    }
}

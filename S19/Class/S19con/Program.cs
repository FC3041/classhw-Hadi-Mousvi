using System.IO.Pipelines;

namespace S19con;

class Program
{
    public delegate void LogFn(string msg);
    public delegate int BinaryOp(int a , int b);
    // private static  LogFn Log;
    private static event LogFn Log; // we can only add(+=) and remove(-=), we cant =

    static int[] Apply(int[] nums1 , int[] nums2 , BinaryOp op)
    {
            int[] result = new int[nums1.Length];
            for(int i=0 ; i < nums1.Length ; i++)
                result[i] = op(nums1[i] , nums2[i]);
            return result;
    }


    static void LogToFile(string msg)
    {
        File.AppendAllText("log.txt" , msg);
    }
    static int add(int a , int b) => a+b;
    static int mul(int a , int b) => a*b;

    static void Main2(string[] args)
    {
        Log += Console.WriteLine;
        Log += LogToFile;

        int[] nums1 = new int[4] {1,2,3,4};    
        int[] nums2 = new int[4] {3,7,4,2};
        int[] result1 = Apply(nums1 , nums2 , add);
        foreach(var r1 in result1)
            Log?.Invoke(r1.ToString()); // when we want to use ? , we have to use invoke

        Log -= LogToFile;
        Log += msg => Console.WriteLine($"SMS:+98124124 {msg}"); // Anymous Function
        Log -= msg => Console.WriteLine($"SMS:+98124124 {msg}"); // because it doesnt have name it wont work

        var v = new {Name="Ali" , Id = 123}; // Anymous Object 


        int r = 15;
        string s = null;
        // s?.Length if its null it wont run
        string name = s ?? string.Empty; // if s!=null => name = s else name = string.Empty
        string name2 = s != null ? s : string.Empty; 
      
        int[] result2 = Apply(nums1 , nums2 , (int a , int b) =>(a*2 - b + 5) % r);
        foreach(var r1 in result2)
            Log?.Invoke(r1.ToString());
        BinaryOp op1 = (int a , int b) =>{return (a*2 - b + 5) % r;};
        // BinaryOp op2 = (a ,b) =>{return (a*2 - b + 5) % r;};
        var op3 = (int a ,int b) =>{return (a*2 - b + 5) % r;};

        Log?.Invoke("Hello");
    }
}

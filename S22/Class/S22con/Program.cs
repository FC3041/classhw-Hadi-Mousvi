using System.IO.IsolatedStorage;
using System.Runtime.Serialization;

namespace S22con;

class Program
{
    static bool IsOdd(int n)
    {
        return n%2==1;
    }

    static bool IsPrime(int n)
    {
        if(n == 0 || n == 1)
            return false;
        if(n==2)
            return true;
        for(int i = 2 ; i < n ; i++)
        {
            if(n%i==0)
                return false;
        }
        return true;
    }

    static string ListToString(IEnumerable<int> nums)
    {
        return string.Join(" " , nums);
    }

    static void Main(string[] args)
    {
        var data = Enumerable.Range(1,100)
                        .Where(x =>IsPrime(x))
                        .Select(x =>(
                           item1 : x , 
                            item2 : x.ToString().Select(c => c-48).Sum()
                        ));
        data.Join(data, d1 => d1.item2 , d2 => d2.item2 ,(d1 ,d2) => (d1.item1 , d2.item1 , d2.item2))
            .DistinctBy(t => (t1,t2,k) =>
            {
                if(n1<n2)
                    return(n1,n2);
                return(n2,n1);
            })
            .ToList()
            .ForEach(x => Console.WriteLine(x));  

        return;            
        // Enumerable.Range(1,100).Where(IsOdd).ToList().ForEach(n => Console.WriteLine(n));
        Enumerable.Range(0,100)
                        .GroupBy(x => x/10)
                        .Select(ListToString)
                        .ToList()
                        .ForEach(System.Console.WriteLine);
        
        Enumerable.Range(0,100)
                        .GroupBy(x => x/10)
                        .Select(ig =>
                        (
                            ig.Key,
                            ig.Where(x => x%2 == 1).Average()
                        ))
                        .ToList()
                        .ForEach(x => Console.WriteLine(x));

    }
}

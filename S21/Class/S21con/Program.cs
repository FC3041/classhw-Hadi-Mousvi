using System.Data;
using System.Security.Cryptography;

namespace S21con;

class Program
{
    public static IEnumerable<string> GetNames()
    {
        yield return "ali"; //yield is for IEnumrable
        yield return "Fateme";
        yield return "Zhara";
    }

    static void Main(string[] args)
    {
        var data = File.ReadAllLines("children-per-woman-UN.csv")
                        .Skip(1)
                        .Select(l =>
                        {
                            string[] tokens = l.Split(',');
                            string country = tokens[0];
                            int year = int.Parse(tokens[2]);
                            double rate = double.Parse(tokens[3]);
                            return (country : country , year : year , rate : rate);
                        });
        data.Join(data , 
                        (d1) => (d1.country,d1.year),
                        (d2) => (d2.country , d2.year -1),
                        (d1,d2) => (country:d1.country , y1:d1.year , y2:d2.year , r1:d1.rate , r2:d2.rate)
                        )
                        .GroupBy(t => t.country)
                        .Select(g =>
                        {
                            var maxdiff = g.MaxBy(t=>Math.Abs(t.r2-t.r1 ));
                            return ( country : g.Key , diff:Math.Abs(maxdiff.r2-maxdiff.r1));
                        })
                        .OrderBy(t => t.diff)
                        .ToList()
                        .ForEach(l => System.Console.WriteLine(l));
    }
    static void Main2(string[] args)
    {
        // string[] Lines =
        File.ReadAllLines("children-per-woman-UN.csv")
                // .Where(l=> l.ToLower().Contains("iran"))
                .Skip(1)
                .Select(l =>
                {
                    string[] tokens = l.Split(',');
                    string country = tokens[0];
                    int year = int.Parse(tokens[2]);
                    double rate = double.Parse(tokens[3]);
                    return (country : country , year : year , rate : rate);
                })
                .GroupBy(t=>t.country)
                .Select(g =>
                {
                    return(country : g.Key , rate:g.Average(t=>t.rate));
                })
                // .Where(t=>(t.year>2012) && (t.rate > 3))
                .OrderBy(t=>t.rate)
                // .Take(5)
                .ToList()
                .ForEach(l=>System.Console.WriteLine(l));


        // foreach(var Item in Lines.MyTake2<string>(10))
        // {
        //     System.Console.WriteLine(Item);
        // }
    }
    static void Main1(string[] args)
    {
        foreach(var Item in GetNames())
        {
            System.Console.WriteLine(Item);
        }
    }
}

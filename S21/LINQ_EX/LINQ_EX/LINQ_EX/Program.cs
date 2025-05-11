namespace LINQ_EX;

enum LifeExpectancyType {AtBirth, At60}
enum DataGender { Male, Female, Both}
class Data
{
    public Data(LifeExpectancyType leType, int year, string territory, string country, DataGender dg, double value)
    {
        LEType = leType;
        Year = year;
        Territory = territory;
        Country = country;
        DataGender = dg;
        Value = value;
    }

    public LifeExpectancyType LEType {get; }
    public int Year {get; }
    public string Country {get;}
    public DataGender DataGender {get;}
    public double Value {get;}
    public string Territory { get; }

    public override string ToString() =>
        $"{Country},{Year},{LEType},{DataGender},{Value}";

    public static Data Parse(string line)
    {
        var toks = line.Split(',').Select(t => t.Trim('"')).ToArray();        
        LifeExpectancyType leType = toks[0].Contains("60") ? 
                LifeExpectancyType.At60 :
                LifeExpectancyType.AtBirth;
        int year = int.Parse(toks[1]);
        string territory = toks[2].ToLower();
        string country = toks[3].ToLower();
        DataGender dg = toks[4].Contains("Both") ?
            DataGender.Both :
            (
                toks[4].Contains("Male") ? 
                    DataGender.Male :
                    DataGender.Female
            );
        double value = double.Parse(toks[5]);
        return new Data(leType, year, territory, country, dg, value);
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<string> Lines = File.ReadAllLines("data.csv").Skip(1).ToList();
        Data[] Datas = new Data[Lines.Count()];
        for(int i = 0 ; i < Lines.Count() ; i++)
        {
            Datas[i] = Data.Parse(Lines[i]);
        }

        //Query 1
        Console.WriteLine("Query 1");
        //
        var DTuples =
        Datas
            .Where(d => d.Country.ToLower().Contains("iran"))
            .Where(d => d.LEType == LifeExpectancyType.AtBirth)
            .Where(d => d.DataGender == DataGender.Both)
            .OrderBy(d => d.Value)
            .Select(d =>
            {
                return (country : d.Country , year : d.Year , LEType : d.LEType , gender : d.DataGender , value : d.Value);
            })
            .ToList();
        foreach(var dt in DTuples)
        {
            Console.WriteLine(dt);
        }
        //
        Console.WriteLine();

        //Query 2
        Console.WriteLine("Query 2");
        //
        double maxdiff = DTuples[DTuples.Count()-1].value - DTuples[0].value;
        Console.WriteLine(maxdiff); 
        //

        Console.WriteLine();


        //Query 3
        Console.WriteLine("Query 3");
        //
        
        //
        Console.WriteLine();

        //Query 4
        Console.WriteLine("Query 4");
        //
        //
        Console.WriteLine();

    }
}

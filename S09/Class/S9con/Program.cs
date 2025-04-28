
namespace S9con;

class Program
{
    static void Main(string[] args)
    {
        int x = int.Parse("534"); // string to int
        int y = 5;
        if(y.CompareTo(x) > 0)
            System.Console.WriteLine("-");
        Console.WriteLine(y.ToString());  // first to string then write in terminal == Console.WriteLine()

        Student s = new Student(  
            name : "Hadi Mousavi" ,
            stdid : 403522 ,
            natid : 02505269 ,
            credits : 33 ,
            active : true);

        string str = "Hadi Mousavi , 403522 , 2505269 , 33 , True";
        Student sc = Student.Parse(str);
        
        int i = 5;
        object o = i;
        int n = (int) o;

        File.WriteAllLines("test.csv" ,new string[]{s.ToString() , sc.ToString()});
        
        // Console.WriteLine(sc);
        // Console.WriteLine(s.ToString());
    }
}

public class Student
{
    private string name;
    private int stdid;
    private int natid;
    private int credits;
    private bool active;

    public Student(string name, int stdid, int natid, int credits, bool active)
    {
        this.name = name;
        this.stdid = stdid;
        this.natid = natid;
        this.credits = credits;
        this.active = active;
    }

    public static Student Parse(string str) // it doesnt need override because its static and for that we cant just put name or stdid =
    {
        string[] tokens = str.Split(',');
        var name = tokens[0];
        var stdid = int.Parse(tokens[1]);
        var natid = int.Parse(tokens[2]);
        var credits = int.Parse(tokens[3]);
        var active = bool.Parse(tokens[4]);
        return new Student(name , stdid , natid , credits , active);

    }

    public override bool Equals(object obj)
    {
        if(obj is Student){
            Student other = obj as Student;
            return 
                name.Equals(other.name) &&
                stdid.Equals(other.stdid) &&
                natid.Equals(other.natid) &&
                credits.Equals(other.credits) &&
                active.Equals(other.active);
        }
        else
            return false; 
    }

    public override string ToString() => $"{name} , {stdid} , {natid} , {credits} , {active}"; // == { return $"....."; } it has to be one line

    // public void printme() => System.Console.WriteLine(this.ToString());
}
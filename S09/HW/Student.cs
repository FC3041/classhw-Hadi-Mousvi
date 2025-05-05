using System.Reflection.Metadata;

public class Student
{
    private string name;
    private int stdid;
    private int credits;

    public Student(string m_name, int m_stdid, int m_credits)
    {
        name = m_name;
        stdid = m_stdid;
        credits = m_credits;
    }

    public static Student Parse(string v)
    {
        string[] lstr = v.Split(',');
        var name = lstr[0];
        var stdid = int.Parse(lstr[1]);
        var credits = int.Parse(lstr[2]);
        return new Student(name , stdid , credits);
    }

    public override string ToString() => $"{name} , {stdid} , {credits}";

    public void PrintStudent() => Console.WriteLine(this.ToString()); 
}
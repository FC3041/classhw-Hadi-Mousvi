
public interface IsHigher<T>
{
    bool IsHigher(T std);
}

public class Student : IComparable
{
    public string fname;
    public string lname;
    public int NID;
    public Student(string f , string l , int id)
    {
        fname = f;
        lname = l;
        NID = id;
    }

    public int IsHigher(Student std)
    {

    }
    public int CompareTo(object? obj)
    {
        Student tempt = obj as Student;
        if(tempt == null)
        {
            return 1;
        }
        return this.NID.CompareTo(tempt.NID);
    }
}
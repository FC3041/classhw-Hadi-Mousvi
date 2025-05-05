public class Student : IComparable<Student>
{

    public static bool operator <(Student a , Student b) =>  a.CompareTo(b) < 0;
    public static bool operator >(Student a , Student b) =>  !(a < b);

    public static Student[] operator + (Student a , Student b)
    {
        return new Student[]{a,b};
    }
    
    public static Student operator + (Student a , double b)
    {
        a.Akhlagh += b;
        return a;
    }

    public double Akhlagh {get; set;}

    public int CompareTo(Student? other)
    {
        return this.Akhlagh.CompareTo(other.Akhlagh);
    }
}
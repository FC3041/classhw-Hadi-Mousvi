public interface IPerson<_Type> 
{
    _Type id {get; set;}
    string Firstname {get;set;}
    string Lastname {get; set;}
    string FullName {get;}
}

class Student : IPerson<int> , IComparable<Student>
{
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string FullName => Firstname + " " + Lastname;
    // {
    //     get{return Firstname + " " + Lastname}
    // }
    public double GPA {get; set;}
    public int id { get; set;}

    public int CompareTo(Student other)
    {
        return this.Lastname.CompareTo(other.Lastname);
    }

    public override string ToString()
    {
        return $"{Firstname} , {Lastname} , {GPA} , {id}";
    }
}

class Teacher : IPerson<string>
{
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string FullName => Firstname + " " + Lastname;
    public double Rating {get ; set;}
    public string id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    // {
    //     get{return Firstname + " " + Lastname}
    // }
}
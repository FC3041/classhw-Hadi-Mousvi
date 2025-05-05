public class Citizen
{
    public string Firstname{get;set;}
    public string Lastname{get;set;}
    public int NationalID{get;set;}
    public bool Is_Male{get;set;}
    public int PostalCode{get;set;} = 0;

    public Citizen(string fname, string lname , int id , bool isMale , int postcode)
    {
        this.Firstname = fname;
        this.Lastname = lname;
        this.NationalID = id;
        this.Is_Male = isMale;
        this.PostalCode = postcode;
    }
    public Citizen(string fname, string lname , int id , bool isMale)
        : this(fname , lname , id , isMale , 0){}

    public override string ToString()
    {
        return $"{base.ToString()} ({this.Firstname} , {this.Lastname})";
    }
    // public Citizen(){}
}

public class Student : Citizen
{
    public int StdID{get;set;}
    public string Major{get;set;}
    public bool IsPaying{get;set;}

    public Student(string fname, string lname , int id, string major , int stdid , bool isPaying )
        : base(fname , lname , id , false , 16312) 
    {
        this.IsPaying = isPaying;
        this.StdID = stdid;
        this.Major = major;
        //----------------------------
        // this.Firstname = fname;
        // this.Lastname = lname;
        // this.NationalID = id;
        // this.Is_Male = isMale;
        // these give error because it doesnt call the constructor of Citizen
    }

    public virtual void Register(string course)
    {
        Console.WriteLine($"{this.Firstname} reg in {course}");
    }

    public override string ToString()
    {
        return $"{base.ToString()} - {this.Major}";
    }
}

public class GrandSudent : Student
{
    public string Minor{get; set;}
    public string ThesisTitle{get;set;}
    public GrandSudent(string fname, string lname , int id, string major , int stdid , bool isPaying , string minor , string thesisTitle)
        : base(fname , lname , id , major , stdid , isPaying) 
    {
        this.Minor = minor;
        this.ThesisTitle = thesisTitle;
    }

    public override string ToString()
    {
        return $"{base.ToString()} - {this.Minor}";
    }
    public override void Register(string course)  //because the Register in Student was virtual, we can override it.
    //  but if we put new instead of override, Grandsudents Register will lose its connection to Register in Student and it is only for GrandStudent and Student cant use it
    {
        Console.WriteLine($"{this.Firstname} intro to prof in {course}");
    }

}

// public class Teacher : Citizen
// {
    //TODO Salary
    //TODO Rating
    //TODO EmployeeID
// }
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

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
}

public class Teacher : Citizen
{
    public double Salary{get;set;}
    public int Rating{get;set;}
    public int EmployeeID{get;set;}
    public Teacher(string fname, string lname , int id , bool isMale, int postcode , double salary, int rating , int EID)
        : base (fname,lname,id,isMale)
    {
        this.Salary = salary;
        this.Rating = rating;
        this.EmployeeID = EID;
    }
}
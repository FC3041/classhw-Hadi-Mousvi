using System.Drawing;

namespace S16con;

class Program
{

    static void print_citizen(Citizen[] cs)
    {
        foreach(var c in cs)
            Console.WriteLine(c.ToString());
    }
    static void Main(string[] args)
    {
        Vector[] Points = new Vector[3]
        {
            new Vector(1,1),
            new Vector(1,3),
            new Vector(5,2)
        };

        List<Square> squares = new List<Square>();
        foreach(var p in Points)
        {
                
        }
    }
    static void Main2(string[] args)
    {
        Citizen k = new Citizen("Hadi" , "Mousavi" , 025052,true);
        Student s = new Student("Zari" , "Hedayati" , 2 , "math" , 403522 , false);
        GrandSudent gs = new GrandSudent("Zari" , "Hedayati" , 2 , "math" , 403522 , false , "Calculus" , "Integral");

        Citizen [] citizens = new Citizen[]{k,s,gs};
        // print_citizen(citizens);
        // Console.WriteLine(k);
        // Console.WriteLine(s); // it will write student instead of citizen because when we create an student , it will be its own class and base.
        // Console.WriteLine(gs);
        s.Register("Numericals");
        gs.Register("Numericals 2");
        Student s2 = gs; // because Student is its base
        s2.Register("Numercials 3");
        // GrandSudent gs2 = (GrandSudent)s2;
        // GrandSudent gs3 = (GrandSudent)s;
        

    }
}

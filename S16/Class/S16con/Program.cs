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
    }
}

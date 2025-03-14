namespace HW;

class Program
{
    public static void RegisterStds(string filename)
    {
       string[] rawstd =  File.ReadAllLines(filename);
       Student[] students = new Student[rawstd.Length];
       int i = 0;
       foreach(string s in rawstd)
       {
            students[i] = Student.Parse(s);
            i++;
       }
    }

    static void Main(string[] args)
    {

    }
}

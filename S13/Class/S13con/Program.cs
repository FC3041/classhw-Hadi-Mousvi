
namespace S13con;

class Program
{
//     public static void PrintPerson(Student s)
//     {
//         Console.WriteLine(s.FullName);
//     }
//     public static void PrintPerson(Teacher s)
//     {
//         Console.WriteLine(s.FullName);
//     }
    public static void PrintPerson(IPerson<int>[] s)
    {
        foreach(var person in s)
        {
            Console.WriteLine(person);
        }
    }
    static void Main(string[] args)
    {
        Student[] students = new Student[]{
            new Student() {
                Firstname = "Ali",
                Lastname = "hamedi" ,
                 GPA = 15,
                 id = 12},
            new Student(){
                Firstname = "Hadi",
                Lastname = "Mousavi",
                GPA = 18,
                id = 5}};
        Teacher t = new Teacher(){Firstname = "Ali1" , Lastname = "Hamedi1" , id = "3123F"};
        PrintPerson(students);
        MySort(students);

        
        // PrintPerson(t);

    }

    private static void MySort(IPerson<int>[] people)
    {
        for(int i=0; i<people.Length ; i++)
        {
            for(int j=1+i ; j < people.Length ; j++)
            {
                
            }
        }
    }
}

namespace S12con;

class Program
{

    public static void MySort<T>(T[] plist)
    {
        for(int i = 0; i < plist.Length ; i++)
        {
            for(int j=i; j < plist.Length ; j++)
            {
                if(plist[i].NID < plist[j].NID)
                {
                    swap(plist , i ,j);
                }
            }
        }
    }

    public static void swap<T>(T[] plist , int i , int j)
    {

    }

    static void Main(string[] args)
    {
        Student[] students = new Student[3](
            new Student("ali" , "mohammadi" , 341234),
            new Student("ali2" , "mohammadi5" , 341234),
            new Student("ali3" , "mohammadi4" , 341234)
        );
    }

    // static void Main(string[] args)
    // {
    //     Student p1 = new Student("ali" , "mohammadi" , 341234); 
    //     Student p2 = new Student("ali2" , "mohammadi5" , 341234);
    //     Student p3 = new Student("ali3" , "mohammadi4" , 341234);
    //     List<Student> Student = new List<Student>();
    //     Student.Add(p1);
    //     Student.Add(p2);
    //     Student.Add(p3);

    //     Student.Sort();
        

    // }

    static void Main1(string[] args)
    {
        IShape[] shape = new IShape[](
            new Rectangle(2,3),
            new Circle(8),
            new Rectangle(7,5)
        );
        double Area_sum = 0;
        double P_sum = 0;
        for(int i = 0; i < shape.Length ; i++)
        {
            P_sum += shape[i].Perimeter();
            Area_sum += shape[i].Area();
        }
        Console.WriteLine($"{Area_sum} , {P_sum}");
    }
}

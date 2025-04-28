namespace S9con.Test;

[TestClass]
public sealed class StudentTest
{
    [TestMethod]
    public void ParseTest()
    {
        Student s = new Student(  
            name : "Hadi Mousavi" ,
            stdid : 403522 ,
            natid : 02505269 ,
            credits : 33 ,
            active : true);

        string str = "Hadi Mousavi , 403522 , 2505269 , 33 , True";
        Student sc = Student.Parse(str);
        Assert.AreEqual(s , sc);
        // System.Console.WriteLine(sc.Equals(1243));
    }
}

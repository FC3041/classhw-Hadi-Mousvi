using System.Numerics;

namespace S14test;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void TestMethod1()
    {
        MyVector v1 = new MyVector(3,4);
        MyVector v2 = new MyVector(1,2);

        MyVector vsum = v1.SumOfVectors(v2);
        MyVector Expected = new MyVector(4,6);

        
    }
}

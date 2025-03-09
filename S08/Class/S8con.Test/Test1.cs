namespace S8con.Test;

using Microsoft.VisualStudio.TestPlatform.TestHost;
using S8con;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void TestMethod1()
    {
        int i = 1;
        Assert.AreEqual(i+1 , 2);
    }

    public void TestMethod2()
    {
        int result = S8con.Program.add(1,2);
        Assert.AreEqual(result , 3);    
    }

}

using System.Diagnostics;


public class MyTimer : IDisposable
{
    public string name;
    private Stopwatch sw;
    public MyTimer(string nm)
    {
        name = nm;
        sw.Start();
    } 
    public void Dispose()
    {
        sw.Stop();
        Console.WriteLine($"{this.name} , {this.sw}");
    }
    public void printSw()
    {
        Console.WriteLine();
    }
}
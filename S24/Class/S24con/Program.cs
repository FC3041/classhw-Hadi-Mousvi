using System.Diagnostics;

namespace S24con;

class Program
{

    static async Task<double> CPUintensiveAsync()
    {
        int n = 15;
        double d = n;
        for (int i = 0; i < 100_000; i++)
        {
            d = d * Math.Sqrt(n) % n;
        }
        return d;
    }
    static void Main(string[] args)
    {
        CPUintensiveAsync().Start();
        Stopwatch sw = new Stopwatch();
        double sum = 0;
        sw.Start();
        for (int i = 0; i < 20; i++)
        {
            sum += CPUintensive();
        }
        sw.Stop();
        System.Console.WriteLine(sum);
        System.Console.WriteLine(sw.Elapsed.ToString());

    }
    static void Main33(string[] args)
    {
        Stopwatch sw = Stopwatch.StartNew();
        Task<double>[] tasks = new Task<double>[20];
        for (int i = 0; i < 20; i++)
        {
            // Task<double> t = new Task<double>(CPUintensive);
            tasks[i] = new Task<double>(CPUintensive);
            // tasks[i].RunSynchronously();
            tasks[i].Start();
        }
        Task.WaitAll(tasks);
        double sum = 0;
        for (int i = 0; i < 20; i++)
            sum += tasks[i].Result;
        sw.Stop();
        System.Console.WriteLine(sw.Elapsed.ToString());
        System.Console.WriteLine(sum);

        // t.Wait();
        // System.Console.WriteLine(t.Result);
    }









    const int COUNT = 1_000_000;
    static int counter = 1_000;

    static double CPUintensive()
    {
        int n = 15;
        double d = n;
        for (int i = 0; i < 100_000; i++)
        {
            d = d * Math.Sqrt(n) % n;
        }
        return d;
    }
    static void Main2(string[] args)
    {
        AutoResetEvent ase = new AutoResetEvent(false);
        int counter = 1_000;
        var s = Stopwatch.StartNew();
        for (int i = 0; i < 1_000; i++)
        {
            ThreadPool.QueueUserWorkItem(obj =>
            {
                // Console.Write("worker thread -" + Thread.CurrentThread.ManagedThreadId + ",");
                CPUintensive();
                Interlocked.Increment(ref counter);
                if (counter == 0)
                    ase.Set();
            });
        }
        ase.WaitOne();
        s.Stop();
        Console.WriteLine(s.Elapsed.ToString());
    }
    static void Main1(string[] args)
    {
        AutoResetEvent ase = new AutoResetEvent(false);
        int counter = 1_000;
        var s = Stopwatch.StartNew();
        for (int i = 0; i < 1_000; i++)
        {
            new Thread(() =>
            {
                Thread.Sleep(1);
                Interlocked.Decrement(ref counter);
                if (counter == 0)
                    ase.Set();
            }).Start();
        }
        ase.WaitOne();
        s.Stop();
        System.Console.WriteLine(s.Elapsed.ToString());
        System.Console.WriteLine(counter);
    }
}

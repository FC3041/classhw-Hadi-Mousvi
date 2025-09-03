using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Reflection.Emit;
using System.Threading;
using System.Threading.Tasks;

namespace E3;


public class Animal
{
    public virtual string MakeSound() => "Some generic animal sound";
}

public class Dog : Animal
{
    public override string MakeSound() => "Woof";
}


public class MyPointType1
{
    public int X;
    public int Y;
}

public struct MyPointType2
{
    public int X;
    public int Y;
}

public class Product : IComparable
{
    public string Name;
    public int Price;

    public int CompareTo(object? obj)
    {
        Product P = (Product)obj;
        if (P != null)
            return this.Price.CompareTo(P.Price);
        throw new NotImplementedException();
    }
}

public class Comparer<T>
    where T : IComparable
{
    public T item1;
    public T item2;
    public Comparer(T i1, T i2)
    {
        this.item1 = i1;
        this.item2 = i2;
    }

    public T GetLarger()
    {
        if (item1.CompareTo(item2) > 0)
            return item1;
        else
            return item2;
    }
}


public class ResourceManager : IDisposable
{
    public bool IsDisposed;
    public ResourceManager()
    {
        this.IsDisposed = false;
    }

    public void Dispose()
    {
        this.IsDisposed = true;
    }
}

public class LinqProblems
{
    public static List<int> FilterAndDouble(IEnumerable<int> intList)
    {
        return intList.Where(n => (n > 5) && (n % 2 == 0)).Select(n => n * 2).ToList();
    }

    // public static Dictionary<string, int> GetTotalAmountByCategory(List<Sale> sales)
    // {
    //     var asdf = new Dictionary<string, int> { { "dfsadf", 123 } };
    //     return sales.Join(sales, s1 => s1.Category, s2 => s2.Category, (s1, s2) => (s1.Category, s1.Amount + s2.Amount))
    //         .ToDictionary<string,int>(s => {s.item1 , s.item2});
    // }
}

public class Sale
{
    public string Category;
    public int Amount;
}

public class Money : IEquatable<Money>
{
    public string Mn;
    public int Amount;
    public Money(int amount, string mn)
    {
        this.Mn = mn;
        this.Amount = amount;
    }

    public static Money operator +(Money m1, Money m2) => new Money(m1.Amount + m2.Amount, m1.Mn);
    public static bool operator ==(Money m1, Money m2) => m1.Amount == m2.Amount;
    public static bool operator !=(Money m1, Money m2) => m1.Amount != m2.Amount;
    public bool Equals(Money? m2)
    {
        return (m2.Mn == this.Mn) && (m2.Amount == this.Amount);
    }
}

public class DelegateProblems
{
    public delegate string StringOperation(string a);
    public static string ToUpper(string s)
    {
        return s.ToUpper();
    }
    public static string ToLower(string s)
    {
        return s.ToLower();
    }

    public static string ProcessString(string s, StringOperation fn)
    {
        return fn(s);
    }

}


public class LambdaProblems
{
    public static Func<string, int> GetStringLengthCalculator()
    {
        return (str) => str.Count();
    }
}

// public class Publisher
// {
//     public event RaiseEvent(string)
//     {
//         using()
//     }
// }

// public class Subscriber
// {

// }

public class Cl
{
    public int a=0;
}

public class Closures
{
    public int a = 0;
    public static Func<int> CreateCounter()
    {
        var c = new Cl();
        return () => { c.a++; return c.a; };
    }
}

public class SafeCounter
{
    public object lockobj = "asdf";
    public int Count = 0;
    public void Increment()
    {
        lock (lockobj)
        {
            this.Count++;
        }
    }
}

public class DataService
{
    public async Task<string> FetchDataAsync(string str)
    {
        Task.Delay(100);
        return "Data for " + str;
    }
}

public interface IEntity 
{
    
}

public class Customer : IEntity
{
    public Guid Id;
    public Customer() { }

    public ConstructorInvoker Invoker()
    {
        throw new NotImplementedException();
    }
}

public class Order : IEntity
{
    public Guid Id;
    public Order() {}

    public ConstructorInvoker Invoker()
    {
        throw new NotImplementedException();
    }
}

public class Repository<T>
        where T : IEntity, new()
{
    public T item;
    public T CreateNew()
    {
        return new T();
    }
}
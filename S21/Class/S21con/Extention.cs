using System.Security.Cryptography.X509Certificates;

public static class Extention
{
    public static IEnumerable<T> MyTake<T>(this IEnumerable<T> source , int count)
    {
        List<T> values = new List<T>();
        foreach(var item in source)
        {
            if(values.Count() < count)
                values.Add(item);
            else 
                break;
        }
        return values;
    }
    public static IEnumerable<T> MyTake2<T>(this IEnumerable<T> source , int count)
    {
        foreach(var item in source)
        {
            if(count-- > 0)
                yield return item;
        }
    }
}
namespace SeedData.Helper;

public static class ListExtensions
{
    public static void Print<T>(this IEnumerable<T> list)
    {
        foreach (var item in list) Console.WriteLine(item.ToString());
    }
}
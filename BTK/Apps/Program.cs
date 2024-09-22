using System.Collections;

namespace Apps;

class Program
{
    static void Main(string[] args)
    {
        var p1 = new DataStructures.Array.Array<int>(1, 2, 3, 4);
        var p2 = new int[] { 8, 9, 10, 11 };
        var p3 = new List<int>() { 5, 15, 20, 25 };
        var p4 = new ArrayList() { 12, 14, 15 }; // The reason for the error description here is because the hint is not safe.

        var arr = new DataStructures
            .Array
            .Array<int>(p3);

        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }

    }


    /*
    static void Main(string[] args)
    {
        var arr = new DataStructures
            .Array
            .Array<int>();

        arr.Add(23);
        arr.Add(22);
        arr.Add(44);
        arr.Add(34);
        arr.Add(45);

        // arr.Remove();

        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("---");

        arr.Where(x => x % 2 == 0)
            .ToList()
            .ForEach(x => Console.WriteLine(x));

        Console.WriteLine($"{arr.Count} / {arr.Capacity}");
        // Console.ReadKey();
    }
    */

    /*
    static void Main(string[] args)
    {
        // array - Dez avantajı sabit boyuttatır

        char[] arrChar = new char[3];
        var arrInt = Array.CreateInstance(typeof(int), 5);
        arrInt.SetValue(10, 0); // arrInt[0]=10
        arrInt.GetValue(0);     // 10
        Console.WriteLine(arrChar.Length);

        // arratList - type-safe yapısnı kaybediyoruz

        // 10 -> boxing -> object
        // b -> boxing -> object
        // object -> unboxing - int

        // Burada tip güvenliğini kaybettiğimizden dolayı nesneler üzerinden çalışır ve bundan ötürü performansda kayıplar yaşıyoruz
        var arrObj = new ArrayList();
        arrObj.Add(10);
        arrObj.Add('b');
        Console.WriteLine(arrObj.Count);

        // List<T>
        // Burada her ikisninde özelliğini alır. Tip güvenliğini sağlar ve dynamic olarak veri eklenebilir.
        var arrInt1 = new List<int>();
        arrInt1.Add(10);
        arrInt1.Add((int)'b');
        arrInt1.AddRange(new int[] { 1, 2, 3 });
        Console.WriteLine(arrInt1.Count);

                               Collections
        Collections nedir ?

        - Bir grup nesnenin organize şekilde yönetildiği yapılar Collections olarak ifade edilebilir.
        - Bu yapılar ilgili veri yapısına ekleme yapma, araya ekleme yapma, arama, sıralama ya da özel bir takım fonksiyonlar içerir.
        - Collections ifadeleri generic ya da non-generic(object-boxing-unboxing) olarka tanımlanabilirler.

        System.Collections
            - ArrayList, Hashtable, Queue, Stack

        System.Collections.Generic (key,value)
            - Dictionary<TKey, TValue>, List<T>, Queue<T>
            - SortedList<TKey, TValue>, Stack<T>
            - SortedSet<TKey, Tvalue>, HashSet<TKey, TValue>

    } 
    */

}
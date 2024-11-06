
public class SinglyLinkedListNode<T>
{
    public SinglyLinkedListNode<T> Next { get; set; }
    public T Value { get; set; }

    public SinglyLinkedListNode(T value)
    {
        Value = value;
    }

    public override string ToString() => $"{Value}";

}


public class Program
{
    public static void Main()
    {
        var rnd = new Random();
        var initial = Enumerable.Range(1, 5).OrderBy(x => rnd.Next()).ToList();
        var list = new SinglyLinkedList<int>(initial);

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        list.Remove(2);


        Console.WriteLine();
        foreach (var item in list)
        {
            Console.WriteLine(item);
            Console.ReadKey();
        }
    }
}

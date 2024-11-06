namespace DataStructures.Stack;

public class ArrayStack<T> : IStack<T>
{
    public int Count { get; private set; }
    private readonly List<T> list = [];

    public T Peek()
    {
        if (Count == 0)
            throw new Exception("Empty Stack!");

        return list[list.Count - 1];
    }

    public T Pop()
    {
        if (Count == 0)
            throw new Exception("Empty Stack!");

        var temp = list[list.Count - 1];
        list.RemoveAt(list.Count - 1);
        Count--;
        return temp;
    }

    public void Push(T value)
    {
        ArgumentNullException.ThrowIfNull(value);
        list.Add(value);
        Count++;
    }
}

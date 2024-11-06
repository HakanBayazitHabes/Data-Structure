namespace DataStructures.Stack;

public class Stack<T>
{
    private readonly IStack<T> stack;
    public int Count => stack.Count;
    public Stack(StackType type = StackType.Array)
    {
        if (type == StackType.Array)
        {
            stack = new ArrayStack<T>();
        }
        else
        {
            stack = new LinkedListStack<T>();
        }
    }

    public T Pop()
    {
        return stack.Pop();
    }

    public T Peek()
    {
        return stack.Peek();
    }

    public void Push(T value)
    {
        stack.Push(value);
    }

}
public interface IStack<T>
{
    int Count { get; }
    void Push(T value);
    T Peek();
    T Pop();

}
public enum StackType
{
    Array = 0,      // List<T>
    Linkedlist = 1  // SinglyLinkedlist<T>
}

public class Program()
{
    public static void Main()
    {
        var charset = new char[] { 'a', 'b', 'c', 'd', 'e' };
        var stack1 = new Stack<char>();
        var stack2 = new Stack<char>(StackType.Linkedlist);

        foreach (var item in charset)
        {
            Console.WriteLine(item);
            stack1.Push(item);
            stack2.Push(item);
        }

        Console.WriteLine("\nPeek");
        Console.WriteLine($"Stack1: {stack1.Peek()}");
        Console.WriteLine($"Stack1: {stack2.Peek()}");

        Console.WriteLine("\nCount");
        Console.WriteLine($"Stack1: {stack1.Count}");
        Console.WriteLine($"Stack1: {stack2.Count}");

        Console.WriteLine("\nPop");
        Console.WriteLine($"Stack1: {stack1.Pop()} has been removed");
        Console.WriteLine($"Stack1: {stack2.Pop()} has been removed");

    }
}
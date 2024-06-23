
public class MyStack
{

    Queue<int> elements;

    public MyStack()
    {
        elements = [];
    }

    public void Push(int x)
    {
        elements.Enqueue(x);
    }

    public int Pop()
    {
        int dequeueElement = 0;
        int elementCount = elements.Count;
        for (int i = 0; i < elementCount; i++)
        {
            dequeueElement = elements.Dequeue();
            if (i == elementCount - 1) break;
            elements.Enqueue(dequeueElement);
        }
        return dequeueElement;
    }

    // int elementCount = elements.Count;
    //     for (int i = 0; i < elementCount - 1; i++)
    //     {
    //         elements.Enqueue(elements.Dequeue());
    //     }
    //     return elements.Dequeue();


    public int Top()
    {
        return elements.LastOrDefault();
    }

    public bool Empty()
    {
        return elements.Count == 0;
    }

    public int Size()
    {
        return elements.Count;
    }
}

public class Program()
{
    public static void Main()
    {
        MyStack obj = new();

        obj.Push(1);
        obj.Push(2);

        Console.WriteLine(obj.Top());
        Console.WriteLine(obj.Pop());
        Console.WriteLine(obj.Pop());
        Console.WriteLine(obj.Empty());

    }
}









public class MyStack
{
    Queue<int> elements;
    int lastElement;

    public MyStack()
    {
        elements = [];
    }

    public void Push(int x)
    {
        elements.Enqueue(x);
        lastElement = x;
    }

    public int Pop()
    {
        int elementCount = elements.Count;
        for (int i = 0; i < elementCount - 1; i++)
        {
            int temp = elements.Dequeue();
            if (i == elementCount - 2) lastElement = temp;
            elements.Enqueue(temp);
        }
        return elements.Dequeue();
        // int dequeueElement = 0;
        // int elementCount = elements.Count;
        // for (int i = 0; i < elementCount; i++)
        // {
        //     dequeueElement = elements.Dequeue();
        //     if (i == elementCount - 1) break;
        //     elements.Enqueue(dequeueElement);
        // }
        // return dequeueElement;
    }

    // int elementCount = elements.Count;
    //     for (int i = 0; i < elementCount - 1; i++)
    //     {
    //         elements.Enqueue(elements.Dequeue());
    //     }
    //     return elements.Dequeue();


    public int Top()
    {
        return lastElement;
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








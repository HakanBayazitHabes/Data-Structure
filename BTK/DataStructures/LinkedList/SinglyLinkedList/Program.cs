using System.Collections;

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

public class SinglyLinkedList<T> : IEnumerable<T>
{
    public SinglyLinkedList(IEnumerable<T> collection)
    {
        foreach (var item in collection)
        {
            this.AddFirst(item);
        }
    }

    public SinglyLinkedListNode<T> Head { get; set; }

    public void AddFirst(T value)
    {
        var newNode = new SinglyLinkedListNode<T>(value);
        newNode.Next = Head;
        Head = newNode;
    }

    public void AddLast(T value)
    {
        var newNode = new SinglyLinkedListNode<T>(value);

        if (Head == null)
        {
            Head = newNode;
            return;
        }

        var currentNode = Head;
        while (currentNode.Next != null)
        {
            currentNode = currentNode.Next;
        }
        currentNode.Next = newNode;
    }

    public void AddAfter(SinglyLinkedListNode<T> node, T value)
    {
        ArgumentNullException.ThrowIfNull(node);

        if (Head == null)
        {
            AddFirst(value);
            return;
        }

        var newNode = new SinglyLinkedListNode<T>(value);
        var current = Head;
        while (current != null)
        {
            if (current.Equals(node))
            {
                newNode.Next = current.Next;
                current.Next = newNode;
                return;
            }
            current = current.Next;
        }

        throw new ArgumentException("The reference node is not in this list.");
    }

    public void AddAfter(SinglyLinkedListNode<T> refNode, SinglyLinkedListNode<T> newNode)
    {
        ArgumentNullException.ThrowIfNull(refNode);

        if (Head == null)
        {
            AddFirst(newNode.Value);
            return;
        }

        var current = Head;
        while (current != null)
        {
            if (current.Equals(refNode))
            {
                newNode.Next = refNode.Next;
                refNode.Next = newNode;
                return;
            }
            current = current.Next;
        }

        throw new ArgumentException("The reference node is not in this list.");
    }

    public void AddBefore(SinglyLinkedListNode<T> node, T value)
    {
        ArgumentNullException.ThrowIfNull(node);

        if (Head == null)
        {
            AddFirst(value);
            return;
        }

        var previousNode = Head;
        var currentNode = Head;
        var newNode = new SinglyLinkedListNode<T>(value);
        while (currentNode != null)
        {

            if (currentNode.Equals(node))
            {
                newNode.Next = previousNode.Next;
                previousNode.Next = newNode;
                return;
            }
            previousNode = currentNode;
            currentNode = currentNode.Next;
        }

        throw new ArgumentException("The reference node is not in this list.");

    }

    public void AddBefore(SinglyLinkedListNode<T> refNode, SinglyLinkedListNode<T> newNode)
    {
        ArgumentNullException.ThrowIfNull(refNode);

        if (Head == null)
        {
            AddFirst(newNode.Value);
            return;
        }

        var previousNode = Head;
        var currentNode = Head;
        while (currentNode != null)
        {
            if (currentNode.Equals(refNode))
            {
                newNode.Next = previousNode.Next;
                previousNode.Next = newNode;
                return;
            }
            previousNode = currentNode;
            currentNode = currentNode.Next;
        }

        throw new ArgumentException("The reference node is not in this list.");
    }
    public void GetListOfNode()
    {
        var current = Head;
        while (current != null)
        {
            Console.Write(current.Value + " ");
            current = current.Next;
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        return new SinglyLinkedListEnumerator<T>(Head);
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public T RemoveFirst()
    {
        if (Head == null)
            throw new Exception("Underflow! Nothing to remove");

        var firstValue = Head.Value;
        Head = Head.Next;
        return firstValue;
    }

    public T RemoveLast()
    {
        var current = Head;
        SinglyLinkedListNode<T> prev = null;
        while (current.Next != null)
        {
            prev = current;
            current = current.Next;
        }
        var lastValue = prev.Next.Value;
        prev.Next = null;
        return lastValue;
    }

    public void Remove(T value)
    {
        if (Head == null)
            throw new Exception("Underflow! Nothing to remove");

        if (value == null)
            throw new ArgumentNullException();

        var current = Head;
        SinglyLinkedListNode<T> prev = null;
        do
        {
            if (current.Value.Equals(value))
            {
                if (current.Next == null)
                {
                    if (prev == null)
                    {
                        Head = null;
                        return;
                    }
                    else
                    {
                        prev.Next = null;
                        return;
                    }
                }
                else
                {
                    if (prev == null)
                    {
                        Head = Head.Next;
                        return;
                    }
                    else
                    {
                        prev.Next = current.Next;
                        return;
                    }
                }
            }

            prev = current;
            current = current.Next;
        } while (current != null);

        throw new ArgumentException("The value could not be found in the list");
    }

}

class Program
{
    static void Main()
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
        }

        Console.ReadKey();
    }
}
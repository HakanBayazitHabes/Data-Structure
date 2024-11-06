using System.Collections;
using DataStructures.LinkedList.DoublyLinkedList;

namespace DoublyLinkedList;

public class DoublyLinkedList<T> : IEnumerable
{
    public DoublyLinkedListNode<T> Head { get; set; }
    public DoublyLinkedListNode<T> Tail { get; set; }
    bool IsHeadNull => Head == null;
    bool IsTailNull => Tail == null;


    public DoublyLinkedList()
    {

    }
    public DoublyLinkedList(IEnumerable<T> collection)
    {
        foreach (var item in collection)
        {
            AddLast(item);
        }
    }
    public void AddFirst(T value)
    {
        var newNode = new DoublyLinkedListNode<T>(value);
        if (Head != null)
        {
            Head.Prev = newNode;
        }

        newNode.Next = Head;
        newNode.Prev = null;
        Head = newNode;

        if (Tail == null)
        {
            Tail = Head;
        }
    }

    public void AddLast(T value)
    {
        if (Tail == null)
        {
            AddFirst(value);
            return;
        }

        var newNode = new DoublyLinkedListNode<T>(value);
        Tail.Next = newNode;
        newNode.Next = null;
        newNode.Prev = Tail;
        Tail = newNode;

        return;

    }

    public void AddAfter(DoublyLinkedListNode<T> refNode, DoublyLinkedListNode<T> newNode)
    {
        ArgumentNullException.ThrowIfNull(refNode);

        if (refNode == Head && refNode == Tail)
        {
            refNode.Next = newNode;
            refNode.Prev = null;

            newNode.Next = null;
            newNode.Prev = refNode;

            Head = refNode;
            Tail = newNode;

            return;
        }
        if (refNode != Tail)
        {
            newNode.Prev = refNode;
            newNode.Next = refNode.Next;

            refNode.Next.Prev = newNode;
            refNode.Next = newNode;
        }
        else
        {
            newNode.Prev = refNode;
            newNode.Next = null;

            refNode.Next = newNode;
            Tail = newNode;
        }
    }

    public void AddBefore(DoublyLinkedListNode<T> refNode, DoublyLinkedListNode<T> newNode)
    {
        ArgumentNullException.ThrowIfNull(refNode);

        if (refNode == Head && refNode == Tail)
        {
            refNode.Next = null;
            refNode.Prev = newNode;

            newNode.Next = refNode;
            newNode.Prev = null;

            Head = newNode;
            Tail = refNode;
            return;
        }
        if (refNode != Tail)
        {
            newNode.Next = refNode;
            newNode.Prev = refNode.Prev;

            refNode.Prev.Next = newNode;
            refNode.Prev = newNode;
        }
        else
        {
            newNode.Next = refNode;
            newNode.Prev = refNode.Prev;

            refNode.Prev = newNode;
            refNode.Next = null;

            Tail = refNode;
        }
    }

    public List<DoublyLinkedListNode<T>> GetList()
    {
        var list = new List<DoublyLinkedListNode<T>>();
        var current = Head;
        while (current != null)
        {
            list.Add(current);
            current = current.Next;
        }
        return list;
    }

    public IEnumerator GetEnumerator()
    {
        return GetList().GetEnumerator();
    }

    public T RemoveFirst()
    {
        ArgumentNullException.ThrowIfNull(IsHeadNull);

        var temp = Head.Value;
        if (Head == Tail)
        {
            Head = null;
            Tail = null;
        }
        else
        {
            Head = Head.Next;
            Head.Prev = null;
        }

        return temp;
    }

    public T RemoveLast()
    {
        ArgumentNullException.ThrowIfNull(IsTailNull);

        var temp = Tail.Value;
        if (Head == Tail)
        {
            Head = null;
            Tail = null;
        }
        else
        {
            Tail.Prev.Next = null;
            Tail = Tail.Prev;
        }
        return temp;
    }

    public void Remove(T value)
    {
        ArgumentNullException.ThrowIfNull(IsHeadNull);

        if (Head == Tail)
        {
            if (Head.Value.Equals(value))
            {
                RemoveFirst();
            }
            return;
        }

        var current = Head;

        while (current != null)
        {
            if (current.Value.Equals(value))
            {
                if (current.Prev == null)
                {
                    current.Next.Prev = null;
                    Head = current.Next;
                }
                else if (current.Next == null)
                {
                    current.Prev.Next = null;
                    Tail = current.Prev;
                }
                else
                {
                    current.Prev.Next = current.Next;
                    current.Next.Prev = current.Prev;
                }
                break;
            }
            current = current.Next;
        }
    }
}

public class Program
{
    public static void Main()
    {
        var list = new DoublyLinkedList<int>([22, 33, 34, 44, 55]);

        list.Remove(55);
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

    }

    private static void DoublyLinkedListApp02()
    {
        var list = new DoublyLinkedList<char>(['a', 'b', 'c']);

        list.RemoveFirst();
        list.RemoveLast();

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }

    private static void DoublyLinkedListApp01()
    {
        var doublyLinkedList = new DoublyLinkedList<int>();

        doublyLinkedList.AddFirst(55);
        doublyLinkedList.AddFirst(44);
        doublyLinkedList.AddFirst(33);
        doublyLinkedList.AddFirst(23);

        doublyLinkedList.AddAfter(doublyLinkedList.Head.Next,
            new DoublyLinkedListNode<int>(34));
        // 23 33 34 44 55

        doublyLinkedList.AddBefore(doublyLinkedList.Head.Next,
        new DoublyLinkedListNode<int>(32));
        // 23 32 33 34 44 55

        foreach (var item in doublyLinkedList)
        {
            Console.WriteLine(item);
        }
    }
}
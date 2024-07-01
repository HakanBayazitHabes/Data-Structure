public class ListNode(int val = 0, ListNode next = null)
{
    public int val = val;
    public ListNode next = next;
}

public class LinkedList
{
    private ListNode head;

    public LinkedList()
    {
        this.head = null;
    }

    public void AddNode(int data)
    {
        ListNode newNode = new ListNode(data);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            ListNode current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = newNode;
        }
    }

    public ListNode RemoveNthFromEnd(int n)
    {
        ListNode dummy = new ListNode(0);
        dummy.next = head;
        ListNode leftPointer = dummy;
        ListNode rightPointer = dummy;

        // rightPointer'ı n+1 adım ilerlet.
        for (int i = 0; i <= n; i++)
        {
            rightPointer = rightPointer.next;
        }

        // rightPointer sona ulaşana kadar her iki pointer'ı da ilerlet.
        while (rightPointer != null)
        {
            leftPointer = leftPointer.next;
            rightPointer = rightPointer.next;
        }

        // Silme işlemi.
        leftPointer.next = leftPointer.next.next;

        // Dummy'nin next'i, düzenlenmiş listenin başıdır.
        return dummy.next;
    }

    public void PrintList()
    {
        ListNode current = head;
        while (current != null)
        {
            Console.Write(current.val + " -> ");
            current = current.next;
        }
        Console.WriteLine("null");
    }

}



public class Program
{
    public static void Main()
    {
        LinkedList linkedList = new();

        linkedList.AddNode(1);
        // linkedList.AddNode(2);
        // linkedList.AddNode(3);
        // linkedList.AddNode(4);
        // linkedList.AddNode(5);

        linkedList.RemoveNthFromEnd(1);

        linkedList.PrintList();
    }
}





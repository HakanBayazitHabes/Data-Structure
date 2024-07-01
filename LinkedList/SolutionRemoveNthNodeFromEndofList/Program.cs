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
        ListNode leftPointer = head;
        ListNode rightPointer = head;

        while (n > 0 && rightPointer != null)
        {
            rightPointer = rightPointer.next;
            n -= 1;
        }

        while (rightPointer != null && rightPointer.next != null)
        {
            leftPointer = leftPointer.next;
            rightPointer = rightPointer.next;
        }

        if (leftPointer == head && rightPointer == null)
        {
            return head.next;
        }

        leftPointer.next = leftPointer.next.next;

        return head;
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





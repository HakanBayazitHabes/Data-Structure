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
        if (head == null)
        {
            Console.WriteLine("List is Empty");
        }

        ListNode current = head;
        List<ListNode> previousList = [];
        ListNode previous = null;

        while (current != null)
        {
            previousList.Add(current);
            current = current.next;

            if (current == null)
            {
                ListNode lastNthNode = previousList.TakeLast(n).First();
                ListNode lastNPlus1thNode = previousList.TakeLast(n + 1).First();
                if (lastNthNode == lastNPlus1thNode)
                {
                    head = head.next;
                    break;
                }
                current = lastNthNode;
                previous = lastNPlus1thNode;
                previous.next = current.next;

                break;
            }
        }

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





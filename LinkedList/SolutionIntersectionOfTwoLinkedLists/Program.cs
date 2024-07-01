public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}


public class LinkedList
{
    private ListNode headA;
    private ListNode headB;

    public LinkedList()
    {
        this.headA = null;
        this.headB = null;
    }


    public void AddNodeA(int data)
    {
        ListNode newNodeA = new(data);

        if (headA == null)
        {
            headA = newNodeA;
        }
        else
        {
            ListNode current = headA;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = newNodeA;
        }
    }

    public void AddNodeB(int data)
    {
        ListNode newNodeB = new(data);

        if (headB == null)
        {
            headB = newNodeB;
        }
        else
        {
            ListNode current = headB;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = newNodeB;
        }
    }

    public ListNode GetIntersectionNode()
    {
        ListNode firstPointer = headA;
        ListNode secondPointer = headB;

        while (firstPointer != secondPointer)
        {
            firstPointer = firstPointer == null ? headB : firstPointer.next;
            secondPointer = secondPointer == null ? headA : secondPointer.next;
        }

        return firstPointer;
    }
}


public class Program
{
    public static void Main()
    {
        LinkedList linkedList = new();

        linkedList.AddNodeA(4); linkedList.AddNodeA(1); linkedList.AddNodeA(8); linkedList.AddNodeA(4); linkedList.AddNodeA(5);

        linkedList.AddNodeB(5); linkedList.AddNodeB(6); linkedList.AddNodeB(1); linkedList.AddNodeB(8); linkedList.AddNodeB(4); linkedList.AddNodeB(5);

        Console.WriteLine(linkedList.GetIntersectionNode());

    }
}







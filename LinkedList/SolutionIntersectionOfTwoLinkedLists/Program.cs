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

    private int CountLinkedList(ListNode node)
    {
        int counter = 0;
        while (node != null)
        {
            counter++;
            node = node.next;
        }
        return counter;
    }

    public ListNode GetIntersectionNode()
    {
        ListNode longerList;
        ListNode shorterList;

        int headALenght = CountLinkedList(headA);
        int headBLenght = CountLinkedList(headB);

        int diff = Math.Abs(headALenght - headBLenght);

        if (headALenght > headBLenght)
        {
            longerList = headA; shorterList = headB;
        }
        else
        {
            longerList = headB; shorterList = headA;
        }

        for (int i = 0; i < diff; i++)
        {
            longerList = longerList.next;
        }

        while (shorterList != null && longerList != null)
        {
            if (shorterList == longerList)
                return longerList;
            shorterList = shorterList.next;
            longerList = longerList.next;
        }

        return null;
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







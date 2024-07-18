public class Node
{
    public int value;
    public Node left = null;
    public Node right = null;

    public Node(int value)
    {
        this.value = value;
    }
}

class BinarySearchTree
{
    public Node root = null;

    public bool Insert(int value)
    {
        Node newNode = new Node(value);

        if (root is null)
        {
            root = newNode;
            return true;
        }

        Node tempNode = root;

        while (true)
        {
            if (newNode.value == tempNode.value)
            {
                return false;
            }
            if (newNode.value < tempNode.value)
            {
                if (tempNode.left is null)
                {
                    tempNode.left = newNode;
                    return true;
                }
                tempNode = tempNode.left;
            }

            else
            {
                if (tempNode.right is null)
                {
                    tempNode.right = newNode;
                    return true;
                }
                tempNode = tempNode.right;
            }
        }
    }

    public bool Contains(int value)
    {
        Node tempNode = root;

        while (tempNode != null)
        {
            if (value < tempNode.value)
            {
                tempNode = tempNode.left;
            }
            else if (value > tempNode.value)
            {
                tempNode = tempNode.right;
            }
            else
            {
                return true;
            }
        }

        return false;
    }

    public Node MinOfNode(Node currentNode)
    {
        while (currentNode.left != null)
        {
            currentNode = currentNode.left;
        }
        return currentNode;
    }

    public Node MaxOfNode(Node currentNode)
    {
        while (currentNode.right != null)
        {
            currentNode = currentNode.right;
        }
        return currentNode;
    }
}


class Program
{
    public static void Main()
    {
        BinarySearchTree binarySearchTree = new();

        Console.WriteLine(binarySearchTree.Insert(10));
        Console.WriteLine(binarySearchTree.Insert(8));
        Console.WriteLine(binarySearchTree.Insert(20));
        Console.WriteLine(binarySearchTree.Insert(25));
        Console.WriteLine(binarySearchTree.Insert(16));
        Console.WriteLine(binarySearchTree.Contains(10));
        Console.WriteLine(binarySearchTree.MaxOfNode(binarySearchTree.root).value);


    }
}




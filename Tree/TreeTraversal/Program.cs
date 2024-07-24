using System.Collections;
using System.Security.Cryptography.X509Certificates;

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
        Node newNode = new(value);


        if (root is null)
        {
            root = newNode;
            return true;
        }

        Node tempNode = root;


        while (true)
        {
            if (newNode.value == tempNode.value)
                return false;

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

    public List<int> BFS()
    {
        Node currentNode = root;
        Queue myQueue = [];
        List<int> values = [];
        myQueue.Enqueue(currentNode);

        while (myQueue.Count > 0)
        {
            currentNode = (Node)myQueue.Dequeue();
            values.Add(currentNode.value);
            if (currentNode.left is not null)
            {
                myQueue.Enqueue(currentNode.left);
            }
            if (currentNode.right is not null)
            {
                myQueue.Enqueue(currentNode.right);
            }
        }
        return values;
    }

    public List<int> DFSPreOrder()
    {
        List<int> values = [];

        void Traverse(Node currnetNode)
        {
            if (currnetNode == null) return;

            values.Add(currnetNode.value);
            if (currnetNode.left is not null)
                Traverse(currnetNode.left);

            if (currnetNode.right is not null)
                Traverse(currnetNode.right);
        }
        Traverse(root);
        return values;
    }
}


class Program
{
    public static void Main()
    {
        BinarySearchTree binarySearchTree = new();

        Console.WriteLine(binarySearchTree.Insert(38));
        Console.WriteLine(binarySearchTree.Insert(19));
        Console.WriteLine(binarySearchTree.Insert(69));
        Console.WriteLine(binarySearchTree.Insert(12));
        Console.WriteLine(binarySearchTree.Insert(24));
        Console.WriteLine(binarySearchTree.Insert(59));
        Console.WriteLine(binarySearchTree.Insert(95));

        Console.WriteLine(string.Join(", ", binarySearchTree.BFS()));
        Console.WriteLine(string.Join(", ", binarySearchTree.DFSPreOrder()));

    }
}










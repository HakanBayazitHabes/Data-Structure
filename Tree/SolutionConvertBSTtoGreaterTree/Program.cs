public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}


public class Solution
{
    public TreeNode ConvertBST(TreeNode root)
    {
        int total = 0;
        Convert(root, ref total);
        return root;
    }

    private void Convert(TreeNode node, ref int total)
    {
        if (node == null) return;

        Convert(node.right, ref total);

        total += node.val;
        node.val = total;

        Convert(node.left, ref total);
    }
}

class Program
{
    public static void Main()
{
    Solution solution = new Solution();

    TreeNode root = new(4);
    root.left = new(1);
    root.right = new(6);
    root.left.left = new(0);
    root.left.right = new(2);
    root.left.right.right = new(3);
    root.right.left = new(5);
    root.right.right = new(7);
    root.right.right.right = new(8);

    TreeNode newRoot = solution.ConvertBST(root);

    PrintTree(newRoot);
}

    public static void PrintTree(TreeNode node)
    {
        if (node == null) return;

        PrintTree(node.left);
        Console.Write(node.val+" ");
        PrintTree(node.right);
    }
}










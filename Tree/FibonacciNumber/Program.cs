public class Solution
{
    public static int Fib(int n)
    {
        if (n == 1 || n == 0)
            return n;

        return Fib(n - 1) + Fib(n - 2);
    }
}

public class Solution2
{
    public static int IterativeFibonacci(int n)
    {
        int x = 0, y = 1;

        for (int i = 0; i < n; i++)
        {
            (x, y) = (y, x + y);
        }
        return x;
    }
}

class Program
{
    public static void Main()
    {
        Console.WriteLine(Solution.Fib(3));
        Console.WriteLine(Solution2.IterativeFibonacci(3));
    }
}






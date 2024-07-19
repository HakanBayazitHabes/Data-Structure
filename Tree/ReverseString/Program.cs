

public class Solution
{
    public char[] ReverseString(char[] s)
    {
        int length = s.Length;

        for (int i = 0; i < length / 2; i++)
        {
            // tupple
            (s[length - 1 - i], s[i]) = (s[i], s[length - 1 - i]);
            // char temp = s[i];
            // s[i] = s[length - 1 - i];
            // s[length - 1 - i] = temp;            
        }
        return s;
    }
}

public class Program
{
    public static void Main()
    {
        char[] input = ['h', 'e', 'l', 'l', 'o'];

        Solution solution = new();

        Console.WriteLine(solution.ReverseString(input));

    }
}



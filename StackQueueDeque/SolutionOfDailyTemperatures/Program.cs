


class Solution
{
    private Stack<int> stack;
    int[] temperatures = [73,74,75,71,69,72,76,73];
    int n;
    int[] answer;

    // Output: [1,1,4,2,1,1,0,0]

    public Solution()
    {
        stack = [];
        n = temperatures.Length;
        answer = new int[n];
    }


    public int[] DailyTemperatures()
    {
        for (int i = n - 1; i >= 0; i--)
        {

            while (stack.Count > 0 && temperatures[i] >= temperatures[stack.Peek()])
            {
                stack.Pop();
            }
            if (stack.Count > 0)
            {
                answer[i] = stack.Peek() - i;
            }
            stack.Push(i);
        }

        return answer;
    }
}

class Program
{
    public static void Main()
    {
        Solution solution = new();

        foreach (var item in solution.DailyTemperatures())
        {
            Console.Write(item);
        }

    }
}



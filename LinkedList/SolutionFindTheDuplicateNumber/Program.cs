
// Floyd Solution

public class Solution
{
    public int FindDuplicate(int[] nums)
    {
        int slowPointer = 0;
        int fastPointer = 0;

        while (true)
        {
            slowPointer = nums[slowPointer];
            fastPointer = nums[nums[fastPointer]];
            Console.WriteLine(slowPointer);
            Console.WriteLine(fastPointer);
            if (slowPointer == fastPointer)
                break;
        }

        int secondSlowPointer = 0;

        while (true)
        {
            slowPointer = nums[slowPointer];
            secondSlowPointer = nums[secondSlowPointer];
            Console.WriteLine("Second while");
            Console.WriteLine(slowPointer);
            Console.WriteLine(secondSlowPointer);
            if (slowPointer == secondSlowPointer)
                return slowPointer;
        }

    }
}


public class Program
{
    public static void Main()
    {
        int[] nums = [1, 3, 4, 7, 2, 5, 6, 7];
        Solution solution = new();

        Console.WriteLine(solution.FindDuplicate(nums));
    }
}





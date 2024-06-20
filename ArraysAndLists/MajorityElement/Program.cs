/*
Boyer Moore Algoritması



Beklenilen 
Birinci Örnek için 
    Time Complexity : O(n)
    Space Complexity : O(n)

İkinci Örnek için
    Time Complexity : O(n)
    Space Complexity : O(1)

*/

int[] nums = [2, 3, 4, 1, 1, 1, 1, 5,6,6,6,6,6,6,6];

int MajorityElement()
{
    Dictionary<int, int> numbers = [];

    int result = 0;
    int maxNumber = 0;

    for (int num = 0; num < nums.Length; num++)
    {
        if (numbers.ContainsKey(nums[num]))
        {
            numbers[nums[num]] = 1 + numbers[nums[num]];
        }
        else
        {
            numbers[nums[num]] = 1;
        }

        if (numbers[nums[num]] > maxNumber)
        {
            result = nums[num];
        }

        maxNumber = Math.Max(maxNumber, numbers[nums[num]]);
    }
    return result;
}

Console.WriteLine(MajorityElement());




int BoyerMoore()
{
    int result = 0;
    int count = 0;

    foreach (var num in nums)
    {
        if (count == 0) result = num;
        if (num == result) count += 1;
        else count -= 1;
    }

    return result;
}

Console.WriteLine(BoyerMoore());




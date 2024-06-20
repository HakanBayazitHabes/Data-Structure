/*
Majority Element

Given an array nums of size n, return the majority element.

The majority element is the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array.

 

Example 1:

Input: nums = [3,2,3]
Output: 3
Example 2:

Input: nums = [2,2,1,1,1,2,2]
Output: 2
 

Constraints:

n == nums.length
1 <= n <= 5 * 104
-109 <= nums[i] <= 109
 

Follow-up: Could you solve the problem in linear time and in O(1) space?


Boyer Moore Algoritması

Beklenilen BigO:

Birinci Örnek için 
    Time Complexity : O(n)
    Space Complexity : O(n)

İkinci Örnek için
    Time Complexity : O(n)
    Space Complexity : O(1)

*/

int[] nums = [2, 3, 4, 1, 1, 1, 1, 5, 6, 6, 6, 6, 6, 6, 6];

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




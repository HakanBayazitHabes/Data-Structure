// Given an integer array 'nums', returns true if any value appears at least twice int he array, and return false if every elements is distinct 

/*
Example 1:

Input : nums = [1,2,3,1]
Output : true

Example 2:

Input : nums = [1,2,3,4]
output: false
*/


int[] myArray = [3,3];

bool Solution1()
{
    HashSet<int> mySet = [];

    for (int i = 0; i < myArray.Length; i++)
    {
        if (mySet.Contains(myArray[i])) return true;
        mySet.Add(myArray[i]);
    }
    return false;
}

Console.WriteLine(Solution1());


bool Solution2()
{
    return myArray.Length != new HashSet<int>(myArray).Count;
}

Console.WriteLine(Solution2());


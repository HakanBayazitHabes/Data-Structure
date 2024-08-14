from typing import List


class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        hashMap = {}
        for index, num in enumerate(nums):
            hashMap[num] = index
        for index, num in enumerate(nums):
            result = target - num
            if result in hashMap:
                return [hashMap[result], index]
        return []

# Input: wall = [[1,2,2,1],[3,1,2],[1,3,2],[2,4],[3,1,2],[1,3,1,1]]
# Output: 2

from typing import List


class Solution:
    def leastBricks(self, wall: List[List[int]]) -> int:
        myHashTable = {0: 0}

        for row in wall:
            gapIndex = 0
            for brick in row[:-1]:
                gapIndex += brick
                myHashTable[gapIndex] = 1 + myHashTable.get(gapIndex, 0)

        maxGapNumber = max(myHashTable.values())
        rowNum = len(wall)
        return rowNum - maxGapNumber

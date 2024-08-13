from typing import Optional


class TreeNode:
    def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right


class Solution:

    answer = -float("inf")

    def __init__(self) -> None:
        root = TreeNode(-10)
        root.left = TreeNode(9)
        root.right = TreeNode(20)
        root.right.left = TreeNode(15)
        root.right.right = TreeNode(7)
        print(self.maxPathSum(root))

    def maxPathSum(self, root: Optional[TreeNode]) -> int:
        self.dfs(root)
        return int(self.answer)

    def dfs(self, node):
        if node is None:
            return 0

        left = self.dfs(node.left)
        right = self.dfs(node.right)

        left = max(left, 0)  # type: ignore
        right = max(right, 0)  # type: ignore

        self.answer = max(self.answer, node.val + left + right)

        return node.val + max(left, right)


solution = Solution()

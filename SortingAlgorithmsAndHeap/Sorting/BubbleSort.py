class SortingAlgorithms:
    def bubbleSort(self, arr):
        for i in range(len(arr) - 1, 0, -1):
            for j in range(i):
                if arr[j] > arr[j + 1]:
                    arr[j], arr[j + 1] = arr[j + 1], arr[j]

        return arr
    
sorting = SortingAlgorithms()
print(sorting.bubbleSort([2,5,4,6,7,8,3,9]))

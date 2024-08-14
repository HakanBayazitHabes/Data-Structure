class SortingAlgorithms:
    def bubbleSort(self, arr):
        for i in range(len(arr) - 1, 0, -1):
            for j in range(i):
                if arr[j] > arr[j + 1]:
                    arr[j], arr[j + 1] = arr[j + 1], arr[j]

        return arr

    def selectionSort(self, arr):
        for i in range(len(arr) - 1):
            minIndex = i
            for j in range(i + 1, len(arr)):
                if arr[j] < arr[minIndex]:
                    minIndex = j
            if i != minIndex:
                arr[i], arr[minIndex] = arr[minIndex], arr[i]
        return arr

    def insertionSort(self, arr):
        for i in range(1, len(arr)):
            temp = arr[i]
            j = i - 1
            while temp < arr[j] and j > -1:
                arr[j + 1] = arr[j]
                arr[j] = temp
                j -= 1
        return arr

    def merge(self, arr1, arr2):
        firstPointer = 0
        secondPointer = 0
        mergedList = []

        while firstPointer < len(arr1) and secondPointer < len(arr2):
            if arr1[firstPointer] < arr2[secondPointer]:
                mergedList.append(arr1[firstPointer])
                firstPointer += 1
            else:
                mergedList.append(arr2[secondPointer])
                secondPointer += 1

        while firstPointer < len(arr1):
            mergedList.append(arr1[firstPointer])
            firstPointer += 1
        while secondPointer < len(arr2):
            mergedList.append(arr2[secondPointer])
            secondPointer += 1

        return mergedList

    def mergeSort(self, arr):
        if len(arr) == 1:
            return arr

        midPoint = int(len(arr) / 2)
        leftPart = arr[:midPoint]
        rightPart = arr[midPoint:]

        return self.merge(self.mergeSort(leftPart), self.mergeSort(rightPart))

    def pivot(self, arr, pivotIndex, endIndex):
        swapIndex = pivotIndex
        for i in range(pivotIndex + 1, endIndex + 1):
            if arr[i] < arr[pivotIndex]:
                swapIndex += 1
                arr[swapIndex], arr[i] = arr[i], arr[swapIndex]
        arr[pivotIndex], arr[swapIndex] = arr[swapIndex], arr[pivotIndex]
        return swapIndex

    def qucikSort(self, arr, leftPointer=0, rightPointer=None):
        if rightPointer == None:
            rightPointer = len(arr) - 1
        if leftPointer < rightPointer:
            swapIndex = self.pivot(arr, leftPointer, rightPointer)
            self.qucikSort(arr, leftPointer, swapIndex - 1)
            self.qucikSort(arr, swapIndex + 1, rightPointer)
        return arr


sorting = SortingAlgorithms()
print(sorting.bubbleSort([2, 5, 4, 6, 7, 8, 3, 9]))
print(sorting.selectionSort([2, 5, 4, 6, 7, 8, 3, 9]))
print(sorting.insertionSort([2, 5, 4, 6, 7, 8, 3, 9]))
print(sorting.mergeSort([2, 5, 4, 6, 7, 8, 3, 9]))
print(sorting.qucikSort([2, 5, 4, 6, 7, 8, 3, 9]))

class SearchingAlgorithms:
    def sequantialSearchUnordered(self, unorderedList, number):
        ix = 0
        found = False

        while ix < len(unorderedList) and not found:
            if unorderedList[ix] == number:
                found = True
            else:
                ix += 1
        return found

    def binarySearch(self, orderedList, number):
        firstPointer = 0
        lastPointer = len(orderedList) - 1

        found = False

        while firstPointer <= lastPointer and not found:
            midPoint = (firstPointer + lastPointer) // 2

            if orderedList[midPoint] == number:
                found = True
            else:
                if number < orderedList[midPoint]:
                    lastPointer = midPoint - 1
                else:
                    firstPointer = midPoint + 1
        return found


search = SearchingAlgorithms()
myList = [40, 2, 4, 12, 67, 3, 43, 12, 68, 90, 1]
print(search.sequantialSearchUnordered(myList, 2))

myList.sort()
print(search.binarySearch(myList, 68))

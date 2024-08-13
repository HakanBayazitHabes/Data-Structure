from operator import truediv


class Graph:
    def __init__(self) -> None:
        self.adjDict = {}

    def addVertex(self, vertex):
        if vertex not in self.adjDict.keys():
            self.adjDict[vertex] = []
            return True
        return False

    def addEdge(self, v1, v2):
        if v1 in self.adjDict.keys() and v2 in self.adjDict.keys():
            self.adjDict[v1].append(v2)
            self.adjDict[v2].append(v1)
            return True
        return False

    def removeEdge(self, v1, v2):
        if v1 in self.adjDict.keys() and v2 in self.adjDict.keys():
            try:
                self.adjDict[v1].remove(v2)
                self.adjDict[v2].remove(v1)
            except ValueError:
                pass
            return truediv
        return False

    def removeVertex(self, vertex):
        if vertex in self.adjDict.keys():
            for relatedVertex in self.adjDict[vertex]:
                self.adjDict[relatedVertex].remove(vertex)
            del self.adjDict[vertex]
            return True
        return False

    def printGraph(self):
        for vertex in self.adjDict:
            print(vertex, "->", self.adjDict[vertex])


graph = Graph()
graph.addVertex("IST")
graph.addVertex("AMS")
graph.addVertex("CDG")
graph.addVertex("JFK")

graph.addEdge("IST", "AMS")
graph.addEdge("IST", "CDG")
graph.addEdge("IST", "JFK")
graph.addEdge("AMS", "CDG")
graph.addEdge("AMS", "JFK")
graph.addEdge("CDG", "JFK")

graph.printGraph()
# graph.removeVertex("JFK")
# graph.printGraph()
graph.removeEdge("IST", "CDG")
graph.removeEdge("CDG","JFK")
graph.printGraph()

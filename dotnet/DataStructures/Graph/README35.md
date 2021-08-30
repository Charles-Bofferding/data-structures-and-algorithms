# Graphs
A graph is a collection of nodes that have a list of neighbors and a possible weight applied to an edge between those nodes.

## Challenge
Create a functional graph class containing vertex style of nodes

## Approach & Efficiency
For this data structure there is more of an effort to have properties attached to the graph that make some operations
much easier, like adding vertex to the list of nodes whenever we add them in to not do that computation when pulling that data out.

Efficiency is hard to say because there are a lot of different things happening here. I would say O(n) because each method is scalar,
not going through the entire array to much, except for printing out the graph, but that is a small portion of the functionality.

## API
AddNode: Adds a node to the graph and return that node.
AddEdge: Takes in two nodes already present in the graph and connects them with an edge and weight
GetNodes: Returns all of the nodes in the graph
GetNeighbors: Returns a collection of edges connected to the given node
Size: REturns an int of the number of nodes in the graph
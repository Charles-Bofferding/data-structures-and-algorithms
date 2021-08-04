# Tree Breadth First Processing
Implemented a method that takes in a tree and outputs a list that is all of the values stored in the nodes, by performing a top down search moving left to right in each row

## Challenge
Because the method needs to process all of the information sequentially, and return a list withoput any input recursion was not the correct choice
Since the first node loaded into the helper data structure would need to be processed in a FIFO style a Queue was the correct thing to use.

## Approach & Efficiency

[whiteboard](Code-Challenge-17.md)
The only tricky part about this is that I wanted to use the custom Queue, but because of the definitions of Enqueue and Dequeue only returning the node and not the value
I added EnqueueNode and DequeueNode methods that have the same functionality but move around nodes instead of the values in those nodes.

## Efficiency
Time Efficiency: Because the method needs to cycle through the entire tree it will scale requirements with the size of the tree, making the efficiency O(n)
Memory Efficiency: Because te mothod will have a recursive call through all the nodes it will scale proportionaly to the size of the input tree, making the efficiency O(n)

## API
BreadthFirst Method: Give in a binary tree of Node<int>s and it will output a list that is the values in each of the nodes, ordered by the first level node, then the second level nodes
left to right, then the next level nodes left to right, and so forth until all nodes are processed.

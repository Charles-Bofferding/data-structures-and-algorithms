# Tree GetMax
Implemented a binary tree and then an extension of that class, the binary search tree which orders the nodes added to it.

## Challenge
Create a method called GetMax that is in the binary tree class. Have it return the max value in the tree, we can assume the values will always be some 

## Approach & Efficiency

[whiteboard](Code-Challenge-15.md)
Recursively call a function that checks the children node values and returns that up the recursive call stack to give the largest value in a breadth search.
Time Efficiency: Because the method needs to cycle through the entire tree it will scale requirements with the size of the tree, making the efficiency O(n)
Memory Efficiency: Because te mothod will have a recursive call through all the nodes it will scale proportionaly to the size of the input tree, making the efficiency O(n)

## API
GetMax method: Input Root node of tree find the maximum value on that tree. The T must be enumerable to allow the compare function to work.

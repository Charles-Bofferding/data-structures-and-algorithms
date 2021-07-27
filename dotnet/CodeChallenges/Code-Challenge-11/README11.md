# Psuedo Queue
Create a class that mimics the first in first out functionality of a queue, but instead have 
two internal stack data structures to make the same funcionality happen. Both enqueue and dequeue
must be implemented.

## Whiteboard Process
[whiteboard](Code-Challenge-11.png)

## Approach & Efficiency
Memory
The big o efficiency for this is O(N). As the Psuedo Queue grows the size of the memory used needs to be increased
in proportion.

Time
The big O efficiency for the enqueue method is O(n). This is because it requires looping through the entire collection
of nodes.
The big O efficiency for the dequeue method is O(1), it only needs to return the top node of the stack.


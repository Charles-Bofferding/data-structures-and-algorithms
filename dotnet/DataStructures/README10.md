# Stacks and Queues

Stack: Data structure that creates a collection of nodes which adhere to a first in last out ordering.
The top of the stack is the typical target for all the methods called. They will be descirbed later in this README

Queue: Date structure that creates a collection of nodes which adhere to a first in first out ordering.
Nodes are added to the back of the queue and information is taken from the front.

## Challenge

Create the data structures described above

## Approach & Efficiency

The Stack data structure has a big O space efficiency of O(n). This is because it scales it's size depending on how large 
the amount of values input to it are directly and proportionally.
The Stack data structure has a big O time efficiency of O(1). This is because all of the methods run for a finite amount 
and do not cycle through the data structure.

The Queue data structure has a big O space efficiency of O(n). This is because it scales it's size depending on how large 
the amount of values input to it are directly and proportionally.
The Queue data structure has a big O time efficiency of O(1). This is because all of the methods run for a finite amount 
and do not cycle through the data structure.

## API

Stack Public Methods
- Push: create a node and place it at the head of the stack, preserving the rest of the stack nodes if they are present
- Pop: Return the value of the node at the head of the stack and then remove that node from the stack
- - Returns NullRefferenceException if the stack is empty
- Peek: Return the value of the node at the head of the stack without removing the node. 
- - Returns NullRefferenceException if the stack is empty
- IsEmnpty: Return boolean true if the stack has no nodes, and false if there are nodes.

Queue Public Methods
- Enqueue: create a node and place it at the back of the stack, moving all other nodes forawrd
- Dequeue: Return the value of the node at the front of the queue and then remove that node from the queue
- - Returns NullRefferenceException if the queue is empty
- Peek: Return the value of the node at the Front of the queue without removing the node. 
- - Returns NullRefferenceException if the queue is empty
- IsEmnpty: Return boolean true if the queue has no nodes, and false if there are nodes.
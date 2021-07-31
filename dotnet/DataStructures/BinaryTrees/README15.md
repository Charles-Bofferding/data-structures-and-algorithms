# Trees
Implemented a binary tree and then an extension of that class, the binary search tree which orders the nodes added to it.

## Challenge
Create a binary serach tree class with an add and a contains methods.

## Approach & Efficiency
Modified the Node class to have a left and right property to allow for the same node class
to be used for binary trees. 
Time Efficiency: Because add and contains actions only go through a subset of the whole tree the time efficiency is O(logn)
Time Efficiency: Because all of the traversal methods run through the entire tree the time efficiency is O(n)
Memory Efficiency: Because all the  methods only create a set number of ectra refference variables they have a 
memory efficiency of O(1)

## API
Add method: Input Root node of tree and value to be added. The value will either make a new node at the root location,
place the item on the left and recursively call if the value is less than the root value, or vice versa for right.
Contains: Using the same logic as the above method except check each time for the root value to be equal to the
input value and return a boolean if that value is detected anywhere.

# References
John's Replit code sample
https://replit.com/@johncokos/Iteration-Practice-C#main.cs

Traveresal Output through writleine inspiration
http://csharpexamples.com/tag/preorder-traversal/
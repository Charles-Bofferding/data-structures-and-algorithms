# Zip together two Linked Lists
Write a method that takes in two linked lists and returns a linked list(LL) that is the two mashed together.
The method for mashing is to take the head node of the first LL, then add the head of the second LL. Then to
that add the next node in the first LL, and then the second node for the second LL and so on. If either run out of
nodes keep adding nodes from the other LL until there are no more to add.

## Whiteboard Process
[whiteboard](Code-Challenge-08.png)

## Approach & Efficiency
Memory
The big o efficiency for this is O(1) I think. There are only a set number of refference Nodes created and no matter
the size of the linked lists fed in this will not change.

Time
The big O efficiency for this is O(n). You will need to go through the linked list no matter what so the time the method
takes will scale with the size of the linked lists that you input into the method.


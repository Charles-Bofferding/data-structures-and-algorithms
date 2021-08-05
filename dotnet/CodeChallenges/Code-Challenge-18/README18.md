# Fizz Buzz Tree

## Challenge
Given a K-ary tree of integer values return a tree of an identical structure that performs the famous FizzBuzz transformation on those integer values.

## Approach & Efficiency

[whiteboard](Code-Challenge-18.md)
So this method doesn't quite fit the inputs and outputs that the original prompt requested. I reworked it somewhat to try and use a while loop going through a stack of nodes
to process all these things. It seems to have problems with "Object reference not set to an instance of an object." on line 40 But I am 

## Efficiency
Time Efficiency: Because the method needs to cycle through the entire tree it will scale requirements with the size of the tree, making the efficiency O(n)
Memory Efficiency: Because the method will hwhile loop through all the nodes it will scale proportionaly to the size of the input tree, making the efficiency O(n)

## API
FizzBuzzTree: For each node with an int, i the number is divisible by 3 output a node with the value Fizz, divisible by 5 is Buzz, both is FIZZBUZZ
Create a tree that is the same structure as the 

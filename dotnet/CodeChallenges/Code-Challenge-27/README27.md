# Merge Sorting

## Challenge
Use the psuedo code provided in the assignment to succesfully implement an array sort method.

## Approach
Please see the [BLOG.md](BLOG.md) for an in depth description of both of these.

## Efficiency
Time Efficiency: The method will need to run a number of times equal to the size of the array, plus a number of times equal to half the array size, and so on until you get to having the left and right nly be arrays of 1 length.
This is more than N but not n squared. My best approximation is an efficiency of O(nlog(n))
Memory Efficiency: Because the method will need to make a number of new arrays and extra calls in a size that increases with the input array size the memory efficiency is O(n)

## Solution
Input an array of integers and it sorts the array in place.
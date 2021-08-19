# Merge Sort BLOOOOOOOG

By Charles Bofferding, Steven Boston, and Joel

## Problem Domain

Implement a method that takes in an array of integers and returns the array with the values sorted from smallest to largest.

## Process

### High level description

Each recursive call of the method tries to acheive one thing. That is to choose some value in the array as a pivot point and restructure
the array so that all values below the pivot are moved on to the left side of the array, all values larger than the pivot are moved
to the right side of the array, and the final location of the pivot is returned. 

#### Why does this matter for us?

We now have a section of the array that are all smaller than the pivot, the pivot, and all values larger in that order. Now if we just look
at the values before the pivot we can handle them independently because that pocket of the array is a self contained thing. The same logic
applies for the array locations after the pivot so they can be sorted, and the pivot is exactly where it should be. This is where the recursion
comes in. You just the process the smaller and smaller parts of the array and ordering them, with the smallest being just 2 locations that 
we ordered correctly and then begin returning up the call stack to make sure that we sort every pocket of the array.

## Detailed Step by Step Quick Sort Algorithm

![QuickSort](./Code-Challenge-28.png)


## Explicit Console.Writeline calls made during a call

QuickSort Call:
  Left: 0
  Right: 5
  Array Status: 8, 4, 23, 42, 16, 15,

Partition, Left = 0, Right = 5
  i: 0
  pivot: 15
  Array Status: 8, 4, 23, 42, 16, 15,
  After Check/Swap: 8, 4, 23, 42, 16, 15,

  i: 1
  pivot: 15
  Array Status: 8, 4, 23, 42, 16, 15,
  After Check/Swap: 8, 4, 23, 42, 16, 15,

  i: 2
  pivot: 15
  Array Status: 8, 4, 23, 42, 16, 15,
  After Check/Swap: 8, 4, 23, 42, 16, 15,

  i: 3
  pivot: 15
  Array Status: 8, 4, 23, 42, 16, 15,
  After Check/Swap: 8, 4, 23, 42, 16, 15,

  i: 4
  pivot: 15
  Array Status: 8, 4, 23, 42, 16, 15,
  After Check/Swap: 8, 4, 23, 42, 16, 15,

Position: 2
QuickSort Call:
  Left: 0
  Right: 1
  Array Status: 8, 4, 15, 42, 16, 23,

Partition, Left = 0, Right = 1
  i: 0
  pivot: 4
  Array Status: 8, 4, 15, 42, 16, 23,
  After Check/Swap: 8, 4, 15, 42, 16, 23,

Position: 0
QuickSort Call:
  Left: 0
  Right: -1
  Array Status: 4, 8, 15, 42, 16, 23,

QuickSort Call:
  Left: 1
  Right: 1
  Array Status: 4, 8, 15, 42, 16, 23,

QuickSort Call:
  Left: 3
  Right: 5
  Array Status: 4, 8, 15, 42, 16, 23,

Partition, Left = 3, Right = 5
  i: 3
  pivot: 23
  Array Status: 4, 8, 15, 42, 16, 23,
  After Check/Swap: 4, 8, 15, 42, 16, 23,

  i: 4
  pivot: 23
  Array Status: 4, 8, 15, 42, 16, 23,
  After Check/Swap: 4, 8, 15, 16, 42, 23,

Position: 4
QuickSort Call:
  Left: 3
  Right: 3
  Array Status: 4, 8, 15, 16, 23, 42,

QuickSort Call:
  Left: 5
  Right: 5
  Array Status: 4, 8, 15, 16, 23, 42,

Array after sort:
 4, 8, 15, 16, 23, 42

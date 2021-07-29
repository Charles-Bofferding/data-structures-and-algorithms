# Validate Brackets
Create a method to check an input string and make sure that all three types of brackets have appropriate 
opening and closing characters. The three bracket types are (), {}, and [].

## Whiteboard Process
[whiteboard](Code-Challenge-13.png)

## Approach & Efficiency
Memory
The big o efficiency for memory in this is O(N). The largest memory sink is the string array that is made from
the input string and scales with the input size linearly.

Time
The big 0 efficiency for time in this is O(n). The method will need to loop through all characters in the input
string and will therefore need to scale the ime usage linearly with the input.


# Hashtables
Hash tables are a way to store information in a way that requires a heavier lift while storing the information to have an easier time pulling that
information back out of storage. There is a key value pair to be stored, and the key is transformed into an index location in an array of lists.
When looking to retreive the value atached to that key only the items that have been mapped to that particular array location need to be searched through 
instead of all items.

## Challenge
IMplement a hash table using the basic hash algorithm provided.

## Approach & Efficiency
The approach is to provide the methods needed to store data in the hash table, though there is the caveat that both the key and value must be strings.
The Big O efficiency for a hashtable has a considerable bit of wiggle to it. If there is only 1 item at each location then teh efficiency is O(1) because
only one location needs to be accessed. At the worst possible case every single item will be hashed to the same location and the efficiency decreases
to O(n).

## API
Add: Insert a key value pair into the ash table. Both must be strings with this implementation
Get: Retreive the value associated with an input key. 
Contains: Check the hash table to see if the input key has been previously added to the hash table, returns a bool.
Print: Through the console print out all contents stored n the hash table.
Hash: take the key and through the "hash" process transform it into a 
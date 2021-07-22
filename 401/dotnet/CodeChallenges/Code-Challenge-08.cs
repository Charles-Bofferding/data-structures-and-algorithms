using DataStructures;
using System;

namespace CodeChallenges
{
    public class CodeChallenge08
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static LinkedList ZipLists(LinkedList LLa, LinkedList LLb)
        {

            //Edge case protection of null inputs
            if (LLa == null)
            {
                return LLb;
            }
            else if (LLb == null)
            {
                return LLa;
            }

            //Setting up variables
            Node tempA = new(1);
            Node tempB = new(1);
            Node targetA = LLa.Head;
            Node targetB = LLb.Head;

            while (targetA.Next != null && targetB.Next != null)
            {
                //Link the targetB node into the middle of LinkedListA
                tempA = targetA.Next;
                tempB = targetB.Next;
                targetA.Next = targetB;
                targetB.Next = tempA;

                //Increment targets forward one
                targetB = tempB;
                targetA = tempA;
            }

            //Now we decide what to do based off which list has empty values
            //If both are empty then just return LLa which should be built up

            //If LLb has empty next throw the last value into LLa in the same way
            if (targetB.Next == null && targetA.Next == null)
            {
                targetA.Next = targetB;
                return LLa;
            }
            else if (targetB.Next == null)
            {
                tempA = targetA.Next;
                targetA.Next = targetB;
                targetB.Next = tempA;
            }
            else if (targetA.Next == null)
            {
                targetA.Next = targetB;
            }

            return LLa;
        }

    }
}

using DataStructures;
using CodeChallenges;
using System;
using Xunit;

namespace CodeChallengesTest
{
    public class Tests08
    {
        //Linked List Zip Tests

        //LLa 3 nodes, LLb 4 nodes
        [Fact]
        public void ZipLinkList1()
        {
            //create first linked list
            LinkedList testA = new();
            testA.Insert(12);
            testA.Insert(11);
            testA.Insert(10);

            //create second linked list
            LinkedList testB = new();
            testB.Insert(23);
            testB.Insert(22);
            testB.Insert(21);
            testB.Insert(20);

            LinkedList testC = CodeChallenge08.ZipLists(testA, testB);

            //Check for middle value of 3
            Assert.Equal("10 -> 20 -> 11 -> 21 -> 12 -> 22 -> 23 -> NULL", testC.MakeString());

        }

        //LLa 4 nodes, LLb 2 nodes
        [Fact]
        public void ZipLinkList2()
        {
            //create first linked list
            LinkedList testA = new();
            testA.Insert(13);
            testA.Insert(12);
            testA.Insert(11);
            testA.Insert(10);

            //create second linked list
            LinkedList testB = new();
            testB.Insert(21);
            testB.Insert(20);

            LinkedList testC = CodeChallenge08.ZipLists(testA, testB);

            //Check for middle value of 3
            Assert.Equal("10 -> 20 -> 11 -> 21 -> 12 -> 13 -> NULL", testC.MakeString());

        }

        //LLa 4 nodes, LLb 4 nodes
        [Fact]
        public void ZipLinkList3()
        {
            //create first linked list
            LinkedList testA = new();
            testA.Insert(13);
            testA.Insert(12);
            testA.Insert(11);
            testA.Insert(10);

            //create second linked list
            LinkedList testB = new();
            testB.Insert(23);
            testB.Insert(22);
            testB.Insert(21);
            testB.Insert(20);

            LinkedList testC = CodeChallenge08.ZipLists(testA, testB);

            //Check for middle value of 3
            Assert.Equal("10 -> 20 -> 11 -> 21 -> 12 -> 22 -> 13 -> 23 -> NULL", testC.MakeString());

        }
    }
}

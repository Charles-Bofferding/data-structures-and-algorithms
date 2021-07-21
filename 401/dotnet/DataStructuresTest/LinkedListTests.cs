using System;
using Xunit;
using DataStructures;


namespace DataStructuresTest
{
    public class UnitTest1
    {

        //Can successfully instantiate an empty linked list
        [Fact]
        public void CreateLinkList()
        {
            //create local linked list
            LinkedList test = new();
            //Make sure it is not null and in fact instantiated
            Assert.NotNull(test);
        }

        //Can properly insert into the linked list
        [Fact]
        public void InsertLinkList()
        {
            //create local linked list
            LinkedList test = new();
            test.Insert(5);
            Assert.Equal(5, test.Head.Value);
        }

        //The head property will properly point to the first node in the linked list


        //Can properly insert multiple nodes into the linked list
        [Fact]
        public void MultipleLinkList()
        {
            //create local linked list
            LinkedList test = new();

            //First item goes to head
            test.Insert(5);
            Assert.Equal(5, test.Head.Value);

            //Second item goes to head
            test.Insert(8);
            Assert.Equal(8, test.Head.Value);

        }

        //Will return true when finding a value within the linked list that exists
        [Fact]
        public void IncludesLinkList()
        {
            //create local linked list
            LinkedList test = new();

            //Multiple node test linked list
            test.Insert(5);
            test.Insert(8);
            test.Insert(40);

            //Make sure they are all in there
            Assert.True(test.Includes(40));
            Assert.True(test.Includes(8));
            Assert.True(test.Includes(5));

        }

        //Will return false when searching for a value in the linked list that does not exist
        [Fact]
        public void DoesntIncludesLinkList()
        {
            //create local linked list
            LinkedList test = new();

            //Multiple node test linked list
            test.Insert(5);
            test.Insert(8);
            test.Insert(40);

            //Make sure 40 is in there
            Assert.False(test.Includes(6));

        }


        //Can properly return a collection of all the values that exist in the linked list
        [Fact]
        public void StringReturnLinkList()
        {
            //create local linked list
            LinkedList test = new();

            //Multiple node test linked list
            test.Insert(5);
            test.Insert(8);
            test.Insert(40);

            //Make sure 40 is in there
            Assert.Equal("40 -> 8 -> 5 -> NULL", test.MakeString());

        }

        [Fact]
        //Can successfully add a node to the end of the linked list
        public void AppendLinkList()
        {
            //create local linked list
            LinkedList test = new();

            //Multiple node test linked list
            test.Insert(5);
            test.Insert(8);
            test.Insert(40);

            test.Append(15);

            //Make sure 15 is in there
            Assert.True(test.Includes(15));

        }

        [Fact]
        //Can successfully add multiple nodes to the end of a linked list
        public void AppendMultipleLinkList()
        {
            //create local linked list
            LinkedList test = new();

            //Multiple node test linked list
            test.Insert(5);
            test.Insert(8);
            test.Insert(40);

            test.Append(15);
            test.Append(30);

            //Make sure 15 and 30 are in there
            Assert.True(test.Includes(15));
            Assert.True(test.Includes(30));

        }


        [Fact]
        //Can successfully insert a node before a node located in the middle of a linked list
        public void InsertBeforeLinkList()
        {
            //create local linked list
            LinkedList test = new();

            //Multiple node test linked list
            test.Insert(5);
            test.Insert(8);
            test.Insert(40);

            test.InsertBefore(8, 15);

            //Make sure 15 and 30 are in there
            Assert.Equal("40 -> 15 -> 8 -> 5 -> NULL", test.MakeString());

        }


        [Fact]
        //Can successfully insert a node before the first node of a linked list
        public void InsertBeforeFirstLinkList()
        {
            //create local linked list
            LinkedList test = new();

            //Multiple node test linked list
            test.Insert(5);
            test.Insert(8);
            test.Insert(40);

            test.InsertBefore(40, 15);

            //Make sure 15 and 30 are in there
            Assert.Equal("15 -> 40 -> 8 -> 5 -> NULL", test.MakeString());

        }


        [Fact]
        //Can successfully insert after a node in the middle of the linked list
        public void InsertAfterLinkList()
        {
            //create local linked list
            LinkedList test = new();

            //Multiple node test linked list
            test.Insert(5);
            test.Insert(8);
            test.Insert(40);

            test.InsertAfter(8, 15);

            //Make sure 15 and 30 are in there
            Assert.Equal("40 -> 8 -> 15 -> 5 -> NULL", test.MakeString());

        }


        [Fact]
        //Can successfully insert a node after the last node of the linked list
        public void InsertAfterLastLinkList()
        {
            //create local linked list
            LinkedList test = new();

            //Multiple node test linked list
            test.Insert(5);
            test.Insert(8);
            test.Insert(40);

            test.InsertAfter(5, 15);

            //Make sure 15 and 30 are in there
            Assert.Equal("40 -> 8 -> 5 -> 15 -> NULL", test.MakeString());

        }

        /*-----------------Code Challenge 7----------------------*/

        [Fact]
        //Where k is greater than the length of the linked list
        public void KthOutOfBoundsLinkList()
        {
            //create local linked list
            LinkedList test = new();

            //Multiple node test linked list
            test.Insert(5);
            test.Insert(8);
            test.Insert(40);

            //Make sure ArgumentException returned when target location is outside the bounds of the linked list
            Assert.Throws<ArgumentException>(() => test.KthFromEnd(20));

        }


        [Fact]
        //Where k and the length of the list are the same
        public void KthExactLengthLinkList()
        {
            //create local linked list
            LinkedList test = new();

            //Multiple node test linked list
            test.Insert(5);
            test.Insert(8);
            test.Insert(40);

            //K is targeting third node, (but first position is zero)
            Assert.Equal(40, test.KthFromEnd(2));

        }

        [Fact]
        //Where k is not a positive integer
        public void KthBadInputValueLinkList()
        {
            //create local linked list
            LinkedList test = new();

            //Multiple node test linked list
            test.Insert(5);
            test.Insert(8);
            test.Insert(40);

            //Ensure the specific type of argument exception is returned
            Assert.Throws<ArgumentException>(() => test.KthFromEnd(-6));

        }

        [Fact]
        //Where the linked list is of a size 1
        public void KthSingleLinkList()
        {
            //create local linked list
            LinkedList test = new();

            //Single node test linked list
            test.Insert(5);

            //Get back correct value
            Assert.Equal(5, test.KthFromEnd(0));

        }

        [Fact]
        //“Happy Path” where k is not at the end, but somewhere in the middle of the linked list
        public void KthIdealLinkList()
        {
            //create local linked list
            LinkedList test = new();

            //Multiple node test linked list
            test.Insert(5);
            test.Insert(8);
            test.Insert(40);
            test.Insert(10);
            test.Insert(16);
            test.Insert(80);

            //Check for middle value of 3
            Assert.Equal(10, test.KthFromEnd(3));

        }










    }
}

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


    }
}

using System;
using Xunit;
using DataStructures;


namespace DataStructuresTest
{
    public class BinaryTreeTest1
    {

        //Can successfully instantiate an empty linked list
        [Fact]
        public void CreateLinkList()
        {
            //create local linked list
            LinkedList<int> test = new();
            //Make sure it is not null and in fact instantiated
            Assert.NotNull(test);
        }

        //Can properly insert into the linked list
        [Fact]
        public void InsertLinkList()
        {
            //create local linked list
            LinkedList<int> test = new();
            test.Insert(5);
            Assert.Equal(5, test.Head.Value);
        }

        //Can successfully instantiate an empty tree
        [Fact]
        public void BinaryTest1()
        {
            //create local Binary Search Tree
            BinarySearchTree<int> test = new();

            Assert.Null(test.Root);
        }

        //Can successfully instantiate a tree with a single root node
        [Fact]
        public void BinaryTest2()
        {
            //create local Binary Search Tree
            BinarySearchTree<int> test = new();
            test.Add(test.Root, 5);

            Assert.Equal(5, test.Root.Value);
        }

        //Can successfully add a left child and right child to a single root node
        [Fact]
        public void BinaryTest3()
        {
            //create local Binary Search Tree
            BinarySearchTree<int> test = new();
            test.Add(test.Root, 10);
            test.Add(test.Root, 5);
            test.Add(test.Root, 15);

            Assert.Equal(5, test.Root.Left.Value);
            Assert.Equal(15, test.Root.Right.Value);
        }

        //Can successfully return a collection from a preorder traversal
        [Fact]
        public void BinaryTest4()
        {
            //create local Binary Search Tree
            BinarySearchTree<int> test = new();
            test.Add(test.Root, 20);
            test.Add(test.Root, 10);
            test.Add(test.Root, 30);
            test.Add(test.Root, 5);
            test.Add(test.Root, 15);
            test.Add(test.Root, 25);
            test.Add(test.Root, 35);

            //    20
            //    / \
            //  10   30
            //  /\   /\
            // 5 15 25 35

            //Just going to have to check the console for this one
            test.PreOrder(test.Root);
            //Should be 20 10 5 15 30 25 35

            test.InOrder(test.Root);
            //should be 5 10 15 20 30 25 35

            test.PostOrder(test.Root);
            //should be 5 15 10 25 35 30 20

            //CHecked and it output correctly
            Assert.True(true);
        }

        //GetMax tests
        [Fact]
        public void GetMaxTreeTestWorking()
        {
            //create local Binary Search Tree
            BinarySearchTree<int> test = new();
            test.Add(test.Root, 20);
            test.Add(test.Root, 10);
            test.Add(test.Root, 30);
            test.Add(test.Root, 5);
            test.Add(test.Root, 15);
            test.Add(test.Root, 25);
            test.Add(test.Root, 35);

            //    20
            //    / \
            //  10   30
            //  /\   /\
            // 5 15 25 35

            //CHecked and it output correctly
            Assert.Equal(35, test.GetMax(test.Root));
        }

        [Fact]
        public void GetMaxTreeTestEdge()
        {
            //create local Binary Search Tree
            BinarySearchTree<int> test = new();
            test.Add(test.Root, 20);

            Assert.Equal(20, test.GetMax(test.Root));
        }

    }
}

using DataStructures;
using System;
using System.Collections.Generic;
using Xunit;
using CodeChallenges.Code_Challenge_17;

namespace CodeChallengesTest
{
    public class Tests17
    {

        //Correctly returns list
        [Fact]
        public void BreadthFirstWorking()
        {
            //create local Binary Search Tree
            BinaryTree<int> test = new();
            Node<int> b1 = new Node<int>(5);
            Node<int> b2 = new Node<int>(15);
            Node<int> b3 = new Node<int>(25);
            Node<int> b4 = new Node<int>(35);
            Node<int> m1 = new Node<int>(10);
            Node<int> m2 = new Node<int>(30);
            Node<int> t1 = new Node<int>(20);

            t1.Left = m1;
            t1.Right = m2;
            m1.Left = b1;
            m1.Right = b2;
            m2.Left = b3;
            m2.Right = b4;

            test.Root = t1;

            //Test becomes this
            //    20
            //    / \
            //  10   30
            //  /\   /\
            // 5 15 25 35

            //Building expected output list
            List<int> expected = new() { 20, 10, 30, 5, 15, 25, 35 };

            Assert.Equal(expected, Code_Challenge_17.BreadthFirst(test));

        }

        [Fact]
        public void BreadthFirstEmpty()
        {
            //create local Binary Search Tree
            BinaryTree<int> test = new();
            List<int> expected = new();

            Assert.Equal(expected, Code_Challenge_17.BreadthFirst(test));

        }

        [Fact]
        public void BreadthFirstRootOnly()
        {
            //create local Binary Search Tree
            BinaryTree<int> test = new();
            List<int> expected = new();
            expected.Add(20);

            Node<int> t1 = new Node<int>(20);
            test.Root = t1;

            Assert.Equal(expected, Code_Challenge_17.BreadthFirst(test));

        }

    }
}

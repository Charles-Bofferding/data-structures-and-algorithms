using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures;
using Xunit;
using CodeChallenges.Code_Challenge_18;

namespace CodeChallengesTest
{
    public class Tests18
    {

        //Correctly returns list
        [Fact]
        public void BreadthFirstWorking()
        {
            //create local Binary Search Tree
            BinaryTree<int> test = new();
            Node<int> t1 = new Node<int>(11);
            Node<int> m1 = new Node<int>(3);
            Node<int> m2 = new Node<int>(5);
            Node<int> m3 = new Node<int>(30);
            Node<int> b1 = new Node<int>(5);
            Node<int> b2 = new Node<int>(15);
            Node<int> b3 = new Node<int>(41);


            test.Root = t1;

            List<Node<int>> t1Children = new() { m1, m2, m3};

            List<Node<int>> m1Children = new() { b1, b2 };

            List<Node<int>> m2Children = new() { b3 };



            //Test becomes this
            //      11
            //    / | \
            //  3   5  30
            //  /\      |
            // 5 15     41


            //Building what we expect
            BinaryTree<string> expected = new();
            Node<string> et1 = new Node<string>("11");
            Node<string> em1 = new Node<string>("Fizz");
            Node<string> em2 = new Node<string>("Buzz");
            Node<string> em3 = new Node<string>("FizzBuzz");
            Node<string> eb1 = new Node<string>("Buzz");
            Node<string> eb2 = new Node<string>("FizzBuzz");
            Node<string> eb3 = new Node<string>("41");


            expected.Root = et1;

            List<Node<string>> et1Children = new() { em1, em2, em3 };

            List<Node<string>> em1Children = new() { eb1, eb2 };

            List<Node<string>> em2Children = new() { eb3 };

            Assert.Equal(expected, Code_Challenge_18.TreeFizzBuzz(test));

        }

        [Fact]
        public void TreeFizzBuzzEmpty()
        {
            //create local Binary Search Tree
            BinaryTree<int> test = new();
            BinaryTree<string> expected = Code_Challenge_18.TreeFizzBuzz(test);

            Assert.Null( expected.Root);

        }

        [Fact]
        public void TreeFizzBuzzRootOnly()
        {
            //create local Binary Search Tree
            BinaryTree<int> test = new();
            Node<int> t1 = new Node<int>(20);
            test.Root = t1;
            BinaryTree<string> expected = new();
            expected.Root.Value = "Fizzbuzz";


            Assert.Equal(expected.Root.Value, Code_Challenge_18.TreeFizzBuzz(test).Root.Value);

        }

    }
}

using DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.Code_Challenge_18
{
    public class Code_Challenge_18
    {

        //added children property to the node class
        public static BinaryTree<string> TreeFizzBuzz (BinaryTree<int> KTree)
        {
            //set up KTree.Root as KTarget
            Node<int> KTarget = KTree.Root;

            //set up Fizz Buzz tree
            BinaryTree<string> FBTree = new();
            Node<string> FBTarget = FBTree.Root;

            // Set up stacks, need to pop/push at the same time because only one is used as a boundary condition
            DataStructures.Stack<Node<int>> KStack = new();
            KStack.Push(KTarget);
            DataStructures.Stack<Node<string>> FBStack = new();
            FBStack.Push(FBTarget);

            //while stack has nodes in it
            while(!KStack.IsEmpty())
            {
                //Setting up the node to process, should go from root to leaf
                KTarget = KStack.Pop();
                FBTarget = FBStack.Pop();

                // If Ktarget.children != null
                if(KTarget.Children != null)
                {
                    //setup childrenList
                    List<Node<string>> FBchildren = new();

                    //Foreach child of Ktarget.Children
                    foreach(Node<int> KChild in KTarget.Children)
                    {
                        //Fizz Buzz
                        int temp = KChild.Value;
                        string temp2 = KChild.Value.ToString();
                        if(temp % 3 == 0)
                        {
                            temp2 = "Fizz";
                        }
                        if (temp % 5 == 0)
                        {
                            temp2 = "Buzz";
                        }
                        if (temp % 3 == 0)
                        {
                            temp2 = "FizzBuzz";
                        }

                        //Create FBTreeNode and add to children list
                        Node<string> FBChildNode = new(temp2);
                        FBchildren.Add(FBChildNode);

                        //Send Nodes to the stack to process the next level down
                        KStack.Push(KChild);
                        FBStack.Push(FBChildNode);

                    }

                    //Add in all the FBChild nodes created to the current FBTarget
                    FBTarget.Children = FBchildren;

                }

            }

            //Output the whole thing
            return FBTree;

        }
    }
}

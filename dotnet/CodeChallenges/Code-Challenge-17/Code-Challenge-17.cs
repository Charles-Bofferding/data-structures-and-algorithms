using DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.Code_Challenge_17
{
    public class Code_Challenge_17
    {
        //Going with int because that is the only example we have and I wanted this outside the Binary Tree area to avoid over packing it with work
        //Putting it here requires T to be defined but doesn't have 3 code challenges all sharing the same work space
        public static List<int> BreadthFirst(BinaryTree<int> input)
        {
            //Make sure to use our Queue and not the generic one
            DataStructures.Queue<int> NodeQ = new();
            List<int> output = new();

            //Prime the Queue with the root of the input tree
            Node<int> target = input.Root;
            NodeQ.EnqueueNode(target);

            while(!NodeQ.IsEmpty())
            {
                target = NodeQ.DequeueNode();
                output.Add(target.Value);

                if (target.Left != null)
                {
                    NodeQ.EnqueueNode(target.Left);
                }
                if (target.Right != null)
                {
                    NodeQ.EnqueueNode(target.Right);
                }

            }

            return output;
        }

    }
}

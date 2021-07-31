using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class BinarySearchTree<T> : BinaryTree<T> 
        where T : IComparable
    {

        // Add new node, sort smaller left and higher right to current node recursively
        public void Add(Node<T> target, T value)
        {
            //Setup Variable
            Node<T> newNode = new(value);
            
            //If current place empty drop here
            if (Root == null)
            {
                Root = newNode;
                return;
            }

            //If smaller go to left node of target
            if (newNode.Value.CompareTo(target.Value) < 0)
            {
                if (target.Left == null) 
                { 
                    target.Left = newNode;
                }
                else 
                { 
                    Add(target.Left, value);
                }
            }

            //If Larger go to right node of target
            else if (newNode.Value.CompareTo(target.Value) > 0)
            {
                if (target.Right == null) 
                {
                    target.Right = newNode;
                }
                else 
                { 
                    Add(target.Right, value); 
                }
            }

        }

        public bool Contains(T value)
        {
            bool output = false;
            Node<T> target = Root;

            while(target != null)
            {
                //If smaller go to left node of target
                if (value.CompareTo(target.Value) < 0)
                {
                    target = target.Left;
                }

                //If Larger go to right node of target
                else if (value.CompareTo(target.Value) > 0)
                {
                    target = target.Right;
                }

                else if (value.CompareTo(target.Value) == 0)
                {
                    output = true;
                    target = null;
                }
            }

            return output;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class BinaryTree<T> where T : IComparable //Comparable thing to let GetMax still use the T valuable 
    {

        public Node<T> Root { get; set; }

        //Search through the tree recursively to find the max value stored in it.
        public T GetMax(Node<T> target)
        {
            //Setup initial value
            T currentMax = target.Value;

            //Bounding condition
            if( target.Left != null)
            {
                //Get back max value from further calls
                T temp = GetMax(target.Left);

                //Take the bigger value
                if (temp.CompareTo(target.Value) > 0)
                {
                    currentMax = temp;
                }
            }

            //Bounding condition
            if (target.Right != null)
            {
                //Get back max value from further calls
                T temp = GetMax(target.Right);

                //Take the bigger value
                if (temp.CompareTo(target.Value) > 0)
                {
                    currentMax = temp;
                }
            }

            //Send back your local max
            return currentMax;
        }



        //Because Arrays can't be dynamically expanded in c# I used write to console instead
        public void PreOrder(Node <T> root)
        {
            if (root != null)
            {
                Console.Write(root.Value + " ");
                PreOrder(root.Left);
                PreOrder(root.Right);
            }
        }

        //Because Arrays can't be dynamically expanded in c# I used write to console instead
        public void InOrder(Node<T> root)
        {
            if (root != null)
            {
                InOrder(root.Left);
                Console.Write(root.Value + " ");
                InOrder(root.Right);
            }
        }

        //Because Arrays can't be dynamically expanded in c# I used write to console instead
        public void PostOrder(Node<T> root)
        {
            if (root != null)
            {
                PostOrder(root.Left);
                PostOrder(root.Right);
                Console.Write(root.Value + " ");
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class BinaryTree<T>
    {

        public Node<T> Root { get; set; }

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

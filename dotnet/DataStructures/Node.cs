using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Node<T>
    {

        //The lab does not refference what data type to be stored in value so I am following John's lead here and making it int
        public T Value { get; set; }

        public Node<T> Next { get; set; }

        public Node<T> Left { get; set; }

        public Node<T> Right { get; set; }

        //Added 8/4/2021 to let a binary tree pretend to be a K-ary tree
        public List<Node<T>> Children { get; set; }

        public Node(T value)
        {
            Value = value;
        }
    }
}

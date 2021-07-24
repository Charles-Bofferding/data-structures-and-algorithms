using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Stack<T>
    {

        //top pointer
        public Node<T> Top { get; set; }

        //push adds a new node with an input value to the top of the stack
        public void Push(T value)
        {
            Node<T> input = new(value);
            input.Next = Top;
            Top = input;
        }

        //pop return the value from the node on top of the stack, removes the node, raise exception when called on empty stack
        public T Pop()
        {

            //Throw the exception
            if(Top == null)
            {
                throw new NullReferenceException();
            }
            T output = Top.Value;
            Top = Top.Next;
            return output;
        }

        //peek returns value of node at the top of the stack, raise exception when called on empty stack
        public T Peek()
        {

            //Throw the exceotion
            if (Top == null)
            {
                throw new NullReferenceException();
            }
            return Top.Value;

        }

        //isEmpty outputs boolean
        //This is the opposite of John's example but I think it should return true if top is null to match the language of the methods name
        public bool IsEmpty()
        {
            return Top == null;
        }

    }
}

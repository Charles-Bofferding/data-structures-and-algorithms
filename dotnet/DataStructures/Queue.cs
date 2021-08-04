using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Queue<T>
    {

        //top pointer
        public Node<T> Front { get; set; }

        //End pointer
        public Node<T> Back { get; set; }

        //enqueue takes in value and add node with the value to the back
        public void Enqueue(T value)
        {
            Node<T> input = new(value);

            if(Front == null)
            {
                //make this front and back
                Front = input;
                Back = input;

            } 
            else
            {
                //add this as next of back, then update back
                Back.Next = input;
                Back = input;
            }
        }

        //dequeue returns value from the node at the front, then remove that node from queue, raises exception on empty queue
        public T Dequeue()
        {
            //Throw the exception
            if (Front == null)
            {
                throw new NullReferenceException();
            }

            T output = Front.Value;
            Front = Front.Next;
            return output;
        }

        public void EnqueueNode(Node<T> input)
        {

            if (Front == null)
            {
                //make this front and back
                Front = input;
                Back = input;

            }
            else
            {
                //add this as next of back, then update back
                Back.Next = input;
                Back = input;
            }
        }

        public Node<T> DequeueNode()
        {
            //Throw the exception
            if (Front == null)
            {
                throw new NullReferenceException();
            }

            Node<T> output = Front;
            Front = Front.Next;
            return output;
        }

        //peek returns value of node at the front, exception stuff for empty queue
        public T Peek()
        {
            //Throw the exception
            if (Front == null)
            {
                throw new NullReferenceException();
            }

            return Front.Value;
        }

        //IsEmpty returns boolean saying if the stack is empty or not
        public bool IsEmpty()
        {
            return Front == null;
        }

    }
}

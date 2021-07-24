using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class LinkedList<T>
    {

        //Make a head property
        public Node<T> Head { get; set; }

        //insert method
        public void Insert(T value) 
        {
            //make new node
            Node<T> newNode = new(value);

            //If there already was a head put that into the new Node so we don't lose the data
            if (Head != null)
            {
                newNode.Next = Head;
            }

            //this node is now the current head
            Head = newNode;

        }

        //include method
        public bool Includes(T search)
        {
            //set peek target to head
            Node<T> target = Head;
            //while next is not null
            while (target != null)
            {
                if (target.Value.Equals(search))
                {
                    return true;
                }
                target = target.Next;
            }
             
            //never found the target
            return false;
        }

        //The code challenge said make this called ToString but that is a reserved word
        public string MakeString()
        {
            string temp = "";
            Node<T> target = Head;

            //Whenever there is a target
            while (target != null)
            {
                temp += $"{target.Value} -> ";
                target = target.Next;
            }

            //Add on the null indicator for the tail
            temp += "NULL";
            return temp;
        }

        //append
        public void Append(T value)
        {
            Node<T> newNode = new(value);
            Node<T> target = Head;
            while (target.Next != null)
            {
                target = target.Next;
            }
            target.Next = newNode;
        }

        //insert before
        public void InsertBefore(T search, T value)
        { 
            Node<T> newNode = new(value);
            Node<T> target = Head;
            Node<T> previousNode = null;
            while (target != null)
            {
                if (target.Value.Equals(search))
                {
                    if (previousNode == null)
                    {
                        Head = newNode;
                        newNode.Next = target;
                        break;
                    }
                    else 
                    {
                        previousNode.Next = newNode;
                        newNode.Next = target;
                        break;
                    }
                }

                previousNode = target;
                target = target.Next;
            }
            Console.WriteLine("Insert Before never found a match.");
        }


        //insert after
        public void InsertAfter(T search, T value) 
        {
            Node<T> newNode = new(value);
            Node<T> target = Head;

            while (target != null)
            {
                if (target.Value.Equals(search))
                {
                    Node<T> temp = target.Next;
                    target.Next = newNode;
                    newNode.Next = temp;
                    break;
                }
                target = target.Next;
            }
        }

        public T KthFromEnd(int position) 
        {
            //Setup variables
            Node<T> target = Head;
            int length = 0;

            //get the length
            while (target != null)
            {
                length++;
                target = target.Next;
            }

            //Resseting back at the start
            target = Head;

            //Check input value
            if (position > length || position < 0)
            {
                throw new ArgumentException("Bad LinkedList Location Selected");
            }

            //Starts at 1 because we are already in Head
            for (int i = 1; i < (length - position); i++)
            {
                target = target.Next;
            }

            return target.Value;

        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class LinkedList
    {

        //Make a head property
        public Node Head { get; set; }

        //insert method
        public void Insert(int value) 
        {
            //make new node
            Node newNode = new(value);

            //If there already was a head put that into the new Node so we don't lose the data
            if (Head != null)
            {
                newNode.Next = Head;
            }

            //this node is now the current head
            Head = newNode;

        }

        //include method
        public bool Includes(int search)
        {
            //set peek target to head
            Node target = Head;
            //while next is not null
            while (target != null)
            {
                if (target.Value == search)
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
            Node target = Head;

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
        public void Append(int value)
        {
            Node newNode = new(value);
            Node target = Head;
            while (target.Next != null)
            {
                target = target.Next;
            }
            target.Next = newNode;
        }

        //insert before
        public void InsertBefore(int search, int value)
        { 
            Node newNode = new(value);
            Node target = Head;
            Node previousNode = null;
            while (target != null)
            {
                if (target.Value == search)
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
        public void InsertAfter(int search, int value) 
        {
            Node newNode = new(value);
            Node target = Head;

            while (target != null)
            {
                if (target.Value == search)
                {
                    Node temp = target.Next;
                    target.Next = newNode;
                    newNode.Next = temp;
                    break;
                }
                target = target.Next;
            }
        }
    }
}

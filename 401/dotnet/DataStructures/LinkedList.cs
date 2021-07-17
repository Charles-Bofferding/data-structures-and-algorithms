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

    }
}

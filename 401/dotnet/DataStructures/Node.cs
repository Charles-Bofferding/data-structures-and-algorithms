using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Node
    {

        //The lab does not refference what data type to be stored in value so I am following John's lead here and making it int
        public int Value { get; set; }

        public Node Next { get; set; }

        public Node(int value)
        {
            Value = value;
        }
    }
}

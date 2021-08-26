using DataStructures;
using DataStructures.HashMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.Code_Challenge_32
{
    public class Code_Challenge_32
    {

        public static int[] TreeIntersection(BinaryTree<int> a, BinaryTree<int> b)
        {
            List<int> output = new();

            HashMap storageTable = new HashMap(32);

            if(a.Root != null && b.Root != null)
            {
                HashAdder(storageTable, a.Root);
                HashChecker(storageTable, b.Root, output);
            }

            return output.ToArray();
        }

        public static void HashAdder(HashMap table, Node<int> current)
        {
            if(current.Left != null)
            {
                HashAdder(table, current.Left);
            }

            string value = current.Value.ToString();
            table.Add(value, "potatoe");

            if(current.Right != null)
            {
                HashAdder(table, current.Right);
            }
        }

        public static void HashChecker(HashMap table, Node<int> current, List<int> output)
        {
            if (current.Left != null)
            {
                HashChecker(table, current.Left, output);
            }

            string value = current.Value.ToString();
            if(table.Contains(value) && !output.Contains(current.Value))
            {
                output.Add(current.Value);
            }

            if (current.Right != null)
            {
                HashChecker(table, current.Right, output);
            }
        }
    }
}

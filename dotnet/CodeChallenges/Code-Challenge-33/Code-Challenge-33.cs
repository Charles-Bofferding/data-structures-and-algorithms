using DataStructures;
using DataStructures.HashMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.Code_Challenge_33
{
    class Code_Challenge_33
    {

        public List<string[]> LeftJoin(HashMap left, HashMap right)
        {
            List<string[]> results = new();
            //Had to make Map public and not private
            for(int i = 0; i<left.Map.Length; i++)
            {
                if(left.Map[i] != null)
                {
                    //Start the search 
                    Node<KeyValuePair<string, string>> current = left.Map[i].Head;

                    //continue the search
                    while(current != null)
                    {
                        string[] values = new string[3];
                        values[0] = current.Value.Key;
                        values[1] = current.Value.Value;
                        //check if it is in right hash and if so add that value
                        if(right.Contains(current.Value.Key))
                        {
                            values[2] = right.Get(current.Value.Key);
                        }

                        results.Add(values);
                        current = current.Next;
                    }
                }
            }
            return results;
        }

    }
}

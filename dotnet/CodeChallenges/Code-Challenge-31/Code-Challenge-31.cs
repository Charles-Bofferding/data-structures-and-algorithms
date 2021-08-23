using DataStructures.HashMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeChallenges.Code_Challenge_31
{
    public class Code_Challenge_31
    {

        public static string RepeatedWord(string input)
        {
            string[] filtered = ProcessString(input);

            HashMap storage = new HashMap(64);

            foreach (string word in filtered)
            {
                if(!storage.Contains(word))
                {
                    storage.Add(word, "potatoe");
                }
                else
                {
                    return word;
                }
            }

            return null;
        }

        //Inspiration from https://stackoverflow.com/questions/16725848/how-to-split-text-into-words/16725861
        //Regex is difficult
        public static string[] ProcessString(string input)
        {

            string filteredInput = Regex.Replace(input, "[^a-zA-Z0-9% ._]", string.Empty);

            string[] stringArray = filteredInput.Split(' ');

            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] = stringArray[i].ToLower();
            }

            return stringArray;
        }

    }
}

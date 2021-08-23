using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.HashMap
{
    public class HashMap
    {

        private LinkedList<KeyValuePair<string, string>>[] Map { get; set; }

        public HashMap (int size)
        {
            Map = new LinkedList<KeyValuePair<string, string>>[size];
        }

        public int Hash(string key) 
        {
            int hashValue = 0;
            char[] letters = key.ToCharArray();
            for (int i = 0; i < letters.Length; i++)
            {
                hashValue += letters[i];
            }

            hashValue = (hashValue * 599) % Map.Length;

            return hashValue;
        }

        public void Add(string key, string value)
        {
            int hashKey = Hash(key);

            if (Map[hashKey] == null)
            {
                Map[hashKey] = new LinkedList<KeyValuePair<string, string>>();
            }

            KeyValuePair<string, string> entry = new KeyValuePair<string, string>(key, value);
            Map[hashKey].Insert(entry);
        }

        public bool Contains(string key)
        {
            int hashKey = Hash(key);

            if(Map[hashKey !] != null)
            {
                Node<KeyValuePair<string, string>> current = Map[hashKey].Head;

                while (current != null)
                {
                    if (current.Value.Key == key) { return true; }
                    current = current.Next;
                }
            }

            return false;
        }

        //returns value stored at the input key
        //returning null if key not found in hash map
        public string Get(string key)
        {
            int hashKey = Hash(key);

            if (Map[hashKey!] != null)
            {
                Node<KeyValuePair<string, string>> current = Map[hashKey].Head;

                while (current != null)
                {
                    if (current.Value.Key == key) { return current.Value.Value; }
                    current = current.Next;
                }
            }

            return null;
        }

        public void Print()
        {
            for (int i = 0; i < Map.Length; i++)
            {
                if (Map[i] != null)
                {
                    Console.Write($"{ i}-- ");
                    Node<KeyValuePair<string, string>> current = Map[i].Head;
                    while (current != null)
                    {
                        Console.Write($"[{current.Value.Key}]:{current.Value.Value}] =>");
                        current = current.Next;
                    }
                    Console.WriteLine();
                }
            }
        }

    }
}

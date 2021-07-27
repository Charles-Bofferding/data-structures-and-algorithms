using System;
using DataStructures;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.Code_Challenge_11
{
    public class PsuedoQueue
    {
        //Make two stacks
        public Stack<int> Main =  new Stack<int>();
        public Stack<int> Reversing = new Stack<int>();


        //enqueue
        //So I used the IsEmpty method instead of Peek because the way John uses Peek is the way the rest of the 
        //world uses IsEmpty and I am guessing there was a typo there.
        public void Enqueue(int value)
        {

            Main.Push(value);

        }

        //dequeue
        public int Dequeue()
        {
            while (!Main.IsEmpty())
            {
                int temp = Main.Pop();
                Reversing.Push(temp);
            }

            int output = Reversing.Pop();

            while (!Reversing.IsEmpty())
            {
                int temp = Reversing.Pop();
                Main.Push(temp);
            }

            return output;

        }

    }
}

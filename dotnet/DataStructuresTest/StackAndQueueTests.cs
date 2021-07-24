using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using DataStructures;

namespace DataStructuresTest
{
    public class StackAndQueueTests
    {


        [Fact]
        public void StackTests()
        {

            //Can successfully instantiate an empty stack
            Stack<int> test = new();
            Assert.True(test.IsEmpty());

            //Can successfully push onto a stack
            test.Push(5);
            Assert.Equal(5, test.Peek());

            //Can successfully push multiple values onto a stack
            test.Push(10);
            Assert.Equal(10, test.Peek());

            //Can successfully pop off the stack
            int temp = test.Pop();
            Assert.Equal(5, test.Peek());

            //Can successfully empty a stack after multiple pops
            temp = test.Pop();
            Assert.True(test.IsEmpty());

            //Can successfully peek the next item on the stack
            test.Push(10);
            Assert.Equal(10, test.Peek());

            //Calling pop or peek on empty stack raises exception
            test.Pop();
            Assert.Throws<NullReferenceException>(() => test.Pop());
            Assert.Throws<NullReferenceException>(() => test.Peek());

        }

        //Can successfully instantiate an empty queue
        [Fact]
        public void QueueTest1()
        {
            Queue<int> test = new();
            Assert.True(test.IsEmpty());
        }


        //Can successfully enqueue into a queue
        [Fact]
        public void QueueTest2()
        {
            Queue<int> test = new();
            test.Enqueue(5);
            Assert.Equal(5, test.Peek());
        }


        //Can successfully enqueue multiple values into a queue
        [Fact]
        public void QueueTest3()
        {
            Queue<int> test = new();
            test.Enqueue(5);
            test.Enqueue(10);
            test.Enqueue(15);
            Assert.Equal(5, test.Peek());
        }


        //Can successfully dequeue out of a queue the expected value
        [Fact]
        public void QueueTest4()
        {
            Queue<int> test = new();
            test.Enqueue(5);
            int temp = test.Dequeue();
            Assert.Equal(5, temp);
        }


        //Can successfully peek into a queue, seeing the expected value
        [Fact]
        public void QueueTest5()
        {
            Queue<int> test = new();
            test.Enqueue(5);
            Assert.Equal(5, test.Peek());
        }


        //Can successfully empty a queue after multiple dequeues
        [Fact]
        public void QueueTest6()
        {
            Queue<int> test = new();
            int temp;
            test.Enqueue(5);
            test.Enqueue(10);
            test.Enqueue(15);

            temp = test.Dequeue();
            temp = test.Dequeue();
            temp = test.Dequeue();

            Assert.True(test.IsEmpty());
        }


        //Calling dequeue or peek on empty queue raises exception
        [Fact]
        public void QueueTest7()
        {
            Queue<int> test = new();
            int temp;
            test.Enqueue(5);

            temp = test.Dequeue();

            Assert.True(test.IsEmpty());

            Assert.Throws<NullReferenceException>(() => test.Dequeue());
            Assert.Throws<NullReferenceException>(() => test.Peek());
        }
 
    }
}

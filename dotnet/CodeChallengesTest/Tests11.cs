using System;
using Xunit;
using CodeChallenges.Code_Challenge_11;

namespace CodeChallenge11Tests
{
    public class Test11
    {
        //Enqueue and dequeue one value
        [Fact]
        public void Test1()
        {
            PsuedoQueue test = new();
            test.Enqueue(5);

            Assert.Equal(5, test.Dequeue());
        }

        //Enqueue and dequeue several values
        [Fact]
        public void Test2()
        {
            PsuedoQueue test = new();
            test.Enqueue(5);
            test.Enqueue(10);
            test.Enqueue(15);

            Assert.Equal(5, test.Dequeue());
            Assert.Equal(10, test.Dequeue());
            Assert.Equal(15, test.Dequeue());
        }

        [Fact]
        public void Test3()
        {
            PsuedoQueue test = new();
            Assert.Throws<NullReferenceException>(() => test.Dequeue());
        }

    }
}

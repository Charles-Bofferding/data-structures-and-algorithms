using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CodeChallenges.Code_Challenge_31;

namespace CodeChallengesTest
{
    public class Tests31
    {

        //Testing the whole function on the three provided samples
        [Fact]
        public void HashRepeat1()
        {
            string test1 = "Once upon a time, there was a brave princess who...";
            string result1 = "a";
            string test2 = "It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only...";
            string result2 = "it";
            string test3 = "It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, and I didn’t know what I was doing in New York...";
            string result3 = "summer";

            Assert.Equal(result1, Code_Challenge_31.RepeatedWord(test1));
            Assert.Equal(result2, Code_Challenge_31.RepeatedWord(test2));
            Assert.Equal(result3, Code_Challenge_31.RepeatedWord(test3));
        }

        //Adding a key/value to your hashtable results in the value being in the data structure
        [Fact]
        public void HashRepeat2()
        {
            string test1 = "Once upon a time, there was a brave princess who";
            string[] result1 = new string[] { "once", "upon", "a", "time", "there", "was", "a", "brave", "princess", "who" };
            string test2 = "This is a sample sentence";
            string[] result2 = new string[] { "this", "is", "a", "sample", "sentence" };
            string test3 = "I must not fear, fear is the mind killer";
            string[] result3 = new string[] { "i", "must", "not", "fear", "fear", "is", "the", "mind", "killer"  };

            Assert.Equal(result1, Code_Challenge_31.ProcessString(test1));
            Assert.Equal(result2, Code_Challenge_31.ProcessString(test2));
            Assert.Equal(result3, Code_Challenge_31.ProcessString(test3));

        }

        //Check for a null return when no repeated values
        [Fact]
        public void HashRepeat3()
        {
            string test1 = "Once upon a time, there was an brave princess who...";
            string test2 = "This is a sentence without repeated words";
            string test3 = "I must not fear, feer is the mind killer";

            Assert.Null(Code_Challenge_31.RepeatedWord(test1));
            Assert.Null(Code_Challenge_31.RepeatedWord(test2));
            Assert.Null(Code_Challenge_31.RepeatedWord(test3));
        }
    }
}

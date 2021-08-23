using DataStructures.HashMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CodeChallengesTest
{
    public class tests30
    {
        //Adding a key/value to your hashtable results in the value being in the data structure
        [Fact]
        public void HashMap1()
        {
            HashMap test = new HashMap(16);

            test.Add("key1", "value1");
            test.Add("key2", "value2");
            test.Add("key3", "value3");
            test.Add("key4", "value4");

            Assert.True(test.Contains("key3"));
            Assert.False(test.Contains("key6"));
        }

        //Retrieving based on a key returns the value stored
        [Fact]
        public void HashMap2()
        {
            HashMap test = new HashMap(16);

            test.Add("key1", "value1");
            test.Add("key2", "value2");
            test.Add("key3", "value3");
            test.Add("key4", "value4");

            Assert.Equal("value2", test.Get("key2"));
            Assert.Equal("value4", test.Get("key4"));
        }

        //Successfully returns null for a key that does not exist in the hashtable
        [Fact]
        public void HashMap3()
        {
            HashMap test = new HashMap(16);

            test.Add("key1", "value1");
            test.Add("key2", "value2");
            test.Add("key3", "value3");
            test.Add("key4", "value4");

            Assert.Null(test.Get("potatoes"));
            Assert.Null(test.Get("key7"));
        }

        //Successfully handle a collision within the hashtable
        [Fact]
        public void HashMap4()
        {
            HashMap test = new HashMap(16);

            test.Add("key1", "value1");
            test.Add("ey1k", "value2");
            test.Add("y1ke", "value3");
            test.Add("1key", "value4");

            Assert.NotNull(test.Get("y1ke"));
        }

        //Successfully retrieve a value from a bucket within the hashtable that has a collision
        [Fact]
        public void HashMap5()
        {
            HashMap test = new HashMap(16);

            test.Add("key1", "value1");
            test.Add("ey1k", "value2");
            test.Add("y1ke", "value3");
            test.Add("1key", "value4");

            Assert.Equal("value3", test.Get("y1ke"));
        }

        //Successfully hash a key to an in-range value
        [Fact]
        public void HashMap6()
        {
            HashMap test = new HashMap(16);

            int index = test.Hash("ATest");

            Assert.InRange<int>(index, 0, 15);
        }

    }
}

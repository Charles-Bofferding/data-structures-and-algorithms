using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures;
using Xunit;
using CodeChallenges.Code_Challenge_26;

namespace CodeChallengesTest
{
    public class Tests26
    {

        //Sorts Array Correctly
        [Fact]
        public void InsertionSort1()
        {
            //[8,4,23,42,16,15]
            int[] test = new int[] { 8, 4, 23, 42, 16, 15 };
            int[] result = new int[] { 4, 8, 15, 16, 23, 42 };

            Assert.Equal(result, Code_Challenge_26.InsertionSort(test));

        }

        //Sorts Array Correctly
        [Fact]
        public void InsertionSort2()
        {
            //[20,18,12,8,5,-2]
            int[] test = new int[] { 20, 18, 12, 8, 5, -2 };
            int[] result = new int[] { -2, 5, 8, 12, 18, 20 };

            Assert.Equal(result, Code_Challenge_26.InsertionSort(test));

        }

        //Sorts Array Correctly
        [Fact]
        public void InsertionSort3()
        {
            //[5,12,7,5,5,7]
            int[] test = new int[] { 5, 12, 7, 5, 5, 7 };
            int[] result = new int[] { 5, 5, 5, 7, 7, 12 };

            Assert.Equal(result, Code_Challenge_26.InsertionSort(test));

        }

        //Sorts Array Correctly
        [Fact]
        public void InsertionSort4()
        {
            //[2,3,5,7,13,11]
            int[] test = new int[] { 2, 3, 5, 7, 13, 11 };
            int[] result = new int[] { 2, 3, 5, 7, 11, 13 };

            Assert.Equal(result, Code_Challenge_26.InsertionSort(test));

        }

    }
}

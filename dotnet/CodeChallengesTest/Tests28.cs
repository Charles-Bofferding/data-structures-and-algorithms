using CodeChallenges.Code_Challenge_28;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CodeChallengesTest
{
    public class Tests28
    {


        //Sorts Even Sized Array Correctly
        [Fact]
        public void QuickSort1()
        {
            //[2,3,5,7,13,11]
            int[] test = new int[] { 2, 6, 9, 4, 3, 7, 1, 8, 10, 5 };
            int[] result = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Code_Challenge_28.QuickSort(test, 0, 9);

            Assert.Equal(result, test);
        }

        //length 1 array
        [Fact]
        public void QuickSort2()
        {
            //[2,3,5,7,13,11]
            int[] test = new int[] { 5 };
            int[] result = new int[] { 5 };

            Code_Challenge_28.QuickSort(test, 0, 0);

            Assert.Equal(result, test);
        }

        //length 2 array
        [Fact]
        public void QuickSort3()
        {
            //[2,3,5,7,13,11]
            int[] test = new int[] { 10, 5 };
            int[] result = new int[] { 5, 10 };

            Code_Challenge_28.QuickSort(test, 0, 1);

            Assert.Equal(result, test);
        }

    }
}

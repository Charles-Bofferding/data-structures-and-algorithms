using CodeChallenges.Code_Challenge_27;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CodeChallengesTest
{
    public class Tests27
    {

        //Sorts Even Sized Array Correctly
        [Fact]
        public void MergeSort1()
        {
            //[2,3,5,7,13,11]
            int[] test = new int[] { 2, 3, 5, 7, 13, 11 };
            int[] result = new int[] { 2, 3, 5, 7, 11, 13 };

            Code_Challenge_27.MergeSort(test);

            Assert.Equal(result, test);

        }

        //Sorts Small Array Correctly
        [Fact]
        public void MergeSort2()
        {
            //[12,5]
            int[] test = new int[] { 12,5 };
            int[] result = new int[] { 5, 12 };

            Code_Challenge_27.MergeSort(test);

            Assert.Equal(result, test);

        }

        //Sorts Odd sized Array Correctly
        [Fact]
        public void MergeSort3()
        {
            //[5, 4, 3, 2, 1]
            int[] test = new int[] { 5, 4, 3, 2, 1 };
            int[] result = new int[] { 1, 2, 3, 4, 5 };

            Code_Challenge_27.MergeSort(test);

            Assert.Equal(result, test);

        }

    }
}

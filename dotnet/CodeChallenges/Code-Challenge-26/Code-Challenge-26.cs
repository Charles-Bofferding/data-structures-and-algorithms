using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.Code_Challenge_26
{
    public class Code_Challenge_26
    {

    //    InsertionSort(int[] arr)
        public static int[] InsertionSort(int[] arr)
        {
            //Declaring out here to only have one variable created for all the loops
            int j;
            int temp;
            
            //FOR i = 1 to arr.length
            for(int i = 1; i < arr.Length; i++)
                {
                    j = i - 1;
                    temp = arr[i];

                    //  WHILE j >= 0 AND temp < arr[j]
                    while (j >= 0 && temp < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                    }

                    arr[j + 1] = temp;

                }

            return arr;

        }
    }
}

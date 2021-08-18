using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.Code_Challenge_27
{
    public class Code_Challenge_27
    {

        //ALGORITHM Mergesort(arr)
        public static void MergeSort(int[] arr)
        {
            int n = arr.Length;

            if (n > 1)
            {
                int mid = n / 2;
                int[] left = arr[0..mid];
                int[] right = arr[mid..n];

                MergeSort(left);

                MergeSort(right);

                Merge(left, right, arr);
            }
        }
        //    DECLARE n<-- arr.length

        //    if n > 1
        //      DECLARE mid <-- n/2
        //      DECLARE left <-- arr[0...mid]
        //      DECLARE right<-- arr[mid...n]
        //      // sort the left side
        //      Mergesort(left)
        //      // sort the right side
        //      Mergesort(right)
        //      // merge the sorted left and right sides together
        //      Merge(left, right, arr)

        public static void Merge(int[] left, int[] right, int[] arr)
        {
            int i = 0;
            int j = 0;
            int k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    arr[k] = left[i];
                    i++;
                }
                else
                {
                    arr[k] = right[j];
                    j++;
                }
                k++;
            }

            if (i == left.Length)
            {
                while (j < right.Length)
                {
                    arr[k] = right[j];
                    k++;
                    j++;
                }
            }
            else
            {
                while (i < left.Length)
                {
                    arr[k] = left[i];
                    k++;
                    i++;
                }
            }
        }
    }
}

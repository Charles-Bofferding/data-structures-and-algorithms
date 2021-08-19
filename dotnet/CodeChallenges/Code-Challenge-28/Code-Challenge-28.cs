using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.Code_Challenge_28
{
    public class Code_Challenge_28
    {

        /*
        ALGORITHM QuickSort(arr, left, right)
            if left<right
                // Partition the array by setting the position of the pivot value
                DEFINE position<-- Partition(arr, left, right)
               // Sort the left
               QuickSort(arr, left, position - 1)
                // Sort the right
                QuickSort(arr, position + 1, right)
        */
        static public void QuickSort(int[] arr, int left, int right)
        {
            //Bounding condition making sure that while left and right shift we never invert them or have them at the same index
            if (left < right)
            {
                // Perform a sort over the entire array and return the position where the pivot ended up
                int position = Partition(arr, left, right);

                // Now sort over about half of the array
                QuickSort(arr, left, position - 1);

                // Now sort over the other half
                QuickSort(arr, position + 1, right);
            }
        }

        /*
        ALGORITHM Partition(arr, left, right)
            // set a pivot value as a point of reference
            DEFINE pivot<-- arr[right]
            // create a variable to track the largest index of numbers lower than the defined pivot
            DEFINE low<-- left - 1
            for i<- left to right do
                if arr[i] <= pivot
                    low++
                    Swap(arr, i, low)

             // place the value of the pivot location in the middle.
             // all numbers smaller than the pivot are on the left, larger on the right.
             Swap(arr, right, low + 1)
            // return the pivot index point
             return low + 1
        */
        //Sort the array segment into values lower than a pivot target and values that are higher, and return where in the
        //the array that divide can be found
        public static int Partition(int[] arr, int left, int right)
        {
            //make the pivot value tha twe will sort against, if it was directly in the middle of the values
            //that would be best, but we are just kind of randomly saying it is the thing on the right
            int pivot = arr[right];

            //set up a pointer to find greatest location index with a value less than the stored pivot value
            int low = left - 1;

            //Looking over our selected area
            for(int i = left; i < right; i++ )
            {
                //If any location is smaller than the pivot swap that location to the right
                //Think about this step at a 2 size array
                if (arr[i] <= pivot)
                {
                    //We always increment low just before we use it 
                    low++;
                    //Swap the target index with index tracking values beneath the pivot
                    Swap(arr, i, low);
                }
            }

            //We always increment low just before we use it 
            //Move the pivot from the end to 1 space past the "lower than pivot" swap index
            Swap(arr, right, low + 1);
            return low + 1;
        }

        /*
        ALGORITHM Swap(arr, i, low)
            DEFINE temp;
                temp<-- arr[i]

                arr[i] <-- arr[low]

                arr[low] <-- temp
        */
        //Inside arr swap locations a and b
        public static void Swap(int[] arr, int a, int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }

    }
}

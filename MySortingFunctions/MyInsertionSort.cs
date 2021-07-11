/* Justin Gallagher
 * C# Practice
 * 07/10/2021 */

namespace MySortingFunctions
{
    class MyInsertionSort
    {
        /* InsertionSort takes an unsorted array and sorts it using the insertion sort algorithm.
        * This works by iterating over the unsorted array from indices 1 to the length of the array.
        * The current element in the loop is compared to the previous element. If the current element
        * is smaller than the one before it, then the current element is compared to the elements that
        * come before both the current and its previous starting from the beginning of the array. The
        * current element is repeatedly swapped with any elements it is less than until it is placed
        * in its proper spot.
        */
        public static void InsertionSort(int[] arr)
        {
            // initialize n as the length of the array - 1
            int n = arr.Length - 1;
            for (int i = 1; i <= n; i++) // loop over unsorted array from 1 to n
            {
                if (arr[i] < arr[i - 1]) // check if current key element is less than its predecessor
                {
                    for (int j = 0; j < i; j++) // loop over unsorted array from 0 to i
                    {
                        if (arr[i] < arr[j]) // if key element is less than element arr[j], then swap them
                        {
                            int temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }
            }
        }
    }
}

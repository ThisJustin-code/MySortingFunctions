/* Justin Gallagher
 * C# Practice
 * 07/10/2021 */

namespace MySortingFunctions
{
    class MySelectionSort
    {
        /* SelectionSort takes an unsorted array and sorts it using the selection sort algorithm.
         * This works by "splitting" the unsorted array into a sorted portion at the beginning and 
         * an unsorted portion at the end by finding minimun elements within the unsorted portion
         * and moving them to the beginning sorted portion.
         */
        public static void SelectionSort(int[] arr)
        {
            // initialize n as the length of the array - 1
            int n = arr.Length - 1;
            for (int i = 0; i < n; i++)  // loop over unsorted array
            {
                int min = i; // set min index to i
                for (int j = i + 1; j <= n; j++) // set j to i + 1 and loop over rest of unsorted array
                {
                    if (arr[j] < arr[min]) // if element at index j is less than the current min
                        min = j; // set min equal to index j
                }
                if (min != i) // if a new min index was found, swap the elements at those indices
                {
                    int temp = arr[min];
                    arr[min] = arr[i];
                    arr[i] = temp;
                }
            }
        }
    }
}

/* Justin Gallagher
 * C# Practice
 * 07/10/2021 */

namespace MySortingFunctions
{
    class MyBubbleSort
    {
        /* BubbleSort takes an unsorted array and sorts it using the bubble sort algorithm.
         * This works by repeatedly looping over the unsorted array comparing an element and
         * the one next to it. If the element next to the current element is smaller, then 
         * they are swapped. This continues until no more swaps have taken place and the array
         * is sorted.
         */
        public static void BubbleSort(int[] arr)
        {
            // initialize n as the length of the array - 1 and swaps as true
            int n = arr.Length - 1;
            bool swaps = true;
            while (swaps) // while swaps is true (while swaps are still being made)
            {
                // initialize count to 0 (counter variable)
                int count = 0;
                for (int i = 0; i < n; i++) // loop over entire unsorted array
                {
                    if (arr[i] > arr[i + 1]) // if the current element is larger than the next, then swap them
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        count += 1; //increment count
                    }
                }
                if (count == 0) // if count equals 0 (no swaps were made), set swaps to false
                {
                    swaps = false;
                }
            }
        }
    }
}

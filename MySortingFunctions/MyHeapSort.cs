/* Justin Gallagher
 * C# Practice
 * 07/12/2021 */

namespace MySortingFunctions
{
    class MyHeapSort
    {
        /* HeapSort is an array based heap sort where parent node at index i has
         * left child at index 2*i+1 and right child at index 2*i+2. 
         */
        public static void HeapSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = (n / 2) - 1; i >= 0; i--)
            {
                Heapify(arr, n, i);
            }

            for (int i = n - 1; i > 0; i--)
            {
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                Heapify(arr, i, 0);
            }
        }

        public static void Heapify(int[] arr, int n, int i)
        {
            int root = i;
            int leftChild = 2 * i + 1;
            int rightChild = 2 * i + 2;

            if (leftChild < n && arr[leftChild] > arr[root])
                root = leftChild;

            if (rightChild < n && arr[rightChild] > arr[root])
                root = rightChild;

            if (root != i)
            {
                int temp = arr[i];
                arr[i] = arr[root];
                arr[root] = temp;

                Heapify(arr, n, root);
            }
        }
    }
}

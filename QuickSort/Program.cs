using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 7, 8, 9, 1, 5 };
            int n = arr.Length;
            quickSort(arr, 0, n - 1);
            Console.WriteLine("sorted array ");
            printArray(arr, n);
        }

        static int partition(int[] arr, int low, int high)
        {
            #region Version 1
            int pivot = arr[high];

            // index of smaller element 
            int i = low;

            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than the pivot 
                if (arr[j] < pivot)
                {
                    // swap arr[i] and arr[j] 
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;

                    i++;
                }
            }

            // swap arr[i] and arr[high] (or pivot) 
            int temp1 = arr[i];
            arr[i] = arr[high];
            arr[high] = temp1;

            return i;
            #endregion

            #region Version 2
            //int pivot = arr[low];
            //int start = low;
            //int end = high;

            //while(start < end)
            //{
            //    while(arr[start] <= pivot && start < end)
            //    {
            //        start++;
            //    }

            //    while (arr[end] > pivot)
            //    {
            //        end--;
            //    }

            //    if(start < end)
            //    {
            //        int temp = arr[start];
            //        arr[start] = arr[end];
            //        arr[end] = temp;
            //    }
            //}

            //int tempp = arr[low];
            //arr[low] = arr[end];
            //arr[end] = tempp;

            //return end;
            #endregion
        }


        /* The main function that implements QuickSort() 
        arr[] --> Array to be sorted, 
        low --> Starting index, 
        high --> Ending index */
        static void quickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = partition(arr, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                quickSort(arr, low, pi - 1);
                quickSort(arr, pi + 1, high);
            }
        }

        static void printArray(int[] arr, int n)
        {
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");

            Console.WriteLine();
        }
    }
}
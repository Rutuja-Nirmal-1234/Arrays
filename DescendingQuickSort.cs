// Problem: Sort Array Elements in Descending Order (QuickSort - No Built-in Functions)

// Question:
// Write a program to sort the elements of an integer array in descending order
// without using any built-in sorting methods.

// Input:
// - An array of integers (e.g., [5, 2, 9, 1, 7])

// Output:
// - The array sorted in descending order

// Example:
// Input: [5, 2, 9, 1, 7]
// Output: [9, 7, 5, 2, 1]
//
// Input: [3, -1, 4, -2]
// Output: [4, 3, -1, -2]

// Notes:
// - QuickSort is a divide-and-conquer algorithm.
// - Partition step places elements greater than pivot to the left (for descending order).
// - Then recursively sort left and right subarrays.

// Complexity:
// Time Complexity: O(n log n) on average, O(n²) in worst case
// Space Complexity: O(log n) due to recursion stack

using System;

public class DescendingQuickSort
{
    public static void Main(string[] args)
    {
        Console.Write("Enter array elements separated by space: ");
        string[] input = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(input, int.Parse);

        QuickSort(arr, 0, arr.Length - 1);

        Console.WriteLine("Sorted Array (Descending): " + string.Join(" ", arr));
    }

    static void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(arr, low, high);

            QuickSort(arr, low, pivotIndex - 1);
            QuickSort(arr, pivotIndex + 1, high);
        }
    }

    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            // For descending, place larger elements on the left
            if (arr[j] > pivot)
            {
                i++;
                Swap(arr, i, j);
            }
        }

        Swap(arr, i + 1, high);
        return i + 1;
    }

    static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}

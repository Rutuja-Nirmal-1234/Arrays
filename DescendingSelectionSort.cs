// Problem: Sort Array Elements in Descending Order (Selection Sort - No Built-in Functions)

// Question:
// Write a program to sort the elements of an integer array in descending order
// without using any built-in sorting methods. Use Selection Sort.

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
// - In each iteration, find the maximum element in the unsorted part of the array
//   and place it at the current position.
// - This approach is simple but not efficient for large arrays.

// Complexity:
// Time Complexity: O(n²) (two nested loops)
// Space Complexity: O(1) (in-place sorting)

using System;

public class DescendingSelectionSort
{
    public static void Main(string[] args)
    {
        Console.Write("Enter array elements separated by space: ");
        string[] input = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(input, int.Parse);

        SelectionSortDescending(arr);

        Console.WriteLine("Sorted Array (Descending): " + string.Join(" ", arr));
    }

    static void SelectionSortDescending(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int maxIndex = i;

            // Find maximum in the remaining unsorted array
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] > arr[maxIndex])
                {
                    maxIndex = j;
                }
            }

            // Swap current element with maximum
            int temp = arr[i];
            arr[i] = arr[maxIndex];
            arr[maxIndex] = temp;
        }
    }
}

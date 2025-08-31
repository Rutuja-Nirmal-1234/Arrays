// Problem: Merge Two Sorted Arrays

// Question:
// Given two sorted arrays `arr1` and `arr2`, merge them into a single sorted array.
// The result should also be in ascending order.

// Input:
// First line contains size of first array `n1`
// Next line contains `n1` integers (first sorted array)
// Next line contains size of second array `n2`
// Next line contains `n2` integers (second sorted array)

// Output:
// Print the merged sorted array

// Example:
// Input: arr1 = [1, 3, 5], arr2 = [2, 4, 6]
// Output: [1, 2, 3, 4, 5, 6]
// Explanation: All elements from both arrays are merged in sorted order

// Complexity:
// Time Complexity: O(n1 + n2)  (single pass through both arrays)
// Space Complexity: O(n1 + n2) (for storing merged array)

using System;
using System.Collections.Generic;

public class MergeSortedArrays
{
    static int[] Merge(int[] arr1, int[] arr2)
    {
        int n1 = arr1.Length, n2 = arr2.Length;
        int i = 0, j = 0;
        List<int> merged = new List<int>();

        while (i < n1 && j < n2)
        {
            if (arr1[i] <= arr2[j])
            {
                merged.Add(arr1[i]);
                i++;
            }
            else
            {
                merged.Add(arr2[j]);
                j++;
            }
        }

        // Add remaining elements
        while (i < n1) merged.Add(arr1[i++]);
        while (j < n2) merged.Add(arr2[j++]);

        return merged.ToArray();
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter size of first sorted array: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        int[] arr1 = new int[n1];
        for (int i = 0; i < n1; i++)
        {
            Console.Write($"Enter element {i+1} of first array: ");
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Enter size of second sorted array: ");
        int n2 = Convert.ToInt32(Console.ReadLine());
        int[] arr2 = new int[n2];
        for (int i = 0; i < n2; i++)
        {
            Console.Write($"Enter element {i+1} of second array: ");
            arr2[i] = Convert.ToInt32(Console.ReadLine());
        }

        int[] merged = Merge(arr1, arr2);
        Console.WriteLine("Merged Sorted Array: " + string.Join(" ", merged));
    }
}

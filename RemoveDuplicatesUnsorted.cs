// Problem: Remove Duplicates from an Unsorted Array

// Question:
// Given an unsorted integer array `arr`, remove all duplicates and return a new array containing only unique elements.
// The relative order of first occurrences should be preserved.
//
// This solution uses a HashSet to track seen elements.

// Input:
// First line contains size of array `n`
// Next line contains `n` integers (array elements)

// Output:
// Print the array after removing duplicates

// Example:
// Input: arr = [4,5,2,4,2,3]
// Output: [4,5,2,3]
// Explanation: All duplicates are removed, preserving first occurrence order.

// Complexity:
// Time Complexity: O(n)  (iterate through array once)
// Space Complexity: O(n)  (for HashSet and result list)

using System;
using System.Collections.Generic;

public class RemoveDuplicatesUnsorted
{
    // Function to remove duplicates from unsorted array
    static int[] RemoveDuplicates(int[] arr)
    {
        HashSet<int> seen = new HashSet<int>();
        List<int> result = new List<int>();

        foreach (int num in arr)
        {
            if (!seen.Contains(num))
            {
                seen.Add(num);
                result.Add(num);
            }
        }

        return result.ToArray();
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter size of array: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter element {i+1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        int[] result = RemoveDuplicates(arr);

        Console.WriteLine("Array after removing duplicates: " + string.Join(" ", result));
    }
}

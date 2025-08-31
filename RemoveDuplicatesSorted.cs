// Problem: Remove Duplicates from Sorted Array

// Question:
// Given a sorted integer array `arr`, remove the duplicates in-place such that each element appears only once 
// and return the new length. The relative order of the elements should be kept the same.
//
// Do not allocate extra space for another array; you must do this by modifying the input array in-place with O(1) extra memory.

// Input:
// First line contains size of array `n`
// Next line contains `n` integers (sorted array elements)

// Output:
// Print the array after removing duplicates (only first `newLength` elements are valid)

// Example:
// Input: arr = [1,1,2]
// Output: [1,2]
// Explanation: Unique elements are [1,2], so new length is 2.
//
// Input: arr = [0,0,1,1,1,2,2,3,3,4]
// Output: [0,1,2,3,4]

// Complexity:
// Time Complexity: O(n)   (single pass through the array)
// Space Complexity: O(1)  (in-place modification)

using System;

public class RemoveDuplicatesSorted
{
    // Function to remove duplicates from sorted array
    static int RemoveDuplicates(int[] arr)
    {
        if (arr.Length == 0) return 0;

        int j = 0; // index of last unique element

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] != arr[j])
            {
                j++;
                arr[j] = arr[i];
            }
        }
        return j + 1; // new length after removing duplicates
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

        int newLength = RemoveDuplicates(arr);

        Console.Write("Array after removing duplicates: ");
        for (int i = 0; i < newLength; i++)
            Console.Write(arr[i] + " ");
    }
}

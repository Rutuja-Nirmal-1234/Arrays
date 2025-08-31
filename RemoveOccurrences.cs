// Problem: Remove All Occurrences of a Value from an Array

// Question:
// Given an integer array `arr` and an integer `val`, remove all occurrences of `val` in `arr` in-place.
// The relative order of the other elements may be changed. Return the new length of the array after removal.
//
// Do not allocate extra space for another array; you must do this by modifying the input array in-place.

// Input:
// First line contains size of array `n`
// Next line contains `n` integers (array elements)
// Last line contains the value `val` to remove

// Output:
// Print the new array after removing all occurrences of `val` (only first `newLength` elements are valid)

// Example:
// Input: arr = [3,2,2,3], val = 3
// Output: [2,2]

// Explanation:
// After removing all occurrences of 3, the array becomes [2,2]

// Complexity:
// Time Complexity: O(n)  (single pass through the array)
// Space Complexity: O(1) (in-place modification)

using System;

public class RemoveOccurrences
{
    // Function to remove all occurrences of a given value
    static int RemoveElement(int[] arr, int val)
    {
        int k = 0; // position to place next non-val element

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != val)
            {
                arr[k] = arr[i];
                k++;
            }
        }
        return k; // new length after removal
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

        Console.Write("Enter value to remove: ");
        int val = Convert.ToInt32(Console.ReadLine());

        int newLength = RemoveElement(arr, val);

        Console.Write("Array after removing occurrences: ");
        for (int i = 0; i < newLength; i++)
            Console.Write(arr[i] + " ");
    }
}

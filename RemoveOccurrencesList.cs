// Problem: Remove All Occurrences of a Value from an Array (Using List)

// Question:
// Given an integer array `arr` and an integer `val`, remove all occurrences of `val` in `arr` using a List.
// Return the new array/list without the value `val`.

// Input:
// First line contains size of array `n`
// Next line contains `n` integers (array elements)
// Last line contains the value `val` to remove

// Output:
// Print the array after removing all occurrences of `val`

// Example:
// Input: arr = [3,2,2,3], val = 3
// Output: [2,2]
// Explanation: All occurrences of 3 are removed from the array

// Complexity:
// Time Complexity: O(n)  (single pass to remove elements from list)
// Space Complexity: O(n)  (for the List storing elements)

using System;
using System.Collections.Generic;

public class RemoveOccurrencesList
{
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

        List<int> list = new List<int>(arr); // convert array to list
        list.RemoveAll(x => x == val);       // remove all occurrences

        Console.WriteLine("Array after removing occurrences: " + string.Join(" ", list));
    }
}

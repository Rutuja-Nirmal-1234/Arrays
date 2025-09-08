// Problem: Sort Array Elements in Descending Order (Using Built-in Functions)

// Question:
// Write a program to sort the elements of an integer array in descending order.
// Use built-in sorting methods (Array.Sort + Array.Reverse).

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
// - Array.Sort() sorts the array in ascending order.
// - Array.Reverse() then reverses it to descending order.
// - This is the best and most efficient way if built-in functions are allowed.

// Complexity:
// Time Complexity: O(n log n) (due to Array.Sort)
// Space Complexity: O(1) (in-place sorting)

using System;

public class DescendingSortArrayBuiltin
{
    public static void Main(string[] args)
    {
        Console.Write("Enter array elements separated by space: ");
        string[] input = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(input, int.Parse);

        // Built-in sorting
        Array.Sort(arr);     // Ascending
        Array.Reverse(arr);  // Convert to Descending

        Console.WriteLine("Sorted Array (Descending): " + string.Join(" ", arr));
    }
}

// Problem: Find the Maximum Element in an Array

// Question:
// Write a program to find the maximum element in a given integer array.

// Input:
// - An array of integers (e.g., [5, 7, 2, 9, 1])

// Output:
// - The maximum element in the array

// Example:
// Input: [5, 7, 2, 9, 1]
// Output: 9
//
// Input: [-3, -7, -1, -9]
// Output: -1

// Notes:
// - Traverse through the array and keep track of the maximum value.
// - Update the maximum whenever a larger element is found.

// Complexity:
// Time Complexity: O(n) (where n = number of elements in array)
// Space Complexity: O(1)

// Approach:
// - Initialize max with the first element of the array
// - Loop through the array and compare each element with max
// - Update max if current element is greater

using System;

public class MaxElementInArray
{
    public static void Main(string[] args)
    {
        Console.Write("Enter array elements separated by space: ");
        string[] input = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(input, int.Parse);

        int max = FindMax(arr);
        Console.WriteLine("Maximum Element: " + max);
    }

    public static int FindMax(int[] arr)
    {
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
                max = arr[i];
        }
        return max;
    }
}

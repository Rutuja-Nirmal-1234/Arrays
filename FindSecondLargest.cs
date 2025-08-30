// Problem: Find the Second Largest Element in an Array

// Question:
// Write a C# program to find the second largest element in an array.
//
// Input:
// First line contains size of array `n`
// Next line contains `n` integers (array elements)
//
// Output:
// Print the second largest element

// Example:
// Input: n = 6, arr = [12, 35, 1, 10, 34, 1]
// Output: 34

// Notes:
// If all elements are equal or array size < 2, then "second largest" does not exist.

// Complexity:
// Time Complexity: O(n)
// Space Complexity: O(1)

using System;

public class ArrayProblems
{
    // Function to find second largest element
    public static int FindSecondLargest(int[] arr)
    {
        int first = int.MinValue, second = int.MinValue;

        foreach (int num in arr)
        {
            if (num > first)
            {
                second = first;
                first = num;
            }
            else if (num > second && num < first)
            {
                second = num;
            }
        }

        return second;
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter size of array: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter element {i + 1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        int result = FindSecondLargest(arr);

        if (result == int.MinValue)
            Console.WriteLine("Second Largest Element does not exist.");
        else
            Console.WriteLine("Second Largest Element: " + result);
    }
}

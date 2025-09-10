// Problem: Find the Second Smallest Element in an Array (using Sorting)

// Question:
// Write a C# program to find the second smallest element in an array.

// Input:
// First line contains size of array `n`
// Next line contains `n` integers (array elements)
      
// Output:
// Print the second smallest element

// Example:
// Input: n = 6, arr = [12, 35, 1, 10, 34, 1]
// Output: 10

// Notes:
// If all elements are equal or array size < 2, then "second smallest" does not exist.
// This solution uses Array.Sort().

// Complexity:
// Time Complexity: O(n log n)  
// Space Complexity: O(1) 
     

using System;

public class SecondSmallest
{
    // Function to find second smallest element using sorting
    static int FindSecondSmallest(int[] arr)
    {
        Array.Sort(arr); // Sort array in ascending order

        // Find first element different from arr[0]
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] != arr[0])
                return arr[i];
        }

        return -1; // No second smallest exists
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

        int result = FindSecondSmallest(arr);

        if (result == -1)
            Console.WriteLine("Second smallest element does not exist.");
        else
            Console.WriteLine("Second smallest element: " + result);
    }
}

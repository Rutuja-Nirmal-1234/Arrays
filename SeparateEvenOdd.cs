// Problem: Separate Even and Odd Numbers in an Array with Counts

// Question:
// Write a program to separate even and odd numbers from a predefined array,
// and display both the count and the actual numbers for each category.

// Input:
// Predefined array in code (can be modified)

// Output:
// Count of even numbers
// Count of odd numbers
// Even numbers list
// Odd numbers list

// Example:
// Input: arr = { 3, 2, 2, 6, 8, 7, 9 }
// Output:
// Count of even numbers: 4
// Count of odd numbers: 3
// Even numbers: 2, 2, 6, 8
// Odd numbers: 3, 7, 9

// Notes:
// Traverse the array, separate numbers into even and odd lists,
// then display counts and elements.

// Complexity:
// Time Complexity: O(n)  (each element visited once)
// Space Complexity: O(n)  (for storing even and odd numbers)

using System;
using System.Collections.Generic;

public class SeparateEvenOddWithCount
{
    public static void Main(string[] args)
    {
        int[] arr = { 3, 2, 2, 6, 8, 7, 9 };

        List<int> even = new List<int>();
        List<int> odd = new List<int>();

        // Separate even and odd numbers
        foreach (int num in arr)
        {
            if (num % 2 == 0)
                even.Add(num);
            else
                odd.Add(num);
        }

        // Display counts
        Console.WriteLine("Count of even numbers: " + even.Count);
        Console.WriteLine("Count of odd numbers: " + odd.Count);

        // Display the actual numbers
        Console.WriteLine("Even numbers: " + string.Join(", ", even));
        Console.WriteLine("Odd numbers: " + string.Join(", ", odd));
    }
}

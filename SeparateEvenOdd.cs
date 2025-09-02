// Problem: Separate Even and Odd Numbers in an Array

// Question:
// Write a program to take an array of integers from the user
// and separate the even and odd numbers, displaying them separately.

// Input:
// First line: integer n (size of array)
// Next n lines: array elements

// Output:
// Even numbers and odd numbers displayed separately

// Example:
// Input: [1, 2, 3, 4, 5, 6]
// Output:
// Even Numbers: 2 4 6
// Odd Numbers: 1 3 5

// Notes:
// Traverse the array once, check each number with modulus operator,
// and categorize into even and odd.

// Complexity:
// Time Complexity: O(n)  (each element checked once)
// Space Complexity: O(n)  (for storing even and odd arrays)

using System;
using System.Collections.Generic;

public class SeparateEvenOdd
{
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

        List<int> even = new List<int>();
        List<int> odd = new List<int>();

        foreach (int num in arr)
        {
            if (num % 2 == 0)
                even.Add(num);
            else
                odd.Add(num);
        }

        Console.WriteLine("Even Numbers: " + string.Join(" ", even));
        Console.WriteLine("Odd Numbers: " + string.Join(" ", odd));
    }
}

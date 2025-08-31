// Problem: Find Array Leaders

// Question:
// An element of array `arr` is called a leader if it is strictly greater than all the elements to its right.
// Write a C# program to find all leaders in the array and return them in the same order as they appear in the array.

// Input:
// First line contains size of array `n`
// Next line contains `n` integers (array elements)

// Output:
// Print all leaders in the array

// Example:
// Input: arr = [16, 17, 4, 3, 5, 2]
// Output: [17, 5, 2]
// Explanation: 17 is greater than all elements to its right, 5 is greater than 2, and 2 is last element (leader)

// Complexity:
// Time Complexity: O(n)  (single pass from right to left)
// Space Complexity: O(n)  (for storing leaders in a list)

using System;
using System.Collections.Generic;

public class ArrayLeaders
{
    static int[] FindLeaders(int[] arr)
    {
        int n = arr.Length;
        List<int> leaders = new List<int>();
        int maxFromRight = arr[n - 1];

        leaders.Add(maxFromRight);

        for (int i = n - 2; i >= 0; i--)
        {
            if (arr[i] > maxFromRight)
            {
                leaders.Add(arr[i]);
                maxFromRight = arr[i];
            }
        }

        leaders.Reverse(); // to maintain original order
        return leaders.ToArray();
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

        int[] result = FindLeaders(arr);

        Console.WriteLine("Array Leaders: " + string.Join(" ", result));
    }
}

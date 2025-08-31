// Problem: Find Missing Number in an Array from 1 to N

// Question:
// Given an array containing n-1 integers in the range from 1 to n (inclusive) with no duplicates,
// find the missing number in the array.

// Input:
// First line contains integer `n` (size of complete range 1..n)
// Next line contains `n-1` integers (array elements)

// Output:
// Print the missing number

// Example:
// Input: n = 5, arr = [1, 2, 3, 5]
// Output: 4
// Explanation: Numbers from 1 to 5 are expected, 4 is missing

// Complexity:
// Time Complexity: O(n)  (single pass to sum array elements)
// Space Complexity: O(1)  (no extra space except variables)

using System;

public class MissingNumber
{
    static int FindMissingNumber(int[] arr, int n)
    {
        int totalSum = n * (n + 1) / 2;
        int arrSum = 0;

        foreach (int num in arr)
            arrSum += num;

        return totalSum - arrSum;
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter the value of n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write($"Enter {n-1} elements of array: ");
        int[] arr = new int[n - 1];
        for (int i = 0; i < n - 1; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        int missing = FindMissingNumber(arr, n);
        Console.WriteLine("Missing Number is: " + missing);
    }
}

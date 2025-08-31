// Problem: Find Missing Number in an Array from 1 to N (using XOR)

// Question:
// Given an array containing n-1 integers in the range from 1 to n (inclusive) with no duplicates,
// find the missing number using XOR approach.

// Input:
// First line contains integer `n` (size of complete range 1..n)
// Next line contains `n-1` integers (array elements)

// Output:
// Print the missing number

// Example:
// Input: n = 5, arr = [1, 2, 3, 5]
// Output: 4
// Explanation: Numbers from 1 to 5 are expected, 4 is missing

// Notes:
// XOR of all numbers from 1 to n with XOR of array elements gives the missing number.

// Complexity:
// Time Complexity: O(n)  (single pass to XOR all numbers)
// Space Complexity: O(1)  (no extra space except variables)

using System;

public class MissingNumberXOR
{
    static int FindMissingNumber(int[] arr, int n)
    {
        int xor1 = 0; // XOR of numbers from 1 to n
        int xor2 = 0; // XOR of array elements

        for (int i = 1; i <= n; i++)
            xor1 ^= i;

        foreach (int num in arr)
            xor2 ^= num;

        return xor1 ^ xor2; // missing number
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

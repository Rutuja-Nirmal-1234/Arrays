// Problem: Find Majority Element using Moore’s Voting Algorithm

// Question:
// Given an array of size n, find the majority element. 
// A majority element is an element that appears more than n/2 times in the array.
// If no majority element exists, indicate accordingly.

// Input:
// First line contains integer `n` (size of array)
// Next line contains `n` integers (array elements)

// Output:
// Print the majority element or a message if it does not exist

// Example:
// Input: n = 7, arr = [2, 2, 1, 1, 2, 2, 3]
// Output: 2
// Explanation: 2 appears 4 times > 7/2

// Notes:
// Moore’s Voting Algorithm works in O(n) time and O(1) space

// Complexity:
// Time Complexity: O(n)
// Space Complexity: O(1)

using System;

public class MooreVoting
{
    static int FindMajorityElement(int[] arr)
    {
        int candidate = -1, count = 0;

        // Phase 1: Find a candidate
        foreach (int num in arr)
        {
            if (count == 0)
            {
                candidate = num;
                count = 1;
            }
            else if (num == candidate)
                count++;
            else
                count--;
        }

        // Phase 2: Verify candidate
        count = 0;
        foreach (int num in arr)
        {
            if (num == candidate)
                count++;
        }

        return (count > arr.Length / 2) ? candidate : -1;
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

        int majority = FindMajorityElement(arr);

        if (majority == -1)
            Console.WriteLine("No majority element exists.");
        else
            Console.WriteLine("Majority Element: " + majority);
    }
}

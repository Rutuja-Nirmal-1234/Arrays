// Problem: Single Number

// Question:
// Given a non-empty array of integers, every element appears twice except for one. 
// Find that single one.

// Input:
// First line contains size of array `n`
// Next line contains `n` integers (array elements)
      
// Output:
// Print the single number that appears only once

// Example:
// Input: n = 5, nums = [4, 1, 2, 1, 2]
// Output: 4

// Notes:
// You must implement a solution with linear runtime complexity 
// and use only constant extra space.
// This solution uses XOR operation.

// Complexity:
// Time Complexity: O(n)  
// Space Complexity: O(1)      

using System;

public class SingleNumberExample
{
    // Function to find the single number using XOR
    static int FindSingleNumber(int[] nums)
    {
        int result = 0;
        foreach (int num in nums)
        {
            result ^= num;  // XOR cancels out duplicates
        }
        return result;
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter size of array: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] nums = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter element {i + 1}: ");
            nums[i] = Convert.ToInt32(Console.ReadLine());
        }

        int result = FindSingleNumber(nums);
        Console.WriteLine("Single Number is: " + result);
    }
}

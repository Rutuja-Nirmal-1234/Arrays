// Problem: Two Sum

// Question:
// Given an array of integers nums and an integer target, return indices of the two numbers 
// such that they add up to the target.

// Input:
// nums = [2, 7, 11, 15], target = 9

// Output:
// [0, 1]

// Explanation:
// nums[0] + nums[1] = 2 + 7 = 9

// Approach:
// - Use a HashMap (Dictionary in C#) to store visited numbers with their indices.
// - For each element, check if (target - nums[i]) exists in the map.
// - If yes, return indices of current element and its complement.
// - Otherwise, add the current number into the map.

// Complexity:
// Time Complexity: O(n)
// Space Complexity: O(n)

using System;
using System.Collections.Generic;

public class TwoSumExample
{
    static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (map.ContainsKey(complement))
            {
                return new int[] { map[complement], i }; // indices found
            }
            if (!map.ContainsKey(nums[i])) // avoid duplicate overwrite
            {
                map[nums[i]] = i;
            }
        }
        return new int[] { -1, -1 }; // if no pair found
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter size of array: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] nums = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter element {i+1}: ");
            nums[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Enter target: ");
        int target = Convert.ToInt32(Console.ReadLine());

        int[] result = TwoSum(nums, target);

        if (result[0] == -1)
            Console.WriteLine("No two sum solution found.");
        else
            Console.WriteLine($"Indices: [{result[0]}, {result[1]}]");
    }
}

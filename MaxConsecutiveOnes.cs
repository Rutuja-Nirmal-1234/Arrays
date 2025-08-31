// Problem: Find the Maximum Number of Consecutive 1s in a Binary Array

// Question:
// Write a C# program to find the maximum number of consecutive 1s in a binary array.

// Input:
// First line: size of array n
// Next line: n elements (0s and 1s only)

// Output:
// Print the maximum number of consecutive 1s

// Example 1:
// Input: n = 6, arr = [1, 1, 0, 1, 1, 1]
// Output: 3

// Example 2:
// Input: n = 5, arr = [0, 0, 0, 0, 0]
// Output: 0

// Notes:
// Array will only contain 0s and 1s.
// If no 1s exist, the answer is 0.

// Complexity:
// Time Complexity: O(n)
// Space Complexity: O(1)

using System;

public class MaxConsecutiveOnes
{
    // Function to find max consecutive 1s
    static int FindMaxConsecutiveOnes(int[] arr)
    {
        int maxCount = 0, currentCount = 0;

        foreach (int num in arr)
        {
            if (num == 1)
            {
                currentCount++;
                if (currentCount > maxCount)
                    maxCount = currentCount;
            }
            else
            {
                currentCount = 0; // reset when 0 is encountered
            }
        }
        return maxCount;
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter size of array: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter {i + 1} element (0/1): ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        int result = FindMaxConsecutiveOnes(arr);
        Console.WriteLine("Max consecutive ones: " + result);
    }
}

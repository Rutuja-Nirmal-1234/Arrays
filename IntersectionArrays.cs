// Problem: Intersection of Two Arrays II

// Question:
// Given two integer arrays nums1 and nums2, return an array of their intersection.
// Each element in the result should appear as many times as it shows in both arrays.
// The result can be returned in any order.

// Input:
// First line contains size of first array `n1`
// Next line contains `n1` integers (array elements of nums1)
// Next line contains size of second array `n2`
// Next line contains `n2` integers (array elements of nums2)

// Output:
// Print the intersection array elements

// Example:
// Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
// Output: [4,9]

// Notes:
// This solution uses a Dictionary to count frequencies of elements in nums1.
// Then, it iterates nums2 to find matches and decrements the frequency.

// Complexity:
// Time Complexity: O(n1 + n2)  
// Space Complexity: O(min(n1, n2))      

using System;
using System.Collections.Generic;

public class IntersectionArrays
{
    // Function to find intersection of two arrays
    static int[] Intersect(int[] nums1, int[] nums2)
    {
        Dictionary<int, int> freq = new Dictionary<int, int>();
        List<int> result = new List<int>();

        // Count frequency of nums1
        foreach (int num in nums1)
        {
            if (freq.ContainsKey(num))
                freq[num]++;
            else
                freq[num] = 1;
        }

        // Check nums2
        foreach (int num in nums2)
        {
            if (freq.ContainsKey(num) && freq[num] > 0)
            {
                result.Add(num);
                freq[num]--; // reduce frequency
            }
        }

        return result.ToArray();
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter size of first array: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        int[] nums1 = new int[n1];
        for (int i = 0; i < n1; i++)
        {
            Console.Write($"Enter element {i+1} of first array: ");
            nums1[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Enter size of second array: ");
        int n2 = Convert.ToInt32(Console.ReadLine());
        int[] nums2 = new int[n2];
        for (int i = 0; i < n2; i++)
        {
            Console.Write($"Enter element {i+1} of second array: ");
            nums2[i] = Convert.ToInt32(Console.ReadLine());
        }

        int[] result = Intersect(nums1, nums2);
        Console.WriteLine("Intersection: " + string.Join(", ", result));
    }
}

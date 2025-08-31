// Problem: Intersection of Two Arrays II (Two Pointer Approach)

// Question:
// Given two integer arrays nums1 and nums2, return an array of their intersection.
// Each element in the result should appear as many times as it shows in both arrays.
// The result can be returned in any order.
//
// Here we use sorting + two-pointer technique to find the intersection.

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
// 1. First sort both arrays.
// 2. Use two pointers (i, j) to traverse arrays simultaneously.
// 3. If elements match → add to result and move both pointers.
// 4. If nums1[i] < nums2[j] → increment i else increment j.

// Complexity:
// Time Complexity: O(n1 log n1 + n2 log n2)  (due to sorting)
// Space Complexity: O(1) extra (excluding output array)

using System;
using System.Collections.Generic;

public class IntersectionArraysTwoPointer
{
    // Function to find intersection using sorting + two pointers
    static int[] Intersect(int[] nums1, int[] nums2)
    {
        Array.Sort(nums1);
        Array.Sort(nums2);

        List<int> result = new List<int>();
        int i = 0, j = 0;

        while (i < nums1.Length && j < nums2.Length)
        {
            if (nums1[i] == nums2[j])
            {
                result.Add(nums1[i]);
                i++; j++;
            }
            else if (nums1[i] < nums2[j])
                i++;
            else
                j++;
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

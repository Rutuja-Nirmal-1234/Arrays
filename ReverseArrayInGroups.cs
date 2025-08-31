// Problem: Reverse Array in Groups

// Question:
// Given an array, the task is to reverse the array in groups of size k.

// Input:
// First line: size of array n
// Next line: n integers
// Last line: integer k (group size)

// Output:
// Array after reversing elements in groups of size k

// Example 1:
// Input: n = 5, arr = [1, 2, 3, 4, 5], k = 3
// Output: [3, 2, 1, 5, 4]

// Example 2:
// Input: n = 8, arr = [1, 2, 3, 4, 5, 6, 7, 8], k = 4
// Output: [4, 3, 2, 1, 8, 7, 6, 5]

// Notes:
// If the last group has less than k elements, reverse whatever is remaining.
// This is a common interview problem asked to check array manipulation skills.

// Complexity:
// Time Complexity: O(n)
// Space Complexity: O(1)

using System;

public class ReverseArrayInGroups
{
    // Function to reverse array in groups of size k
    static void ReverseInGroups(int[] arr, int k)
    {
        for (int i = 0; i < arr.Length; i += k)
        {
            int left = i;
            int right = Math.Min(i + k - 1, arr.Length - 1);

            // Reverse current group
            while (left < right)
            {
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
                left++;
                right--;
            }
        }
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter size of array: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter {i + 1} element: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Enter group size k: ");
        int k = Convert.ToInt32(Console.ReadLine());

        ReverseInGroups(arr, k);

        Console.WriteLine("Array after reversing in groups: " + string.Join(" ", arr));
    }
}

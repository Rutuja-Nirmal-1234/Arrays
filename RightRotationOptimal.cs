// Problem: Right Rotation of an Array by K Elements (Optimal In-place Solution)

// Question:
// Write a program to rotate the elements of an array to the right by K positions
// using an in-place algorithm with O(1) extra space.

// Input:
// - An array of integers (e.g., [1, 2, 3, 4, 5])
// - An integer K (number of rotations)

// Output:
// - The rotated array after shifting elements K times to the right

// Example:
// Input: [1, 2, 3, 4, 5], K = 2
// Output: [4, 5, 1, 2, 3]
//
// Input: [10, 20, 30, 40, 50], K = 3
// Output: [30, 40, 50, 10, 20]

// Notes:
// - Right rotation by K means last K elements move to the front.
// - We use the reversal algorithm:
//   1. Reverse the entire array
//   2. Reverse the first K elements
//   3. Reverse the remaining elements

// Complexity:
// Time Complexity: O(n) (each element reversed at most twice)
// Space Complexity: O(1) (in-place rotation)

using System;

public class RightRotationOptimal
{
    public static void Main(string[] args)
    {
        Console.Write("Enter array elements separated by space: ");
        string[] input = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(input, int.Parse);

        Console.Write("Enter K (number of rotations): ");
        int k = int.Parse(Console.ReadLine());

        int n = arr.Length;
        k = k % n; // Handle K > n

        // Step 1: Reverse whole array
        Reverse(arr, 0, n - 1);

        // Step 2: Reverse first K elements
        Reverse(arr, 0, k - 1);

        // Step 3: Reverse remaining elements
        Reverse(arr, k, n - 1);

        Console.WriteLine("Array after Right Rotation: " + string.Join(" ", arr));
    }

    static void Reverse(int[] arr, int left, int right)
    {
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

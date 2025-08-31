// Problem: Convert Array to Wave Form

// Question:
// Rearrange the array elements into a wave-like fashion.
// For an array arr[], the wave condition is:
// arr[0] >= arr[1] <= arr[2] >= arr[3] <= arr[4] ...

// Input: arr = [10, 90, 49, 2, 1, 5, 23]
// Output: [90, 10, 49, 2, 5, 1, 23]

// Explanation:
// - First element >= second
// - Second <= third
// - Third >= fourth, and so on...

// Notes:
// - Only swapping adjacent pairs is needed.
// - Sorting before swapping ensures lexicographically smallest wave array.

// Complexity:
// Time Complexity: O(n)
// Space Complexity: O(1)

using System;

public class WaveArray
{
    static void ConvertToWave(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i += 2)
        {
            // Swap arr[i] and arr[i+1]
            int temp = arr[i];
            arr[i] = arr[i + 1];
            arr[i + 1] = temp;
        }
    }

    public static void Main(string[] args)
    {
        int[] arr = { 10, 90, 49, 2, 1, 5, 23 };

        Console.WriteLine("Original Array: " + string.Join(" ", arr));

        ConvertToWave(arr);

        Console.WriteLine("Wave Array: " + string.Join(" ", arr));
    }
}

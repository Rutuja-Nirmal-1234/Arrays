// Problem: Reverse an Array

// Question:
// Write a program to reverse an array in place without using any extra array.

// Input:
// An array of size n

// Output:
// The reversed array

// Example:
// Input: arr = [1, 2, 3, 4, 5]
// Output: [5, 4, 3, 2, 1]
     
// Notes:
// Reversal should be done in place (O(1) extra space).
// Commonly asked in interviews as the base of many rotation/2-pointer problems.

// Complexity:
// Time Complexity: O(n)
// Space Complexity: O(1)

using System;

public class ReverseArray
{
    // Function to reverse array in place
    static void Reverse(int[] arr)
    {
        int left = 0, right = arr.Length - 1;

        while (left < right)
        {
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;
            left++;
            right--;
        }
    }

    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Original Array: " + string.Join(" ", arr));

        Reverse(arr);

        Console.WriteLine("Reversed Array: " + string.Join(" ", arr));
    }
}

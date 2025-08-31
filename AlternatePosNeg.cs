// Problem: Rearrange Array in Alternating Positive and Negative Numbers

// Question:
// Given an array `arr` of positive and negative numbers, rearrange the array such that positive and negative numbers alternate.
// Relative order of elements may be changed. If extra positive or negative numbers exist, they appear at the end.

// Input:
// First line contains size of array `n`
// Next line contains `n` integers (array elements)

// Output:
// Print the array after rearranging in alternating positive and negative order

// Example:
// Input: arr = [1, 2, 3, -4, -1, 4]
// Output: [1, -4, 2, -1, 3, 4]
// Explanation: Positive and negative numbers alternate. Extra positive numbers are at the end.

// Complexity:
// Time Complexity: O(n^2)  (due to right rotation during placement)
// Space Complexity: O(1)    (in-place rearrangement)

using System;

public class AlternatePosNeg
{
    static void Rearrange(int[] arr)
    {
        int n = arr.Length;
        int wrongIndex = -1;

        for (int i = 0; i < n; i++)
        {
            if (wrongIndex >= 0)
            {
                // check if element at i can be swapped with wrongIndex
                if ((arr[wrongIndex] >= 0 && arr[i] < 0) ||
                    (arr[wrongIndex] < 0 && arr[i] >= 0))
                {
                    // right rotation to place arr[i] at wrongIndex
                    int temp = arr[i];
                    for (int j = i; j > wrongIndex; j--)
                        arr[j] = arr[j - 1];
                    arr[wrongIndex] = temp;

                    // if distance > 2, next wrongIndex moves by 2
                    if (i - wrongIndex > 2)
                        wrongIndex += 2;
                    else
                        wrongIndex = -1;
                }
            }
            else
            {
                // mark index where element is out of place
                if (((arr[i] >= 0) && (i % 2 == 1)) ||
                    ((arr[i] < 0) && (i % 2 == 0)))
                {
                    wrongIndex = i;
                }
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
            Console.Write($"Enter element {i+1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Rearrange(arr);

        Console.WriteLine("Array after alternating positive and negative: " + string.Join(" ", arr));
    }
}

// Problem: Move All Zeroes to the End of the Array

// Question:
// Write a C# program to move all 0s to the end of the array
// while keeping the relative order of non-zero elements.

// Input:
// First line: size of array n
// Next line: n integers

// Output:
// Print array after moving zeroes to the end

// Example 1:
// Input: n = 5, arr = [0, 1, 0, 3, 12]
// Output: [1, 3, 12, 0, 0]

// Example 2:
// Input: n = 6, arr = [1, 2, 0, 4, 0, 5]
// Output: [1, 2, 4, 5, 0, 0]

// Notes:
// Maintain relative order of non-zero elements.
// Solve in-place without using extra array.

// Complexity:
// Time Complexity: O(n)
// Space Complexity: O(1)

using System;

public class MoveZeroes
{
    // Function to move all zeroes to the end
    static void MoveAllZeroes(int[] arr)
    {
        int index = 0; // Pointer for placing non-zero elements

        // Place all non-zero elements in correct order
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != 0)
            {
                arr[index] = arr[i];
                index++;
            }
        }

        // Fill remaining positions with zero
        while (index < arr.Length)
        {
            arr[index] = 0;
            index++;
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

        MoveAllZeroes(arr);

        Console.WriteLine("Array after moving zeroes: " + string.Join(" ", arr));
    }
}

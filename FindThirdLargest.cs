// Problem: Find the Third Largest Element in an Array

// Question:
// Write a C# program to find the third largest element in an array.

// Input:
// First line contains size of array `n`
// Next line contains `n` integers (array elements)

// Output:
// Print the third largest element

// Example:
// Input: n = 6, arr = [12, 35, 1, 10, 34, 1]
// Output: 12

// Notes:
// If the array has less than 3 unique elements, then "third largest" does not exist.
// This solution uses a single pass without sorting.

// Complexity:
// Time Complexity: O(n)
// Space Complexity: O(1)

using System;

public class ThirdLargest
{
    // Function to find third largest element
    static int FindThirdLargest(int[] arr)
    {
        int first = int.MinValue, second = int.MinValue, third = int.MinValue;

        foreach (int num in arr)
        {
            if (num > first)  // Update all three
            {
                third = second;
                second = first;
                first = num;
            }
            else if (num > second && num < first)  // Update 2nd & 3rd
            {
                third = second;
                second = num;
            }
            else if (num > third && num < second)  // Update 3rd only
            {
                third = num;
            }
        }

        return third;
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter size of array: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter element {i + 1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        int result = FindThirdLargest(arr);

        if (result == int.MinValue)
            Console.WriteLine("Third largest element does not exist.");
        else
            Console.WriteLine("Third largest element: " + result);
    }
}

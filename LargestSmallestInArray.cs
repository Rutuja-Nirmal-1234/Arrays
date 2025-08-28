// Problem: Find the Largest and Smallest Number in an Array

// Question:
// Write a C# program to find the largest and smallest elements in an array.

// Input:
// First line contains size of array `n`
// Next line contains `n` integers (array elements)

// Output:
// Print the smallest and largest element in the array

// Example:
// Input: n = 6, arr = [12, 5, 7, 22, 9, 1]
// Output: Smallest = 1, Largest = 22

// Complexity:
// Time Complexity: O(n)
// Space Complexity: O(1)

using System;

public class LargestSmallestInArray
{
    // Function to find smallest and largest numbers
    static void FindMinMax(int[] arr, out int smallest, out int largest)
    {
        smallest = arr[0];
        largest = arr[0];

        foreach (int num in arr)
        {
            if (num < smallest)
                smallest = num;

            if (num > largest)
                largest = num;
        }
    }

    public static void Main(string[] args)
    {
        // Input: size of array
        Console.Write("Enter size of array: ");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[size];

        // Input: array elements
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Enter element {i + 1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Find smallest and largest
        FindMinMax(arr, out int smallest, out int largest);

        // Output results
        Console.WriteLine("Smallest element in array: " + smallest);
        Console.WriteLine("Largest element in array: " + largest);
    }
}



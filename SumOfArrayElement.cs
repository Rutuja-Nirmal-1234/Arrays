// Problem: Sum of All Elements in an Array

// Question:
// Write a C# program to find the sum of all elements in an array.

// Input: Size of array n, followed by n integers.
// Output: Sum of all array elements.

// Example:
// Input: n = 5, arr = [10, 20, 30, 40, 50]  
// Output: 150

// Complexity Analysis
// Time Complexity: O(n) 
// Space Complexity: O(n) 
// Optimized approach (without storing array) → O(1) space

using System;

public class HelloWorld
{
    static int SumArr(int[] arr)
    {
        int sum = 0;
        foreach (int num in arr)
        {
            sum += num;
        }
        return sum;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter size of array: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];

        Console.WriteLine("Enter array elements: ");
        for (int i = 0; i < size; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        int result = SumArr(arr);
        Console.WriteLine("Sum of array elements = " + result);
    }
}

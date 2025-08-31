// Problem: Bubble Sort

// Question:
// Write a program to sort an array of integers using the Bubble Sort algorithm.

// Input:
// n = 5
// arr = [64, 34, 25, 12, 22]

// Output:
// Sorted Array (Ascending): 12 22 25 34 64

// Explanation:
// - Bubble Sort compares adjacent elements and swaps them if they are out of order.
// - After each pass, the largest element "bubbles up" to the end.

// Complexity:
// Time Complexity: O(n^2) in worst/average case
//                  O(n) in best case (if already sorted, with optimization)
// Space Complexity: O(1) (in-place sort)

using System;

public class BubbleSortExample
{
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1]) // Swap if out of order
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
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

        BubbleSort(arr);

        Console.WriteLine("Sorted Array (Ascending): ");
        Console.WriteLine(string.Join(" ", arr));
    }
}

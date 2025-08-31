// Problem: Plus One

// Question:
// You are given a large integer represented as an integer array `digits`,
// where each digits[i] is the ith digit of the integer. Add one to the integer.
// The digits are stored such that the most significant digit is at the head of the list.

// Input: digits = [9,9,9]
// Output: [1,0,0,0]

// Explanation:
// - Add 1 to 999 → becomes 1000.
// - Carry is propagated until a non-9 digit is found.

// Notes:
// - Handles normal increments (e.g. 123 → 124).
// - Handles edge case when all digits are 9 (e.g. 999 → 1000).

// Complexity:
// Time Complexity: O(n)
// Space Complexity: O(1) if modification in-place, O(n+1) in worst case (all 9's).

using System;

public class PlusOneProblem
{
    static int[] PlusOne(int[] digits)
    {
        int n = digits.Length;

        for (int i = n - 1; i >= 0; i--)
        {
            if (digits[i] < 9)
            {
                digits[i]++;   // simple increment
                return digits; // no carry, return result
            }
            digits[i] = 0;      // if digit was 9, set to 0 and continue loop
        }

        // If all digits were 9 → need extra space [1000...]
        int[] result = new int[n + 1];
        result[0] = 1;
        return result;
    }

    public static void Main(string[] args)
    {
        int[] digits = { 9, 9, 9 };
        
        Console.WriteLine("Input: " + string.Join("", digits));

        int[] result = PlusOne(digits);

        Console.WriteLine("Output: " + string.Join("", result));
    }
}

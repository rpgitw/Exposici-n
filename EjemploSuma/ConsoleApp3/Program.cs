// A Divide and Conquer based C# 
// program for maximum subarray sum 
// problem 
using System;

class GFG
{

    // Find the maximum possible sum in arr[] 
    // such that arr[m] is part of it 
    static int maxCrossingSum(int[] arr, int l, int m,
                            int h)
    {
        // Include elements on left of mid. 
        int sum = 0;
        int left_sum = int.MinValue;
        for (int i = m; i >= l; i--)
        {
            sum = sum + arr[i];
            if (sum > left_sum)
                left_sum = sum;
        }

        // Include elements on right of mid 
        sum = 0;
        int right_sum = int.MinValue;
        ;
        for (int i = m; i <= h; i++)
        {
            sum = sum + arr[i];
            if (sum > right_sum)
                right_sum = sum;
        }

        // Return sum of elements on left 
        // and right of mid 
        // returning only left_sum + right_sum will fail for 
        // [-2, 1] 
        return Math.Max(left_sum + right_sum - arr[m],
                        Math.Max(left_sum, right_sum));
    }

    // Returns sum of maximum sum subarray 
    // in aa[l..h] 
    static int maxSubArraySum(int[] arr, int l, int h)
    {
        //Invalid Range: low is greater than high 
        if (l > h)
            return int.MinValue;
        // Base Case: Only one element 
        if (l == h)
            return arr[l];

        // Find middle point 
        int m = (l + h) / 2;

        /* Return maximum of following three 
		possible cases: 
		a) Maximum subarray sum in left half 
		b) Maximum subarray sum in right half 
		c) Maximum subarray sum such that the 
		subarray crosses the midpoint */
        return Math.Max(
            Math.Max(maxSubArraySum(arr, l, m - 1),
                    maxSubArraySum(arr, m + 1, h)),
            maxCrossingSum(arr, l, m, h));
    }

    /* Driver program to test maxSubArraySum */
    public static void Main()
    {
        int[] arr = { 2, 3, 4, 5, 7 };
        int n = arr.Length;
        int max_sum = maxSubArraySum(arr, 0, n - 1);

        Console.Write("La suma contigua máxima es: "
                    + max_sum);

        Console.ReadKey();
    }
}



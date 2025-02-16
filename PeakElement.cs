using System;

class Program
{
    static int FindPeakElement(int[] nums)
    {
        int left = 0, right = nums.Length - 1;
        
        while (left < right)
        {
            int mid = left + (right - left) / 2;
            
            if (nums[mid] > nums[mid + 1])
                right = mid;
            else
                left = mid + 1;
        }
        
        return left;
    }

    static void Main()
    {
        int[] nums = {1, 2, 3, 1};
        int peakIndex = FindPeakElement(nums);
        Console.WriteLine("Peak element index: " + peakIndex);
        Console.WriteLine("Peak element value: " + nums[peakIndex]);
    }
}
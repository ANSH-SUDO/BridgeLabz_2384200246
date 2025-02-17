﻿using System;
using System.Diagnostics;

class Program1
{
   public static bool LinearSearch(int[] data, int target)
   {
       for (int i = 0; i < data.Length; i++)
       {
           if (data[i] == target)
           {
               return true;
           }
       }
       return false;
   }

   public static bool BinarySearch(int[] data, int target)
   {
       int left = 0, right = data.Length - 1;

       while (left <= right)
       {
           int mid = (left + right) / 2;

           if (data[mid] == target)
           {
               return true;
           }
           else if (data[mid] < target)
           {
               left = mid + 1;
           }
           else
           {
               right = mid - 1;
           }
       }
       return false;
   }

   public static int[] GenerateDataset(int size)
   {
       Random random = new Random();
       int[] data = new int[size];
       for (int i = 0; i < size; i++)
       {
           data[i] = random.Next(0, size);
       }
       return data;
   }

   public static void MeasureSearchTime(string searchType, int[] data, int target, string searchMethod)
   {
       Stopwatch stopwatch = new Stopwatch();
       stopwatch.Start();

       if (searchMethod == "Linear")
       {
           LinearSearch(data, target);
       }
       else if (searchMethod == "Binary")
       {
           Array.Sort(data);
           BinarySearch(data, target);
       }

       stopwatch.Stop();
       Console.WriteLine($"{searchType} - {searchMethod} Search Time: {stopwatch.ElapsedMilliseconds} ms");
   }

   static void Main()
   {
       int target = 999999;
       int size = 100000;
       int[] data = GenerateDataset(size);

       MeasureSearchTime($"Linear Search for {size} elements", data, target, "Linear");
       MeasureSearchTime($"Binary Search for {size} elements", data, target, "Binary");

       Console.WriteLine();
   }

}

﻿namespace ArrayWithNumberAndStrings
{
    public class ReverseStringWords
    {
        /// <summary>
        /// it's using 2 pointer technique - https://blog.algomaster.io/p/69025a2e-b0d5-4705-8507-bba16c2691f1
        /// time complexity O(N) and space complexity O(1)
        /// Leet code problem - https://leetcode.com/problems/reverse-words-in-a-string/?envType=study-plan-v2&envId=top-interview-150
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ReverseWords(string s)
        {
            string[] arr = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int n = arr.Length - 1;
            for (int i = 0; i <= n; i++)
            {
                string ss = arr[i];
                arr[i] = arr[n];
                arr[n] = ss;
                n--;
            }
            return string.Join(" ", arr);
        }
    }
}

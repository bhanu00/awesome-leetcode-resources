using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPractice
{
    public class ReverseStringWords
    {
        public string ReverseWords(string s)
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

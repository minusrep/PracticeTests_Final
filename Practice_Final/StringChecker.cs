using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Final
{
    public class StringChecker
    {
        public static bool IsPalindrome(string value)
        {
            var correct = value.Replace(" ", "").ToLower();
            int left = 0;
            int right = correct.Length - 1;

            while (left < right)
            {
                if (correct[left] != correct[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
    }
}

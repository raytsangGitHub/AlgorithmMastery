using System.Text.RegularExpressions;

namespace LeetCode150Lib.TwoPointers
{
    /// <summary>
    /// Definition: A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.
    /// Given a string s, return true if it is a palindrome, or false otherwise.
    /// Input: s = "A man, a plan, a canal: Panama"
    /// Output: true
    /// Explanation: "amanaplanacanalpanama" is a palindrome.

    /// </summary>
    public class ValidPalindrome125 : ITwoPointerOperation<bool>
    {
        public bool Execute(params object[] parameters)
        {
            if (parameters[0] == null) return true;
            if (parameters[0] != null)
            {
                var newStr = parameters[0]?.ToString().ToLower();
                var pattern = @"[^a-zA-Z0-9]";
                var result = Regex.Replace(newStr, pattern, string.Empty).ToArray();
                int endPointer = result.Length - 1;
                int startPoint = 0;
                while (startPoint < endPointer)
                {
                    if (!result[startPoint].Equals(result[endPointer]))
                    {
                        return false;
                    }
                    startPoint++;
                    endPointer--;
                }
            }

            return true;
        }
    }
}
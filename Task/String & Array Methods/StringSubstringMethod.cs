using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.String___Array_Methods
{
    internal class StringSubstringMethod
    {
        public string customSubstring(string input, int startIndex)
        {
            if (startIndex < 0 || startIndex >= input.Length)
            {
                return "Invalid index.";
            }
            string result = "";
            for (int i = startIndex; i < input.Length; i++)
            {
                result += input[i];
            }
            return result;
        }
        public string customSubstring(string input, int startIndex, int length)
        {
            if (startIndex < 0 || startIndex >= input.Length || length < 0 || startIndex + length > input.Length)
            {
                return "Invalid index or length.";
            }
            string result = "";
            for (int i = startIndex; i < startIndex + length; i++)
            {
                result += input[i];
            }
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.String___Array_Methods
{
    internal class StringContainsMethod
    {
        public bool customContains(string input, string substring)
        {
            if (substring.Length == 0)
            {
                return true;
            }
            for (int i = 0; i <= input.Length - substring.Length; i++)
            {
                int j;
                for (j = 0; j < substring.Length; j++)
                {
                    if (input[i + j] != substring[j])
                    {
                        break;
                    }
                }
                if (j == substring.Length)
                {
                    return true;
                }
            }
            return false;
        }
        public bool customContains(string input, char character)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == character)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

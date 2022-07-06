using System;
using System.Collections.Generic;
using System.Text;

namespace AvailityLISPValidator
{
    public class Validator
    {


        public bool IsValid(string input)
        {
            Stack<char> s = new Stack<char>();
            char[] arr = input.ToCharArray();
            int index = 0;

            while (index < input.Length)
            {
                if (arr[index] == '{' || arr[index] == '[' || arr[index] == '{')
                {
                    s.Push(arr[index]);
                }

                if (arr[index] == '}' || arr[index] == ']' || arr[index] == ')')
                {
                    if (s.Count == 0)
                    {
                        return false;
                    }

                    else if (IsMatch(s.Pop(), arr[index]))
                    {
                        return true;
                    }

                    return false;
                }

                index++;
            }

            if (s.Count == 0)
            {
                return false;
            }

            return false;
        }

        private bool IsMatch(char firstChar, char secondChar)
        {
            if (firstChar == '(' && secondChar == ')')
            {
                return true;
            }
            else if (firstChar == '[' && secondChar == ']')
            {
                return true;
            }
            else if (firstChar == '{' && secondChar == '}')
            {
                return true;
            }

            return false;
        }
    }
}

using System;

namespace LengthOfLongestSubstring
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution.LengthOfLongestSubstring("pwwkew").ToString());
        }
    }

    public static class Solution
    {
        public static int LengthOfLongestSubstring(string s)
        {
            string newString = "";
            bool isDifferent = false;
            int count = 0;
            string temp = "";
            int[] arrLengths = new int[s.Length];
            int maximumNumber = 0;
            int result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (newString.Length == 0)
                {
                    newString += s[i];
                }
                else
                {
                    for (int j = 0; j < newString.Length; j++)
                    {
                        if (s[i] == newString[j])
                        {
                            isDifferent = false;

                            if (j != newString.Length - 1)
                            {
                                for (int k = j + 1; k < newString.Length; k++)
                                {
                                    temp += newString[k];
                                }
                            }

                            break;
                        }
                        else
                        {
                            isDifferent = true;
                        }
                    }

                    if (isDifferent)
                    {
                        newString += s[i];
                    }
                    else
                    {
                        arrLengths[count] = newString.Length;

                        if (temp.Length > 0)
                        {
                            newString = "";
                            newString = temp;
                            newString += s[i];
                            temp = "";
                        }
                        else
                        {
                            newString = "";
                            newString += s[i];
                        }

                        count++;
                    }
                }
            }

            for (int i = 0; i < arrLengths.Length; i++)
            {
                if (arrLengths[i] > maximumNumber)
                {
                    maximumNumber = arrLengths[i];
                    result = maximumNumber;
                }
            }

            if (newString.Length > maximumNumber)
            {
                result = newString.Length;
            }

            return result;
        }
    }
}

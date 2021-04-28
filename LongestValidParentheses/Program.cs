using System;
using System.Collections.Generic;

namespace LongestValidParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestValidParentheses(")()((()").ToString()); //")()((())"
        }

        public static int LongestValidParentheses(string s)
        {
            string input = s;
            char left = '(';
            char right = ')';
            int pairedCount = 0;
            int tempPairedCount = 0;
            int indexOfItemToBeRemoved = 0;
            List<int> tempIndexesOfItemToBeRemoved = new List<int>();
            bool hasFoundCouple = false;
            int duplicateConsecutiveParenthesCount = 0;
            //int tempCount = 0;
            int result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (j == input.Length)
                    {
                        break;
                    }

                    if (i == 0 && input[i] == right)
                    {
                        break;
                    }

                    if (i != j)
                    {
                        //Found Couple
                        if (input[i] == left && input[j] == right)
                        {
                            hasFoundCouple = true;

                            if(duplicateConsecutiveParenthesCount == 0)
                            {
                                indexOfItemToBeRemoved = j;
                                input = input.Remove(indexOfItemToBeRemoved, 1);
                                input = input.Insert(indexOfItemToBeRemoved, "X");
                                pairedCount += 2;
                                break;
                            }

                            if(duplicateConsecutiveParenthesCount > 0)
                            {
                                duplicateConsecutiveParenthesCount--;
                                tempIndexesOfItemToBeRemoved.Add(j);
                                tempPairedCount += 2;
                            }
                        }

                        //Found Duplicate Consecutive Parenthes
                        if(input[i] == left && input[j] == left)
                        {
                            duplicateConsecutiveParenthesCount++;
                            hasFoundCouple = false;
                            //tempCount++;
                        }
                    }
                }
            }

            return pairedCount;
        }
    }
}
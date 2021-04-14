using System;

namespace Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BuddyStrings("acccccb", "bccccca").ToString());
        }

        public static bool BuddyStrings(string a, string b)
        {
            bool isBuddy = false;
            bool hasInnerDifference = false;
            int externalDifferenceCount = 0;
            char firstTemp = ' ';
            char secondTemp = ' ';
            bool hasCopiedLetter = false;
            char copiedLetter = ' ';

            if (a.Length == b.Length && a.Length > 1 && b.Length > 1)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] != b[i])
                    {
                        externalDifferenceCount++;

                        if (externalDifferenceCount == 1)
                        {
                            firstTemp = a[i];
                            secondTemp = b[i];
                        }
                    }

                    if (externalDifferenceCount == 2)
                    {
                        if (a[i] == secondTemp && b[i] == firstTemp)
                        {
                            isBuddy = true;
                        }
                    }

                    if (externalDifferenceCount > 2)
                    {
                        isBuddy = false;
                    }

                    if (i != a.Length - 1)
                    {
                        if (a[i] != a[i + 1])
                        {
                            hasInnerDifference = true;
                        }
                    }

                    copiedLetter = a[i];

                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[j] == copiedLetter)
                        {
                            hasCopiedLetter = true;
                            break;
                        }
                    }
                }

                if (externalDifferenceCount == 0)
                {
                    if (!hasInnerDifference)
                    {
                        isBuddy = true;
                    }
                    else
                    {
                        if (hasCopiedLetter)
                        {
                            isBuddy = true;
                        }
                    }
                }
            }

            return isBuddy;
        }
    }
}

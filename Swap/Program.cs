using System;

namespace Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine(); //ab
            string b = Console.ReadLine(); //ba //result TRUE
            char temp1 = ' ';
            char temp2 = ' ';
            bool isDifferent = false;
            byte differenceCount = 0;
            bool isSwap = false;

            //abcf //ab
            //cbaa //ba

            if (a.Length == b.Length)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] != b[i] && !isDifferent)
                    {
                        temp1 = a[i];
                        temp2 = b[i];
                        differenceCount++;
                        isDifferent = true;
                        isSwap = false;
                    }
                    else if (a[i] != b[i] && isDifferent)
                        differenceCount++;


                    if (a[i] == b[i])
                        isSwap = true;

                    if (differenceCount == 2 && a[i] != temp2 && b[i] != temp1)
                    {
                        isSwap = false;
                        break;
                    }
                    else if (differenceCount == 2 && a[i] == temp2 && b[i] == temp1)
                        isSwap = true;
                }
            }
            else
            {
                Console.WriteLine("Two values must be in same length");
                return;
            }

            Console.WriteLine(isSwap.ToString());
        }
    }
}

using System;

namespace ConsecutiveOnes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] binary = Console.ReadLine().Split(',');
            int maxSum = 0;
            int tempSum = 0;

            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == "1")
                    tempSum += Convert.ToInt32(binary[i]);
                else if(binary[i] == "0")
                    tempSum = 0;
                else
                {
                    Console.WriteLine("The value must contain only '0' and '1'.");
                    return;
                }

                if (maxSum < tempSum)
                    maxSum = tempSum;
            }

            Console.WriteLine(maxSum.ToString());
        }
    }
}

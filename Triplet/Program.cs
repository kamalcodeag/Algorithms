using System;
using System.Collections.Generic;

namespace Triplet
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = { -5, 9, 3, -7, 12, 1, 0, -7, 8 };
            List<int[]> failedCouples = new List<int[]>();
            List<int[]> resultTriplets = new List<int[]>();

            for (int i = 0; i < inputNumbers.Length-2; i++)
            {
                bool notFoundFailedCouple = false;
                bool isSuccessfulCouple = false;

                for (int j = i+1; j < inputNumbers.Length-1; j++)
                {
                    int totalCouple = inputNumbers[i] + inputNumbers[j];
                    int[] temporaryArray = new int[3];
                    temporaryArray[0] = inputNumbers[i];
                    temporaryArray[1] = inputNumbers[j];

                    if (failedCouples.Count > 0)
                    {
                        for (int k = 0; k < failedCouples.Count; k++)
                        {
                            if ((temporaryArray[0] == failedCouples[k][0] || temporaryArray[0] == failedCouples[k][1])
                                && (temporaryArray[1] == failedCouples[k][0] || temporaryArray[1] == failedCouples[k][1]))
                            {
                                notFoundFailedCouple = false;
                                break;
                            }
                            else
                                notFoundFailedCouple = true;
                        }
                    }
                    else
                        AddThirdItem(j, inputNumbers, totalCouple, temporaryArray, isSuccessfulCouple, failedCouples, resultTriplets);

                    if (notFoundFailedCouple)
                        AddThirdItem(j, inputNumbers, totalCouple, temporaryArray, isSuccessfulCouple, failedCouples, resultTriplets);
                }
            }

            #region See result
            for (int i = 0; i < resultTriplets.Count; i++)
            {
                if(i == 0)
                    Console.Write("[");

                for (int j = 0; j < resultTriplets[i].Length; j++)
                    if (j != resultTriplets[i].Length - 1)
                        Console.Write(resultTriplets[i][j] + ",");
                    else
                        Console.Write(resultTriplets[i][j] + ";");

                if (i == resultTriplets.Count - 1)
                    Console.Write("]");
            }
            #endregion
        }

        static void AddThirdItem(int j, int[] inputNumbers, int totalCouple, int[] temporaryArray,
                                 bool isSuccessfulCouple, List<int[]> failedCouples, List<int[]> resultTriplets)
        {
            for (int l = j + 1; l < inputNumbers.Length; l++)
            {
                totalCouple += inputNumbers[l];
                temporaryArray[2] = inputNumbers[l];

                if (totalCouple != 0)
                {
                    totalCouple -= inputNumbers[l];

                    if (l == inputNumbers.Length - 1 && !isSuccessfulCouple)
                    {
                        int[] failedArray = new int[2];
                        failedArray[0] = temporaryArray[0];
                        failedArray[1] = temporaryArray[1];
                        failedCouples.Add(failedArray);
                    }
                }
                else
                {
                    int[] successArray = new int[3];
                    successArray[0] = temporaryArray[0];
                    successArray[1] = temporaryArray[1];
                    successArray[2] = temporaryArray[2];
                    resultTriplets.Add(successArray);
                    totalCouple -= inputNumbers[l];
                    isSuccessfulCouple = true;
                }
            }
        }
    }
}

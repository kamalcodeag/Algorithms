using System;

namespace Estate
{
    class Program
    {
        static void Main(string[] args)
        {
            byte testCasesNumber = 0;
            int estateNumber = 0;
            int budget = 0;
            string[] estatePrices = new string[0];

            Console.WriteLine("Please, enter number of test cases.");
            testCasesNumber = Convert.ToByte(Console.ReadLine());

            for (int k = 0; k < testCasesNumber; k++)
            {
                Console.WriteLine($"Case #{k+1}. Please, enter number of estates.");
                estateNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Case #{k+1}. Please, enter budget amount.");
                budget = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Case #{k+1}. Please, enter estate prices with ',' (comma).");
                estatePrices = Console.ReadLine().Split(",");

                int result = 0;
                int sum = 0;
                int temporaryResult = 0;

                for (int i = 0; i < estatePrices.Length; i++)
                {
                    sum = Convert.ToInt32(estatePrices[i]);

                    if (sum <= budget)
                        temporaryResult = 1;

                    for (int j = 0; j < estatePrices.Length; j++)
                    {
                        if (i != j)
                        {
                            sum += Convert.ToInt32(estatePrices[j]);

                            if (sum <= budget)
                                temporaryResult++;
                            else
                                sum -= Convert.ToInt32(estatePrices[j]);

                            if (result < temporaryResult)
                                result = temporaryResult;
                        }
                    }
                }


                Console.WriteLine($"Case #{k+1}. Result: " + result.ToString());
            }
        }
    }
}

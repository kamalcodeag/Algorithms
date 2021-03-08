using System;
using System.Diagnostics;

namespace NaturalNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N number");
            long N = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter k number");
            long k = Convert.ToInt64(Console.ReadLine());

            long sum = 0;
            long result = 0;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (long i = 1; i <= N; i++)
            {
                sum = 0;

                if (i != k)
                {
                    string numberText = i.ToString();

                    for (int j = 0; j < numberText.Length; j++)
                    {
                        long number = Convert.ToInt64(numberText[j].ToString());
                        sum += number;

                        if (sum == k)
                            result += 1;
                    }
                }
            }

            stopwatch.Stop();

            Console.WriteLine(result.ToString() + "\nTime: " + stopwatch.Elapsed.TotalMilliseconds + " milliseconds");
        }
    }
}

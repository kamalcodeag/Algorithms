using System;

namespace OccurenceOfZero
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] input = Console.ReadLine().Split(','); //[1,0,2,3,0,4,5,0]
            //string[] output = new string[input.Length]; //[1,0,0,2,3,0,0,4]
            //int newIndex = 0;

            //for (int i = 0; i < input.Length; i++)
            //{
            //    if(input[i] == "0")
            //    {
            //        output[newIndex] = input[i];
            //        newIndex++;

            //        if (newIndex != output.Length)
            //        {
            //            output[newIndex] = input[i];
            //            newIndex ++;
            //        }
            //    }
            //    else
            //    {
            //        output[newIndex] = input[i];
            //        newIndex++;
            //    }

            //    if (newIndex == output.Length)
            //        break;
            //}

            ////Print
            //for (int i = 0; i < output.Length; i++)
            //{
            //    if(i == output.Length - 1)
            //        Console.Write(output[i].ToString());
            //    else
            //        Console.Write(output[i].ToString() + ",");
            //}



            //Call method
            int[] a = { 1, 0, 2, 3, 0, 4, 5, 0 };
            DuplicateZeros(a);

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i].ToString());
            }
        }

        public static void DuplicateZeros(int[] arr)
        {
            int[] output = new int[arr.Length]; //[1,0,0,2,3,0,0,4]
            int newIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    output[newIndex] = arr[i];
                    newIndex++;

                    if (newIndex != output.Length)
                    {
                        output[newIndex] = arr[i];
                        newIndex++;
                    }
                }
                else
                {
                    output[newIndex] = arr[i];
                    newIndex++;
                }

                if (newIndex == output.Length)
                    break;
            }


            for (int i = 0; i < output.Length; i++)
            {
                arr[i] = output[i];
            }
        }
    }
}

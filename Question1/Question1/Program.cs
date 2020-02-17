using System;
using System.Collections.Generic;

namespace Question1
{
    class Question
    {
        public int Challenge(int[] input)
        {
            int frequency_of_number = 0; int max_frequency_number = 0;
            int[]input_after_upadete  = new int[input.Length];
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

                //to discard items that we calculated its frequency previously in input array
            for (int i = 0; i < input.Length; i++)
            {
                if (dictionary.ContainsKey(input[i]))
                {
                    continue;

                }
                frequency_of_number = 0;

                //In order to calculate the frequency of each element in input array
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                        frequency_of_number++;
                }

                //caclulate the max_frequncy_number in input array
                if (frequency_of_number > max_frequency_number)
                {
                    max_frequency_number = frequency_of_number;
                }

                // this dictionary contain the items in input array of as keys and its frequency as values
                dictionary.Add(input[i], frequency_of_number);
            }

                // put all array items in input array that meet the condition(frequncy_of_number must be >=max_frequncy_number) in new array 
            for (int k = 0; k < input.Length; k++)
            {
                if (dictionary[input[k]] >= (max_frequency_number - 1))
                {
                    input_after_upadete[k] = input[k];
                }
            }

               //calculate the biggest two neighbor elements 
            int maxSum = 0;
            for (int i = 0; i < input_after_upadete.Length - 1; i++)
            {
                int sum = Convert.ToInt32(input_after_upadete[i]) + Convert.ToInt32(input_after_upadete[i + 1]);
                if (sum > maxSum)
                   maxSum = sum;
            }

            return maxSum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please Insert The number of array elements");
            int Count = Convert.ToInt32(Console.ReadLine()); int Result;
            int[] input = new int[Count];
            Question question = new Question();            
            for (int i = 0; i < Count; i++)
            {
                int arrayItem = Convert.ToInt32(Console.ReadLine());
                input[i] = arrayItem;            }
            Result = question.Challenge(input);
            Console.WriteLine("Result = " + Result);
        }
    }
}

using System;

namespace NewC_3_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int lengthArray = 10;
            int minRandomNumbers = 1;
            int maxRandomNumbers = 11;

            int[] numbers = new int[lengthArray];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(minRandomNumbers, maxRandomNumbers);
                Console.Write($"{numbers[i]} ");
            }

            while (lengthArray != 0)
            {
                int maxIndex = 0;

                for (int i = 1; i < lengthArray; i++)
                {
                    if (numbers[i - 1] > numbers[i])
                    {
                        int bufferNumder = numbers[i - 1];
                        numbers[i - 1] = numbers[i];
                        numbers[i] = bufferNumder;
                        maxIndex = i;
                    }
                }

                lengthArray = maxIndex;
            }

            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }

            Console.ReadKey();
        }
    }
}
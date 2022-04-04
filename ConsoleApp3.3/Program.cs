using System;

namespace ConsoleApp3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int minNumber = 1;
            int maxNumber = 10;
            int arraySize = 30;
            int[] array = new int[arraySize];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(minNumber, maxNumber);

                Console.Write(array[i] + " ");                                
            }
            
            Console.WriteLine("\n");

            if(array[0] > array[1])
            {
                Console.Write(array[0]+ " ");
            }

            for (int i = 1; i < array.Length - 1; ++i)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    Console.Write(array[i] + " ");
                }
            }

            if (array[array.Length-1] > array[array.Length - 2])
            {
                Console.Write(array[arraySize-1]);
            }
        }
    }
}

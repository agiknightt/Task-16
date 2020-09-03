using System;

namespace Task_16
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[10, 10];
            Random rand = new Random();
            int maxNumber = int.MinValue;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(1, 50);
                    Console.Write(array[i, j] + " ");

                    if (maxNumber < array[i, j])
                    {
                        maxNumber = array[i, j];
                    }
                }
                Console.WriteLine("");
            }

            Console.WriteLine($"\n{maxNumber}\n");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (maxNumber == array[i,j])
                    {
                        array[i, j] = 0;
                    }
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}

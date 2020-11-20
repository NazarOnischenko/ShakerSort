using System;

namespace ShakerSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array declaration
            int[] array = new int[10];
            //Randon object declaration
            var srn = new Random();
            //Filling array with random numbers and output in the console
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = srn.Next(0, 11);
                Console.Write(array[i]+" ");
            }
            Console.WriteLine();
            //Method shaker sort
            int temp;
            for (int i = 0;i<array.Length/2; i++)
            {
                for (int j = i;j < array.Length-1-i;j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
                for (int k = array.Length - 2-i;k > i;k--)
                {
                    if (array[k] < array[k - 1])
                    {
                        temp = array[k];
                        array[k] = array[k - 1];
                        array[k - 1] = temp;
                    }
                }
            }
            //Output sorted array in the console
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+" ");
            }
        }
    }
}

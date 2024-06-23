using System;

namespace Sorting
{
    class Sorting
    {

        static void Main(string[] args)
        {

            int[] numbers = { 9, 2, 3, 4, 5, 6, 1, 8, 7 };

            Sort(numbers);

            foreach (int number in numbers)
            {
                Console.Write(number);
            }
        }

       public static void Sort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for(int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }

    }

}
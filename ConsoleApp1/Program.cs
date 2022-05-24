using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, 5, 7, 8, 9 };
            int n = 7;
            var index = -1;
            int min = 0;
            int max = numbers.Length - 1;

            while (min < max)
            {
                int mid = (max - min) / 2;

                if (numbers[mid] == n)
                {
                    index = mid;
                    break;
                }

                else if (n < numbers[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }

            }
            Console.WriteLine(index);

        }
    }
}


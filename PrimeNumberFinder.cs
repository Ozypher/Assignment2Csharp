using System;

namespace PrimeNumberFinder
{
    class PrimeNumberFinder
    {
        static void Main(string[] args)
        {
            int startNum = 0;
            int endNum = 0;

            Console.WriteLine("Enter first number.");
            startNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number.");
            endNum = int.Parse(Console.ReadLine());

            FindPrimeNumbers(startNum, endNum);
        }
        static void FindPrimeNumbers(int startNum, int endNum)
        {
            int[] results = new int[endNum];
            int counter = 0;
            bool flag = false;
            for (int i = startNum; i < endNum; i++)
            {
                for (int j = 2; j < i/2; j++)
                {
                    if(i%j == 0)
                    {
                        flag = true;
                    }
                }
                if (!flag)
                {
                    if (i > 4)
                    {
                        results[counter] = i;
                        counter++;
                    }
                    else
                    {
                        flag = false;
                    }
                }
                else { flag = false; }
            }
            for (int i = 0; i < results.Length; i++)
            {
                Console.Write(results[i] + ",");
            }
        }
    }
}

using System;

namespace HackerRank30DaysOfCodeD5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            int result;
            if (n >= 2 && n <= 20)
            {
                for (int i = 1; i <= 10; i++)
                {
                    result = n * i;
                    Console.WriteLine(n + " x " + i + " = " + result);
                }
            }
        }
    }
}

using System;

namespace LotterySimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int lotteryLength = 6;
            int[] lotteryNumbers = new int[lotteryLength];

            Random random = new Random();

            int lotteryNumberIndex = 0;
            while (lotteryNumberIndex < lotteryLength)
            {
                lotteryNumbers[lotteryNumberIndex] = random.Next(1, 46);

                bool hasDuplicate = false;
                for (int i = 0; i < lotteryNumberIndex; i++)
                {
                    if (lotteryNumbers[lotteryNumberIndex] == lotteryNumbers[i])
                    {
                        hasDuplicate = true;
                        break;
                    }
                }

                if (!hasDuplicate)
                {
                    lotteryNumberIndex++;
                }
            }

            Console.Write("Lottery Number: ");
            for (int i = 0; i < lotteryLength; i++)
            {
                Console.Write(lotteryNumbers[i]);
                Console.Write(", ");
            }
            Console.WriteLine();
        }
    }
}

using System;

namespace PartialClasses
{
    public partial class PartialClass
    {
        public void For()
        {
            Console.WriteLine(Math.Pow(2, 4));
            int[] luckyNumbers = { 4, 5, 6, 7, 8, 9 };

            for (int i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
            }
            Console.ReadLine();

        }
    }
}
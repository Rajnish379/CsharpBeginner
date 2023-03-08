using System;

namespace PartialClasses
{
    public partial class PartialClass
    {
        public void Arrays()
        {

            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            string[] friends = new string[10];
            friends[0] = "Jim";
            friends[1] = "Kelly";
            luckyNumbers[0] = 900;
            Console.WriteLine(luckyNumbers[0]);
            Console.WriteLine(luckyNumbers[2]);
            Console.ReadLine();

        }
    }
}
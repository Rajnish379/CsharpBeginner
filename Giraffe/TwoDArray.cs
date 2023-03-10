using System;

namespace PartialClasses
{
    public partial class PartialClass
    {
        public void TwoDArray()
        {
            int[,] numberGrid =
            {
                {1,2 },
                {3,4},
                {5,6}
            };
            /*
           abce
          efg
          hijk
          */
            // Declaring a 2D array with number of rows and columns
            int[,] myArray = new int[2, 3];
            Console.WriteLine(numberGrid[2, 0]);
            Console.ReadLine();

        }
    }
}
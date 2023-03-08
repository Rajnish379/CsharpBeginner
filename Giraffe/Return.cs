using System;

namespace PartialClasses
{
    public partial class PartialClass
    {
        public void Return()
        {
            double cubedNumber = cube(2);
            Console.WriteLine(cubedNumber);
            Console.WriteLine(cube(5));
            Console.ReadLine();


        }

        static double cube(int num)
        {
            return Math.Pow(num, 3);
        }
    }
}
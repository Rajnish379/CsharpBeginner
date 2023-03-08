using System;

namespace PartialClasses
{
    public partial class PartialClass
    {
        public void If()
        {
            bool isMale = false;
            bool isTall = false;

            // If isMale is false the line inside this if won't be printed
            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male");
            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("You are a short male");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("You are not a male but you are tall");
            }
            else
            {
                Console.WriteLine("You are not Male and not tall");
            }

            Console.ReadLine();


        }
    }
}
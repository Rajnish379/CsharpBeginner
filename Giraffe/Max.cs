using System;

namespace PartialClasses
{
    public partial class PartialClass
    {
        public void Max()
        {
            Console.WriteLine(GetMax(2, 10, 9));
            Console.ReadLine();


        }
        static int GetMax(int num1, int num2, int num3)
        {
            int result;

            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }


            return result;
        }
    }
}
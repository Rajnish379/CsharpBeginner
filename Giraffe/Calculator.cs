using System;

namespace PartialClasses
{
    public partial class PartialClass
    {
        public void Calculator()
        {
            // The string inside the ToInt32 method should be a convertable number but not some gibberish like 56asdf
            int num = Convert.ToInt32("45");
            Console.WriteLine("43" + "56");
            Console.WriteLine(num + 6);

            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num1 + num2);
            Console.ReadLine();

        }
    }
}
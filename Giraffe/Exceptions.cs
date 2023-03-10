using System;

namespace PartialClasses
{
    public partial class PartialClass
    {
        public void Exceptions()
        {
            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num1 / num2);
            }
            // Use Exception class if you want to catch all exceptions in general
            // Use DivideByZeroException class only if you want to catch the divide by zero exception
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            // FormatException will catch all the input format exceptions like suppose if you enter a string instead of a number and ask the compiler to divide it for us
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }





            Console.ReadLine();

        }
    }
}
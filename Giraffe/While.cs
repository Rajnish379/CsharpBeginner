using System;

namespace PartialClasses
{
    public partial class PartialClass
    {
        public void While()
        {

            int index = 6;
            while (index <= 5)
            {
                Console.WriteLine(index);
                // If we don't increment it every time then it becomes an infinite loop always printing out 1 
                index++;
            }
            do
            {
                Console.WriteLine("This is do while loop");
                index++;
            } while (index <= 5);

            Console.ReadLine();

        }
    }
}
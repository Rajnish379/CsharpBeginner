using System;

namespace PartialClasses
{
    public partial class PartialClass
    {
        public void Methods()
        {
            SayHi("Mike", 11);
            SayHi("John", 22);
            SayHi("Tom", 33);
            Console.ReadLine();
        }

        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age);
        }


    }
}

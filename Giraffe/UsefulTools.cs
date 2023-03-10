using System;

namespace Giraffe
{
    // If you declare a class as static then you cannot create instances of it
    static class UsefulTools
    {
        public static void SayHi(string name)
        {
            Console.WriteLine("Hi " + name);
        }
    }
}
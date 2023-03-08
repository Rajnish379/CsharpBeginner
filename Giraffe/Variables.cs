using System;

namespace PartialClasses
{
    public partial class PartialClass
    {
        public void Variables()
        {
            string characterName = "Johneker";
            // Declaring and assigning the age variable separately
            int characterAge;
            characterAge = 35;

            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");
            characterName = "Mike";
            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But didn't like being " + characterAge);
            Console.ReadLine();


        }
    }
}
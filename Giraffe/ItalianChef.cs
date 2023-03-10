using System;

namespace Giraffe
{
    // This class inherits all the methods of the Chef class
    class ItalianChef : Chef
    {
        // override keyword means that we are overriding the functionality of the method present in the super class
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes Carbonera");
        }
        public void MakePasta()
        {
            Console.WriteLine("The Chef makes Pasta");
        }
    }
}
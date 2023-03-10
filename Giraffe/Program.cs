namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("a","b",1);
            Student student1 = new Student("Jim", "Business", 2.8);
            Student student2 = new Student("Pam", "Arts", 4.0);
            book1.pages = 500;

            Book book2 = new Book();
            book2.title = "Harry";
            book2.author = "JK";
            book2.pages = 600;

            Movie avengers = new Movie("The Avengers", "Joe Atto", "Gog");
            Movie shrek = new Movie("Shrek", "Adam", "PG");
            // G, PG, PG-13, R, NR
            shrek.Rating = "R";


            Song holiday = new Song("Holiday", "Raj", 12);
            Console.WriteLine(Song.count);
            Song kashmir = new Song("Kashmir", "Adi", 20);

            Console.WriteLine(Song.count);
            Console.WriteLine(holiday.title);
           
            Console.WriteLine(kashmir.title);
            Console.WriteLine(kashmir.getSongCount());
            // Static attributes of a class apply to the entire class itself but not to objects unlike the other attributes
            // Static attributes belong to the class but not to its objects
           
            Console.WriteLine(shrek.Rating);

            Console.WriteLine(avengers.Rating);
            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());
            Console.WriteLine(book1.pages);
            Console.WriteLine(book2.pages);

            Console.WriteLine(Math.Sqrt(144));

            UsefulTools.SayHi("Mile");

            Chef chef = new Chef();
            chef.MakeChicken();
            chef.MakeSpecialDish();

            ItalianChef italianChef = new ItalianChef();
            italianChef.MakePasta();
            italianChef.MakeSpecialDish();
            Console.ReadLine();

            
        }
        
    }
}
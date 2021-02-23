using System;

namespace GetterAndSetter
{
    class Program
    {
        static void Main()
        {
            // only possible ratings for the movie should be "G", "PG" and "PG-13" and Title = Rocky
            // therefore we need get and set
            Movie avengers = new Movie("Rocky", "Joss Whedon", "G");
            //avengers.Rating = "G";
                        
            Console.WriteLine("Rating = {0}",avengers.Rating);
            Console.WriteLine("Title = {0}", avengers.Title);

            Console.Write("Title eingeben: ");
            avengers.Title = Console.ReadLine();
            Console.WriteLine("Title = {0}", avengers.Title);

            Console.Write("Rating eingeben: ");
            avengers.Rating = Console.ReadLine();
            Console.WriteLine("Rating = {0}", avengers.Rating);

            Console.ReadKey();
        }
    }
    
}
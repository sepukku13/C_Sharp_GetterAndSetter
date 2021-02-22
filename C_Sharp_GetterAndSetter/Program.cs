using System;

namespace GetterAndSetter
{
    class Program
    {
        static void Main()
        {
            Movie avengers = new Movie("Rocky", "Joss Whedon", "G");
            //avengers.Rating = "G";

            
            Console.WriteLine("Rating = {0}",avengers.Rating);
            Console.WriteLine("Title = {0}", avengers.Title);

            Console.Write("Title eineben: ");
            avengers.Title = Console.ReadLine();
            Console.WriteLine("Title = {0}", avengers.Title);

            Console.ReadKey();
        }
    }
    
}
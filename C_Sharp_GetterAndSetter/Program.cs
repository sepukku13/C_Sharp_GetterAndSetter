using System;

namespace GetterAndSetter
{
    class Program
    {
        static void Main()
        {
            Movie avengers = new Movie("The Avangers", "Joss Whedon", "G");
            //avengers.Rating = "G";
            Console.WriteLine(avengers.Rating);
            Console.ReadKey();
        }
    }
    
}
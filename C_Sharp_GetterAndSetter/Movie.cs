using System;


class Movie
{
    //Variable
    private string rating;

    //Eigenschaft
    public string Title { get; set; }
    public string Director { get; set; }
        
    public string Rating
    {
        get
        {
            Console.WriteLine("public string Rating - get: {0}", rating);
            return rating;
        }
        set
        {
            if (value == "G" || value == "PG" || value == "PG-13")
                rating = value;
            else
                rating = "Nicht Vorhanden";
        }
    }
    //Konstruktor
    public Movie(string _title, string _director, string _rating)
    {
        Title = _title;
        Director = _director;
        Rating = _rating;
    }
}
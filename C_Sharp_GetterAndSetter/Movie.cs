using System;

class Movie
{
    //Variable
    private string rating;
    private string title;

    //Eigenschaft
    public string Director { get; set; }
        
    public string Rating
    {
        get
        {
            return rating;
        }
        set
        {
            if (value == "G" || value == "PG" || value == "PG-13")
                rating = value;
            else
                rating = "Nicht Vorhanden!!";
        }
    }
    public string Title
    {
        get
        {
            return title;
        }
        set
        {
            if (value != "Rocky")
                title = "Nicht aktzeptabel!";
            else
                title = value;
        }
    }
    //Konstruktor
    public Movie (string aTitle, string aDirector, string aRating)
    {
        Title = aTitle;
        Director = aDirector;
        Rating = aRating;
    }
}
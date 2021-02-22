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
                rating = "Nicht Vorhanden!";
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
                title = "Nicht aktzeptable";
            else
                title = value;
        }
    }
    //Konstruktor
    public Movie (string _title, string _director, string _rating)
    {
        Title = _title;
        Director = _director;
        Rating = _rating;
    }
}
namespace librarian;

public class Book
{
    public string NameOfBook { get; set; } = "";
    public string Author { get; set; } = "";
    public string Publisher { get; set; } = "";
    public string GenreOfBook { get; set; } = "";
    public string Year { get; set; } = "";
    public string Origin { get; set; } = "";
    public string Novelty { get; set; } = "";
    public string Sector { get; set; } = "";
    public string Grade { get; set; } = "";
    public string Status { get; set; } = "";
    public void Properties_Init(string nameOfBook, string author, string publisher, string year, string genre, 
                    string sector, string origin, string novelty, string grade, string status)
    {
        NameOfBook = nameOfBook;
        Author = author;
        Publisher = publisher;
        Year = year;
        Sector = sector;
        Origin = origin;
        Novelty = novelty;
        GenreOfBook = genre;
        Grade = grade;
        Status = status;
    }
}
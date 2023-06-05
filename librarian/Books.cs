using static librarian.PropsEnum;

namespace librarian;

internal static class Books
{
    public static List<BookPanel> AllBooks = new();

    public static int Count => AllBooks.Count;

    public static void Add(BookPanel book)
    {
        AllBooks.Add(book);
    }

    public static void Remove(BookPanel book)
    {
        AllBooks.Remove(book);
    }

    public static List<BookPanel> FindSuitableBooks(string searchRequest, Func<BookPanel, string> BookProperty)
    {
        List<BookPanel> resultCollection = new();

        foreach (var Book in AllBooks.OfType<BookPanel>().Where(c => BookProperty(c).Contains(searchRequest)).Cast<BookPanel>())
        {
            var BookCopy = new BookPanel(Book, Book.Parent!);
            resultCollection.Add(BookCopy);
        }

        return resultCollection;
    }

    public static List<BookPanel> GetBookPanelsCopy(Control parentControl)
    {
        return AllBooks.Select(Book => new BookPanel(Book, parentControl)).ToList();
    }

    public static void WriteAllBooksToFile()
    {
        string filePath = Path.Combine(Directory.GetCurrentDirectory(), "BooksStoring.txt"); ;

        using StreamWriter writer = new(filePath);
        foreach (var Book in AllBooks)
        {
            string line = $"{Book.Book.NameOfBook}|{Book.Book.Author}|{Book.Book.Publisher}|" +
                $"{Book.Book.Year}|{Book.Book.Sector}|{Book.Book.Origin}|{Book.Book.Novelty}|" +
                $"{Book.Book.GenreOfBook}|{Book.Book.Grade}|{Book.Book.Status}";
            writer.WriteLine(line);
        }
    }

    public static void SetLocationForAllBooks(Panel control, IEnumerable<BookPanel> Books)
    {
        Positioning.LocateBook(control, Books.OfType<Control>());
    }

    public static void FillBooksFromFile(Panel BookPanelContainer)
    {
        string filePath = Path.Combine(Directory.GetCurrentDirectory(), "BooksStoring.txt");

        if (!File.Exists(filePath)) return;

        string[] lines = File.ReadAllLines(filePath);

        string[,] BooksArray = new string[lines.Length, 10];


        for (int i = 0; i < lines.Length; i++)
        {
            string[] values = lines[i].Split('|');

            for (int j = 0; j < values.Length; j++)
            {
                BooksArray[i, j] = values[j];
            }
        }

        for (int i = 0; i < BooksArray.GetLength(0); i++)
        {
            Add(new (
                BooksArray[i, (int)NAME],
                BooksArray[i, (int)AUTHOR],
                BooksArray[i, (int)PUBLISHER],
                BooksArray[i, (int)YEAR],
                BooksArray[i, (int)SECTOR],
                BooksArray[i, (int)ORIGIN],
                BooksArray[i, (int)NOVELTY],
                BooksArray[i, (int)GENRE],
                BooksArray[i, (int)GRADE],
                BooksArray[i, (int)STATUS],
                BookPanelContainer));
        }

        SetLocationForAllBooks(BookPanelContainer, AllBooks);
    }
}

namespace librarian;

internal static class Books
{
    public static List<BookPanel> AllBooks = new();
    public static List<BookPanel> FindSuitableBooks(string searchRequest, Func<BookPanel, string> bookProperty)
    {
        List<BookPanel> resultCollection = new();

        foreach (var book in AllBooks.OfType<BookPanel>().Where(c => bookProperty(c).Contains(searchRequest)).Cast<BookPanel>())
        {
            var bookCopy = new BookPanel(book, book.Parent!);
            resultCollection.Add(bookCopy);
        }

        return resultCollection;
    }

    public static List<BookPanel> GetBookPanelsCopy(Control parentControl)
    {
        return AllBooks.Select(book => new BookPanel(book, parentControl)).ToList();
    }
}

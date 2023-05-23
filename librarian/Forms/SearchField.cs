namespace librarian;

public partial class SearchField : Form
{
    private static List<BookPanel> SuitableBooks = new();

    public SearchField()
    {
        InitializeComponent();
        bookArea.Width = Width;
        bookArea.AutoScroll = true;
        Resize += (s, ev) =>
        {
            bookArea.Width = Width;
            bookArea.Height = Height - bookArea.Location.Y;
        };
        bookArea.Resize += BookArea_Resize;
        FormClosing += Search_FormClosing;
    }
    private void BookArea_Resize(object? sender, EventArgs e)
    {
        Form1.LocateBook(bookArea, SuitableBooks.OfType<Control>());
    }
    private void Search_FormClosing(object? sender, FormClosingEventArgs e)
    {
        SuitableBooks.Clear();
        e.Cancel = true;
        Hide();
    }
    private void SearchButton_Click(object? sender, EventArgs e)
    {
        bookArea.Controls.Clear();
        GetSuitableBooks();
        AddBooksToPanel();
        Form1.LocateBook(bookArea, SuitableBooks.OfType<Control>());
    }
    private void GetSuitableBooks()
    {
        Dictionary<Control, bool> keyValuePairs = new Dictionary<Control, bool>
    {
        { NameTextBox, NameRadioButton.Checked },
        { AuthorTextBox, AuthorRadioButton.Checked },
        { PublisherTextBox, PublisherRadioButton.Checked },
        { GenreTextBox, GenreRadioButton.Checked },
        { YearTextBox, YearRadioButton.Checked},
        { SectorComboBox, SectorRadioButton.Checked },
        { OriginComboBox, OriginRadioButton.Checked },
        { NoveltyComboBox, NoveltyRadioButton.Checked },
        { GradeComboBox, GradeRadioButton.Checked }
    };

        List<BookPanel> filteredBooks = Books.GetBookPanelsCopy(bookArea);

        foreach (var pair in keyValuePairs)
        {
            if (pair.Value && pair.Key is TextBoxBase textBox)
            {
                if (pair.Key == GenreTextBox)
                {
                    filteredBooks = filteredBooks.Where(book =>
                        CheckGenre(textBox.Text, book.book.GenreOfBook.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries))).ToList();
                }
                else if (pair.Key == AuthorTextBox)
                {
                    filteredBooks = filteredBooks.Where(book =>
                        CheckAuthor(textBox.Text, book.book.Author.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries))).ToList();
                }
                else if (pair.Key == YearTextBox)
                {
                    filteredBooks = filteredBooks.Where(book => CheckYear(textBox.Text, book.book.Year)).ToList();
                }
                else
                {
                    string searchRequest = textBox.Text.Trim();
                    Func<BookPanel, string>? bookProperty = null;
                    if (pair.Key == NameTextBox)
                        bookProperty = book => book.book.NameOfBook;
                    else if (pair.Key == PublisherTextBox)
                        bookProperty = book => book.book.Publisher;

                    filteredBooks = filteredBooks.Where(book => bookProperty(book) == searchRequest).ToList();
                }
            }
            else if (pair.Value && pair.Key is ComboBox comboBox)
            {
                string searchRequest = comboBox.Text.Trim();
                if (pair.Key == OriginComboBox)
                {
                    filteredBooks = filteredBooks.Where(book => book.book.Origin == searchRequest).ToList();
                }
                else if (pair.Key == NoveltyComboBox)
                {
                    filteredBooks = filteredBooks.Where(book => book.book.Novelty == searchRequest).ToList();
                }
                else if (pair.Key == GradeComboBox)
                {
                    filteredBooks = filteredBooks.Where(book => book.book.Grade == searchRequest).ToList();
                }
                else if (pair.Key == SectorComboBox)
                {
                    filteredBooks = filteredBooks.Where(book => book.book.Sector == searchRequest).ToList();
                }
            }
        }

        SuitableBooks = filteredBooks;
    }


    private bool CheckYear(string year, string searchRequest)
    {
        if (string.IsNullOrEmpty(year))
            return true;

        if (year.Contains('>'))
        {
            string compareYear = year.Substring(1);
            if (int.TryParse(compareYear, out int yearValue) && int.TryParse(searchRequest, out int requestValue))
            {
                return requestValue > yearValue;
            }
        }
        else if (year.Contains('<'))
        {
            string compareYear = year.Substring(1);
            if (int.TryParse(compareYear, out int yearValue) && int.TryParse(searchRequest, out int requestValue))
            {
                return requestValue < yearValue;
            }
        }
        else if (year.Contains('-'))
        {
            string[] range = year.Split('-');
            if (range.Length == 2 && int.TryParse(range[0], out int startYear) && int.TryParse(range[1], out int endYear) && int.TryParse(searchRequest, out int requestValue))
            {
                return requestValue >= startYear && requestValue <= endYear;
            }
        }
        else
        {
            if (int.TryParse(year, out int yearValue) && int.TryParse(searchRequest, out int requestValue))
            {
                return requestValue == yearValue;
            }
        }

        return false;
    }
    private bool CheckGenre(string genre, string[] bookGenres)
    {
        if (string.IsNullOrEmpty(genre))
            return true;

        string[] searchGenres = genre.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

        if (searchGenres.Length == 1)
        {
            return bookGenres.Contains(searchGenres[0]);
        }
        else if (searchGenres.Length == 2)
        {
            return bookGenres.Contains(searchGenres[0]) && bookGenres.Contains(searchGenres[1]);
        }

        return false;
    }


    private bool CheckAuthor(string author, string[] bookAuthors)
    {
        if (string.IsNullOrEmpty(author))
            return true;

        string[] searchAuthors = author.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
        return searchAuthors.All(searchAuthor => bookAuthors.Contains(searchAuthor));
    }


    private void AddBooksToPanel()
    {
        foreach (BookPanel book in SuitableBooks)
            bookArea.Controls.Add(book);
    }
    private void SaveToFileButton_Click(object sender, EventArgs e)
    {
        string filePath = $"{DateTime.Now:yyyyMMdd_HHmmss}.txt";

        using StreamWriter writer = new(filePath);
        writer.WriteLine($"Date and Time of Save: {DateTime.Now}");
        writer.WriteLine();

        Dictionary<Control, bool> keyValuePairs = new()
        {
            { NameTextBox, NameRadioButton.Checked },
            { AuthorTextBox, AuthorRadioButton.Checked },
            { PublisherTextBox, PublisherRadioButton.Checked },
            { GenreTextBox, GenreRadioButton.Checked },
            { YearTextBox, YearRadioButton.Checked},
            { SectorComboBox, SectorRadioButton.Checked },
            { OriginComboBox, OriginRadioButton.Checked },
            { NoveltyComboBox, NoveltyRadioButton.Checked },
            { GradeComboBox, GradeRadioButton.Checked }
        };

        foreach (var pair in keyValuePairs)
        {
            if (pair.Value && pair.Key is TextBoxBase textBox)
            {
                writer.WriteLine($"{pair.Key.Name}: {textBox.Text}");
            }
            else if (pair.Value && pair.Key is ComboBox comboBox)
            {
                writer.WriteLine($"{pair.Key.Name}: {comboBox.Text}");
            }
        }

        writer.WriteLine();
        writer.WriteLine("Name of book | Author | Publisher | Year | Sector | Origin | Novelty | Genre of book | Grade | Status");

        foreach (var book in SuitableBooks)
        {
            string line = $"{book.book.NameOfBook} | {book.book.Author} | {book.book.Publisher} | {book.book.Year} | " +
                          $"{book.book.Sector} | {book.book.Origin} | {book.book.Novelty} | {book.book.GenreOfBook} | " +
                          $"{book.book.Grade} | {book.book.Status}";
            writer.WriteLine(line);
        }
    }
}

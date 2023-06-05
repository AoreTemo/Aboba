namespace librarian;

public partial class SearchField : Form
{
    private static List<BookPanel> SuitableBooks = new();

    private Dictionary<Control, bool> searchFields = new();

    public SearchField()
    {
        InitializeComponent();

        BookArea.Width = Width;
        BookArea.AutoScroll = true;
        SearchButton.Enabled = false;
        SaveToFileButton.Enabled = false;

        Resize += (s, ev) =>
        {
            if (WindowState == FormWindowState.Maximized)
            {
                HorizontalSeparatorPictureBox.Visible = false;

                BookArea.Location = new (BookArea.Location.X, OriginComboBox.Bottom + 10);
                SearchingInputPanel.Size = new(SaveToFileButton.Location.X - 20, Height);

                BookArea.Size = new(SaveToFileButton.Location.X - 20, Height - BookArea.Location.Y - 20);

                YearTextBox.Location = new (AuthorRadioButton.Right + (AuthorTextBox.Left - NameRadioButton.Right), AuthorTextBox.Top);
                YearRadioButton.Location = new (YearTextBox.Right + (AuthorRadioButton.Left - AuthorTextBox.Right), AuthorRadioButton.Top);

                GradeComboBox.Location = new (YearTextBox.Left, GenreTextBox.Top);
                GradeRadioButton.Location = new (YearRadioButton.Left, GenreRadioButton.Top);

                OriginComboBox.Location = new (YearTextBox.Left, NoveltyComboBox.Top);
                OriginRadioButton.Location = new (YearRadioButton.Left, NoveltyRadioButton.Top);

                SeparatorPictureBox.Size = new(3, Height);
                SeparatorPictureBox.Location = new(SaveToFileButton.Location.X - 20, 0);
            }
            else if (WindowState == FormWindowState.Normal)
            {
                HorizontalSeparatorPictureBox.Visible = true;
    
                BookArea.Location = new (0, 446);
                SearchingInputPanel.Size = new (930, 452);
                BookArea.Size = new (1127, 382);

                YearTextBox.Location = new (NameTextBox.Location.X, 359);
                YearRadioButton.Location = new (NameRadioButton.Location.X, 376);

                GradeComboBox.Location = new (483, 273);
                GradeRadioButton.Location = new (887, 294);

                OriginComboBox.Location = new (NameTextBox.Location.X, 273);
                OriginRadioButton.Location = new Point(NameRadioButton.Location.X, 294);

                SeparatorPictureBox.Location = new (931, 0);
                SeparatorPictureBox.Size = new (3, 446);
            }

            Positioning.LocateBook(BookArea, SuitableBooks.OfType<Control>());
        };
    
        FormClosing += SearchField_FormClosing;

        foreach (TextBox control in SearchingInputPanel.Controls.OfType<TextBox>())
            control.TextChanged += IsEnableToSearch;

        foreach (ComboBox control in SearchingInputPanel.Controls.OfType<ComboBox>())
            control.SelectedIndexChanged += IsEnableToSearch;

        foreach (CheckBox control in SearchingInputPanel.Controls.OfType<CheckBox>())
            control.CheckedChanged += IsEnableToSearch;

        UpdateSearchFields();
    }

    private void UpdateSearchFields()
    {
        searchFields = new()
        {
            { NameTextBox, NameRadioButton.Checked },
            { AuthorTextBox, AuthorRadioButton.Checked },
            { PublisherTextBox, PublisherRadioButton.Checked },
            { GenreTextBox, GenreRadioButton.Checked },
            { YearTextBox, YearRadioButton.Checked },
            { SectorComboBox, SectorRadioButton.Checked },
            { OriginComboBox, OriginRadioButton.Checked },
            { NoveltyComboBox, NoveltyRadioButton.Checked },
            { GradeComboBox, GradeRadioButton.Checked }
        };
    }
    private void SearchField_FormClosing(object? sender, FormClosingEventArgs e)
    {
        SuitableBooks.Clear();
        e.Cancel = true;
        Hide();
    }

    private void SearchButton_Click(object? sender, EventArgs e)
    {
        UpdateSearchFields();
        BookArea.Controls.Clear();
        GetSuitableBooks();
        AddBooksToPanel();
        Positioning.LocateBook(BookArea, SuitableBooks.OfType<Control>());
    }

    private void GetSuitableBooks()
    {
        SaveToFileButton.Enabled = true;
        List<BookPanel> filteredBooks = Books.GetBookPanelsCopy(BookArea);

        foreach (var Book in filteredBooks)
        {
            Book.panel1.Controls.Remove(Book.editButton);
            Book.moreButton.Location = new((Book.Width - Book.moreButton.Width) / 2, Book.moreButton.Location.Y);
        }

        foreach (var pair in searchFields)
        {
            if (pair.Value && pair.Key is TextBoxBase textBox)
            {
                if (pair.Key == GenreTextBox)
                {
                    filteredBooks = filteredBooks.Where(Book =>
                        CheckGenre(textBox.Text, Book.Book.GenreOfBook.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)))
                        .ToList();
                }
                else if (pair.Key == AuthorTextBox)
                {
                    filteredBooks = filteredBooks.Where(Book =>
                        CheckAuthor(textBox.Text, Book.Book.Author.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)))
                        .ToList();
                }
                else if (pair.Key == YearTextBox)
                {
                    filteredBooks = filteredBooks.Where(Book => CheckYear(textBox.Text, Book.Book.Year)).ToList();
                }
                else
                {
                    string searchRequest = textBox.Text.Trim();
                    Func<BookPanel, string>? BookProperty = null;
                    if (pair.Key == NameTextBox)
                        BookProperty = Book => Book.Book.NameOfBook;
                    else if (pair.Key == PublisherTextBox)
                        BookProperty = Book => Book.Book.Publisher;

                    filteredBooks = filteredBooks.Where(Book => BookProperty(Book) == searchRequest).ToList();
                }
            }
            else if (pair.Value && pair.Key is ComboBox comboBox)
            {
                string searchRequest = comboBox.Text.Trim();
                if (pair.Key == OriginComboBox)
                {
                    filteredBooks = filteredBooks.Where(Book => Book.Book.Origin == searchRequest).ToList();
                }
                else if (pair.Key == NoveltyComboBox)
                {
                    filteredBooks = filteredBooks.Where(Book => Book.Book.Novelty == searchRequest).ToList();
                }
                else if (pair.Key == GradeComboBox)
                {
                    filteredBooks = filteredBooks.Where(Book => Book.Book.Grade == searchRequest).ToList();
                }
                else if (pair.Key == SectorComboBox)
                {
                    filteredBooks = filteredBooks.Where(Book => Book.Book.Sector == searchRequest).ToList();
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

    private bool CheckGenre(string genre, string[] BookGenres)
    {
        if (string.IsNullOrEmpty(genre))
            return true;

        string[] searchGenres = genre.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

        if (searchGenres.Length == 1)
        {
            return BookGenres.Contains(searchGenres[0]);
        }
        else if (searchGenres.Length == 2)
        {
            return BookGenres.Contains(searchGenres[0]) && BookGenres.Contains(searchGenres[1]);
        }

        return false;
    }

    private bool CheckAuthor(string author, string[] BookAuthors)
    {
        if (string.IsNullOrEmpty(author))
            return true;

        string[] searchAuthors = author.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
        return searchAuthors.All(searchAuthor => BookAuthors.Contains(searchAuthor));
    }

    private void AddBooksToPanel()
    {
        foreach (BookPanel Book in SuitableBooks)
            BookArea.Controls.Add(Book);
    }

    private void SaveToFileButton_Click(object sender, EventArgs e)
    {
        UpdateSearchFields();
        string filePath = $"{DateTime.Now:yyyyMMdd_HHmmss}.txt";

        using StreamWriter writer = new(filePath);
        writer.WriteLine($"Date and Time of Save: {DateTime.Now}");
        writer.WriteLine();

        foreach (var pair in searchFields)
        {
            if (!pair.Value)
                continue;

            string keyName = pair.Key.Name;

            if (string.IsNullOrEmpty(keyName))
                continue;

            int capitalIndex = 0;
            for (int i = 1; i < keyName.Length; i++)
            {
                if (!char.IsUpper(keyName[i]))
                    continue;

                capitalIndex = i;
                break;
            }

            if (capitalIndex > 0)
                keyName = keyName.Substring(0, capitalIndex);

            writer.WriteLine($"{keyName}: {pair.Key.Text}");
        }


        writer.WriteLine();

        foreach (var Book in SuitableBooks)
        {
            writer.WriteLine("Name of Book: " + Book.Book.NameOfBook);
            writer.WriteLine("Author: " + Book.Book.Author);
            writer.WriteLine("Publisher: " + Book.Book.Publisher);
            writer.WriteLine("Year: " + Book.Book.Year);
            writer.WriteLine("Sector: " + Book.Book.Sector);
            writer.WriteLine("Origin: " + Book.Book.Origin);
            writer.WriteLine("Novelty: " + Book.Book.Novelty);
            writer.WriteLine("Genre of Book: " + Book.Book.GenreOfBook);
            writer.WriteLine("Grade: " + Book.Book.Grade);
            writer.WriteLine("Status: " + Book.Book.Status);
            writer.WriteLine("\n");
        }
    }

    private void IsEnableToSearch(object? sender, EventArgs e)
    {
        UpdateSearchFields();
        bool isEnable = false;

        foreach (var pair in searchFields)
        {
            if (!pair.Value)
                continue;

            if (string.IsNullOrEmpty(pair.Key.Text))
            {
                isEnable = false;
                break;
            }

            isEnable = true;
        }

        SearchButton.Enabled = isEnable;
    }
}
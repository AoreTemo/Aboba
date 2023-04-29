namespace librarian
{
    public partial class SearchField : Form
    {
        public static List<BookPanel> SuitableBooks = new List<BookPanel>();

        public SearchField()
        {
            InitializeComponent();
            bookArea.Width = Width;
            Resize += (s, ev) =>
            {
                bookArea.Width = Width;
                bookArea.Height = Height - bookArea.Location.Y;
                searchTextBox.Width = WindowState == FormWindowState.Maximized ? SearchComboBox.Left - 20 : 653;
            };
            bookArea.Resize += bookArea_Resize;
            searchButton.Enabled = false;
            FormClosing += Search_FormClosing;
            searchTextBox.TextChanged += ButtonEnabler!;
            SearchComboBox.SelectedIndexChanged += ButtonEnabler!;
        }
        private void bookArea_Resize(object? sender, EventArgs e)
        {
            Form1.LocateBook(bookArea, SuitableBooks.OfType<Control>());
        }
        private void Search_FormClosing(object? sender, FormClosingEventArgs e)
        {
            SuitableBooks.Clear();
            e.Cancel = true;
            Hide();
        }
        private void ButtonEnabler(object sender, EventArgs e)
        {
            searchButton.Enabled = searchTextBox.Text != "" && searchTextBox.Text != null && SearchComboBox.SelectedIndex != -1;
        }
        private void searchButton_Click(object? sender, EventArgs e)
        {
            bookArea.Controls.Clear();
            SuitableBooks.Clear();
            foreach (var book in Form1.books.OfType<BookPanel>().Where(checkInput))
            {
                var bookCopy = new BookPanel(book, bookArea, this);
                bookCopy.panel1.Controls.Remove(bookCopy.editButton);
                SuitableBooks.Add(bookCopy);
            }

            Form1.LocateBook(bookArea, SuitableBooks.OfType<Control>());
        }
        private bool checkInput(BookPanel book)
        {
            switch (SearchComboBox.SelectedIndex)
            {
                case (int)Genres.NAME:
                    return book.book.NameOfBook.Contains(searchTextBox.Text);
                case (int)Genres.AUTHOR:
                    return book.book.Author.Contains(searchTextBox.Text);
                case (int)Genres.GENRE:
                    return book.book.GenreOfBook.Contains(searchTextBox.Text);
                case (int)Genres.YEAR:
                    return book.book.Year.Contains(searchTextBox.Text);
                case (int)Genres.PUBLISHER:
                    return book.book.Publisher.Contains(searchTextBox.Text);
                case (int)Genres.NOVELTY:
                    return book.book.Novelty.Contains(searchTextBox.Text);
                case (int)Genres.SECTOR:
                    return book.book.Sector.Contains(searchTextBox.Text);
                case (int)Genres.GRADE:
                    return book.book.Grade.Contains(searchTextBox.Text);
                case (int)Genres.ORIGIN:
                    return book.book.Origin.Contains(searchTextBox.Text);
                default:
                    return false;
            }
        }
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchValidating();
            if(searchTextBox.Text.Length > 30)
            {
                searchTextBox.Text = searchTextBox.Text.Substring(0, searchTextBox.Text.Length - 1);
            }
        }
        private void SearchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchValidating();
        }
        private void SearchValidating()
        {
            if (SearchComboBox.SelectedIndex == (int)Genres.YEAR)
            {
                searchTextBox.Text = Validator.Year_Validator(searchTextBox.Text);
            }
            else if (new int[] { (int)Genres.NAME, (int)Genres.AUTHOR, (int)Genres.PUBLISHER }.Contains(SearchComboBox.SelectedIndex))
            {
                searchTextBox.Text = Validator.RegularText_Validator(searchTextBox.Text);
            }
        }
    }
}

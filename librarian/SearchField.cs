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
            };
            bookArea.Resize += bookArea_Resize;
            searchButton.Enabled = false;
            FormClosing += Search_FormClosing;
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
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            searchButton.Enabled = searchTextBox.Text != "" && searchTextBox.Text != null;
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
            return book.book.NameOfBook.Contains(searchTextBox.Text);
        }
    }
}

namespace librarian
{
    internal class NumberAndProperty
    {
        private readonly Book _book;
        private readonly string[] _bookProperties;

        public NumberAndProperty(Book book)
        {
            _book = book;
            _bookProperties = new string[]
            {
                _book.NameOfBook,
                _book.Author,
                _book.GenreOfBook,
                _book.Year,
                _book.Publisher,
                _book.Novelty,
                _book.Sector,
                _book.Grade,
                _book.Origin,
                _book.Status
            };
        }

        public string GetBookProperty(int indexOfProperty)
        {
            return _bookProperties[indexOfProperty];
        }
    }
}
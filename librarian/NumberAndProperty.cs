namespace librarian
{
    internal class NumberAndProperty
    {
        private readonly Book _Book;
        private readonly string[] _BookProperties;

        public NumberAndProperty(Book Book)
        {
            _Book = Book;
            _BookProperties = new string[]
            {
                _Book.NameOfBook,
                _Book.Author,
                _Book.GenreOfBook,
                _Book.Year,
                _Book.Publisher,
                _Book.Novelty,
                _Book.Sector,
                _Book.Grade,
                _Book.Origin,
                _Book.Status
            };
        }

        public string GetBookProperty(int indexOfProperty)
        {
            return _BookProperties[indexOfProperty];
        }
    }
}
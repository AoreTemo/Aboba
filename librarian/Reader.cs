namespace librarian
{
    public class Reader
    {
        private BookPanel? favoriteBookByGrade;

        public Reader()
        {
            UpdateInfo();
        }

        public string FavoriteBook { get; private set; } = "";
        public string FavoriteAuthor { get; private set; } = "";
        public string FavoriteGenre { get; private set; } = "";
        public int CountOfBooks { get; private set; } = 0;

        public void UpdateInfo()
        {
            if (Books.AllBooks.Count != 0)
            {
                FavoriteBook = GetFavoriteBook();
                FavoriteAuthor = GetFavoriteAuthor();
                FavoriteGenre = GetFavoriteGenre();
                CountOfBooks = Books.Count;
            }
        }

        public string GetFavoriteBook()
        {
            List<string> result = new List<string>();
            int maxGrade = 0;

            foreach (var Book in Books.AllBooks)
            {
                if (int.Parse(Book.Book.Grade) > maxGrade)
                {
                    result.Clear();
                    maxGrade = int.Parse(Book.Book.Grade);
                    favoriteBookByGrade = Book;
                    result.Add(Book.Book.NameOfBook);
                    result.Add(Book.Book.Author);
                }
            }

            return $"{((result[0].Length > 24) ? result[0][..21] + "..." : result[0])}\n" +
                    $"{((result[1].Length > 24) ? result[1][..21] + "..." : result[1])}";
        }

        public string GetFavoriteAuthor()
        {
            return GetMostCommonValue(Books.AllBooks, Book => Book.Book.Author);
        }

        public string GetFavoriteGenre()
        {
            string favoriteGenre = GetMostCommonValue(Books.AllBooks, Book => Book.Book.GenreOfBook);

            if (favoriteGenre == "")
            {
                favoriteGenre = $"Genre of {GetFavoriteBook().Split("\n")[0]}";
            }

            return favoriteGenre;
        }

        public string GetMostCommonValue(List<BookPanel> Books, Func<BookPanel, string> propertySelector)
        {
            string result = "";
            Dictionary<string, int> values = new Dictionary<string, int>();

            foreach (var Book in Books)
            {
                string[] genres = propertySelector(Book).Split(',');
                foreach (string genre in genres)
                {
                    string value = genre.Trim();
                    if (!values.ContainsKey(value))
                    {
                        values.Add(value, 1);
                    }
                    else
                    {
                        values[value]++;
                    }
                }
            }

            if (values.Values.All(val => val == values.Values.First()))
            {
                result = propertySelector(favoriteBookByGrade!);
                return $"{((result.Length > 24) ? result[..21] + "..." : result)}";
            }

            int maxCount = 0;
            foreach (string value in values.Keys)
            {
                if (values[value] > maxCount)
                {
                    maxCount = values[value];
                    result = value;
                }
            }

            return result;
        }
    }
}

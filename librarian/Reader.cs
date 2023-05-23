namespace librarian
{
    public class Reader
    {
        private static BookPanel? favoriteBookByGrade;
        public string FavoriteBook { get; set; } = "";
        public string FavoriteAuthor { get; set; } = "";
        public string FavoriteGenre { get; set; } = "";
        public int CountOfBooks { get; private set; } = 0;

        public Reader()
        {
            UpdateInfo();
        }
        public void UpdateInfo()
        {
            if (Books.AllBooks.Count != 0)
            {
                FavoriteBook = GetFavoriteBook();
                FavoriteAuthor = GetFavoriteAuthor();
                FavoriteGenre = GetFavoriteGenre();
                CountOfBooks = Books.AllBooks.Count;
            }
        }

        public static string GetFavoriteBook()
        {
            List<string> result = new ();
            int maxGrade = 0;

            foreach (var book in Books.AllBooks)
            {
                if (int.Parse(book.book.Grade) > maxGrade)
                {
                    result.Clear();
                    maxGrade = int.Parse(book.book.Grade);
                    favoriteBookByGrade = book;
                    result.Add(book.book.NameOfBook);
                    result.Add(book.book.Author);
                }
            }

            return string.Concat($"{((result[0].Length > 24) ? result[0][..21] + "..." : result[0])}\n",
                $"{((result[1].Length > 24) ? result[1][..21] + "..." : result[1])}");
        }
        public static string GetFavoriteAuthor()
        {
            return GetMostCommonValue(Books.AllBooks, book => book.book.Author);
        }
        public static string GetFavoriteGenre()
        {
            return GetMostCommonValue(Books.AllBooks, book => book.book.GenreOfBook);
        }
        public static string GetMostCommonValue(List<BookPanel> books, Func<BookPanel, string> propertySelector)
        {
            string result = "";
            Dictionary<string, int> values = new();

            foreach (var book in books)
            {
                string value = propertySelector(book);
                if (!values.ContainsKey(value))
                {
                    values.Add(value, 1);
                }
                else
                {
                    values[value]++;
                }
            }

            if (values.Values.All(val => val <= 1))
            {
                result = propertySelector(favoriteBookByGrade!);
                return $"{((result.Length > 24) ? result[..21] + "..." : result)}\n"; ;

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

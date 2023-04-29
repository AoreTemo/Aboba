namespace librarian
{
    public class Reader
    {
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
            if (Form1.books.Count != 0)
            {
                FavoriteBook = GetFavoriteBook();
                FavoriteAuthor = GetFavoriteAuthor();
                FavoriteGenre = GetFavoriteGenre();
                CountOfBooks = Form1.books.Count;
            }
        }

        public static string GetFavoriteBook()
        {
            List<string> result = new List<string>();
            int maxGrade = 0;

            foreach (var book in Form1.books)
            {
                if (int.Parse(book.book.Grade) > maxGrade)
                {
                    result.Clear();
                    maxGrade = int.Parse(book.book.Grade);
                    result.Add(book.book.NameOfBook);
                    result.Add(book.book.Author);
                }
            }

            return $"Name:  {((result[0].Length > 9) ? result[0].Substring(0, 7) + "..." : result[0])}\n" +
                $"Author: {((result[1].Length > 9) ? result[1].Substring(0, 7) + "..." : result[1])}";
        }

        public static string GetFavoriteAuthor()
        {
            return GetMostCommonValue(Form1.books, book => book.book.Author);
        }
        public static string GetFavoriteGenre()
        {
            return GetMostCommonValue(Form1.books, book => book.book.GenreOfBook);
        }
        public static string GetMostCommonValue(List<BookPanel> books, Func<BookPanel, string> propertySelector)
        {
            string result = "";
            Dictionary<string, int> values = new Dictionary<string, int>();

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

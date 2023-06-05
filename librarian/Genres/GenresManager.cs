namespace librarian.Genres;

public static class GenresManager
{
    public static string[] GetGenres()
    {
        string genresText = File.ReadAllText(@"genres.txt");
        string[] genres = genresText.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

        return genres;
    }

    public static string GetTextGenres()
    {
        return File.ReadAllText(@"genres.txt");
    }
}

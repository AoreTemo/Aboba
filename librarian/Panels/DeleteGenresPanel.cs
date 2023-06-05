using librarian.Genres;

namespace librarian.Panels;

public partial class DeleteGenresPanel : UserControl
{
    public DeleteGenresPanel()
    {
        InitializeComponent();
        Load += DeleteGenresPanel_Load;

        VerifyDeletingButton.Enabled = false;
        BackColor = MyColor.LightGreen;
        BorderStyle = BorderStyle.FixedSingle;
        VerifyDeletingButton.BackColor = MyColor.Green;
    }

    public void UpdateGenresToGenresDeletingListBox()
    {
        GenresDeletingListBox.Items.Clear();

        string[] genres = GenresManager.GetGenres();

        for (int i = 5; i < genres.Length; i++)
        {
            GenresDeletingListBox.Items.Add(genres[i]);
        }
    }

    private void GenresDeletingListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        VerifyDeletingButton.Enabled = GenresDeletingListBox.SelectedIndex != -1;
    }

    private void VerifyDeletingButton_Click(object sender, EventArgs e)
    {
        string selectedGenre = GenresDeletingListBox.SelectedItem?.ToString()!;

        if (selectedGenre == null)
            return;

        string genresFilePath = Path.Combine(Application.StartupPath, "genres.txt");

        if (File.Exists(genresFilePath))
        {
            string[] genres = File.ReadAllText(genresFilePath).Split(", ");
            genres = genres.Where(genre => genre != selectedGenre).ToArray();
            string updatedGenres = string.Join(", ", genres);
            File.WriteAllText(genresFilePath, updatedGenres);
        }

        foreach (BookPanel BookPanel in Books.AllBooks)
        {
            if (!BookPanel.AllInfo.GenreInfo.Text.Contains(selectedGenre))
                continue;

            string[] genreParts = BookPanel.AllInfo.GenreInfo.Text.Split(", ");
            genreParts = genreParts.Where(genre => genre != selectedGenre).ToArray();
            BookPanel.AllInfo.GenreInfo.Text = string.Join(", ", genreParts);

            genreParts = BookPanel.Book.GenreOfBook.Split(", ");
            genreParts = genreParts.Where(genre => genre != selectedGenre).ToArray();
            BookPanel.Book.GenreOfBook = string.Join(", ", genreParts);
        }

        UpdateGenresToGenresDeletingListBox();
    }

    private void DeleteGenresPanel_Load(object? sender, EventArgs e)
    {
        UpdateGenresToGenresDeletingListBox();
    }
}

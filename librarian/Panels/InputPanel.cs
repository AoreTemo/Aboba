using librarian.Forms;
using librarian.Genres;

namespace librarian
{
    public partial class InputPanel : UserControl
    {
        private readonly Control bookParent = new();

        public InputPanel() { }

        public InputPanel(Control BookParent, EventHandler? saveButton_Click)
        {
            bookParent = BookParent;
            Anchor = AnchorStyles.None;

            InitializeComponent();
            Events_Init(saveButton_Click ?? SaveButton_Click);
            Panel_Init();

            GenreComboBox.Items.AddRange(GenresManager.GetGenres());

            saveButton.Enabled = false;
            AddGenreButton.Enabled = false;
        }

        private void SaveButton_Click(object? sender, EventArgs e)
        {
            FormManager.ControlSwitching(FormManager.GetAllControls(Parent!), true, c => !c.Enabled);

            Positioning.panelsPerRow = Positioning.CalculatePanelsPerRow(Parent!.Width);

            BookPanel newBookPanel = CreateBookPanel();

            Books.AllBooks.Add(newBookPanel);

            Positioning.LocateBook((Panel)bookParent, Books.AllBooks.OfType<Control>());

            Parent!.Controls.Remove(this);
        }

        private BookPanel CreateBookPanel()
        {
            string name = NameTextBox.Text;
            string author = AuthorTextBox.Text;
            string publisher = PublisherTextBox.Text;
            string year = YearTextBox.Text;
            string sector = SectorComboBox.Text;
            string origin = OriginComboBox.Text;
            string novelty = NoveltyComboBox.Text;
            string genres = string.Join(", ", GenreComboBox.CheckedItems.Cast<string>());
            string grade = GradeComboBox.Text;
            string status = StatusComboBox.Text;

            BookPanel newBookPanel = new BookPanel(name, author, publisher, year,
                sector, origin, novelty, genres, grade, status, bookParent);

            return newBookPanel;
        }

        private void CloseButton_Click(object? sender, EventArgs e)
        {
            string genres = string.Join(", ", GenreComboBox.Items.Cast<string>());

            File.WriteAllText(@"genres.txt", genres);

            if (Parent == null)
                return;

            FormManager.ControlSwitching(FormManager.GetAllControls(Parent), true, c => !c.Enabled);

            Parent.Controls.Remove(this);
        }

        private void TextBoxOrComboBox_TextChanged(object sender, EventArgs e)
        {
            bool allTextBoxesFilled = !panel1.Controls.OfType<TextBox>()
                .Where(tb => tb != AddYourGenreTextBox)
                .Any(textBox => string.IsNullOrEmpty(textBox.Text));

            bool allComboBoxesSelected = !panel1.Controls.OfType<ComboBox>()
                .Any(comboBox => comboBox.SelectedIndex == -1);

            bool genreSelected = GenreComboBox.CheckedItems.Count > 0;

            bool allFilled = allTextBoxesFilled && allComboBoxesSelected && genreSelected;

            saveButton.Enabled = allFilled;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            NameTextBox.Text = Validator.RegularText_Validator(NameTextBox.Text);
        }

        private void AuthorTextBox_TextChanged(object sender, EventArgs e)
        {
            AuthorTextBox.Text = Validator.RegularText_Validator(AuthorTextBox.Text);
        }

        private void PublisherTextBox_TextChanged(object sender, EventArgs e)
        {
            PublisherTextBox.Text = Validator.RegularText_Validator(PublisherTextBox.Text);
        }

        private void YearTextBox_TextChanged(object sender, EventArgs e)
        {
            YearTextBox.Text = Validator.Year_Validator(YearTextBox.Text);
        }

        private void AddYourGenreTextBox_TextChanged(object sender, EventArgs e)
        {
            AddGenreButton.Enabled = !string.IsNullOrEmpty(AddYourGenreTextBox.Text);
        }

        private void Panel_Init()
        {
            panel1.BackColor = MyColor.Green;
        }

        private void Events_Init(EventHandler SaveButton_Click)
        {
            PublisherTextBox.TextChanged += TextBoxOrComboBox_TextChanged!;
            YearTextBox.TextChanged += TextBoxOrComboBox_TextChanged!;
            AuthorTextBox.TextChanged += TextBoxOrComboBox_TextChanged!;
            NameTextBox.TextChanged += TextBoxOrComboBox_TextChanged!;

            GenreComboBox.SelectedValueChanged += TextBoxOrComboBox_TextChanged!;
            GradeComboBox.SelectedIndexChanged += TextBoxOrComboBox_TextChanged!;
            NoveltyComboBox.SelectedIndexChanged += TextBoxOrComboBox_TextChanged!;
            SectorComboBox.SelectedIndexChanged += TextBoxOrComboBox_TextChanged!;
            OriginComboBox.SelectedIndexChanged += TextBoxOrComboBox_TextChanged!;
            StatusComboBox.SelectedIndexChanged += TextBoxOrComboBox_TextChanged!;

            CloseButton.Click += CloseButton_Click!;
            saveButton.Click += SaveButton_Click!;
        }

        private void AddGenreButton_Click(object sender, EventArgs e)
        {
            string newGenre = AddYourGenreTextBox.Text;

            if (string.IsNullOrWhiteSpace(newGenre))
            {
                AddYourGenreTextBox.Text = "";

                return;
            }

            string genresFilePath = Path.Combine(Application.StartupPath, "genres.txt");
            string existingGenres = File.Exists(genresFilePath) ? File.ReadAllText(genresFilePath) : "";

            if (existingGenres.Split(',').Select(g => g.Trim()).Contains(newGenre))
            {
                MessageBox.Show("Such a genre already exists.", "Re-adding");

                AddYourGenreTextBox.Text = "";

                return;
            }

            GenreComboBox.Items.Add(newGenre);
            GenresForListBox.genres.Add(newGenre);

            string updatedGenres;

            if (string.IsNullOrEmpty(existingGenres))
            {
                updatedGenres = newGenre;
            }
            else
            {
                updatedGenres = existingGenres + ", " + newGenre;
            }

            File.WriteAllText(genresFilePath, updatedGenres);

            AddYourGenreTextBox.Text = "";
        }
    }
}

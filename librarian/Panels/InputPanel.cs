using System.Windows.Forms;

namespace librarian
{
    public partial class InputPanel : UserControl
    {
        private readonly Control BookParent = new();
        public InputPanel()
        {

        }
        public InputPanel(Control bookParent, EventHandler? saveButton_Click)
        {
            BookParent = bookParent;
            Anchor = AnchorStyles.None;
            InitializeComponent();
            Events_Init(saveButton_Click ?? SaveButton_Click);
            Panel_Init();
            saveButton.Enabled = false;
            AddGenreButton.Enabled = false;
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
            GenreComboBox.SelectedIndexChanged += TextBoxOrComboBox_TextChanged!;
            GradeComboBox.SelectedIndexChanged += TextBoxOrComboBox_TextChanged!;
            NoveltyComboBox.SelectedIndexChanged += TextBoxOrComboBox_TextChanged!;
            SectorComboBox.SelectedIndexChanged += TextBoxOrComboBox_TextChanged!;
            OriginComboBox.SelectedIndexChanged += TextBoxOrComboBox_TextChanged!;
            StatusComboBox.SelectedIndexChanged += TextBoxOrComboBox_TextChanged!;
            CloseButton.Click += CloseButton_Click!;
            saveButton.Click += SaveButton_Click!;
        }
        public void SaveButton_Click(object? sender, EventArgs e)
        {
            FormManager.ControlSwitching(FormManager.GetAllControls(Parent!), true, c => !c.Enabled);
            Positioning.panelsPerRow = Positioning.CalculatePanelsPerRow(Parent!.Width);
            Books.AllBooks.Add(new BookPanel(NameTextBox.Text, AuthorTextBox.Text, PublisherTextBox.Text,
                         YearTextBox.Text, SectorComboBox.Text, OriginComboBox.Text, NoveltyComboBox.Text,
                         string.Join(", ", GenreComboBox.CheckedItems.Cast<string>()), GradeComboBox.Text, StatusComboBox.Text, BookParent));
            Form1.LocateBook((Panel)BookParent, Books.AllBooks.OfType<Control>());
            Parent!.Controls.Remove(this);
        }
        public void CloseButton_Click(object? sender, EventArgs e)
        {
            if (Parent != null)
            {
                FormManager.ControlSwitching(FormManager.GetAllControls(Parent), true, c => !c.Enabled);
                Parent.Controls.Remove(this);
            }
        }
        private void TextBoxOrComboBox_TextChanged(object sender, EventArgs e)
        {
            bool allFilled = !panel1.Controls.OfType<TextBox>().Where(tb => tb != AddYourGenreTextBox).Any(textBox => string.IsNullOrEmpty(textBox.Text))
                && !panel1.Controls.OfType<ComboBox>().Any(comboBox => comboBox.SelectedIndex == -1);

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
        private void AddGenreButton_Click(object sender, EventArgs e)
        {
            GenreComboBox.Items.Add(AddYourGenreTextBox.Text);
            GenresForListBox.genres.Add(AddYourGenreTextBox.Text);
            AddYourGenreTextBox.Text = "";
        }
    }
}

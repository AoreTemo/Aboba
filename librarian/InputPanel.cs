namespace librarian
{
    public partial class InputPanel : UserControl
    {
        public InputPanel(Control parent, EventHandler? saveButton_Click)
        {
            Parent = parent;
            Anchor = AnchorStyles.None;
            InitializeComponent();
            Events_Init(saveButton_Click ?? SaveButton_Click);
            Panel_Init();
            saveButton.Enabled = false;
        }
        private void Panel_Init()
        {
            int x = (Parent!.Width - Width) / 2;
            int y = (Parent!.Height - Height) / 2;
            Location = new Point(x, y);
        }
        private void Events_Init(EventHandler SaveButton_Click)
        {
            PublisherTextBox.TextChanged += textBoxOrComboBox_TextChanged!;
            YearTextBox.TextChanged += textBoxOrComboBox_TextChanged!;
            AuthorTextBox.TextChanged += textBoxOrComboBox_TextChanged!;
            NameTextBox.TextChanged += textBoxOrComboBox_TextChanged!;
            GenreComboBox.SelectedIndexChanged += textBoxOrComboBox_TextChanged!;
            GradeComboBox.SelectedIndexChanged += textBoxOrComboBox_TextChanged!;
            NoveltyComboBox.SelectedIndexChanged += textBoxOrComboBox_TextChanged!;
            SectorComboBox.SelectedIndexChanged += textBoxOrComboBox_TextChanged!;
            OriginComboBox.SelectedIndexChanged += textBoxOrComboBox_TextChanged!;
            StatusComboBox.SelectedIndexChanged += textBoxOrComboBox_TextChanged!;
            CloseButton.Click += CloseButton_Click!;
            saveButton.Click += SaveButton_Click!;
        }
        public void SaveButton_Click(object? sender, EventArgs e)
        {
            Form1.ControlSwitching(true, Parent!, c => !c.Enabled);
            Positioning.panelsPerRow = Positioning.CalculatePanelsPerRow(Parent!.Width);
            Form1.books.Add(new BookPanel(NameTextBox.Text, AuthorTextBox.Text, PublisherTextBox.Text,
                         YearTextBox.Text, SectorComboBox.Text,  OriginComboBox.Text, NoveltyComboBox.Text,
                         GenreComboBox.Text, GradeComboBox.Text, Parent, Parent));
            Parent!.Controls.Remove(this);
            Positioning.currentColumn++;
            Positioning.CheckColumnAndRow();
        }
        public void CloseButton_Click(object? sender, EventArgs e)
        {
            if(Parent != null)
            {
                Form1.ControlSwitching(true, Parent, c => !c.Enabled);
                Parent.Controls.Remove(this);
            }
        }
        private void textBoxOrComboBox_TextChanged(object sender, EventArgs e)
        {
            bool allFilled = !panel1.Controls.OfType<TextBox>().Any(textBox => string.IsNullOrEmpty(textBox.Text))
                && !panel1.Controls.OfType<ComboBox>().Any(comboBox => comboBox.SelectedIndex == -1);

            saveButton.Enabled = allFilled;
        }

    }
}

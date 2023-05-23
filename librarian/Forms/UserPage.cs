namespace librarian.Forms
{
    public partial class UserPage : Form
    {
        private readonly Panel noBooks = new();

        private readonly Label FavoriteBookLabel = new();
        private readonly Label FavoriteAuthorLabel = new();
        private readonly Label FavoriteGenreLabel = new();
        private readonly Label AmountOfBooksLabel = new();
        public UserPage(Reader reader)
        {
            InitializeComponent();
            LabelsInit(reader);
            Anchor = AnchorStyles.None;
        }

        public void NoBooksInit()
        {
            noBooks.Size = new Size(Width, Height);
            noBooks.BackColor = Color.LightSkyBlue;
            Resize += (sender, e) => noBooks.Size = new Size(Width, Height);

            Label noBooksLabel = new()
            {
                Text = "There are no books.\nAdd any book to see your statistics.",
                Font = new("Segue UI", 36),
                Size = new(Width, Height),
                TextAlign = ContentAlignment.MiddleCenter
            };
            noBooksLabel.Location = new Point((Width - noBooksLabel.Width) / 2, (Height - noBooksLabel.Height) / 2);
            noBooks.Controls.Add(noBooksLabel);
            noBooks.Resize += (sender, e) => noBooksLabel.Size = new Size(Width, Height);
            Controls.Add(noBooks);
            noBooks.BringToFront();
        }
        private void LabelsInit(Reader reader)
        {
            int xPos = (Width / 2) + 10;

            LabelText_Init(reader);

            FavoriteBookLabel.Location = new Point(xPos, FavoriteBookTitle.Location.Y);
            FavoriteAuthorLabel.Location = new Point(xPos, FavoriteAuthorTitle.Location.Y);
            FavoriteGenreLabel.Location = new Point(xPos, FavoriteGenreTitle.Location.Y);
            AmountOfBooksLabel.Location = new Point(xPos, AmountOfBooksTitle.Location.Y);

            FavoriteBookLabel.Anchor = FavoriteBookTitle.Anchor;
            FavoriteAuthorLabel.Anchor = FavoriteAuthorTitle.Anchor;
            FavoriteGenreLabel.Anchor = FavoriteGenreTitle.Anchor;
            AmountOfBooksLabel.Anchor = AmountOfBooksTitle.Anchor;

            FavoriteBookLabel.Font = FavoriteAuthorLabel.Font = FavoriteGenreLabel.Font = AmountOfBooksLabel.Font = new Font("Segue UI", 18);

            FavoriteBookLabel.AutoSize = FavoriteAuthorLabel.AutoSize = FavoriteGenreLabel.AutoSize = AmountOfBooksLabel.AutoSize = true;

            infoPanel.Controls.AddRange(new Control[] { FavoriteBookLabel, FavoriteBookLabel, FavoriteAuthorLabel, FavoriteGenreLabel, AmountOfBooksLabel });
        }
        public void LabelText_Init(Reader reader)
        {
            FavoriteBookLabel.Text = reader.FavoriteBook;
            FavoriteAuthorLabel.Text = reader.FavoriteAuthor;
            FavoriteGenreLabel.Text = reader.FavoriteGenre;
            AmountOfBooksLabel.Text = Convert.ToString(reader.CountOfBooks);
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            FormManager.ControlSwitching(FormManager.GetAllControls(Parent!), true, c => !c.Enabled);
            if (Controls.Contains(noBooks))
            {
                Controls.Remove(noBooks);
            }

            Hide();
        }
    }
}

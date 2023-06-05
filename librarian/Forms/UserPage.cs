namespace librarian.Forms;

public partial class UserPage : Form
{
    public readonly Panel noBooks = new();

    private readonly Label FavoriteBookLabel = new();
    private readonly Label FavoriteAuthorLabel = new();
    private readonly Label FavoriteGenreLabel = new();
    private readonly Label AmountOfBooksLabel = new();
    private readonly Control ControlForPanel = new();
    
    public UserPage(Reader reader, Control controlForPanel)
    {
        InitializeComponent();
        LabelsInit(reader);

        ControlForPanel = controlForPanel;
        Anchor = AnchorStyles.None;
    }

    public void NoBooksInit()
    {

        noBooks.Size = new Size(Width, Height);
        noBooks.BackColor = MyColor.LightPurple;

        Resize += (sender, e) => noBooks.Size = new(Width, Height);

        Label noBooksLabel = new()
        {
            Text = "There are no Books.\nAdd any Book to see your statistics.",
            Font = new("Segue UI", 36),
            Size = new(Width, Height),
            TextAlign = ContentAlignment.MiddleCenter
        };

        int x = (Width - noBooksLabel.Width) / 2;
        int y = (Height - noBooksLabel.Height) / 2;

        noBooksLabel.Location = new(x, y);
        noBooks.Resize += (sender, e) => noBooksLabel.Size = new Size(Width, Height);
        noBooks.Controls.Add(noBooksLabel);
        
        noBooks.BringToFront();

        Controls.Add(noBooks);
    }

    public void LabelsInit(Reader reader)
    {
        int xPos = (Width / 2) + 10;

        LabelText_Init(reader);

        AdjustLabelPositionAndAnchor(FavoriteBookLabel, FavoriteBookTitle, xPos);
        AdjustLabelPositionAndAnchor(FavoriteAuthorLabel, FavoriteAuthorTitle, xPos);
        AdjustLabelPositionAndAnchor(FavoriteGenreLabel, FavoriteGenreTitle, xPos);
        AdjustLabelPositionAndAnchor(AmountOfBooksLabel, AmountOfBooksTitle, xPos);

        SetLabelSizeAndFont(FavoriteBookLabel);
        SetLabelSizeAndFont(FavoriteAuthorLabel);
        SetLabelSizeAndFont(FavoriteGenreLabel);
        SetLabelSizeAndFont(AmountOfBooksLabel);

        var labels = new Label[]
        {
            FavoriteBookLabel,
            FavoriteAuthorLabel,
            FavoriteGenreLabel,
            AmountOfBooksLabel
        };

        infoPanel.Controls.AddRange(labels);
    }

    private void AdjustLabelPositionAndAnchor(Label label, Label title, int xPos)
    {
        label.Location = new Point(xPos, title.Location.Y);
        label.Anchor = title.Anchor;
    }

    private void SetLabelSizeAndFont(Label label)
    {
        label.Size = FavoriteBookTitle.Size;
        label.Font = new Font("Segoe UI", 18);
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

using librarian.Panels;

namespace librarian;

public partial class BookPanel : UserControl
{
    public InputPanel? editPanel;
    private readonly Control EditPanelControl;
    private readonly Control parent;
    private readonly AllInfoAboutBook AllInfo = new();
    public Book book = new();
    public BookPanel(string nameOfBook, string author, string publisher, string year,
                     string sector, string origin, string novelty, string genre, string grade, string status,
                     Control control)
    {
        parent = control;
        InitializeComponent();
        Book_Initializator(nameOfBook, author, publisher, year, sector, origin, novelty, genre, grade, status);
        parent.Controls.Add(this);
        EditPanelControl = parent.Parent!;
        panel1.BackColor = MyColor.Coral;
    }
    public BookPanel(BookPanel other, Control control)
    {
        InitializeComponent();
        parent = control;
        EditPanelControl = parent.Parent!;
        editPanel = other.editPanel;
        book = other.book;
        BookLabels_Init(other.book.NameOfBook, other.book.Author, other.book.Publisher, other.book.Year, other.book.Sector, other.book.Origin,
            other.book.Novelty, other.book.GenreOfBook, other.book.Grade, other.book.Status);
    }
    private void Book_Initializator(string nameOfBook, string author, string publisher, string year,
                     string sector, string origin, string novelty, string genre, string grade, string status)
    {
        book.Properties_Init(nameOfBook, author, publisher, year, genre, sector, origin, novelty, grade, status);
        BookLabels_Init(book.NameOfBook, book.Author, book.Publisher, book.Year, book.Sector, book.Origin,
            book.Novelty, book.GenreOfBook, book.Grade, book.Status);
        Size = new Size(Positioning.PANEL_WIDTH, Positioning.PANEL_HEIGHT);
        panel1.Size = new Size(Positioning.PANEL_WIDTH, Positioning.PANEL_HEIGHT); ;
    }
    private void BookLabels_Init(string nameOfBook, string author, string publisher, string year,
                        string sector, string origin, string novelty, string genre, string grade, string status)
    {
        AllInfo.NameInfo.Text = nameOfBook.Length > 16 ? nameOfBook[..13] + "..." : nameOfBook;
        AllInfo.AuthorInfo.Text = author.Length > 16 ? author[..13] + "..." : author;
        AllInfo.PublisherInfo.Text = publisher.Length > 16 ? publisher[..13] + "..." : publisher;
        AllInfo.YearInfo.Text = year;
        AllInfo.SectorInfo.Text = sector;
        AllInfo.OriginInfo.Text = origin;
        AllInfo.NoveltyInfo.Text = novelty;
        AllInfo.GenreInfo.Text = genre;
        AllInfo.GradeInfo.Text = grade;
        AllInfo.StatusInfo.Text = status;
        AllInfo.Anchor = AnchorStyles.None;
        NameOfBookLabel.Text = nameOfBook.Length > 15 ? nameOfBook[..12] + "..." : nameOfBook;
        AuthorLabel.Text = author.Length > 22 ? author[..19] + "..." : author;
        YearLabel.Text = year;
    }
    private void EditButton_Click(object sender, EventArgs e)
    {
        editPanel = new InputPanel(parent, SaveChanges_Click!);
        editPanel.saveButton.Location = new Point((editPanel.Width - editPanel.saveButton.Width) / 2, 2);
        editPanel.NameTextBox.Text = book.NameOfBook;
        editPanel.AuthorTextBox.Text = book.Author;
        editPanel.PublisherTextBox.Text = book.Publisher;
        editPanel.YearTextBox.Text = book.Year;
        editPanel.GenreComboBox.SelectedItem = book.GenreOfBook;
        editPanel.GradeComboBox.SelectedItem = book.Grade;
        editPanel.NoveltyComboBox.SelectedItem = book.Novelty;
        editPanel.SectorComboBox.SelectedItem = book.Sector;
        editPanel.OriginComboBox.SelectedItem = book.Origin;
        editPanel.StatusComboBox.SelectedItem = book.Status;

        DeleteButton_Init();
        EditPanelControl.Controls.Add(editPanel);
        editPanel.BringToFront();
        editPanel.Location = new Point((EditPanelControl.Width - editPanel.Width) / 2, ((EditPanelControl.Height - editPanel.Height) / 2) - 20);
        FormManager.ControlSwitching(FormManager.GetAllControls(EditPanelControl), false, c => c != editPanel && c.Parent != editPanel && c.Parent != editPanel.panel1);

    }
    private void DeleteButton_Init()
    {
        Button deleteButton = new()
        {
            Text = "delete",
            Font = new Font("Segoe UI", 10),
            Size = new Size(editPanel!.saveButton.Width, editPanel!.saveButton.Height),
            BackColor = editPanel.saveButton.BackColor,
            FlatStyle = FlatStyle.Flat,
        };
        deleteButton.Click += DeleteButton_Click;
        editPanel.panel1.Controls.Add(deleteButton);
        deleteButton.Location = new Point(2, 2);
    }
    private void SaveChanges_Click(object sender, EventArgs e)
    {
        FormManager.ControlSwitching(FormManager.GetAllControls(EditPanelControl), true, c => !c.Enabled);
        Book_Initializator(editPanel!.NameTextBox.Text, editPanel.AuthorTextBox.Text, editPanel.PublisherTextBox.Text,
           editPanel.YearTextBox.Text, editPanel.SectorComboBox.Text, editPanel.OriginComboBox.Text,
           editPanel.NoveltyComboBox.Text, string.Join(", ", editPanel.GenreComboBox.CheckedItems.Cast<string>()), editPanel.GradeComboBox.Text, editPanel.StatusComboBox.Text);
        EditPanelControl!.Controls.Remove(editPanel);
    }
    private void DeleteButton_Click(object? sender, EventArgs e)
    {
        EditPanelControl!.Controls.Remove(editPanel);
        FormManager.ControlSwitching(FormManager.GetAllControls(EditPanelControl), true, c => !c.Enabled);
        parent.Controls.Remove(this);
        Books.AllBooks.Remove(this);
        if (parent != null && parent is Panel parentPanel)
            Form1.LocateBook(parentPanel, Books.AllBooks.OfType<Control>());
    }
    private void MoreButton_Click(object sender, EventArgs e)
    {
        EditPanelControl.Controls.Add(AllInfo);
        AllInfo.Location = new Point((EditPanelControl.Width - AllInfo.Width) / 2, ((EditPanelControl.Height - AllInfo.Height) / 2) - 20);
        AllInfo.BringToFront();
        AllInfo.CloseButton.Click += (s, e) => FormManager.ControlSwitching(FormManager.GetAllControls(EditPanelControl), true, c => c is MyButton);
        FormManager.ControlSwitching(FormManager.GetAllControls(EditPanelControl), false, c => c != AllInfo && c.Parent != AllInfo && c.Parent != AllInfo.panel1);
    }
}

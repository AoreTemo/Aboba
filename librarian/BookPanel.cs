namespace librarian
{
    public partial class BookPanel : UserControl
    {
        public InputPanel? editPanel;
        private Control EditPanelControl;
        private Control parent;
        public Book book = new Book();
        public BookPanel(string nameOfBook, string author, string publisher, string year,
                         string sector, string origin, string novelty, string genre, string grade,
                         Control control, Control editPanelControl)
        {
            EditPanelControl = editPanelControl;
            parent = control;
            InitializeComponent();
            Book_Initializator(nameOfBook, author, publisher, year, sector, origin, novelty, genre, grade);
            parent.Controls.Add(this);
            SetBooks_Properties();
        }
        public BookPanel(BookPanel other, Control control, Control editPanelControl)
        {
            InitializeComponent();
            EditPanelControl = editPanelControl;
            parent = control;
            editPanel = other.editPanel;
            book = other.book;
            BookLabels_Init(other.book.NameOfBook, other.book.Author, other.book.Publisher, other.book.Year, other.book.Sector, other.book.Origin,
                other.book.Novelty, other.book.GenreOfBook, other.book.Grade);
        }
    
        private void Book_Initializator(string nameOfBook, string author, string publisher, string year,
                         string sector, string origin, string novelty, string genre, string grade)
        {
            book.Properties_Init(nameOfBook, author, publisher, year, genre, sector, origin, novelty, grade);
            BookLabels_Init(book.NameOfBook, book.Author, book.Publisher, book.Year, book.Sector, book.Origin,
                book.Novelty, book.GenreOfBook, book.Grade);
        }
        private void SetBooks_Properties()
        {
            int x = Positioning.PANEL_MARGIN_LEFT_TOP + Positioning.currentColumn * (Positioning.PANEL_WIDTH + Positioning.PANEL_MARGIN_LEFT_TOP);
            int y = Positioning.PANEL_MARGIN_LEFT_TOP + Positioning.currentRow * (Positioning.PANEL_HEIGHT + Positioning.PANEL_MARGIN_LEFT_TOP);
            Location = new Point(x, y);
        }
        private void BookLabels_Init(string? nameOfBook, string author, string publisher, string year,
                            string sector, string origin, string novelty, string genre, string grade)
        {
            if (nameOfBook != null) NameOfBookLabel.Text = nameOfBook;
            if (author != null) AuthorLabel.Text = author;
            if (publisher != null) PublisherLabel.Text = publisher;
            if (year != null) YearLabel.Text = year;
            if (sector != null) SectorLabel.Text = sector;
            if (origin != null) OriginLabel.Text = origin;
            if (novelty != null) NoveltyLabel.Text = novelty;
            if (genre != null) GenreLabel.Text = genre;
            if (grade != null) GradeLabel.Text = grade;
        }
        private void editButton_Click(object sender, EventArgs e)
        {
            editPanel = new InputPanel(EditPanelControl, saveChanges_Click!);
            editPanel.saveButton.Location = new Point(40, editPanel!.GenreComboBox.Bottom + 10);
            DeleteButton_Init();
            EditPanelControl.Controls.Add(editPanel);
            editPanel.BringToFront();
        }
        private void DeleteButton_Init()
        {
            Button deleteButton = new Button();
            deleteButton.Text = "delete";
            deleteButton.Font = new Font("Segoe UI", 16);
            deleteButton.Size = new Size(editPanel!.saveButton.Width, editPanel!.saveButton.Height);
            deleteButton.BackColor = editPanel.saveButton.BackColor;
            deleteButton.Click += deleteButton_Click;
            editPanel.panel1.Controls.Add(deleteButton);
            deleteButton.Location = new Point(editPanel!.Width - deleteButton.Width - 10, editPanel!.GenreComboBox.Bottom + 10);
        }
        private void saveChanges_Click(object sender, EventArgs e)
        {
            Form1.ControlSwitching(true, EditPanelControl, c => !c.Enabled);
            Book_Initializator(editPanel!.NameTextBox.Text, editPanel.AuthorTextBox.Text, editPanel.PublisherTextBox.Text,
               editPanel.YearTextBox.Text, editPanel.SectorComboBox.Text, editPanel.OriginComboBox.Text,
               editPanel.NoveltyComboBox.Text, editPanel.GenreComboBox.Text, editPanel.GradeComboBox.Text);
            EditPanelControl!.Controls.Remove(editPanel);
        }
        private void deleteButton_Click(object? sender, EventArgs e)
        {
            EditPanelControl!.Controls.Remove(editPanel);
            Form1.ControlSwitching(true, EditPanelControl, c => !c.Enabled);
            parent.Controls.Remove(this);
            Form1.books.Remove(this);
            if (parent != null)
                Form1.LocateBook(parent, Form1.books.OfType<Control>());
        }
    }
}

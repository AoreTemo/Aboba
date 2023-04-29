using librarian.Panels;
namespace librarian
{
    public partial class BookPanel : UserControl
    {
        public InputPanel? editPanel;
        private Control EditPanelControl;
        private Control parent;
        private AllInfoAboutBook AllInfo = new AllInfoAboutBook();
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
        private void BookLabels_Init(string nameOfBook, string author, string publisher, string year,
                            string sector, string origin, string novelty, string genre, string grade)
        {
            AllInfo.NameInfo.Text = nameOfBook.Length > 16 ? nameOfBook.Substring(0, 13) + "..." : nameOfBook;
            AllInfo.AuthorInfo.Text = author.Length > 16 ? author.Substring(0, 13) + "..." : author;
            AllInfo.PublisherInfo.Text = publisher.Length > 16 ? publisher.Substring(0, 13) + "..." : publisher;
            AllInfo.YearInfo.Text = year;
            AllInfo.SectorInfo.Text = sector;
            AllInfo.OriginInfo.Text = origin;
            AllInfo.NoveltyInfo.Text = novelty;
            AllInfo.GenreInfo.Text = genre;
            AllInfo.GradeInfo.Text = grade;

            NameOfBookLabel.Text = nameOfBook.Length > 15 ? nameOfBook.Substring(0, 12) + "..." : nameOfBook;
            AuthorLabel.Text = author.Length > 22 ? author.Substring(0, 19) + "..." : author;
            PublisherLabel.Text = publisher.Length > 22 ? publisher.Substring(0, 19) + "..." : publisher;
            GenreLabel.Text = genre;
            YearLabel.Text = year;
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

        private void moreButton_Click(object sender, EventArgs e)
        {
            EditPanelControl.Controls.Add(AllInfo);
            AllInfo.Location = new Point((EditPanelControl.Width - AllInfo.Width) / 2, (EditPanelControl.Height - AllInfo.Height) / 2);
            AllInfo.BringToFront();
            Form1.ControlSwitching(false, EditPanelControl, c => c != AllInfo && c.Parent != AllInfo);
        }
    }
}

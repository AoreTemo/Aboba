using librarian.Forms;
using librarian.Panels;

namespace librarian
{
    public partial class BookPanel : UserControl
    {
        public AllInfoAboutBook AllInfo = new();
        public InputPanel EditPanel;
        public Book Book = new();

        private readonly Control editPanelControl;
        private readonly Control parent;

        public BookPanel(string nameOfBook, string author, string publisher,
            string year, string sector, string origin, string novelty,
            string genre, string grade, string status, Control control)
        {
            parent = control;

            InitializeComponent();
            Book_Initializator(nameOfBook, author, publisher, year, sector,
                origin, novelty, genre, grade, status);

            EditPanel = new(parent.Parent!, SaveChanges_Click!);
            parent.Controls.Add(this);

            editPanelControl = parent.Parent!;
            panel1.BackColor = MyColor.Coral;
        }

        public BookPanel(BookPanel other, Control control)
        {
            InitializeComponent();

            parent = control;
            editPanelControl = parent.Parent!;
            EditPanel = other.EditPanel;
            Book = other.Book;

            BookLabels_Init(other.Book.NameOfBook, other.Book.Author,
                other.Book.Publisher, other.Book.Year, other.Book.Sector,
                other.Book.Origin, other.Book.Novelty, other.Book.GenreOfBook,
                other.Book.Grade, other.Book.Status);
        }

        private void Book_Initializator(string nameOfBook, string author,
            string publisher, string year, string sector, string origin,
            string novelty, string genre, string grade, string status)
        {
            Book.Properties_Init(nameOfBook, author, publisher, year,
                genre, sector, origin, novelty, grade, status);
            BookLabels_Init(Book.NameOfBook, Book.Author, Book.Publisher,
                Book.Year, Book.Sector, Book.Origin, Book.Novelty,
                Book.GenreOfBook, Book.Grade, Book.Status);

            Size = new Size(Positioning.PANEL_WIDTH, Positioning.PANEL_HEIGHT);
            panel1.Size = new Size(Positioning.PANEL_WIDTH, Positioning.PANEL_HEIGHT);
        }

        private void BookLabels_Init(string nameOfBook, string author, string publisher,
            string year, string sector, string origin, string novelty,
            string genre, string grade, string status)
        {
            AllInfo.NameInfo.Text = nameOfBook;
            AllInfo.AuthorInfo.Text = author;
            AllInfo.PublisherInfo.Text = publisher;
            AllInfo.YearInfo.Text = year;
            AllInfo.SectorInfo.Text = sector;
            AllInfo.OriginInfo.Text = origin;
            AllInfo.NoveltyInfo.Text = novelty;
            AllInfo.GenreInfo.Text = genre;
            AllInfo.GradeInfo.Text = grade;
            AllInfo.StatusInfo.Text = status;
            AllInfo.Anchor = AnchorStyles.None;

            NameOfBookLabel.Text = nameOfBook;
            AuthorLabel.Text = author;
            YearLabel.Text = year;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {

            int EditPanelXPos = (EditPanel.Width - EditPanel.saveButton.Width) / 2;
            int EditPanelYPos = 2;

            EditPanel.saveButton.Location = new Point(EditPanelXPos, EditPanelYPos);
            EditPanel.NameTextBox.Text = Book.NameOfBook;
            EditPanel.AuthorTextBox.Text = Book.Author;
            EditPanel.PublisherTextBox.Text = Book.Publisher;
            EditPanel.YearTextBox.Text = Book.Year;
            EditPanel.GenreComboBox.SelectedItem = Book.GenreOfBook;
            EditPanel.GradeComboBox.SelectedItem = Book.Grade;
            EditPanel.NoveltyComboBox.SelectedItem = Book.Novelty;
            EditPanel.SectorComboBox.SelectedItem = Book.Sector;
            EditPanel.OriginComboBox.SelectedItem = Book.Origin;
            EditPanel.StatusComboBox.SelectedItem = Book.Status;

            string[] BookGenres = Book.GenreOfBook.Split(new string[] { ", " }, 
                StringSplitOptions.RemoveEmptyEntries);

            List<string> genresList = new (EditPanel.GenreComboBox.Items.Cast<string>());

            foreach (var genre in genresList.Where(genre => BookGenres.Contains(genre)))
            {
                int index = EditPanel.GenreComboBox.Items.IndexOf(genre);
                EditPanel.GenreComboBox.SetItemChecked(index, true);
            }

            if (EditPanel.GenreComboBox.SelectedItems.Count > 0)
                EditPanel.saveButton.Enabled = true;

            DeleteButton_Init();
            editPanelControl.Controls.Add(EditPanel);
            EditPanel.BringToFront();

            int xEditPanelPos = (editPanelControl.Width - EditPanel.Width) / 2;
            int yEditPanelPos = ((editPanelControl.Height - EditPanel.Height) / 2) - 20;

            EditPanel.Location = new(xEditPanelPos, yEditPanelPos);

            bool conditionForSwitching(Control c)
            {
                return c != EditPanel &&
                       c.Parent != EditPanel &&
                       c.Parent != EditPanel!.panel1;
            }

            FormManager.ControlSwitching(FormManager.GetAllControls(editPanelControl), 
                false, conditionForSwitching);
        }

        private void DeleteButton_Init()
        {
            Button deleteButton = new()
            {
                Text = "delete",
                Font = new ("Segoe UI", 10),
                Size = new (EditPanel!.saveButton.Width, EditPanel!.saveButton.Height),
                BackColor = EditPanel.saveButton.BackColor,
                FlatStyle = FlatStyle.Flat,
            };

            deleteButton.Click += DeleteButton_Click;
            deleteButton.Location = new(2, 2);

            EditPanel.panel1.Controls.Add(deleteButton);
        
            deleteButton.BringToFront();
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            FormManager.ControlSwitching(FormManager.GetAllControls(editPanelControl), 
                true, c => !c.Enabled);

            Book_Initializator(EditPanel!.NameTextBox.Text, EditPanel.AuthorTextBox.Text,
               EditPanel.PublisherTextBox.Text, EditPanel.YearTextBox.Text,
               EditPanel.SectorComboBox.Text, EditPanel.OriginComboBox.Text,
               EditPanel.NoveltyComboBox.Text,
               string.Join(", ", EditPanel.GenreComboBox.CheckedItems.Cast<string>()),
               EditPanel.GradeComboBox.Text, EditPanel.StatusComboBox.Text);

            editPanelControl!.Controls.Remove(EditPanel);
        }
        private void DeleteButton_Click(object? sender, EventArgs e)
        {
            FormManager.ControlSwitching(FormManager.GetAllControls(editPanelControl), 
                true, c => !c.Enabled);

            editPanelControl!.Controls.Remove(EditPanel);
            parent.Controls.Remove(this);
            Books.AllBooks.Remove(this);

            if (parent is Panel parentPanel)
                Positioning.LocateBook(parentPanel, Books.AllBooks.OfType<Control>());
        }
        private void MoreButton_Click(object sender, EventArgs e)
        {
            int x = (editPanelControl.Width - AllInfo.Width) / 2;
            int y = ((editPanelControl.Height - AllInfo.Height) / 2) - 20;

            AllInfo.Location = new Point(x, y);
            AllInfo.CloseButton.Click += (s, e) =>
            {
                FormManager.ControlSwitching(FormManager.GetAllControls(editPanelControl), 
                    true, c => c is MyButton);
            };

            editPanelControl.Controls.Add(AllInfo);
            AllInfo.BringToFront();

            bool conditionForSwitching(Control c)
            {
                return c != AllInfo &&
                       c.Parent != AllInfo &&
                       c.Parent != AllInfo.panel1;
            }

            FormManager.ControlSwitching(FormManager.GetAllControls(editPanelControl), 
                false, conditionForSwitching);
        }
    }
}

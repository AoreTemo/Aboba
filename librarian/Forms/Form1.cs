using librarian.Forms;
using librarian.Positions;
using static librarian.PropsEnum;

namespace librarian
{
    public partial class Form1 : Form
    {
        private static bool _isLocatingBooks = false;

        private int previousWidth;

        private MyButton? AddButton;
        private MyButton? SearchButton;
        private MyButton? UserInfoButton;

        public const int BUTTON_WIDTH = 135;
        public const int BUTTON_HEIGHT = 135;

        public const int MINIMUM_WIDTH = ((Positioning.PANEL_WIDTH * 2) + Positioning.PANEL_MARGIN_LEFT_TOP * 3) + 60 + BUTTON_WIDTH + 10;
        public const int MINIMUM_HEIGHT = 815;

        public SearchField? Search;
        public UserPage? UserInfo;

        public Reader? reader;

        public List<Control> AllControlsOnForm = new();

        public Form1()
        {
            InitializeComponent();
            InitializeForm();
            InitializeAddButton();
            InitializeSearchButton();
            InitializeUserInfoButton();
        }

        private void VisibleChange(object? sender, EventArgs e)
        {
            if (!Search!.Visible && !UserInfo!.Visible)
            {
                Show();
            }
        }
        private void InitializeForm()
        {
            MinimumSize = new(MINIMUM_WIDTH, MINIMUM_HEIGHT);
            Size = new(MINIMUM_WIDTH, MINIMUM_HEIGHT);
            BackColor = MyColor.DarkGreen;
            bookPanelContainer.Size = new Size(Width - 30 - BUTTON_WIDTH - 30, Height - 50);
            bookPanelContainer.BackColor = MyColor.Brown;
            reader = new();
            Search = new();
            UserInfo = new(reader);
            Resize += (s, e) =>
            {
                bookPanelContainer.Location = new Point(0, 0);
                bookPanelContainer.Size = new Size(Width - 30 - BUTTON_WIDTH - 30, Height - 50);
            };
            FormClosing += Form1_FormClosing!;
            Load += Form1_Load!;

            bookPanelContainer.Resize += BookPanelContainer_Resize;

            Search.VisibleChanged += VisibleChange;
            UserInfo.VisibleChanged += VisibleChange;
            AllControlsOnForm = FormManager.GetAllControls(this);
        }
        private void InitializeAddButton()
        {
            AddButton = new MyButton(20, "+", BUTTON_WIDTH, BUTTON_HEIGHT, Right - BUTTON_WIDTH - 30, Bottom - BUTTON_HEIGHT - 60, AddButton_Click);
            Controls.Add(AddButton);
            AddButton!.BringToFront();
        }
        private void InitializeSearchButton()
        {
            if (AddButton != null)
            {
                SearchButton = new MyButton(16, "Search", BUTTON_WIDTH, BUTTON_HEIGHT, Right - BUTTON_WIDTH - 30, AddButton.Top - BUTTON_HEIGHT - 20, SearchButton_Click);
            }
            Controls.Add(SearchButton);
            SearchButton!.BringToFront();
        }
        private void InitializeUserInfoButton()
        {
            if (SearchButton != null)
            {
                UserInfoButton = new MyButton(16, "User", BUTTON_WIDTH, BUTTON_HEIGHT, Right - BUTTON_WIDTH - 30, SearchButton.Top - BUTTON_HEIGHT - 20, UserInfoButton_Click);
            }
            Controls.Add(UserInfoButton);
            UserInfoButton!.BringToFront();
        }
        private void AddButton_Click(object? sender, EventArgs e)
        {
            InputPanel panel = new(bookPanelContainer, null);
            Controls.Add(panel);
            panel.BringToFront();
            panel.Location = new Point((Width - panel.Width) / 2, ((Height - panel.Height) / 2) - 20);
            FormManager.ControlSwitching(FormManager.GetAllControls(this), false, c => c != panel && c.Parent != panel.panel1 && c != panel.panel1);
        }
        private void SearchButton_Click(object? sender, EventArgs e)
        {
            Hide();
            Search!.Show();
        }
        private void UserInfoButton_Click(object? sender, EventArgs e)
        {
            reader!.UpdateInfo();

            UserInfo!.LabelText_Init(reader);
            if (Books.AllBooks.Count == 0)
            {
                UserInfo.NoBooksInit();
            }
            UserInfo.TopLevel = false;
            Controls.Add(UserInfo!);
            UserInfo.BringToFront();
            UserInfo.Location = new Point((Width - UserInfo.Width) / 2, (Height - UserInfo.Height) / 2);
            UserInfo.Anchor = AnchorStyles.None;
            FormManager.ControlSwitching(FormManager.GetAllControls(this), false, c => c is not Form && c.Parent != UserInfo.infoPanel && c != UserInfo.infoPanel);
            UserInfo!.Show();
        }
        private void BookPanelContainer_Resize(object? sender, EventArgs e)
        {
            if (bookPanelContainer.Width == previousWidth) return;
            Form1.LocateBook(bookPanelContainer!, Books.AllBooks.OfType<Control>());
            previousWidth = bookPanelContainer.Width;
        }
        public static void LocateBook(Panel control, IEnumerable<Control> books)
        {
            if (_isLocatingBooks) return;
            _isLocatingBooks = true;

            Positioning.panelsPerRow = Positioning.CalculatePanelsPerRow(control!.Width);

            Positioning.currentRow = 0;
            Positioning.currentColumn = 0;

            control.AutoScrollPosition = new Point(0, 0);

            foreach (BookPanel book in books.Where(book => book is BookPanel).Cast<BookPanel>())
            {
                int x = Positioning.GetCoordinateForBook(Coordinates.X) - control.AutoScrollPosition.X;
                int y = Positioning.GetCoordinateForBook(Coordinates.Y) - control.AutoScrollPosition.Y;
                book.Location = new Point(x, y);
                Positioning.currentColumn++;
                Positioning.CheckColumnAndRow();
            }
            _isLocatingBooks = false;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "booksStoring.txt"); ;

            using StreamWriter writer = new(filePath);
            foreach (var book in Books.AllBooks)
            {
                string line = $"{book.book.NameOfBook}|{book.book.Author}|{book.book.Publisher}|" +
                    $"{book.book.Year}|{book.book.Sector}|{book.book.Origin}|{book.book.Novelty}|" +
                    $"{book.book.GenreOfBook}|{book.book.Grade}|{book.book.Status}";
                writer.WriteLine(line);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "booksStoring.txt");

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                string[,] booksArray = new string[lines.Length, 10];


                for (int i = 0; i < lines.Length; i++)
                {
                    string[] values = lines[i].Split('|');

                    for (int j = 0; j < values.Length; j++)
                    {
                        booksArray[i, j] = values[j];
                    }
                }

                for (int i = 0; i < booksArray.GetLength(0); i++)
                {
                    Books.AllBooks.Add(new BookPanel(
                        booksArray[i, (int)NAME],
                        booksArray[i, (int)AUTHOR],
                        booksArray[i, (int)PUBLISHER],
                        booksArray[i, (int)YEAR],
                        booksArray[i, (int)SECTOR],
                        booksArray[i, (int)ORIGIN],
                        booksArray[i, (int)NOVELTY],
                        booksArray[i, (int)GENRE],
                        booksArray[i, (int)GRADE],
                        booksArray[i, (int)STATUS],
                        bookPanelContainer!));
                }
                Form1.LocateBook(bookPanelContainer!, Books.AllBooks.OfType<BookPanel>());
            }
        }
    }
}
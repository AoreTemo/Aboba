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

        public const int MINIMUM_WIDTH = 1080;
        public const int MINIMUM_HEIGHT = 815;

        public const int BUTTON_WIDTH = 135;
        public const int BUTTON_HEIGHT = 135;

        public SearchField? Search;
        public UserPage? UserInfo;

        public Reader? reader;


        public static List<BookPanel> books = new List<BookPanel>();

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
            MinimumSize = new Size(MINIMUM_WIDTH, MINIMUM_HEIGHT);
            Size = new Size(MINIMUM_WIDTH, MINIMUM_HEIGHT);
            bookPanelContainer.Size = new Size(Width, Height - 50);            
            Resize += (s, e) =>
            {
                bookPanelContainer.Location = new Point(0, 0);
                bookPanelContainer.Width = Width;
                bookPanelContainer.Size = new Size(Width, Height - 50);
            };
            FormClosing += Form1_FormClosing!;
            Load += Form1_Load!;
            reader = new Reader();
            Search = new SearchField();
            UserInfo = new UserPage(reader);

            bookPanelContainer.Resize += bookPanelContainer_Resize;

            Search.VisibleChanged += VisibleChange;
            UserInfo.VisibleChanged += VisibleChange;
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
            InputPanel panel = new InputPanel(bookPanelContainer!, null);
            bookPanelContainer!.Controls.Add(panel);
            panel.BringToFront();
            Form1.ControlSwitching(false, bookPanelContainer!, c => c != panel && c.Parent != panel);
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
            if (books.Count == 0)
            {
                UserInfo.noBooks_Init();
            }
            UserInfo.TopLevel = false;
            Controls.Add(UserInfo!);
            UserInfo.BringToFront();
            UserInfo.Location = new Point((Width - UserInfo.Width) / 2, (Height - UserInfo.Height) / 2);
            UserInfo.Anchor = AnchorStyles.None;
            UserInfo!.Show();
        }
        private void bookPanelContainer_Resize(object? sender, EventArgs e)
        {
            if (bookPanelContainer.Width == previousWidth) return;
            Form1.LocateBook(bookPanelContainer!, Form1.books.OfType<Control>());
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

            foreach (BookPanel book in books.Where(book => book is BookPanel))
            {
                int x = Positioning.GetCoordinateForBook(Coordinates.X) - control.AutoScrollPosition.X;
                int y = Positioning.GetCoordinateForBook(Coordinates.Y) - control.AutoScrollPosition.Y;
                book.Location = new Point(x, y);
                Positioning.currentColumn++;
                Positioning.CheckColumnAndRow();
            }
            _isLocatingBooks = false;
        }
        public static void ControlSwitching(bool value, Control control, Func<Control, bool> condition)
        {
            if (control != null)
            {
                foreach (Control element in control.Controls.OfType<Control>().Where(condition))
                    element.Enabled = value;
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "booksStoring.txt"); ;

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var book in books)
                {
                    string line = $"{book.book.NameOfBook}|{book.book.Author}|{book.book.Publisher}|" +
                        $"{book.book.GenreOfBook}|{book.book.Year}|{book.book.Origin}|{book.book.Novelty}|" +
                        $"{book.book.Sector}|{book.book.Grade}";
                    writer.WriteLine(line);
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "booksStoring.txt");

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                string[,] booksArray = new string[lines.Length, 9];


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
                    books.Add(new BookPanel(
                        booksArray[i, (int)NAME],
                        booksArray[i, (int)AUTHOR],
                        booksArray[i, (int)PUBLISHER],
                        booksArray[i, (int)YEAR],
                        booksArray[i, (int)SECTOR],
                        booksArray[i, (int)ORIGIN],
                        booksArray[i, (int)NOVELTY],
                        booksArray[i, (int)GENRE],
                        booksArray[i, (int)GRADE],
                        bookPanelContainer!,
                        bookPanelContainer!));
                }
                Form1.LocateBook(bookPanelContainer!, Form1.books.OfType<BookPanel>());
            }
        }
    }
}
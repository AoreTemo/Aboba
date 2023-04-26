using System.Windows.Forms;

namespace librarian
{
    public partial class Form1 : Form
    {
        private MyButton? addButton;
        private MyButton? searchButton;

        public const int MINIMUM_WIDTH = 1080;
        public const int MINIMUM_HEIGHT = 800;

        public SearchField Search = new SearchField();
        public static List<BookPanel> books = new List<BookPanel>();

        public Form1()
        {
            InitializeComponent();
            InitializeForm();
            InitializeAddButton();
            InitializeSearchButton();
            Resize += Form1_Resize;
            Search.VisibleChanged += Search_VisibleChanged;
        }
        private void Search_VisibleChanged(object? sender, EventArgs e)
        {
            if (!Search.Visible)
            {
                Show();
            }
        }
        private void InitializeForm()
        {
            MinimumSize = new Size(MINIMUM_WIDTH, MINIMUM_HEIGHT);
            Size = new Size(MINIMUM_WIDTH, MINIMUM_HEIGHT);
            flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel1.AutoScroll = true;
        }
        private void InitializeAddButton()
        {
            int ADD_BUTTON_WIDTH = Convert.ToInt32(MinimumSize.Width / 8);
            int ADD_BUTTON_HEIGHT = ADD_BUTTON_WIDTH;
            addButton = new MyButton(20, "+", ADD_BUTTON_WIDTH, ADD_BUTTON_HEIGHT, Right - ADD_BUTTON_WIDTH - 30, Bottom - ADD_BUTTON_HEIGHT - 60, AddButton_Click);
            addButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Controls.Add(addButton);
        }
        private void AddButton_Click(object? sender, EventArgs e)
        {
            InputPanel panel = new InputPanel(this, null);
            Controls.Add(panel);
            panel.BringToFront();
            Form1.ControlSwitching(false, this, c => c != panel && c.Parent != panel);
        }
        private void InitializeSearchButton()
        {
            const int SEARCH_BUTTON_WIDTH = 135;
            int SEARCH_BUTTON_HEIGHT = 135;
            if (addButton != null)
            {
                searchButton = new MyButton(16, "Search", SEARCH_BUTTON_WIDTH, SEARCH_BUTTON_HEIGHT, Right - SEARCH_BUTTON_WIDTH - 30, addButton.Top - SEARCH_BUTTON_HEIGHT - 20, searchButton_Click);
                searchButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            }
            Controls.Add(searchButton);
        }
        private void searchButton_Click(object? sender, EventArgs e)
        {
            Hide();
            Search.Show();
        }
        private void Form1_Resize(object? sender, EventArgs e)
        {
            flowLayoutPanel1_Resize();
            LocateBook(this, books.OfType<Control>());
        }
        public static void LocateBook(Control control, IEnumerable<Control> books)
        {
            if (control != null)
                Positioning.panelsPerRow = Positioning.CalculatePanelsPerRow(control.Width);

            Positioning.currentRow = Positioning.currentColumn = 0;

            foreach (var book in books.Where(book => book is BookPanel))
            {
                int x = Positioning.GetCoordinateForBook(Coordinates.X);
                int y = Positioning.GetCoordinateForBook(Coordinates.Y);
                book.Location = new Point(x, y);
                control.Controls.Add(book);
                Positioning.currentColumn++;
                Positioning.CheckColumnAndRow();
            }
        }

        public static void ControlSwitching(bool value, Control control, Func<Control, bool> condition)
        {
            if (control != null)
            {
                foreach (Control element in control.Controls.OfType<Control>().Where(condition))
                    element.Enabled = value;
            }
        }
        private void flowLayoutPanel1_Resize()
        {
            flowLayoutPanel1.Size = new Size(Width, Height);
        }
    }
}
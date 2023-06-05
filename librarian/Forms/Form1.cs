using librarian.Forms;
using librarian.Panels;

namespace librarian;

public partial class Form1 : Form
{
    public const int BUTTON_WIDTH = 135;
    public const int BUTTON_HEIGHT = 135;
    public const int BUTTON_PADDING = 40;

    public const int MINIMUM_WIDTH = 3 * Positioning.PANEL_WIDTH  + 4 * 
        Positioning.PANEL_MARGIN_LEFT_TOP + 2 * BUTTON_PADDING + BUTTON_WIDTH;
    public const int MINIMUM_HEIGHT = 815;

    public List<Control> AllControlsOnForm = new();

    public SearchField? Search;
    public UserPage? UserInfo;

    public Reader? reader;


    private int previousWidth;

    private MyButton DeleteGenresButton;
    private MyButton UserInfoButton;
    private MyButton SearchButton;
    private MyButton AddButton;

    private readonly DeleteGenresPanel DeleteGenresPanel =  new();
    private bool isDeleteGenresPanelOpened = false;

    public Form1()
    {
        InitializeComponent();
        InitializeForm();
    }

    private void InitializeButtons()
    {
        InitializeDeleteGenresButton();
        InitializeAddButton();
        InitializeSearchButton();
        InitializeUserInfoButton();
    }

    private void VisibleChange(object? sender, EventArgs e)
    {
        if (Search!.Visible || UserInfo!.Visible)
            return;

        Show();
    }

    private void InitializeForm()
    {
        MinimumSize = new(MINIMUM_WIDTH, MINIMUM_HEIGHT);
        Size = new(MINIMUM_WIDTH, MINIMUM_HEIGHT);
        BackColor = MyColor.DarkGreen;
        BookPanelContainer.Size = new(Width - 2 * BUTTON_PADDING - BUTTON_WIDTH, Height);
        BookPanelContainer.BackColor = MyColor.Brown;
        BookPanelContainer.AutoScrollMargin = new Size(BookPanelContainer.Width, BookPanelContainer.Height);
        reader = new Reader();
        Search = new SearchField();
        UserInfo = new UserPage(reader, this);
        
        Resize += (s, e) =>
        {
            BookPanelContainer.Location = new(0, 0);
            BookPanelContainer.Size = new(Width - 2 * BUTTON_PADDING - BUTTON_WIDTH, Height);
        };

        FormClosing += Form1_FormClosing!;
        Load += Form1_Load!;

        BookPanelContainer.Resize += BookPanelContainer_Resize;

        Search.VisibleChanged += VisibleChange;
        UserInfo.VisibleChanged += VisibleChange;
        AllControlsOnForm = FormManager.GetAllControls(this);

        InitializeButtons();

        int x = DeleteGenresButton.Left - DeleteGenresPanel.Width;
        int y = DeleteGenresButton.Top;
        DeleteGenresPanel.Location = new Point(x, y);
        DeleteGenresPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        DeleteGenresPanel.Hide();

        Controls.Add(DeleteGenresPanel);
    }

    private void InitializeAddButton()
    {
        int x = Width - BUTTON_WIDTH - BUTTON_PADDING;
        int y = Bottom - BUTTON_HEIGHT - 60;

        AddButton = InitializeButton("Add", AddButton_Click, x, y);
    }

    private void InitializeSearchButton()
    {
        if (AddButton == null) return;

        int x = Width - BUTTON_WIDTH - BUTTON_PADDING;
        int y = AddButton.Top - BUTTON_HEIGHT - 20;

        SearchButton = InitializeButton("Search", SearchButton_Click, x, y);
    }

    private void InitializeUserInfoButton()
    {
        if (SearchButton == null) return;

        int x = Width - BUTTON_WIDTH - BUTTON_PADDING;
        int y = SearchButton.Top - BUTTON_HEIGHT - 20;

        UserInfoButton = InitializeButton("User", UserInfoButton_Click, x, y);
    }

    private void InitializeDeleteGenresButton()
    {
        int x = Width - BUTTON_WIDTH - BUTTON_PADDING;
        int y = 20;

        DeleteGenresButton = InitializeButton("Delete genre", DeleteGenresButton_Click, x, y, anchorControl: this);
    }

    private MyButton InitializeButton(string text, EventHandler clickHandler, int x, int y, Control? anchorControl = null)
    {
        int buttonWidth = BUTTON_WIDTH;
        int buttonHeight = BUTTON_HEIGHT;

        MyButton button = new MyButton(16, text, buttonWidth, buttonHeight,
            x, y, clickHandler);

        if (anchorControl != null)
        {
            button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        }
        else
        {
            button.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        }

        Controls.Add(button);
        button.BringToFront();

        return button;
    }

    private void DeleteGenresButton_Click(object? sender, EventArgs e)
    {
        if (isDeleteGenresPanelOpened)
        {
            DeleteGenresPanel.Hide();
        }
        else
        {
            DeleteGenresPanel.Show();
            DeleteGenresPanel.UpdateGenresToGenresDeletingListBox();
            DeleteGenresPanel.BringToFront();
        }
        isDeleteGenresPanelOpened = !isDeleteGenresPanelOpened;
    }

    private void AddButton_Click(object? sender, EventArgs e)
    {
        InputPanel panel = new(BookPanelContainer, null);
        Controls.Add(panel);
        panel.BringToFront();
        panel.Location = new((Width - panel.Width) / 2, ((Height - panel.Height) / 2) - 20);

        bool conditionForSwitching(Control c)
        {
            return c != panel &&
                c.Parent != panel.panel1 &&
                c != panel.panel1;
        }

        List<Control> allControls = FormManager.GetAllControls(this);
        FormManager.ControlSwitching(allControls, false, conditionForSwitching);
    }

    private void SearchButton_Click(object? sender, EventArgs e)
    {
        Hide();
        Search!.Show();
    }

    private void UserInfoButton_Click(object? sender, EventArgs e)
    {

        if (Books.AllBooks.Count == 0)
        {
            UserInfo.NoBooksInit();
            UserInfo.infoPanel.Parent!.Controls.Add(UserInfo.noBooks);
            UserInfo.infoPanel.Parent.Controls.Remove(UserInfo.infoPanel);
            UserInfo.noBooks.Controls.Add(UserInfo.CloseButton);
        }
        else if(UserInfo.Controls.Contains(UserInfo.noBooks))
        {
            UserInfo.Controls.Remove(UserInfo.noBooks);
            UserInfo.noBooks.Parent!.Controls.Add(UserInfo.infoPanel);
            UserInfo.infoPanel.BringToFront();
            UserInfo.infoPanel.Controls.Add(UserInfo.CloseButton);
            reader!.UpdateInfo();
            UserInfo!.LabelsInit(reader);
        }
        else
        {
            UserInfo.infoPanel.BringToFront();
            UserInfo.infoPanel.Controls.Add(UserInfo.CloseButton);
            reader!.UpdateInfo();
            UserInfo!.LabelsInit(reader);
        }

        int x = UserInfo.CloseButton.Parent!.Width - UserInfo.CloseButton.Width - 5;
        int y = 5;

        UserInfo.CloseButton.Location = new(x, y);
        UserInfo.CloseButton.BringToFront();
        UserInfo.TopLevel = false;
        Controls.Add(UserInfo!);
        UserInfo.BringToFront();
        UserInfo.Location = new Point((Width - UserInfo.Width) / 2, (Height - UserInfo.Height) / 2);
        UserInfo.Anchor = AnchorStyles.None;
        FormManager.ControlSwitching(FormManager.GetAllControls(this), false, 
            c => c is not Form && 
            c.Parent != UserInfo.infoPanel && 
            c != UserInfo.infoPanel &&
            c.Parent != UserInfo.noBooks &&
            c != UserInfo.noBooks);
        UserInfo!.Show();
    }
    private void BookPanelContainer_Resize(object? sender, EventArgs e)
    {
        if (BookPanelContainer.Width == previousWidth) return;
        Books.SetLocationForAllBooks(BookPanelContainer!, Books.AllBooks);
        previousWidth = BookPanelContainer.Width;
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        Books.WriteAllBooksToFile();
    }
    private void Form1_Load(object sender, EventArgs e)
    {
        Books.FillBooksFromFile(BookPanelContainer);
    }
}
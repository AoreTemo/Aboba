using librarian.Panels;
namespace librarian;

partial class SearchField
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchField));
        SearchButton = new Button();
        BookArea = new CustomPanel();
        SearchingInputPanel = new Panel();
        YearRadioButton = new CheckBox();
        YearTextBox = new TextBox();
        GradeRadioButton = new CheckBox();
        NoveltyRadioButton = new CheckBox();
        GenreRadioButton = new CheckBox();
        AuthorRadioButton = new CheckBox();
        OriginRadioButton = new CheckBox();
        SectorRadioButton = new CheckBox();
        PublisherRadioButton = new CheckBox();
        NameRadioButton = new CheckBox();
        GradeComboBox = new ComboBox();
        OriginComboBox = new ComboBox();
        NoveltyComboBox = new ComboBox();
        SectorComboBox = new ComboBox();
        GenreTextBox = new TextBox();
        PublisherTextBox = new TextBox();
        AuthorTextBox = new TextBox();
        NameTextBox = new TextBox();
        SaveToFileButton = new Button();
        SeparatorPictureBox = new PictureBox();
        HorizontalSeparatorPictureBox = new PictureBox();
        SearchingInputPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)SeparatorPictureBox).BeginInit();
        ((System.ComponentModel.ISupportInitialize)HorizontalSeparatorPictureBox).BeginInit();
        SuspendLayout();
        // 
        // SearchButton
        // 
        SearchButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        SearchButton.BackColor = Color.FromArgb(134, 147, 117);
        SearchButton.FlatStyle = FlatStyle.Flat;
        SearchButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
        SearchButton.Location = new Point(947, 18);
        SearchButton.Name = "SearchButton";
        SearchButton.Size = new Size(121, 61);
        SearchButton.TabIndex = 1;
        SearchButton.Text = "Search";
        SearchButton.UseVisualStyleBackColor = false;
        SearchButton.Click += SearchButton_Click;
        // 
        // BookArea
        // 
        BookArea.AutoScroll = true;
        BookArea.BackColor = Color.SeaGreen;
        BookArea.Location = new Point(0, 446);
        BookArea.Name = "BookArea";
        BookArea.Size = new Size(1127, 382);
        BookArea.TabIndex = 2;
        // 
        // SearchingInputPanel
        // 
        SearchingInputPanel.BackColor = Color.DarkSlateGray;
        SearchingInputPanel.Controls.Add(YearRadioButton);
        SearchingInputPanel.Controls.Add(YearTextBox);
        SearchingInputPanel.Controls.Add(GradeRadioButton);
        SearchingInputPanel.Controls.Add(NoveltyRadioButton);
        SearchingInputPanel.Controls.Add(GenreRadioButton);
        SearchingInputPanel.Controls.Add(AuthorRadioButton);
        SearchingInputPanel.Controls.Add(OriginRadioButton);
        SearchingInputPanel.Controls.Add(SectorRadioButton);
        SearchingInputPanel.Controls.Add(PublisherRadioButton);
        SearchingInputPanel.Controls.Add(NameRadioButton);
        SearchingInputPanel.Controls.Add(GradeComboBox);
        SearchingInputPanel.Controls.Add(OriginComboBox);
        SearchingInputPanel.Controls.Add(NoveltyComboBox);
        SearchingInputPanel.Controls.Add(SectorComboBox);
        SearchingInputPanel.Controls.Add(GenreTextBox);
        SearchingInputPanel.Controls.Add(PublisherTextBox);
        SearchingInputPanel.Controls.Add(AuthorTextBox);
        SearchingInputPanel.Controls.Add(NameTextBox);
        SearchingInputPanel.Location = new Point(1, 0);
        SearchingInputPanel.Name = "SearchingInputPanel";
        SearchingInputPanel.Size = new Size(930, 452);
        SearchingInputPanel.TabIndex = 5;
        // 
        // YearRadioButton
        // 
        YearRadioButton.AutoSize = true;
        YearRadioButton.Location = new Point(426, 376);
        YearRadioButton.Name = "YearRadioButton";
        YearRadioButton.Size = new Size(18, 17);
        YearRadioButton.TabIndex = 32;
        YearRadioButton.UseVisualStyleBackColor = true;
        // 
        // YearTextBox
        // 
        YearTextBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
        YearTextBox.Location = new Point(24, 359);
        YearTextBox.Name = "YearTextBox";
        YearTextBox.PlaceholderText = "Year";
        YearTextBox.Size = new Size(387, 61);
        YearTextBox.TabIndex = 31;
        // 
        // GradeRadioButton
        // 
        GradeRadioButton.AutoSize = true;
        GradeRadioButton.Location = new Point(892, 294);
        GradeRadioButton.Name = "GradeRadioButton";
        GradeRadioButton.Size = new Size(18, 17);
        GradeRadioButton.TabIndex = 29;
        GradeRadioButton.UseVisualStyleBackColor = true;
        // 
        // NoveltyRadioButton
        // 
        NoveltyRadioButton.AutoSize = true;
        NoveltyRadioButton.Location = new Point(892, 206);
        NoveltyRadioButton.Name = "NoveltyRadioButton";
        NoveltyRadioButton.Size = new Size(18, 17);
        NoveltyRadioButton.TabIndex = 28;
        NoveltyRadioButton.UseVisualStyleBackColor = true;
        // 
        // GenreRadioButton
        // 
        GenreRadioButton.AutoSize = true;
        GenreRadioButton.Location = new Point(892, 120);
        GenreRadioButton.Name = "GenreRadioButton";
        GenreRadioButton.Size = new Size(18, 17);
        GenreRadioButton.TabIndex = 27;
        GenreRadioButton.UseVisualStyleBackColor = true;
        // 
        // AuthorRadioButton
        // 
        AuthorRadioButton.AutoSize = true;
        AuthorRadioButton.Location = new Point(892, 34);
        AuthorRadioButton.Name = "AuthorRadioButton";
        AuthorRadioButton.Size = new Size(18, 17);
        AuthorRadioButton.TabIndex = 26;
        AuthorRadioButton.UseVisualStyleBackColor = true;
        // 
        // OriginRadioButton
        // 
        OriginRadioButton.AutoSize = true;
        OriginRadioButton.Location = new Point(426, 294);
        OriginRadioButton.Name = "OriginRadioButton";
        OriginRadioButton.Size = new Size(18, 17);
        OriginRadioButton.TabIndex = 25;
        OriginRadioButton.UseVisualStyleBackColor = true;
        // 
        // SectorRadioButton
        // 
        SectorRadioButton.AutoSize = true;
        SectorRadioButton.Location = new Point(426, 206);
        SectorRadioButton.Name = "SectorRadioButton";
        SectorRadioButton.Size = new Size(18, 17);
        SectorRadioButton.TabIndex = 24;
        SectorRadioButton.UseVisualStyleBackColor = true;
        // 
        // PublisherRadioButton
        // 
        PublisherRadioButton.AutoSize = true;
        PublisherRadioButton.Location = new Point(426, 120);
        PublisherRadioButton.Name = "PublisherRadioButton";
        PublisherRadioButton.Size = new Size(18, 17);
        PublisherRadioButton.TabIndex = 23;
        PublisherRadioButton.UseVisualStyleBackColor = true;
        // 
        // NameRadioButton
        // 
        NameRadioButton.AutoSize = true;
        NameRadioButton.Location = new Point(426, 34);
        NameRadioButton.Name = "NameRadioButton";
        NameRadioButton.Size = new Size(18, 17);
        NameRadioButton.TabIndex = 22;
        NameRadioButton.UseVisualStyleBackColor = true;
        // 
        // GradeComboBox
        // 
        GradeComboBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
        GradeComboBox.FormattingEnabled = true;
        GradeComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
        GradeComboBox.Location = new Point(488, 273);
        GradeComboBox.Name = "GradeComboBox";
        GradeComboBox.Size = new Size(387, 62);
        GradeComboBox.TabIndex = 20;
        GradeComboBox.Text = "Grade";
        // 
        // OriginComboBox
        // 
        OriginComboBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
        OriginComboBox.FormattingEnabled = true;
        OriginComboBox.Items.AddRange(new object[] { "Bought", "Donated", "Borrowed" });
        OriginComboBox.Location = new Point(24, 273);
        OriginComboBox.Name = "OriginComboBox";
        OriginComboBox.Size = new Size(387, 62);
        OriginComboBox.TabIndex = 18;
        OriginComboBox.Text = "Origin";
        // 
        // NoveltyComboBox
        // 
        NoveltyComboBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
        NoveltyComboBox.FormattingEnabled = true;
        NoveltyComboBox.Items.AddRange(new object[] { "On hand", "In the library", "Loaned out" });
        NoveltyComboBox.Location = new Point(488, 185);
        NoveltyComboBox.Name = "NoveltyComboBox";
        NoveltyComboBox.Size = new Size(387, 62);
        NoveltyComboBox.TabIndex = 16;
        NoveltyComboBox.Text = "Novelty";
        // 
        // SectorComboBox
        // 
        SectorComboBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
        SectorComboBox.FormattingEnabled = true;
        SectorComboBox.Items.AddRange(new object[] { "Scientific", "Artistic", "Non-fiction", "Children's", "Economy" });
        SectorComboBox.Location = new Point(24, 185);
        SectorComboBox.Name = "SectorComboBox";
        SectorComboBox.Size = new Size(387, 62);
        SectorComboBox.TabIndex = 15;
        SectorComboBox.Text = "Sector";
        // 
        // GenreTextBox
        // 
        GenreTextBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
        GenreTextBox.Location = new Point(488, 99);
        GenreTextBox.Name = "GenreTextBox";
        GenreTextBox.PlaceholderText = "Genre";
        GenreTextBox.Size = new Size(387, 61);
        GenreTextBox.TabIndex = 8;
        // 
        // PublisherTextBox
        // 
        PublisherTextBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
        PublisherTextBox.Location = new Point(24, 99);
        PublisherTextBox.Name = "PublisherTextBox";
        PublisherTextBox.PlaceholderText = "Publisher";
        PublisherTextBox.Size = new Size(387, 61);
        PublisherTextBox.TabIndex = 7;
        // 
        // AuthorTextBox
        // 
        AuthorTextBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
        AuthorTextBox.Location = new Point(488, 12);
        AuthorTextBox.Name = "AuthorTextBox";
        AuthorTextBox.PlaceholderText = "Author";
        AuthorTextBox.Size = new Size(387, 61);
        AuthorTextBox.TabIndex = 6;
        // 
        // NameTextBox
        // 
        NameTextBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
        NameTextBox.Location = new Point(24, 12);
        NameTextBox.Name = "NameTextBox";
        NameTextBox.PlaceholderText = "Name";
        NameTextBox.Size = new Size(387, 61);
        NameTextBox.TabIndex = 5;
        // 
        // SaveToFileButton
        // 
        SaveToFileButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        SaveToFileButton.BackColor = Color.FromArgb(134, 147, 117);
        SaveToFileButton.FlatStyle = FlatStyle.Flat;
        SaveToFileButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
        SaveToFileButton.Location = new Point(947, 102);
        SaveToFileButton.Name = "SaveToFileButton";
        SaveToFileButton.Size = new Size(121, 150);
        SaveToFileButton.TabIndex = 30;
        SaveToFileButton.Text = "Save to file";
        SaveToFileButton.UseVisualStyleBackColor = false;
        SaveToFileButton.Click += SaveToFileButton_Click;
        // 
        // SeparatorPictureBox
        // 
        SeparatorPictureBox.BackColor = Color.Black;
        SeparatorPictureBox.Location = new Point(931, 0);
        SeparatorPictureBox.Name = "SeparatorPictureBox";
        SeparatorPictureBox.Size = new Size(3, 446);
        SeparatorPictureBox.TabIndex = 33;
        SeparatorPictureBox.TabStop = false;
        // 
        // HorizontalSeparatorPictureBox
        // 
        HorizontalSeparatorPictureBox.BackColor = Color.Black;
        HorizontalSeparatorPictureBox.Location = new Point(931, 443);
        HorizontalSeparatorPictureBox.Name = "HorizontalSeparatorPictureBox";
        HorizontalSeparatorPictureBox.Size = new Size(154, 3);
        HorizontalSeparatorPictureBox.TabIndex = 34;
        HorizontalSeparatorPictureBox.TabStop = false;
        // 
        // SearchField
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(108, 125, 86);
        ClientSize = new Size(1080, 794);
        Controls.Add(HorizontalSeparatorPictureBox);
        Controls.Add(SeparatorPictureBox);
        Controls.Add(BookArea);
        Controls.Add(SearchingInputPanel);
        Controls.Add(SaveToFileButton);
        Controls.Add(SearchButton);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MinimumSize = new Size(1080, 800);
        Name = "SearchField";
        Text = "SearchField";
        SearchingInputPanel.ResumeLayout(false);
        SearchingInputPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)SeparatorPictureBox).EndInit();
        ((System.ComponentModel.ISupportInitialize)HorizontalSeparatorPictureBox).EndInit();
        ResumeLayout(false);
    }

    #endregion
    private Button SearchButton;
    private CustomPanel BookArea;
    private Panel SearchingInputPanel;
    private ComboBox GradeComboBox;
    private ComboBox OriginComboBox;
    private ComboBox NoveltyComboBox;
    private ComboBox SectorComboBox;
    private TextBox GenreTextBox;
    private TextBox PublisherTextBox;
    private TextBox AuthorTextBox;
    private TextBox NameTextBox;
    private CheckBox GradeRadioButton;
    private CheckBox NoveltyRadioButton;
    private CheckBox GenreRadioButton;
    private CheckBox AuthorRadioButton;
    private CheckBox OriginRadioButton;
    private CheckBox SectorRadioButton;
    private CheckBox PublisherRadioButton;
    private CheckBox NameRadioButton;
    private Button SaveToFileButton;
    private TextBox YearTextBox;
    private CheckBox YearRadioButton;
    private PictureBox SeparatorPictureBox;
    private PictureBox HorizontalSeparatorPictureBox;
}
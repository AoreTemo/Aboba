namespace librarian
{
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
            searchButton = new Button();
            bookArea = new Panel();
            SearchingInputPanel = new Panel();
            YearRadioButton = new CheckBox();
            YearTextBox = new TextBox();
            SaveToFileButton = new Button();
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
            SearchingInputPanel.SuspendLayout();
            SuspendLayout();
            // 
            // searchButton
            // 
            searchButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchButton.BackColor = Color.FromArgb(134, 147, 117);
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            searchButton.Location = new Point(945, 12);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(121, 61);
            searchButton.TabIndex = 1;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += SearchButton_Click;
            // 
            // bookArea
            // 
            bookArea.AutoScroll = true;
            bookArea.BackColor = Color.RosyBrown;
            bookArea.Location = new Point(-14, 446);
            bookArea.Name = "bookArea";
            bookArea.Size = new Size(1105, 376);
            bookArea.TabIndex = 2;
            // 
            // SearchingInputPanel
            // 
            SearchingInputPanel.AutoScroll = true;
            SearchingInputPanel.Controls.Add(YearRadioButton);
            SearchingInputPanel.Controls.Add(YearTextBox);
            SearchingInputPanel.Controls.Add(SaveToFileButton);
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
            SearchingInputPanel.Controls.Add(searchButton);
            SearchingInputPanel.Location = new Point(4, 6);
            SearchingInputPanel.Name = "SearchingInputPanel";
            SearchingInputPanel.Size = new Size(1115, 502);
            SearchingInputPanel.TabIndex = 5;
            // 
            // YearRadioButton
            // 
            YearRadioButton.AutoSize = true;
            YearRadioButton.Location = new Point(412, 374);
            YearRadioButton.Name = "YearRadioButton";
            YearRadioButton.Size = new Size(18, 17);
            YearRadioButton.TabIndex = 32;
            YearRadioButton.UseVisualStyleBackColor = true;
            // 
            // YearTextBox
            // 
            YearTextBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            YearTextBox.Location = new Point(8, 355);
            YearTextBox.Name = "YearTextBox";
            YearTextBox.PlaceholderText = ">Year/<Year/=Year";
            YearTextBox.Size = new Size(387, 61);
            YearTextBox.TabIndex = 31;
            // 
            // SaveToFileButton
            // 
            SaveToFileButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SaveToFileButton.BackColor = Color.FromArgb(134, 147, 117);
            SaveToFileButton.FlatStyle = FlatStyle.Flat;
            SaveToFileButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            SaveToFileButton.Location = new Point(945, 94);
            SaveToFileButton.Name = "SaveToFileButton";
            SaveToFileButton.Size = new Size(121, 150);
            SaveToFileButton.TabIndex = 30;
            SaveToFileButton.Text = "Save to file";
            SaveToFileButton.UseVisualStyleBackColor = false;
            SaveToFileButton.Click += SaveToFileButton_Click;
            // 
            // GradeRadioButton
            // 
            GradeRadioButton.AutoSize = true;
            GradeRadioButton.Location = new Point(887, 291);
            GradeRadioButton.Name = "GradeRadioButton";
            GradeRadioButton.Size = new Size(18, 17);
            GradeRadioButton.TabIndex = 29;
            GradeRadioButton.UseVisualStyleBackColor = true;
            // 
            // NoveltyRadioButton
            // 
            NoveltyRadioButton.AutoSize = true;
            NoveltyRadioButton.Location = new Point(887, 203);
            NoveltyRadioButton.Name = "NoveltyRadioButton";
            NoveltyRadioButton.Size = new Size(18, 17);
            NoveltyRadioButton.TabIndex = 28;
            NoveltyRadioButton.UseVisualStyleBackColor = true;
            // 
            // GenreRadioButton
            // 
            GenreRadioButton.AutoSize = true;
            GenreRadioButton.Location = new Point(887, 117);
            GenreRadioButton.Name = "GenreRadioButton";
            GenreRadioButton.Size = new Size(18, 17);
            GenreRadioButton.TabIndex = 27;
            GenreRadioButton.UseVisualStyleBackColor = true;
            // 
            // AuthorRadioButton
            // 
            AuthorRadioButton.AutoSize = true;
            AuthorRadioButton.Location = new Point(887, 31);
            AuthorRadioButton.Name = "AuthorRadioButton";
            AuthorRadioButton.Size = new Size(18, 17);
            AuthorRadioButton.TabIndex = 26;
            AuthorRadioButton.UseVisualStyleBackColor = true;
            // 
            // OriginRadioButton
            // 
            OriginRadioButton.AutoSize = true;
            OriginRadioButton.Location = new Point(412, 291);
            OriginRadioButton.Name = "OriginRadioButton";
            OriginRadioButton.Size = new Size(18, 17);
            OriginRadioButton.TabIndex = 25;
            OriginRadioButton.UseVisualStyleBackColor = true;
            // 
            // SectorRadioButton
            // 
            SectorRadioButton.AutoSize = true;
            SectorRadioButton.Location = new Point(412, 203);
            SectorRadioButton.Name = "SectorRadioButton";
            SectorRadioButton.Size = new Size(18, 17);
            SectorRadioButton.TabIndex = 24;
            SectorRadioButton.UseVisualStyleBackColor = true;
            // 
            // PublisherRadioButton
            // 
            PublisherRadioButton.AutoSize = true;
            PublisherRadioButton.Location = new Point(412, 117);
            PublisherRadioButton.Name = "PublisherRadioButton";
            PublisherRadioButton.Size = new Size(18, 17);
            PublisherRadioButton.TabIndex = 23;
            PublisherRadioButton.UseVisualStyleBackColor = true;
            // 
            // NameRadioButton
            // 
            NameRadioButton.AutoSize = true;
            NameRadioButton.Location = new Point(412, 31);
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
            GradeComboBox.Location = new Point(483, 270);
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
            OriginComboBox.Location = new Point(8, 270);
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
            NoveltyComboBox.Location = new Point(483, 182);
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
            SectorComboBox.Location = new Point(8, 182);
            SectorComboBox.Name = "SectorComboBox";
            SectorComboBox.Size = new Size(387, 62);
            SectorComboBox.TabIndex = 15;
            SectorComboBox.Text = "Sector";
            // 
            // GenreTextBox
            // 
            GenreTextBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            GenreTextBox.Location = new Point(483, 96);
            GenreTextBox.Name = "GenreTextBox";
            GenreTextBox.PlaceholderText = "Genre";
            GenreTextBox.Size = new Size(387, 61);
            GenreTextBox.TabIndex = 8;
            // 
            // PublisherTextBox
            // 
            PublisherTextBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            PublisherTextBox.Location = new Point(8, 96);
            PublisherTextBox.Name = "PublisherTextBox";
            PublisherTextBox.PlaceholderText = "Publisher";
            PublisherTextBox.Size = new Size(387, 61);
            PublisherTextBox.TabIndex = 7;
            // 
            // AuthorTextBox
            // 
            AuthorTextBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            AuthorTextBox.Location = new Point(483, 9);
            AuthorTextBox.Name = "AuthorTextBox";
            AuthorTextBox.PlaceholderText = "Author";
            AuthorTextBox.Size = new Size(387, 61);
            AuthorTextBox.TabIndex = 6;
            // 
            // NameTextBox
            // 
            NameTextBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            NameTextBox.Location = new Point(8, 12);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.PlaceholderText = "Name";
            NameTextBox.Size = new Size(387, 61);
            NameTextBox.TabIndex = 5;
            // 
            // SearchField
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(108, 125, 86);
            ClientSize = new Size(1080, 794);
            Controls.Add(bookArea);
            Controls.Add(SearchingInputPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1080, 800);
            Name = "SearchField";
            Text = "SearchField";
            SearchingInputPanel.ResumeLayout(false);
            SearchingInputPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button searchButton;
        private Panel bookArea;
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
    }
}
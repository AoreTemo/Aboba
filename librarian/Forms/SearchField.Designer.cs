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
            searchTextBox = new TextBox();
            searchButton = new Button();
            bookArea = new Panel();
            SearchComboBox = new ComboBox();
            SuspendLayout();
            // 
            // searchTextBox
            // 
            searchTextBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            searchTextBox.Location = new Point(12, 17);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(653, 61);
            searchTextBox.TabIndex = 0;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // searchButton
            // 
            searchButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchButton.BackColor = Color.White;
            searchButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            searchButton.Location = new Point(947, 17);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(121, 61);
            searchButton.TabIndex = 1;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // bookArea
            // 
            bookArea.AutoScroll = true;
            bookArea.BackColor = Color.Transparent;
            bookArea.Location = new Point(1, 97);
            bookArea.Name = "bookArea";
            bookArea.Size = new Size(1077, 701);
            bookArea.TabIndex = 2;
            // 
            // SearchComboBox
            // 
            SearchComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SearchComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SearchComboBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            SearchComboBox.FormattingEnabled = true;
            SearchComboBox.Items.AddRange(new object[] { "Name", "Author", "Publisher", "Genre", "Sector", "Novelty", "Year", "Grade", "Origin" });
            SearchComboBox.Location = new Point(671, 17);
            SearchComboBox.Name = "SearchComboBox";
            SearchComboBox.Size = new Size(270, 62);
            SearchComboBox.TabIndex = 3;
            SearchComboBox.SelectedIndexChanged += SearchComboBox_SelectedIndexChanged;
            // 
            // SearchField
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(1080, 800);
            Controls.Add(SearchComboBox);
            Controls.Add(bookArea);
            Controls.Add(searchButton);
            Controls.Add(searchTextBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimumSize = new Size(1080, 800);
            Name = "SearchField";
            Text = "SearchField";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox searchTextBox;
        private Button searchButton;
        private Panel bookArea;
        private ComboBox SearchComboBox;
    }
}
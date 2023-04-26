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
            SuspendLayout();
            // 
            // searchTextBox
            // 
            searchTextBox.Anchor = AnchorStyles.Top;
            searchTextBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            searchTextBox.Location = new Point(62, 28);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(765, 61);
            searchTextBox.TabIndex = 0;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // searchButton
            // 
            searchButton.Anchor = AnchorStyles.Top;
            searchButton.BackColor = Color.White;
            searchButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            searchButton.Location = new Point(863, 28);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(155, 61);
            searchButton.TabIndex = 1;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // bookArea
            // 
            bookArea.BackColor = Color.Transparent;
            bookArea.Location = new Point(1, 95);
            bookArea.Name = "bookArea";
            bookArea.Size = new Size(1077, 703);
            bookArea.TabIndex = 2;
            // 
            // SearchField
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(1080, 800);
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
    }
}
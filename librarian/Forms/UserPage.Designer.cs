namespace librarian.Forms
{
    partial class UserPage
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
            FavoriteBookTitle = new Label();
            pictureBox1 = new PictureBox();
            FavoriteAuthorTitle = new Label();
            FavoriteGenreTitle = new Label();
            AmountOfBooksTitle = new Label();
            infoPanel = new Panel();
            closeButton = new Button();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            infoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // FavoriteBookTitle
            // 
            FavoriteBookTitle.Anchor = AnchorStyles.None;
            FavoriteBookTitle.AutoSize = true;
            FavoriteBookTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            FavoriteBookTitle.Location = new Point(88, 54);
            FavoriteBookTitle.Name = "FavoriteBookTitle";
            FavoriteBookTitle.Size = new Size(206, 41);
            FavoriteBookTitle.TabIndex = 1;
            FavoriteBookTitle.Text = "Favorite book:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Location = new Point(95, 208);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(691, 2);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // FavoriteAuthorTitle
            // 
            FavoriteAuthorTitle.Anchor = AnchorStyles.None;
            FavoriteAuthorTitle.AutoSize = true;
            FavoriteAuthorTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            FavoriteAuthorTitle.Location = new Point(88, 213);
            FavoriteAuthorTitle.Name = "FavoriteAuthorTitle";
            FavoriteAuthorTitle.Size = new Size(224, 41);
            FavoriteAuthorTitle.TabIndex = 2;
            FavoriteAuthorTitle.Text = "Favorite author:";
            // 
            // FavoriteGenreTitle
            // 
            FavoriteGenreTitle.Anchor = AnchorStyles.None;
            FavoriteGenreTitle.AutoSize = true;
            FavoriteGenreTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            FavoriteGenreTitle.Location = new Point(88, 357);
            FavoriteGenreTitle.Name = "FavoriteGenreTitle";
            FavoriteGenreTitle.Size = new Size(214, 41);
            FavoriteGenreTitle.TabIndex = 3;
            FavoriteGenreTitle.Text = "Favorite genre:";
            // 
            // AmountOfBooksTitle
            // 
            AmountOfBooksTitle.Anchor = AnchorStyles.None;
            AmountOfBooksTitle.AutoSize = true;
            AmountOfBooksTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            AmountOfBooksTitle.Location = new Point(88, 509);
            AmountOfBooksTitle.Name = "AmountOfBooksTitle";
            AmountOfBooksTitle.Size = new Size(257, 41);
            AmountOfBooksTitle.TabIndex = 4;
            AmountOfBooksTitle.Text = "Amount of books:";
            // 
            // infoPanel
            // 
            infoPanel.Anchor = AnchorStyles.None;
            infoPanel.BackColor = MyColor.Genoa;
            infoPanel.BorderStyle = BorderStyle.FixedSingle;
            infoPanel.Controls.Add(closeButton);
            infoPanel.Controls.Add(pictureBox4);
            infoPanel.Controls.Add(pictureBox3);
            infoPanel.Controls.Add(pictureBox2);
            infoPanel.Controls.Add(pictureBox1);
            infoPanel.Controls.Add(AmountOfBooksTitle);
            infoPanel.Controls.Add(FavoriteGenreTitle);
            infoPanel.Controls.Add(FavoriteBookTitle);
            infoPanel.Controls.Add(FavoriteAuthorTitle);
            infoPanel.Location = new Point(0, 0);
            infoPanel.Name = "infoPanel";
            infoPanel.Size = new Size(866, 653);
            infoPanel.TabIndex = 5;
            // 
            // closeButton
            // 
            closeButton.BackColor = MyColor.Red;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            closeButton.Location = new Point(821, 3);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(40, 37);
            closeButton.TabIndex = 6;
            closeButton.Text = "X";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += CloseButton_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Black;
            pictureBox4.Location = new Point(95, 496);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(691, 2);
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Black;
            pictureBox3.Location = new Point(95, 344);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(691, 2);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Black;
            pictureBox2.Location = new Point(432, 51);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(2, 522);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // UserPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(864, 652);
            Controls.Add(infoPanel);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(864, 652);
            Name = "UserPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserPage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            infoPanel.ResumeLayout(false);
            infoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label FavoriteBookTitle;
        private Label FavoriteAuthorTitle;
        private Label FavoriteGenreTitle;
        private Label AmountOfBooksTitle;
        public Panel infoPanel;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button closeButton;
    }
}
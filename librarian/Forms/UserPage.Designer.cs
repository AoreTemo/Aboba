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
            FavoriteAuthorTitle = new Label();
            FavoriteGenreTitle = new Label();
            AmountOfBooksTitle = new Label();
            infoPanel = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            infoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // FavoriteBookTitle
            // 
            FavoriteBookTitle.Anchor = AnchorStyles.None;
            FavoriteBookTitle.AutoSize = true;
            FavoriteBookTitle.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            FavoriteBookTitle.Location = new Point(12, 60);
            FavoriteBookTitle.Name = "FavoriteBookTitle";
            FavoriteBookTitle.Size = new Size(408, 81);
            FavoriteBookTitle.TabIndex = 1;
            FavoriteBookTitle.Text = "Favorite book:";
            // 
            // FavoriteAuthorTitle
            // 
            FavoriteAuthorTitle.Anchor = AnchorStyles.None;
            FavoriteAuthorTitle.AutoSize = true;
            FavoriteAuthorTitle.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            FavoriteAuthorTitle.Location = new Point(12, 234);
            FavoriteAuthorTitle.Name = "FavoriteAuthorTitle";
            FavoriteAuthorTitle.Size = new Size(448, 81);
            FavoriteAuthorTitle.TabIndex = 2;
            FavoriteAuthorTitle.Text = "Favorite author:";
            // 
            // FavoriteGenreTitle
            // 
            FavoriteGenreTitle.Anchor = AnchorStyles.None;
            FavoriteGenreTitle.AutoSize = true;
            FavoriteGenreTitle.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            FavoriteGenreTitle.Location = new Point(12, 429);
            FavoriteGenreTitle.Name = "FavoriteGenreTitle";
            FavoriteGenreTitle.Size = new Size(425, 81);
            FavoriteGenreTitle.TabIndex = 3;
            FavoriteGenreTitle.Text = "Favorite genre:";
            // 
            // AmountOfBooksTitle
            // 
            AmountOfBooksTitle.Anchor = AnchorStyles.None;
            AmountOfBooksTitle.AutoSize = true;
            AmountOfBooksTitle.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            AmountOfBooksTitle.Location = new Point(12, 615);
            AmountOfBooksTitle.Name = "AmountOfBooksTitle";
            AmountOfBooksTitle.Size = new Size(508, 81);
            AmountOfBooksTitle.TabIndex = 4;
            AmountOfBooksTitle.Text = "Amount of books:";
            // 
            // infoPanel
            // 
            infoPanel.Anchor = AnchorStyles.None;
            infoPanel.BackColor = Color.FromArgb(128, 128, 255);
            infoPanel.BorderStyle = BorderStyle.FixedSingle;
            infoPanel.Controls.Add(pictureBox4);
            infoPanel.Controls.Add(pictureBox3);
            infoPanel.Controls.Add(pictureBox2);
            infoPanel.Controls.Add(pictureBox1);
            infoPanel.Controls.Add(AmountOfBooksTitle);
            infoPanel.Controls.Add(FavoriteGenreTitle);
            infoPanel.Controls.Add(FavoriteBookTitle);
            infoPanel.Controls.Add(FavoriteAuthorTitle);
            infoPanel.Location = new Point(-1, -4);
            infoPanel.Name = "infoPanel";
            infoPanel.Size = new Size(1065, 761);
            infoPanel.TabIndex = 5;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Black;
            pictureBox4.Location = new Point(13, 616);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(1039, 2);
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Black;
            pictureBox3.Location = new Point(13, 425);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1039, 2);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Black;
            pictureBox2.Location = new Point(527, 16);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(2, 735);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Location = new Point(13, 230);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1039, 2);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // UserPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(1062, 753);
            Controls.Add(infoPanel);
            MinimumSize = new Size(1080, 800);
            Name = "UserPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserPage";
            infoPanel.ResumeLayout(false);
            infoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label FavoriteBookTitle;
        private Label FavoriteAuthorTitle;
        private Label FavoriteGenreTitle;
        private Label AmountOfBooksTitle;
        private Panel infoPanel;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}
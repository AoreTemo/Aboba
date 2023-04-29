namespace librarian
{
    partial class BookPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            NameOfBookLabel = new Label();
            panel1 = new Panel();
            GenreLabel = new Label();
            Genre = new Label();
            editButton = new Button();
            YearLabel = new Label();
            label4 = new Label();
            PublisherLabel = new Label();
            label3 = new Label();
            AuthorLabel = new Label();
            label2 = new Label();
            moreButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(5, 26);
            label1.Name = "label1";
            label1.Size = new Size(56, 23);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // NameOfBookLabel
            // 
            NameOfBookLabel.AutoSize = true;
            NameOfBookLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            NameOfBookLabel.Location = new Point(5, 49);
            NameOfBookLabel.Name = "NameOfBookLabel";
            NameOfBookLabel.Size = new Size(112, 23);
            NameOfBookLabel.TabIndex = 1;
            NameOfBookLabel.Text = "NameOfBook";
            // 
            // panel1
            // 
            panel1.Controls.Add(moreButton);
            panel1.Controls.Add(GenreLabel);
            panel1.Controls.Add(Genre);
            panel1.Controls.Add(editButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(YearLabel);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(NameOfBookLabel);
            panel1.Controls.Add(PublisherLabel);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(AuthorLabel);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 280);
            panel1.TabIndex = 2;
            // 
            // GenreLabel
            // 
            GenreLabel.AutoSize = true;
            GenreLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            GenreLabel.Location = new Point(5, 233);
            GenreLabel.Name = "GenreLabel";
            GenreLabel.Size = new Size(96, 23);
            GenreLabel.TabIndex = 18;
            GenreLabel.Text = "GenreLabel";
            // 
            // Genre
            // 
            Genre.AutoSize = true;
            Genre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Genre.Location = new Point(4, 210);
            Genre.Name = "Genre";
            Genre.Size = new Size(56, 23);
            Genre.TabIndex = 17;
            Genre.Text = "Genre";
            // 
            // editButton
            // 
            editButton.Location = new Point(132, 4);
            editButton.Name = "editButton";
            editButton.Size = new Size(65, 29);
            editButton.TabIndex = 16;
            editButton.Text = "edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // YearLabel
            // 
            YearLabel.AutoSize = true;
            YearLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            YearLabel.Location = new Point(5, 141);
            YearLabel.Name = "YearLabel";
            YearLabel.Size = new Size(82, 23);
            YearLabel.TabIndex = 7;
            YearLabel.Text = "YearLabel";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(5, 118);
            label4.Name = "label4";
            label4.Size = new Size(42, 23);
            label4.TabIndex = 6;
            label4.Text = "Year";
            // 
            // PublisherLabel
            // 
            PublisherLabel.AutoSize = true;
            PublisherLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            PublisherLabel.ForeColor = SystemColors.ControlDarkDark;
            PublisherLabel.Location = new Point(5, 187);
            PublisherLabel.Name = "PublisherLabel";
            PublisherLabel.Size = new Size(120, 23);
            PublisherLabel.TabIndex = 5;
            PublisherLabel.Text = "PublisherLabel";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(5, 164);
            label3.Name = "label3";
            label3.Size = new Size(80, 23);
            label3.TabIndex = 4;
            label3.Text = "Publisher";
            // 
            // AuthorLabel
            // 
            AuthorLabel.AutoSize = true;
            AuthorLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            AuthorLabel.ForeColor = SystemColors.ControlDarkDark;
            AuthorLabel.Location = new Point(5, 95);
            AuthorLabel.Name = "AuthorLabel";
            AuthorLabel.Size = new Size(103, 23);
            AuthorLabel.TabIndex = 3;
            AuthorLabel.Text = "AuthorLabel";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(5, 72);
            label2.Name = "label2";
            label2.Size = new Size(63, 23);
            label2.TabIndex = 0;
            label2.Text = "Author";
            // 
            // moreButton
            // 
            moreButton.Location = new Point(131, 39);
            moreButton.Name = "moreButton";
            moreButton.Size = new Size(65, 29);
            moreButton.TabIndex = 19;
            moreButton.Text = "more";
            moreButton.UseVisualStyleBackColor = true;
            moreButton.Click += moreButton_Click;
            // 
            // BookPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(panel1);
            MaximumSize = new Size(200, 280);
            MinimumSize = new Size(200, 280);
            Name = "BookPanel";
            Size = new Size(198, 278);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label NameOfBookLabel;
        public Panel panel1;
        private Label PublisherLabel;
        private Label label3;
        private Label AuthorLabel;
        private Label label2;
        public Button editButton;
        private Label YearLabel;
        private Label label4;
        private Label GenreLabel;
        private Label Genre;
        public Button moreButton;
    }
}

﻿using librarian.Genres;

namespace librarian
{
    partial class InputPanel
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
            panel1 = new Panel();
            AddGenreButton = new Button();
            AddYourGenreTextBox = new TextBox();
            GenreComboBox = new CheckedListBox();
            label2 = new Label();
            StatusComboBox = new ComboBox();
            label1 = new Label();
            saveButton = new Button();
            GradeComboBox = new ComboBox();
            NoveltyComboBox = new ComboBox();
            SectorComboBox = new ComboBox();
            OriginComboBox = new ComboBox();
            YearTextBox = new TextBox();
            PublisherTextBox = new TextBox();
            AuthorTextBox = new TextBox();
            NameTextBox = new TextBox();
            GradeLabel = new Label();
            NoveltyLabel = new Label();
            OriginLabel = new Label();
            SectorLabel = new Label();
            YearLabel = new Label();
            PublisherLabel = new Label();
            AuthorLabel = new Label();
            NameLabel = new Label();
            CloseButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(128, 255, 128);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(AddGenreButton);
            panel1.Controls.Add(AddYourGenreTextBox);
            panel1.Controls.Add(GenreComboBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(StatusComboBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(saveButton);
            panel1.Controls.Add(GradeComboBox);
            panel1.Controls.Add(NoveltyComboBox);
            panel1.Controls.Add(SectorComboBox);
            panel1.Controls.Add(OriginComboBox);
            panel1.Controls.Add(YearTextBox);
            panel1.Controls.Add(PublisherTextBox);
            panel1.Controls.Add(AuthorTextBox);
            panel1.Controls.Add(NameTextBox);
            panel1.Controls.Add(GradeLabel);
            panel1.Controls.Add(NoveltyLabel);
            panel1.Controls.Add(OriginLabel);
            panel1.Controls.Add(SectorLabel);
            panel1.Controls.Add(YearLabel);
            panel1.Controls.Add(PublisherLabel);
            panel1.Controls.Add(AuthorLabel);
            panel1.Controls.Add(NameLabel);
            panel1.Controls.Add(CloseButton);
            panel1.Location = new Point(0, 0);
            panel1.MaximumSize = new Size(540, 740);
            panel1.MinimumSize = new Size(540, 740);
            panel1.Name = "panel1";
            panel1.Size = new Size(540, 740);
            panel1.TabIndex = 0;
            // 
            // AddGenreButton
            // 
            AddGenreButton.BackColor = Color.FromArgb(128, 64, 64);
            AddGenreButton.FlatStyle = FlatStyle.Flat;
            AddGenreButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            AddGenreButton.Location = new Point(320, 663);
            AddGenreButton.Name = "AddGenreButton";
            AddGenreButton.Size = new Size(154, 52);
            AddGenreButton.TabIndex = 24;
            AddGenreButton.Text = "Add genre";
            AddGenreButton.UseVisualStyleBackColor = false;
            AddGenreButton.Click += AddGenreButton_Click;
            // 
            // AddYourGenreTextBox
            // 
            AddYourGenreTextBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            AddYourGenreTextBox.Location = new Point(298, 598);
            AddYourGenreTextBox.Name = "AddYourGenreTextBox";
            AddYourGenreTextBox.Size = new Size(198, 43);
            AddYourGenreTextBox.TabIndex = 23;
            AddYourGenreTextBox.TextChanged += AddYourGenreTextBox_TextChanged;
            // 
            // GenreComboBox
            // 
            GenreComboBox.FormattingEnabled = true;
            GenreComboBox.Location = new Point(38, 598);
            GenreComboBox.Name = "GenreComboBox";
            GenreComboBox.Size = new Size(198, 136);
            GenreComboBox.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(29, 558);
            label2.Name = "label2";
            label2.Size = new Size(88, 37);
            label2.TabIndex = 20;
            label2.Text = "Genre";
            // 
            // StatusComboBox
            // 
            StatusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StatusComboBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Items.AddRange(new object[] { "Scheduled", "In progress", "Abandoned", "Done" });
            StatusComboBox.Location = new Point(38, 510);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(198, 45);
            StatusComboBox.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(29, 470);
            label1.Name = "label1";
            label1.Size = new Size(88, 37);
            label1.TabIndex = 18;
            label1.Text = "Status";
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.FromArgb(134, 147, 117);
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            saveButton.Location = new Point(3, 2);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(82, 40);
            saveButton.TabIndex = 17;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            // 
            // GradeComboBox
            // 
            GradeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            GradeComboBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            GradeComboBox.FormattingEnabled = true;
            GradeComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            GradeComboBox.Location = new Point(298, 510);
            GradeComboBox.Name = "GradeComboBox";
            GradeComboBox.Size = new Size(198, 45);
            GradeComboBox.TabIndex = 16;
            // 
            // NoveltyComboBox
            // 
            NoveltyComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            NoveltyComboBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            NoveltyComboBox.FormattingEnabled = true;
            NoveltyComboBox.Items.AddRange(new object[] { "On hand", "In the library", "Loaned out" });
            NoveltyComboBox.Location = new Point(38, 422);
            NoveltyComboBox.Name = "NoveltyComboBox";
            NoveltyComboBox.Size = new Size(198, 45);
            NoveltyComboBox.TabIndex = 15;
            // 
            // SectorComboBox
            // 
            SectorComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SectorComboBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            SectorComboBox.FormattingEnabled = true;
            SectorComboBox.Items.AddRange(new object[] { "Scientific", "Artistic", "Non-fiction", "Children's", "Economy" });
            SectorComboBox.Location = new Point(298, 422);
            SectorComboBox.Name = "SectorComboBox";
            SectorComboBox.Size = new Size(198, 45);
            SectorComboBox.TabIndex = 14;
            // 
            // OriginComboBox
            // 
            OriginComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            OriginComboBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            OriginComboBox.FormattingEnabled = true;
            OriginComboBox.Items.AddRange(new object[] { "Bought", "Donated", "Borrowed" });
            OriginComboBox.Location = new Point(298, 334);
            OriginComboBox.Name = "OriginComboBox";
            OriginComboBox.Size = new Size(198, 45);
            OriginComboBox.TabIndex = 13;
            // 
            // YearTextBox
            // 
            YearTextBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            YearTextBox.Location = new Point(38, 336);
            YearTextBox.Name = "YearTextBox";
            YearTextBox.Size = new Size(198, 43);
            YearTextBox.TabIndex = 12;
            YearTextBox.TextAlign = HorizontalAlignment.Center;
            YearTextBox.TextChanged += YearTextBox_TextChanged;
            // 
            // PublisherTextBox
            // 
            PublisherTextBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            PublisherTextBox.Location = new Point(38, 250);
            PublisherTextBox.Name = "PublisherTextBox";
            PublisherTextBox.Size = new Size(458, 43);
            PublisherTextBox.TabIndex = 11;
            PublisherTextBox.TextAlign = HorizontalAlignment.Center;
            PublisherTextBox.TextChanged += PublisherTextBox_TextChanged;
            // 
            // AuthorTextBox
            // 
            AuthorTextBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            AuthorTextBox.Location = new Point(38, 164);
            AuthorTextBox.Name = "AuthorTextBox";
            AuthorTextBox.Size = new Size(458, 43);
            AuthorTextBox.TabIndex = 10;
            AuthorTextBox.TextAlign = HorizontalAlignment.Center;
            AuthorTextBox.TextChanged += AuthorTextBox_TextChanged;
            // 
            // NameTextBox
            // 
            NameTextBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            NameTextBox.Location = new Point(38, 78);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(458, 43);
            NameTextBox.TabIndex = 9;
            NameTextBox.TextAlign = HorizontalAlignment.Center;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // GradeLabel
            // 
            GradeLabel.AutoSize = true;
            GradeLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            GradeLabel.Location = new Point(288, 470);
            GradeLabel.Name = "GradeLabel";
            GradeLabel.Size = new Size(89, 37);
            GradeLabel.TabIndex = 8;
            GradeLabel.Text = "Grade";
            // 
            // NoveltyLabel
            // 
            NoveltyLabel.AutoSize = true;
            NoveltyLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            NoveltyLabel.Location = new Point(29, 382);
            NoveltyLabel.Name = "NoveltyLabel";
            NoveltyLabel.Size = new Size(109, 37);
            NoveltyLabel.TabIndex = 7;
            NoveltyLabel.Text = "Novelty";
            // 
            // OriginLabel
            // 
            OriginLabel.AutoSize = true;
            OriginLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            OriginLabel.Location = new Point(288, 296);
            OriginLabel.Name = "OriginLabel";
            OriginLabel.Size = new Size(91, 37);
            OriginLabel.TabIndex = 6;
            OriginLabel.Text = "Origin";
            // 
            // SectorLabel
            // 
            SectorLabel.AutoSize = true;
            SectorLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            SectorLabel.Location = new Point(288, 382);
            SectorLabel.Name = "SectorLabel";
            SectorLabel.Size = new Size(91, 37);
            SectorLabel.TabIndex = 5;
            SectorLabel.Text = "Sector";
            // 
            // YearLabel
            // 
            YearLabel.AutoSize = true;
            YearLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            YearLabel.Location = new Point(29, 296);
            YearLabel.Name = "YearLabel";
            YearLabel.Size = new Size(198, 37);
            YearLabel.TabIndex = 4;
            YearLabel.Text = "Publishing year";
            // 
            // PublisherLabel
            // 
            PublisherLabel.AutoSize = true;
            PublisherLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            PublisherLabel.Location = new Point(29, 210);
            PublisherLabel.Name = "PublisherLabel";
            PublisherLabel.Size = new Size(126, 37);
            PublisherLabel.TabIndex = 3;
            PublisherLabel.Text = "Publisher";
            // 
            // AuthorLabel
            // 
            AuthorLabel.AutoSize = true;
            AuthorLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            AuthorLabel.Location = new Point(29, 124);
            AuthorLabel.Name = "AuthorLabel";
            AuthorLabel.Size = new Size(109, 37);
            AuthorLabel.TabIndex = 2;
            AuthorLabel.Text = "Authors";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            NameLabel.Location = new Point(29, 38);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(88, 37);
            NameLabel.TabIndex = 1;
            NameLabel.Text = "Name";
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.FromArgb(134, 147, 117);
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            CloseButton.Location = new Point(457, 3);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(80, 40);
            CloseButton.TabIndex = 0;
            CloseButton.Text = "close";
            CloseButton.UseVisualStyleBackColor = false;
            // 
            // InputPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            MaximumSize = new Size(540, 740);
            MinimumSize = new Size(540, 740);
            Name = "InputPanel";
            Size = new Size(540, 740);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        public ComboBox GradeComboBox;
        public ComboBox NoveltyComboBox;
        public ComboBox SectorComboBox;
        public ComboBox OriginComboBox;
        public ComboBox StatusComboBox;
        public TextBox PublisherTextBox;
        public TextBox YearTextBox;
        public TextBox AuthorTextBox;
        public TextBox NameTextBox;
        public Button saveButton;
        public Button CloseButton;
        private Label YearLabel;
        private Label PublisherLabel;
        private Label AuthorLabel;
        private Label NameLabel;
        private Label GradeLabel;
        private Label NoveltyLabel;
        private Label OriginLabel;
        private Label SectorLabel;
        private Label label1;
        private Label label2;
        public Panel panel1;
        private Button AddGenreButton;
        private TextBox AddYourGenreTextBox;
        public CheckedListBox GenreComboBox;
    }
}

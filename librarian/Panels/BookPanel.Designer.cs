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
            NameOfBookLabel = new Label();
            panel1 = new Panel();
            moreButton = new Button();
            editButton = new Button();
            YearLabel = new Label();
            AuthorLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // NameOfBookLabel
            // 
            NameOfBookLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            NameOfBookLabel.ForeColor = Color.FromArgb(62, 0, 9);
            NameOfBookLabel.Location = new Point(-1, 101);
            NameOfBookLabel.Name = "NameOfBookLabel";
            NameOfBookLabel.Size = new Size(300, 113);
            NameOfBookLabel.TabIndex = 1;
            NameOfBookLabel.Text = "NameOfBook";
            NameOfBookLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(moreButton);
            panel1.Controls.Add(editButton);
            panel1.Controls.Add(YearLabel);
            panel1.Controls.Add(NameOfBookLabel);
            panel1.Controls.Add(AuthorLabel);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 420);
            panel1.TabIndex = 2;
            // 
            // moreButton
            // 
            moreButton.BackColor = Color.FromArgb(203, 25, 64);
            moreButton.FlatStyle = FlatStyle.Flat;
            moreButton.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            moreButton.ForeColor = Color.FromArgb(62, 0, 9);
            moreButton.Location = new Point(160, 3);
            moreButton.Name = "moreButton";
            moreButton.Size = new Size(135, 95);
            moreButton.TabIndex = 19;
            moreButton.Text = "more";
            moreButton.UseVisualStyleBackColor = false;
            moreButton.Click += MoreButton_Click;
            // 
            // editButton
            // 
            editButton.BackColor = Color.FromArgb(203, 25, 64);
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            editButton.ForeColor = Color.FromArgb(62, 0, 9);
            editButton.Location = new Point(3, 3);
            editButton.Name = "editButton";
            editButton.Size = new Size(135, 95);
            editButton.TabIndex = 16;
            editButton.Text = "edit";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += EditButton_Click;
            // 
            // YearLabel
            // 
            YearLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            YearLabel.ForeColor = Color.FromArgb(62, 0, 9);
            YearLabel.Location = new Point(0, 306);
            YearLabel.Name = "YearLabel";
            YearLabel.Size = new Size(300, 112);
            YearLabel.TabIndex = 7;
            YearLabel.Text = "YearLabel";
            YearLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AuthorLabel
            // 
            AuthorLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            AuthorLabel.ForeColor = Color.FromArgb(62, 0, 9);
            AuthorLabel.Location = new Point(0, 214);
            AuthorLabel.Name = "AuthorLabel";
            AuthorLabel.Size = new Size(300, 107);
            AuthorLabel.TabIndex = 3;
            AuthorLabel.Text = "AuthorLabel";
            AuthorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BookPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 108, 85);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(panel1);
            MaximumSize = new Size(300, 420);
            MinimumSize = new Size(300, 420);
            Name = "BookPanel";
            Size = new Size(298, 418);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label NameOfBookLabel;
        public Panel panel1;
        private Label AuthorLabel;
        public Button editButton;
        private Label YearLabel;
        public Button moreButton;
    }
}

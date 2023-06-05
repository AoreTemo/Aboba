namespace librarian.Panels
{
    partial class DeleteGenresPanel
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
            VerifyDeletingButton = new Button();
            GenresDeletingListBox = new ListBox();
            SuspendLayout();
            // 
            // VerifyDeletingButton
            // 
            VerifyDeletingButton.FlatStyle = FlatStyle.Flat;
            VerifyDeletingButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            VerifyDeletingButton.Location = new Point(3, 255);
            VerifyDeletingButton.Name = "VerifyDeletingButton";
            VerifyDeletingButton.Size = new Size(241, 72);
            VerifyDeletingButton.TabIndex = 1;
            VerifyDeletingButton.Text = "Delete";
            VerifyDeletingButton.UseVisualStyleBackColor = true;
            VerifyDeletingButton.Click += VerifyDeletingButton_Click;
            // 
            // GenresDeletingListBox
            // 
            GenresDeletingListBox.FormattingEnabled = true;
            GenresDeletingListBox.ItemHeight = 20;
            GenresDeletingListBox.Location = new Point(3, 3);
            GenresDeletingListBox.Name = "GenresDeletingListBox";
            GenresDeletingListBox.Size = new Size(241, 244);
            GenresDeletingListBox.TabIndex = 2;
            GenresDeletingListBox.SelectedIndexChanged += GenresDeletingListBox_SelectedIndexChanged;
            // 
            // DeleteGenresPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(GenresDeletingListBox);
            Controls.Add(VerifyDeletingButton);
            Name = "DeleteGenresPanel";
            Size = new Size(247, 330);
            ResumeLayout(false);
        }

        #endregion
        private Button VerifyDeletingButton;
        private ListBox GenresDeletingListBox;
    }
}

using librarian.Panels;

namespace librarian
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BookPanelContainer = new();
            SuspendLayout();
            // 
            // BookPanelContainer
            // 
            BookPanelContainer.AutoScroll = true;
            BookPanelContainer.Location = new Point(-3, -5);
            BookPanelContainer.Name = "BookPanelContainer";
            BookPanelContainer.Size = new Size(811, 456);
            BookPanelContainer.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BookPanelContainer);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Library";
            ResumeLayout(false);
        }

        #endregion

        public CustomPanel BookPanelContainer;
    }
}
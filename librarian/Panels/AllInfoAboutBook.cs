namespace librarian.Panels
{
    public partial class AllInfoAboutBook : UserControl
    {
        public AllInfoAboutBook()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Form1.ControlSwitching(true, Parent!, c => !c.Enabled);
            Parent!.Controls.Remove(this);
        }
    }
}

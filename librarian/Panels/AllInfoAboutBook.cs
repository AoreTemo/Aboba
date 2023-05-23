namespace librarian.Panels
{
    public partial class AllInfoAboutBook : UserControl
    {
        public AllInfoAboutBook()
        {
            InitializeComponent();
            Anchor = AnchorStyles.None;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            FormManager.ControlSwitching(FormManager.GetAllControls(Parent!), true, c => !c.Enabled);
            Parent!.Controls.Remove(this);
        }
    }
}

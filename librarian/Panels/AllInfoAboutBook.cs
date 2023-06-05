using librarian.Forms;

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
            var controls = FormManager.GetAllControls(Parent!);
            FormManager.ControlSwitching(controls, true, c => !c.Enabled);
            Parent!.Controls.Remove(this);
        }
    }
}

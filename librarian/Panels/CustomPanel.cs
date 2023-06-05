namespace librarian.Panels;

public class CustomPanel : Panel
{
    public CustomPanel()
    {
        HorizontalScroll.Maximum = 0;
        AutoScroll = false;
        VerticalScroll.Visible = false;
        AutoScroll = true;

    }

    protected override Point ScrollToControl(Control activeControl)
    {
        return DisplayRectangle.Location;
    }
}

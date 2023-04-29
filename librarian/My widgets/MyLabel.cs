using static librarian.Positions.MyConstantsForWidgets;
namespace librarian
{
    internal class MyLabel : Label
    {
        public MyLabel(string text, int y, int x = PADDING_X)
        {
            Font = new Font("Segoe UI", 16);
            Text = text;
            AutoSize = true;
            Location = new Point(x, y);
        }
    }
}

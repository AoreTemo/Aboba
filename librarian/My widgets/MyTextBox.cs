using static librarian.Positions.MyConstantsForWidgets;
namespace librarian
{
    internal class MyTextBox : TextBox
    {
        public MyTextBox(int y, int width = 432, int x = PADDING_X)
        {
            Font = new Font("Segoe UI", FONT_SIZE);
            Width = width;
            Location = new Point(x, y);
            TextAlign = HorizontalAlignment.Center;
        }
    }
}

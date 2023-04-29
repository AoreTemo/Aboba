using static librarian.Positions.MyConstantsForWidgets;

namespace librarian
{
    internal class MyComboBox : ComboBox
    {
        public MyComboBox(string[] items, int y)
        {
            Font = new Font("Segoe UI", 20);
            DropDownStyle = ComboBoxStyle.DropDownList;
            Items.AddRange(items);
            Width = Items.Cast<object>()
                .Max(item => TextRenderer.MeasureText(item.ToString(), Font).Width) + 20;
            Location = new Point(PADDING_X, y);
        }
    }
}

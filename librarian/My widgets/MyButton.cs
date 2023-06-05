namespace librarian
{
    internal class MyButton : Button
    {
        public MyButton(int font, string text, int width, int height, int x, int y, EventHandler button_Click)
        {
            Font = new Font("Segoe UI", font);
            BackColor = MyColor.Green;
            Text = text;
            Size = new Size(width, height);
            Location = new Point(x, y);
            Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            
            Click += button_Click;
        }
    }
}

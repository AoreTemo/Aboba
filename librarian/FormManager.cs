namespace librarian
{
    internal static class FormManager
    {
        public static List<Control> GetAllControls(Control control)
        {
            List<Control> resultList = new();
            foreach (Control c in control.Controls)
            {
                resultList.Add(c);
                if (c.Controls.Count > 0)
                    resultList.AddRange(GetAllControls(c));
            }

            return resultList;
        }
        public static void ControlSwitching(List<Control> list, bool value, Func<Control, bool> condition)
        {
            foreach (Control element in list.OfType<Control>().Where(condition).Cast<Control>())
                element.Enabled = value;
        }
    }
}

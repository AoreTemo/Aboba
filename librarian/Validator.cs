namespace librarian
{
    internal class Validator
    {
        public static string RegularText_Validator(string text)
        {
            if (text.Length > 30)
            {
                MessageBox.Show("The text is too long");
                text = text.Substring(0, text.Length - 1);
            }
            return text;
        }
        public static string Year_Validator(string year)
        {
            int currentYear = DateTime.Now.Year;
            int parsedYear;
            if (!int.TryParse(year, out parsedYear) || parsedYear > currentYear || year.Length > 4)
            {
                MessageBox.Show("The text must have 4 digits. Year must be lower than current.");
                year = currentYear.ToString();
            }
            else
            {
                year = parsedYear.ToString();
            }
            return year;
        }
    }
}

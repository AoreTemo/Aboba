namespace librarian
{
    internal class Validator
    {
        public static string RegularText_Validator(string text)
        {
            if (text.Length > 30)
            {
                MessageBox.Show("The text is too long");
                text = text[..^1];
            }
            return text;
        }
        public static string Year_Validator(string year)
        {
            int currentYear = DateTime.Now.Year;
            if (!int.TryParse(year, out int parsedYear) || parsedYear > currentYear || year.Length > 4)
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

        public static string Grade_Validator(string grade)
        {
            if(grade.ToCharArray().Any(c => !char.IsDigit(c)) || grade == null || grade == "")
            {
                return "";
            }
            if(Convert.ToInt32(grade) > 5)
            {
                return "5";
            }
            if(Convert.ToInt32(grade) < 1)
            {
                return "1";
            }
            return grade;
        }
    }
}

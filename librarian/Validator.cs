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
            if (string.IsNullOrWhiteSpace(year) || year == "-")
            {
                return year;
            }
            else if ((!int.TryParse(year, out int parsedYear) && !int.TryParse(year.TrimStart('-'), out parsedYear)) || year.Length > 6)
            {
                MessageBox.Show("The text must have 4-5 digits.");
                year = DateTime.Now.Year.ToString();
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

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
            if (year.Any(c => !char.IsDigit(c)))
            {
                MessageBox.Show("For year use only digits");
                int indexOfLetter = 0;
                foreach(var c in year)
                {
                    if (char.IsDigit(c))
                        indexOfLetter++;
                    else
                        break;
                }
                year = year.Substring(0, indexOfLetter);
            }
            if(year.Length > 4)
            {
                MessageBox.Show("The text must have 4 digits");
                year = year.Substring(0, 4);
            }


            return year;
        }
    }
}

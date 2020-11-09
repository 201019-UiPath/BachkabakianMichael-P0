using System.Text.RegularExpressions;

namespace JCLib
{
    public class InputValidator
    {
        public static bool ValidateNameInput(string name)
        {
            return Regex.IsMatch(name, @"^[^\d\s]+$");
        }

        public static bool ValidatePasswordInput(string password)
        {
            return Regex.IsMatch(password, @"^[^\s]{4,20}$");
        }

        public static bool ValidateYesOrNoInput(string YesOrNo)
        {
            return Regex.IsMatch(YesOrNo, @"^[^\d\s]$");
        }

        public static bool ValidateDigitInput(string digit)
        {
            return Regex.IsMatch(digit, @"^[\d]$");
        }

        //public static bool ValidateInputAsNumber(int number)
        //{
        //    return Regex.IsMatch(number, @"^[0-9]{1,3}$");
        //}
    }
}
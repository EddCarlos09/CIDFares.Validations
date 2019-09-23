using System.Text.RegularExpressions;

namespace CIDFares.Library.Validations
{
    public class Validations
    {

        /// <summary>
        /// Validation will fall if the value is not a valid email address.
        /// </summary>
        /// <param name="value">Value to validate</param>
        /// <returns></returns>
        public static bool IsValidEmail(string value)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            return Regex.IsMatch(value, pattern);
        }


        /// <summary>
        /// Password must be 8-16 characters and include at least a digit, a uppercase letter, and a lowercase letter
        /// </summary>
        /// <param name="value">Value to validate</param>
        /// <returns></returns>
        public static bool IsValidPassword(string value)
        {
            string pattern = @"^(?=\w*\d)(?=\w*[A-Z])(?=\w*[a-z])\S{8,16}$";
            return Regex.IsMatch(value, pattern);
        }
    }
}

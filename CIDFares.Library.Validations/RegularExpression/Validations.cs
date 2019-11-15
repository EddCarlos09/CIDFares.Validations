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


        /// <summary>
        /// Validation will fall if the value is no a valid RFC
        /// </summary>
        /// <param name="value">Value to validate</param>
        /// <returns></returns>
        public static bool IsValidRFC(string value)
        {
            string pattern = @"^[a-zA-Z0-9.!#$%&'+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)$";
            return Regex.IsMatch(value, pattern);
        }


        /// <summary>
        /// Validation for ten digits for a number phone
        /// </summary>
        /// <param name="value">Value to validate</param>
        /// <returns></returns>
        public static bool IsValidPhoneNumberDigits(string value)
        {
            string pattern = @"^[\d]{10}$";
            return Regex.IsMatch(value, pattern);
        }


        /// <summary>
        /// Validation for number phone with () and --
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsValidPhoneNumber(string value)
        {
            string pattern = @"(?([0-9]{3})\)?([ .-]?)([0-9]{3})\2([0-9]{4})/";
            return Regex.IsMatch(value, pattern);
        }
    }
}

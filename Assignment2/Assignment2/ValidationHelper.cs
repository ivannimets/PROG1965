using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class ValidationHelper
    {
        public static string Capitalize (string str)
        {
            //if null change to empty string;
            if (str == null)
            {
                str = "";
            }
            // remove all white spaces at the start and the end of string
            str = str.Trim();
            // change all chars to lower case
            str = str.ToLower();

            // Capitalising the first letter of each word in the string
            string[] subs = str.Split (' ');
            str = "";
            foreach (string s in subs)
            {
                if (s.Length > 1)
                {
                    string first = s[0].ToString().ToUpper();
                    str += s[0].ToString().ToUpper() + s.Remove(0, 1) + " ";
                }
                else
                {
                    str += s + " ";
                }
            }
            str = str[0].ToString().ToUpper() + str.Remove(0, 1);
            str = str.Trim();

            return str;
        }

        public static bool IsValidPostalCode (string postalCode)
        {
            // next condition is useless, I added it according to task
            if (String.IsNullOrEmpty(postalCode)) 
            {
                return false;
            }

            Regex codeFormat = new Regex(@"^([a-z]|[A-Z]){1}\d([a-z]|[A-Z]){1}\s?\d([a-z]|[A-Z]){1}\d$");
            if (!codeFormat.IsMatch(postalCode))
            {
                return false;
            }

            return true;
        }

        public static bool IsValidProvinceName (string provinceName)
        {
            // next condition is not necessary, I added it according to task
            if (String.IsNullOrEmpty(provinceName))
            {
                return false;
            }

            string[] validNames = { "ontario", "alberta", "british columbia", "manitoba", "new branswick", "newfoundland and labredor", "nova scotia", "prince edward island", "quebec", "saskatchewan", "northwest territories", "nunavut", "yukon"};
            foreach (string validName in validNames) 
            {
                if (provinceName == validName)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            // next condition is not necessary, I added it according to task
            if (String.IsNullOrEmpty(phoneNumber))
            {
                return false;
            }

            Regex phoneFormat = new Regex(@"^\d{3}-?\d{3}-?\d{4}$");
            if (!phoneFormat.IsMatch(phoneNumber))
            {
                return false;
            }

            return true;
        }

        public static bool IsValidCustomerName (string name)
        {
            if (String.IsNullOrEmpty(name.Trim()))
            {
                return false;
            }
            return true;
        }

        public static bool IsValidEmail (string email)
        {
            Regex emailFormat = new Regex(@"^[A-Z0-9a-z._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,6}$");
            if (!emailFormat.IsMatch(email.Trim()))
            {
                return false;
            }
            return true;
        }

        public static bool IsValidMakeAndModel(string makeAndModel)
        {
            if (String.IsNullOrEmpty(makeAndModel.Trim()))
            {
                return false;
            }
            return true;
        }

        public static bool IsValidYear (string inputYear)
        {
            DateTime now = DateTime.Now;
            string message = "";
            int year = 0;
            if (!int.TryParse(inputYear, out year))
            {
                return false;
            }
            if (year < 1900 || year > now.Year + 1) 
            {
                return false;
            }
            return true;
        }

        public static bool IsValidAppointmantDate (DateTime date)
        {
            if (date < DateTime.Now.Date)
            {
                return false;
            }
            return true;
        }
    }
}

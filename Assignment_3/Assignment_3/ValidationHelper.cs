using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class ValidationHelper
    {
        public static void IsValidPatientName(string patientName) //patient name validation
        {
            string pattern = @"^[a-zA-Z]+(['-][a-zA-Z]+)*\s[a-zA-Z]+(['-][a-zA-Z]+)*\s*$";
            Regex regex = new Regex(pattern);
            patientName = patientName.Trim();
            if (string.IsNullOrEmpty(patientName)) 
            {
                throw new ArgumentException("Patient Name input is required!");
            }
            if (!regex.IsMatch(patientName))
            {
                throw new ArgumentException(@$"Invalid patient name input: {patientName}." + "\nEnter the first and the last names. Valid ex: Jane Doe ");
            }
        }

        public static void IsValidDOB(DateTime birthDate) //dob validation
        {
            if (birthDate > DateTime.UtcNow)
            {
                throw new ArgumentException("Invalid birthdate input! It can not be in the future");
            }
        }

        public static void IsValidProblem(string problem) //null checker for adding problem ...
        {                                                 //we could probably instead do a null checker when calling the add function and not throw an error
            if (string.IsNullOrEmpty(problem))
            {
                throw new ArgumentException("New Problem field can not be empty");
            }
        }

        public static void IsValidNotes(string notes) //null checker for notes ...
        {                                                 //we could probably instead do a null checker when calling the add function and not throw an error
            if (string.IsNullOrEmpty(notes))
            {
                throw new ArgumentException("Notes field can not be empty");
            }
        }

    }
}

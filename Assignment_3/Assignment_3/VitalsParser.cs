using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class VitalsParser
    {
        public static void UpdateVitalsList(string notes, ListBox vitalsListBox) //main function to update listbox
        {
            vitalsListBox.Items.Clear();
            CheckForBp(notes, vitalsListBox);
        }

        private static void CheckForBp(string notes, ListBox vitalsListBox) 
        {
            string bpPattern = @"BP:?\s(\d{2,3})/(\d{2,3})";
            Regex bpRegex = new Regex(bpPattern, RegexOptions.IgnoreCase);
            MatchCollection matches = bpRegex.Matches(notes); // creates an array of matches for given string 

            foreach (Match match in matches) 
            {
                int systolic = int.Parse(match.Groups[1].Value);    //group 1 in regex pattern is systolic
                int diastolic = int.Parse(match.Groups[2].Value);   //group 2 in regex pattern is diastolic
                vitalsListBox.Items.Add(UpdateBpString(systolic, diastolic));
            }
        }
        private static string UpdateBpString(int systolic, int diastolic) //return updated BP string wether its high, low or normal
        {
            if (systolic < 90 && diastolic < 60)
            {
                return $"BP: {systolic}/{diastolic} (LOW)";
            }
            if (systolic > 130 && diastolic > 80) 
            {
                return $"BP: {systolic}/{diastolic} (High)";
            }
                return $"BP: {systolic}/{diastolic}";
        }
    }
}

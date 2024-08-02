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
            CheckForHeartRate(notes, vitalsListBox);
            CheckForRespiratoryRate(notes, vitalsListBox);
            CheckForTemperature(notes, vitalsListBox);
        }

        private static void CheckForBp(string notes, ListBox vitalsListBox) 
        {
            string bpPattern = @"BP:?\s(\d{2,3})/(\d{2,3})";
            Regex bpRegex = new Regex(bpPattern, RegexOptions.IgnoreCase);
            MatchCollection matches = bpRegex.Matches(notes); // creates a collection of matches for given string 

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
                return $"BP: {systolic}/{diastolic} mmHg (LOW)";
            }
            if (systolic > 130 && diastolic > 80) 
            {
                return $"BP: {systolic}/{diastolic} mmHg (High)";
            }
                return $"BP: {systolic}/{diastolic} mmHg";
        }

        private static void CheckForHeartRate(string notes, ListBox vitalsListBox) // check listbox for matching regex string
        {
            string HRPattern = @"HR:?\s(\d{2,3})";
            Regex HRRegex = new Regex(HRPattern, RegexOptions.IgnoreCase);
            MatchCollection matches = HRRegex.Matches(notes); //store matches in collection

            foreach (Match match in matches)
            {
                int heartRate = int.Parse(match.Groups[1].Value);
                vitalsListBox.Items.Add(UpdateHeartRateString(heartRate));
            }
        }

        private static string UpdateHeartRateString(int heartRate)
        {
            if (heartRate > 100)
            {
                return $"HR: {heartRate} BPM (HIGH)";
            }
            if (heartRate < 60)
            {
                return $"HR: {heartRate} BPM (LOW)";
            }
            return $"HR: {heartRate} BPM";
        }

        private static void CheckForRespiratoryRate(string notes, ListBox vitalsListBox)
        {
            string RRPattern = @"RR:?\s(\d{2,3})";
            Regex RRregex = new Regex(RRPattern, RegexOptions.IgnoreCase);
            MatchCollection match = RRregex.Matches(notes);

            foreach (Match matches in match)
            {
                int respiratory = int.Parse(matches.Groups[1].Value);
                vitalsListBox.Items.Add(UpdaterespiratoryRateString(respiratory));
            }
        }

        private static string UpdaterespiratoryRateString(int respiratory)
        {
            if (respiratory > 16)
            {
                return $"RR: {respiratory} (HIGH) bpm";
            }
            if (respiratory < 12)
            {
                return $"RR: {respiratory} (LOW) bpm";
            }
            return $"RR: {respiratory} bpm";
        }

        private static void CheckForTemperature(string notes, ListBox vitalsListBox)
        {
            string TempPattern = @"T:?\s(\d{2}.?\d?)";
            Regex TempRegex = new Regex(TempPattern, RegexOptions.IgnoreCase);
            MatchCollection match = TempRegex.Matches(notes);

            foreach (Match matches in match)
            {
                double temp = double.Parse(matches.Groups[1].Value);
                vitalsListBox.Items.Add(UpdateTempString(temp));
            }
        }
        private static string UpdateTempString(double temp)
        {
            if (temp > 37.2)
            {
                return $"Temp: {temp} C (HIGH)";
            }
            if (temp < 36.5)
            {
                return $"Temp: {temp} C (LOW)";
            }
            return $"Temp: {temp} C";
        }
    }
}

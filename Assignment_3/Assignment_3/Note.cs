using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Note
    {
        private string noteId;
        private string patientName;
        private DateTime dateOfBirth;
        private string notes;
        private List<string> problems;
        public string nameToShow;

        public Note(string noteId, string patientName, DateTime dateOfBirth, string notes, List<string> problems)
        {
            SetNoteId(noteId);
            SetPatientName(patientName);
            SetDateOfBirth(dateOfBirth);
            SetNotes(notes);
            SetProblems(problems);
        }

        public void SetNoteId(string noteId)
        {
            this.noteId = noteId;
        }

        public void SetPatientName(string patientName)
        {
            if (!String.IsNullOrEmpty(patientName.Trim()))
            {
                this.patientName = patientName.Trim();
            }
            else
            {
                throw new ArgumentException("Patient Name is required!");
            }
        }

        public void SetDateOfBirth(DateTime dateOfBirth)
        {
            if (dateOfBirth < DateTime.Now)
            {
                this.dateOfBirth = dateOfBirth;
            }
            else
            {
                throw new ArgumentException("Date of birth cannot be in the future");
            }
        }
        public void SetNotes(string notes)
        {
            if (!String.IsNullOrEmpty(notes.Trim()))
            {
                this.notes = notes.Trim();
            }
            else
            {
                throw new ArgumentException("Clinical note content is required!");
            }
        }

        public void SetProblems(List<string> problems)
        {
            this.problems = new List<string>(); 
            foreach (string problem in problems)
            {
                if (!String.IsNullOrEmpty(problem))
                {
                    this.problems.Add(problem);
                }
            }
        }

        public string GetPatientName()
        {
            return this.patientName;
        }

        public string GetNoteId()
        {
            return this.noteId;
        }

        public DateTime GetDateOfBirth()
        {
            return (DateTime)this.dateOfBirth;
        }

        public string GetNotes()
        {
            return this.notes;
        }

        public string GetProblemsAsString ()
        {
            string problems = "";
            for (int i = 0; i < this.problems.Count; i++)
            {
                problems += this.problems[i].ToString() + ";" ;
            }

            return problems;
        }

        public override string ToString()
        {
            return patientName + " (Note " + noteId + ")"; // Display the Name property in the ListBox
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Note
    {
        private int noteId;
        private string patientName;
        private DateTime dateOfBirth;
        private string notes;
        private List<string> problems;

        public Note(int noteId, string patientName, DateTime dateOfBirth, string notes, List<string> problems)
        {
            SetNoteId(noteId);
            SetPatientName(patientName);
            SetDateOfBirth(dateOfBirth);
            SetNotes(notes);
            this.problems = problems;
        }

        public void SetNoteId(int noteId)
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

        public string GetPatientName()
        {
            return this.patientName;
        }

        public int GetNoteId()
        {
            return this.noteId;
        }

        public override string ToString()
        {
            return patientName; // Display the Name property in the ListBox
        }
    }
}

using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class NoteManager
    {
        public static List<Note> Notes = new List<Note>();
        public static void LoadInfoFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                Notes.Clear();
                StreamReader reader = null;
                int i = 0;
                try
                {
                    reader = new StreamReader(filePath);
                    for (i = 0; !reader.EndOfStream; i++)
                    {
                        string record = reader.ReadLine();
                        if (record.Length > 0)
                        {
                            string[] parts = record.Split('|');
                            Notes.Add(new Note(parts[0], parts[1], DateTime.Parse(parts[2]), parts[3].Replace("~", "\n"), parts[4].Split(';').ToList()));
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Exception reading record: {ex.Message}");
                }
                finally
                {
                    if (reader != null)
                        reader.Dispose();
                }
            }
        }

        public static void SaveInfoToFile(string filePath)
        {
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(filePath, append: false);
                for (int i = 0; i < Notes.Count; i++)
                {
                    string record = "";
                    record += Notes[i].GetNoteId().ToString() + "|";
                    record += Notes[i].GetPatientName().ToString() + "|";
                    record += Notes[i].GetDateOfBirth().ToString() + "|";
                    record += Notes[i].GetNotes().Replace("\n", "~") + "|";
                    record += Notes[i].GetProblemsAsString() + "|";

                    writer.WriteLine(record);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Exception adding record: {ex.Message}");
            }
            finally
            {
                if (writer != null)
                    writer.Dispose();
            }
        }

        //
        //method to get new ID, that is not exist yet
        //
        public static string GetNewId(string filePath)
        {
            string record = "";
            List<int> existIds = new List<int>();

            StreamReader reader = null;
            int i = 0;
            try
            {
                reader = new StreamReader(filePath);
                for (i = 0; !reader.EndOfStream; i++)
                {
                    record = reader.ReadLine();
                    if (record.Length > 0)
                    {
                        existIds.Add(int.Parse(record.Split("|")[0]));
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Exception reading record: {ex.Message}");
            }
            finally
            {
                if (reader != null)
                    reader.Dispose();
            }


            int newId = 1;
            while (existIds.Contains(newId))
            {
                newId++;
            }

            return newId.ToString();
        }

        public static void UpdateNote (string noteId, string patientName, DateTime dateOfBirth, string notes, List<string> problems)
        {
            ValidationHelper.IsValidPatientName(patientName);
            ValidationHelper.IsValidDOB(dateOfBirth);
            ValidationHelper.IsValidNotes(notes);

            int i = 0;
            while (noteId != Notes[i].GetNoteId()) 
            {
                i++;
            }
            Notes[i].SetNoteId(noteId);
            Notes[i].SetPatientName(patientName);
            Notes[i].SetDateOfBirth(dateOfBirth);
            Notes[i].SetNotes(notes);
            Notes[i].SetProblems(problems);

            SaveInfoToFile("notes.as3");
        }

        public static void AddNote (string noteId, string patientName, DateTime dateOfBirth, string notes, List<string> problems)
        {
            ValidationHelper.IsValidPatientName(patientName);
            ValidationHelper.IsValidDOB(dateOfBirth);
            ValidationHelper.IsValidNotes(notes);

            Notes.Add(new Note(noteId, patientName, dateOfBirth, notes, problems));

            SaveInfoToFile("notes.as3");
        }

        public static void RemoveNote(string noteId)
        {
            int i = 0;
            while (noteId != Notes[i].GetNoteId())
            {
                i++;
            }
            Notes.RemoveAt(i);

            SaveInfoToFile("notes.as3");
        }
    }
}

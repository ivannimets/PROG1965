namespace Assignment_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //method to switch between modes:
        private void ChangeMode(string mode)  // valid parameters: “awaiting note mode”, "add mode", "edit mode"
        {
            switch (mode)
            {
                case "awaiting note mode":

                    txtNoteID.Enabled = false;
                    txtPatientName.Enabled = false;
                    datePickerDateOfBirth.Enabled = false;
                    txtNewProblem.Enabled = false;
                    btnAddProblem.Enabled = false;
                    richTextBoxNotes.Enabled = false;
                    btnAddNote.Enabled = false;
                    btnUpdateNote.Enabled = false; //this is fun
                    btnDeleteNote.Enabled = false;
                    btnRemoveProblem.Enabled = false;

                    txtNoteID.Text = string.Empty;
                    txtPatientName.Text = string.Empty;
                    txtNewProblem.Text = string.Empty;
                    richTextBoxNotes.Text = string.Empty;
                    listBoxBPMeasurements.Items.Clear();
                    listBoxProblems.Items.Clear();
                    datePickerDateOfBirth.Value = DateTime.Now;

                    break;

                case "edit mode":

                    txtNoteID.Enabled = false;
                    txtPatientName.Enabled = true;
                    datePickerDateOfBirth.Enabled = true;
                    txtNewProblem.Enabled = true;
                    btnAddProblem.Enabled = true;
                    richTextBoxNotes.Enabled = true;
                    btnAddNote.Enabled = false;
                    btnUpdateNote.Enabled = true;
                    btnDeleteNote.Enabled = true;
                    btnRemoveProblem.Enabled = true;

                    break;

                case "add mode":

                    txtNoteID.Enabled = false;
                    txtPatientName.Enabled = true;
                    datePickerDateOfBirth.Enabled = true;
                    txtNewProblem.Enabled = true;
                    btnAddProblem.Enabled = true;
                    richTextBoxNotes.Enabled = true;
                    btnAddNote.Enabled = true;
                    btnUpdateNote.Enabled = false;
                    btnDeleteNote.Enabled = false;
                    btnRemoveProblem.Enabled = true;

                    txtNoteID.Text = (listBoxNotes.Items.Count + 1).ToString();
                    txtPatientName.Text = string.Empty;
                    txtNewProblem.Text = string.Empty;
                    richTextBoxNotes.Text = string.Empty;
                    listBoxBPMeasurements.Items.Clear();
                    listBoxProblems.Items.Clear();
                    datePickerDateOfBirth.Value = DateTime.Now;

                    break;

                default:
                    throw new NotImplementedException("Mode was not found");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChangeMode("awaiting note mode"); // When form loading it is turning into "Awaiting note mode"
            NoteManager.LoadInfoFromFile("notes.as3");
            listBoxNotes.DataSource = NoteManager.Notes;
            listBoxNotes.SelectedIndex = -1;
        }

        private void richTextBoxNotes_TextChanged(object sender, EventArgs e) //this function will get called with every text change on the textbox
        {
            string notes = richTextBoxNotes.Text;
            VitalsParser.UpdateVitalsList(richTextBoxNotes.Text, listBoxBPMeasurements);// update the vitals listbox if data from textbox matches          
        }

        private void listBoxNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty;
            try
            {
                if (listBoxNotes.SelectedIndex == -1)
                {
                    ClearFields();
                    ChangeMode("awaiting note mode");
                }
                else
                {
                    string patientName = listBoxNotes.SelectedValue.ToString().Split('(')[0].Trim();
                    int i = 0;
                    if (NoteManager.Notes.Count > 0)
                    {
                        while (patientName != NoteManager.Notes[i].GetPatientName())
                        {
                            i++;
                        }
                        txtNoteID.Text = NoteManager.Notes[i].GetNoteId();
                        txtPatientName.Text = patientName;
                        datePickerDateOfBirth.Value = NoteManager.Notes[i].GetDateOfBirth();
                        richTextBoxNotes.Text = NoteManager.Notes[i].GetNotes();
                        List<string> problems = NoteManager.Notes[i].GetProblemsAsString().Split(";").ToList();
                        listBoxProblems.Items.Clear();
                        for (int j = 0; j < problems.Count - 1; j++)
                        {
                            listBoxProblems.Items.Add(problems[j]);
                        }
                        ChangeMode("edit mode");
                    }
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty;
            string patientName = txtPatientName.Text.Trim();
            string noteId = txtNoteID.Text.Trim();
            DateTime dateOfBirth = datePickerDateOfBirth.Value;
            string notes = richTextBoxNotes.Text.Trim();
            List<string> problems = new List<string>();

            try
            {
                foreach (string problem in listBoxProblems.Items)
                {
                    problems.Add(problem);
                }

                NoteManager.AddNote(noteId, patientName, dateOfBirth, notes, problems);
                ClearFields();
                listBoxNotes.DataSource = new List<Note>();
                listBoxNotes.DataSource = NoteManager.Notes;
                listBoxNotes.SelectedIndex = -1;
                ChangeMode("awaiting note mode");
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }

        private void ClearFields()
        {
            txtNoteID.Text = "";
            txtPatientName.Text = "";
            datePickerDateOfBirth.Value = DateTime.Now;
            richTextBoxNotes.Text = "";
            listBoxProblems.Items.Clear();
        }

        private void btnStartNewNote_Click(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty;
            try
            {
                listBoxNotes.SelectedIndex = -1;
                ChangeMode("add mode");
                txtNoteID.Text = NoteManager.GetNewId("notes.as3");
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }

        private void btnAddProblem_Click(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty;
            try
            {
                ValidationHelper.IsValidProblem(txtNewProblem.Text);
                listBoxProblems.Items.Add(txtNewProblem.Text);
                txtNewProblem.Text = "";
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }

        private void btnUpdateNote_Click(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty;

            string patientName = txtPatientName.Text.Trim();
            string noteId = txtNoteID.Text.Trim();
            DateTime dateOfBirth = datePickerDateOfBirth.Value;
            string notes = richTextBoxNotes.Text.Trim();
            List<string> problems = new List<string>();

            try
            {
                foreach (string problem in listBoxProblems.Items)
                {
                    problems.Add(problem);
                }

                NoteManager.UpdateNote(noteId, patientName, dateOfBirth, notes, problems);
                ClearFields();
                listBoxNotes.DataSource = new List<Note>();
                listBoxNotes.DataSource = NoteManager.Notes;
                listBoxNotes.SelectedIndex = -1;
                ChangeMode("awaiting note mode");
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }

        private void btnDeleteNote_Click(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty;

            string noteId = txtNoteID.Text.Trim();
            try
            {
                NoteManager.RemoveNote(noteId);
                ClearFields();
                listBoxNotes.DataSource = new List<Note>();
                listBoxNotes.DataSource = NoteManager.Notes;
                listBoxNotes.SelectedIndex = -1;
                ChangeMode("awaiting note mode");
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }

        private void btnRemoveProblem_Click(object sender, EventArgs e)
        {
            if (listBoxProblems.SelectedIndex != -1)
            {
                listBoxProblems.Items.Remove(listBoxProblems.SelectedItem);
            }
        }
    }
}

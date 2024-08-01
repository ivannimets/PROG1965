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
                    richTextBoxNotes.Enabled = true; 
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
        }

        private void richTextBoxNotes_TextChanged(object sender, EventArgs e) //this function will get called with every text change on the textbox
        {
            string notes = richTextBoxNotes.Text;
            VitalsParser.UpdateVitalsList(richTextBoxNotes.Text, listBoxBPMeasurements);// update the vitals listbox if data from textbox matches          
        }
    }
}

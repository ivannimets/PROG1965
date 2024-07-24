namespace Assignment_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //method to switch between modes:
        private void ChangeMode(string mode)  // valid parameters: “awaiting note mode”
        {
            switch (mode)
            {
                case "awaiting note mode":
                    btnStartNewNote.Enabled = true;
                    listBoxNotes.Enabled = true;

                    txtNoteID.Enabled = false;
                    txtPatientName.Enabled = false;
                    datePickerDateOfBirth.Enabled = false;
                    txtNewProblem.Enabled = false;
                    btnAddProblem.Enabled = false;
                    richTextBoxNotes.Enabled = false;
                    btnAddNote.Enabled = false;
                    btnUpdateNote.Enabled = false;
                    btnDeleteNote.Enabled = false;
                    btnRemoveProblem.Enabled = false;

                    break;
                default:
                    break;

            }
        }
    }
}

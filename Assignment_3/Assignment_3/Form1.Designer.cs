namespace Assignment_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnStartNewNote = new Button();
            listBoxNotes = new ListBox();
            lblMessage = new Label();
            groupBoxForm = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            btnAddProblem = new Button();
            txtNewProblem = new TextBox();
            lblNewProblem = new Label();
            lblDateOfBirth = new Label();
            txtPatientName = new TextBox();
            lblPatientName = new Label();
            txtNoteID = new TextBox();
            label1 = new Label();
            lblProblems = new Label();
            listBoxProblems = new ListBox();
            lblBPMeasurements = new Label();
            listBoxBPMeasurements = new ListBox();
            lblNotes = new Label();
            richTextBoxNotes = new RichTextBox();
            btnAddNote = new Button();
            btnUpdateNote = new Button();
            btnDeleteNote = new Button();
            groupBoxForm.SuspendLayout();
            SuspendLayout();
            // 
            // btnStartNewNote
            // 
            btnStartNewNote.Location = new Point(28, 29);
            btnStartNewNote.Name = "btnStartNewNote";
            btnStartNewNote.Size = new Size(129, 29);
            btnStartNewNote.TabIndex = 0;
            btnStartNewNote.Text = "Start New Note";
            btnStartNewNote.UseVisualStyleBackColor = true;
            // 
            // listBoxNotes
            // 
            listBoxNotes.FormattingEnabled = true;
            listBoxNotes.Location = new Point(28, 74);
            listBoxNotes.Name = "listBoxNotes";
            listBoxNotes.Size = new Size(174, 544);
            listBoxNotes.TabIndex = 1;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(28, 635);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(113, 20);
            lblMessage.TabIndex = 2;
            lblMessage.Text = "Label Messages";
            // 
            // groupBoxForm
            // 
            groupBoxForm.Controls.Add(btnDeleteNote);
            groupBoxForm.Controls.Add(btnUpdateNote);
            groupBoxForm.Controls.Add(btnAddNote);
            groupBoxForm.Controls.Add(richTextBoxNotes);
            groupBoxForm.Controls.Add(lblNotes);
            groupBoxForm.Controls.Add(listBoxBPMeasurements);
            groupBoxForm.Controls.Add(lblBPMeasurements);
            groupBoxForm.Controls.Add(listBoxProblems);
            groupBoxForm.Controls.Add(lblProblems);
            groupBoxForm.Controls.Add(dateTimePicker1);
            groupBoxForm.Controls.Add(btnAddProblem);
            groupBoxForm.Controls.Add(txtNewProblem);
            groupBoxForm.Controls.Add(lblNewProblem);
            groupBoxForm.Controls.Add(lblDateOfBirth);
            groupBoxForm.Controls.Add(txtPatientName);
            groupBoxForm.Controls.Add(lblPatientName);
            groupBoxForm.Controls.Add(txtNoteID);
            groupBoxForm.Controls.Add(label1);
            groupBoxForm.Location = new Point(226, 29);
            groupBoxForm.Name = "groupBoxForm";
            groupBoxForm.Size = new Size(852, 589);
            groupBoxForm.TabIndex = 3;
            groupBoxForm.TabStop = false;
            groupBoxForm.Text = "Add/Edit/Delete Encouter Note:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd MMM yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(130, 142);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(324, 27);
            dateTimePicker1.TabIndex = 8;
            // 
            // btnAddProblem
            // 
            btnAddProblem.Location = new Point(361, 192);
            btnAddProblem.Name = "btnAddProblem";
            btnAddProblem.Size = new Size(93, 29);
            btnAddProblem.TabIndex = 4;
            btnAddProblem.Text = "Add";
            btnAddProblem.UseVisualStyleBackColor = true;
            // 
            // txtNewProblem
            // 
            txtNewProblem.Location = new Point(130, 192);
            txtNewProblem.Name = "txtNewProblem";
            txtNewProblem.Size = new Size(225, 27);
            txtNewProblem.TabIndex = 7;
            // 
            // lblNewProblem
            // 
            lblNewProblem.AutoSize = true;
            lblNewProblem.Location = new Point(18, 196);
            lblNewProblem.Name = "lblNewProblem";
            lblNewProblem.Size = new Size(102, 20);
            lblNewProblem.TabIndex = 6;
            lblNewProblem.Text = "New Problem:";
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Location = new Point(18, 147);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(97, 20);
            lblDateOfBirth.TabIndex = 4;
            lblDateOfBirth.Text = "Date of Birth:";
            // 
            // txtPatientName
            // 
            txtPatientName.Location = new Point(130, 92);
            txtPatientName.Name = "txtPatientName";
            txtPatientName.Size = new Size(324, 27);
            txtPatientName.TabIndex = 3;
            // 
            // lblPatientName
            // 
            lblPatientName.AutoSize = true;
            lblPatientName.Location = new Point(18, 95);
            lblPatientName.Name = "lblPatientName";
            lblPatientName.Size = new Size(101, 20);
            lblPatientName.TabIndex = 2;
            lblPatientName.Text = "Patient Name:";
            // 
            // txtNoteID
            // 
            txtNoteID.Location = new Point(130, 42);
            txtNoteID.Name = "txtNoteID";
            txtNoteID.Size = new Size(324, 27);
            txtNoteID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 45);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Note ID:";
            // 
            // lblProblems
            // 
            lblProblems.AutoSize = true;
            lblProblems.Location = new Point(479, 45);
            lblProblems.Name = "lblProblems";
            lblProblems.Size = new Size(74, 20);
            lblProblems.TabIndex = 9;
            lblProblems.Text = "Problems:";
            // 
            // listBoxProblems
            // 
            listBoxProblems.FormattingEnabled = true;
            listBoxProblems.Location = new Point(479, 68);
            listBoxProblems.Name = "listBoxProblems";
            listBoxProblems.Size = new Size(157, 164);
            listBoxProblems.TabIndex = 10;
            // 
            // lblBPMeasurements
            // 
            lblBPMeasurements.AutoSize = true;
            lblBPMeasurements.Location = new Point(666, 45);
            lblBPMeasurements.Name = "lblBPMeasurements";
            lblBPMeasurements.Size = new Size(129, 20);
            lblBPMeasurements.TabIndex = 11;
            lblBPMeasurements.Text = "BP Measurements:";
            // 
            // listBoxBPMeasurements
            // 
            listBoxBPMeasurements.FormattingEnabled = true;
            listBoxBPMeasurements.Location = new Point(666, 68);
            listBoxBPMeasurements.Name = "listBoxBPMeasurements";
            listBoxBPMeasurements.Size = new Size(157, 164);
            listBoxBPMeasurements.TabIndex = 12;
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Location = new Point(18, 246);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(51, 20);
            lblNotes.TabIndex = 13;
            lblNotes.Text = "Notes:";
            // 
            // richTextBoxNotes
            // 
            richTextBoxNotes.Location = new Point(18, 269);
            richTextBoxNotes.Name = "richTextBoxNotes";
            richTextBoxNotes.Size = new Size(805, 259);
            richTextBoxNotes.TabIndex = 14;
            richTextBoxNotes.Text = "";
            // 
            // btnAddNote
            // 
            btnAddNote.Location = new Point(18, 543);
            btnAddNote.Name = "btnAddNote";
            btnAddNote.Size = new Size(125, 29);
            btnAddNote.TabIndex = 15;
            btnAddNote.Text = "Add Note";
            btnAddNote.UseVisualStyleBackColor = true;
            // 
            // btnUpdateNote
            // 
            btnUpdateNote.Location = new Point(149, 543);
            btnUpdateNote.Name = "btnUpdateNote";
            btnUpdateNote.Size = new Size(125, 29);
            btnUpdateNote.TabIndex = 16;
            btnUpdateNote.Text = "Update Note";
            btnUpdateNote.UseVisualStyleBackColor = true;
            // 
            // btnDeleteNote
            // 
            btnDeleteNote.Location = new Point(280, 543);
            btnDeleteNote.Name = "btnDeleteNote";
            btnDeleteNote.Size = new Size(125, 29);
            btnDeleteNote.TabIndex = 17;
            btnDeleteNote.Text = "Delete Note";
            btnDeleteNote.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 675);
            Controls.Add(groupBoxForm);
            Controls.Add(lblMessage);
            Controls.Add(listBoxNotes);
            Controls.Add(btnStartNewNote);
            Name = "Form1";
            Text = "Form1";
            groupBoxForm.ResumeLayout(false);
            groupBoxForm.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStartNewNote;
        private ListBox listBoxNotes;
        private Label lblMessage;
        private GroupBox groupBoxForm;
        private TextBox txtNoteID;
        private Label label1;
        private Label lblDateOfBirth;
        private TextBox txtPatientName;
        private Label lblPatientName;
        private TextBox txtNewProblem;
        private Label lblNewProblem;
        private DateTimePicker dateTimePicker1;
        private Button btnAddProblem;
        private ListBox listBoxProblems;
        private Label lblProblems;
        private ListBox listBoxBPMeasurements;
        private Label lblBPMeasurements;
        private Label lblNotes;
        private Button btnDeleteNote;
        private Button btnUpdateNote;
        private Button btnAddNote;
        private RichTextBox richTextBoxNotes;
    }
}

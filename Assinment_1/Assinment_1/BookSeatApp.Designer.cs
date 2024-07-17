namespace Assinment_1
{
    partial class BookSeatApp
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
            components = new System.ComponentModel.Container();
            GBConstrols = new GroupBox();
            btnToShowWailist = new Button();
            LBCols = new ListBox();
            LBRows = new ListBox();
            btnStatus = new Button();
            lblLBRows = new Label();
            btnBookAll = new Button();
            lblLBCols = new Label();
            btnBook = new Button();
            txtCustomerName = new TextBox();
            btnCancel = new Button();
            lbltxtCustomerName = new Label();
            btnWaitlist = new Button();
            btnCancelAll = new Button();
            lblStats = new Label();
            lblMessage = new Label();
            toolTip1 = new ToolTip(components);
            RTXTWaitlist = new RichTextBox();
            GBWaitlist = new GroupBox();
            btnCloseWaitlist = new Button();
            GBConstrols.SuspendLayout();
            GBWaitlist.SuspendLayout();
            SuspendLayout();
            // 
            // GBConstrols
            // 
            GBConstrols.Controls.Add(btnToShowWailist);
            GBConstrols.Controls.Add(LBCols);
            GBConstrols.Controls.Add(LBRows);
            GBConstrols.Controls.Add(btnStatus);
            GBConstrols.Controls.Add(lblLBRows);
            GBConstrols.Controls.Add(btnBookAll);
            GBConstrols.Controls.Add(lblLBCols);
            GBConstrols.Controls.Add(btnBook);
            GBConstrols.Controls.Add(txtCustomerName);
            GBConstrols.Controls.Add(btnCancel);
            GBConstrols.Controls.Add(lbltxtCustomerName);
            GBConstrols.Controls.Add(btnWaitlist);
            GBConstrols.Controls.Add(btnCancelAll);
            GBConstrols.Location = new Point(469, 78);
            GBConstrols.Name = "GBConstrols";
            GBConstrols.Size = new Size(257, 358);
            GBConstrols.TabIndex = 16;
            GBConstrols.TabStop = false;
            // 
            // btnToShowWailist
            // 
            btnToShowWailist.Location = new Point(12, 315);
            btnToShowWailist.Name = "btnToShowWailist";
            btnToShowWailist.Size = new Size(230, 29);
            btnToShowWailist.TabIndex = 15;
            btnToShowWailist.Text = "Show Waitlist";
            btnToShowWailist.UseVisualStyleBackColor = true;
            btnToShowWailist.Click += btnToShowWailist_Click;
            // 
            // LBCols
            // 
            LBCols.FormattingEnabled = true;
            LBCols.Location = new Point(146, 35);
            LBCols.Name = "LBCols";
            LBCols.Size = new Size(61, 104);
            LBCols.TabIndex = 1;
            // 
            // LBRows
            // 
            LBRows.FormattingEnabled = true;
            LBRows.Location = new Point(51, 35);
            LBRows.Name = "LBRows";
            LBRows.Size = new Size(61, 104);
            LBRows.TabIndex = 0;
            // 
            // btnStatus
            // 
            btnStatus.Location = new Point(174, 210);
            btnStatus.Name = "btnStatus";
            btnStatus.Size = new Size(68, 29);
            btnStatus.TabIndex = 14;
            btnStatus.Text = "Status";
            btnStatus.UseVisualStyleBackColor = true;
            btnStatus.Click += btnStatus_Click;
            // 
            // lblLBRows
            // 
            lblLBRows.AutoSize = true;
            lblLBRows.Location = new Point(51, 12);
            lblLBRows.Name = "lblLBRows";
            lblLBRows.Size = new Size(44, 20);
            lblLBRows.TabIndex = 2;
            lblLBRows.Text = "Rows";
            // 
            // btnBookAll
            // 
            btnBookAll.Location = new Point(134, 245);
            btnBookAll.Name = "btnBookAll";
            btnBookAll.Size = new Size(108, 29);
            btnBookAll.TabIndex = 10;
            btnBookAll.Text = "Book all seats";
            btnBookAll.UseVisualStyleBackColor = true;
            btnBookAll.Click += btnBookAll_Click;
            // 
            // lblLBCols
            // 
            lblLBCols.AutoSize = true;
            lblLBCols.Location = new Point(141, 12);
            lblLBCols.Name = "lblLBCols";
            lblLBCols.Size = new Size(66, 20);
            lblLBCols.TabIndex = 3;
            lblLBCols.Text = "Columns";
            // 
            // btnBook
            // 
            btnBook.Location = new Point(12, 210);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(74, 29);
            btnBook.TabIndex = 9;
            btnBook.Text = "Book";
            btnBook.UseVisualStyleBackColor = true;
            btnBook.Click += btnBook_Click;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(51, 174);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(156, 27);
            txtCustomerName.TabIndex = 4;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(89, 210);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(79, 29);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lbltxtCustomerName
            // 
            lbltxtCustomerName.AutoSize = true;
            lbltxtCustomerName.Location = new Point(52, 151);
            lbltxtCustomerName.Name = "lbltxtCustomerName";
            lbltxtCustomerName.Size = new Size(116, 20);
            lbltxtCustomerName.TabIndex = 5;
            lbltxtCustomerName.Text = "Customer Name";
            // 
            // btnWaitlist
            // 
            btnWaitlist.Location = new Point(12, 245);
            btnWaitlist.Name = "btnWaitlist";
            btnWaitlist.Size = new Size(116, 29);
            btnWaitlist.TabIndex = 7;
            btnWaitlist.Text = "Add to waitlist";
            btnWaitlist.UseVisualStyleBackColor = true;
            btnWaitlist.Click += btnWaitlist_Click;
            // 
            // btnCancelAll
            // 
            btnCancelAll.Location = new Point(12, 280);
            btnCancelAll.Name = "btnCancelAll";
            btnCancelAll.Size = new Size(230, 29);
            btnCancelAll.TabIndex = 6;
            btnCancelAll.Text = "Cancel All Bookings";
            btnCancelAll.UseVisualStyleBackColor = true;
            btnCancelAll.Click += btnCancelAll_Click;
            // 
            // lblStats
            // 
            lblStats.AutoSize = true;
            lblStats.Location = new Point(32, 35);
            lblStats.Name = "lblStats";
            lblStats.Size = new Size(0, 20);
            lblStats.TabIndex = 15;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(32, 259);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 20);
            lblMessage.TabIndex = 17;
            // 
            // RTXTWaitlist
            // 
            RTXTWaitlist.Location = new Point(16, 26);
            RTXTWaitlist.Name = "RTXTWaitlist";
            RTXTWaitlist.ReadOnly = true;
            RTXTWaitlist.Size = new Size(302, 256);
            RTXTWaitlist.TabIndex = 18;
            RTXTWaitlist.Text = "";
            // 
            // GBWaitlist
            // 
            GBWaitlist.BackColor = SystemColors.ActiveCaption;
            GBWaitlist.Controls.Add(btnCloseWaitlist);
            GBWaitlist.Controls.Add(RTXTWaitlist);
            GBWaitlist.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            GBWaitlist.ForeColor = SystemColors.ActiveCaptionText;
            GBWaitlist.Location = new Point(100, 90);
            GBWaitlist.Name = "GBWaitlist";
            GBWaitlist.Size = new Size(335, 346);
            GBWaitlist.TabIndex = 19;
            GBWaitlist.TabStop = false;
            GBWaitlist.Text = "Waitlist";
            GBWaitlist.Visible = false;
            // 
            // btnCloseWaitlist
            // 
            btnCloseWaitlist.Location = new Point(123, 299);
            btnCloseWaitlist.Name = "btnCloseWaitlist";
            btnCloseWaitlist.Size = new Size(94, 29);
            btnCloseWaitlist.TabIndex = 19;
            btnCloseWaitlist.Text = "Close";
            btnCloseWaitlist.UseVisualStyleBackColor = true;
            btnCloseWaitlist.Click += btnCloseWaitlist_Click;
            // 
            // BookSeatApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 465);
            Controls.Add(GBWaitlist);
            Controls.Add(lblMessage);
            Controls.Add(lblStats);
            Controls.Add(GBConstrols);
            Name = "BookSeatApp";
            Text = "Conestoga Wellcome";
            Load += Form1_Load;
            GBConstrols.ResumeLayout(false);
            GBConstrols.PerformLayout();
            GBWaitlist.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblLBRows;
        private Label lblLBCols;
        private Label lbltxtCustomerName;
        private Button btnCancelAll;
        private Button btnWaitlist;
        private Button btnCancel;
        private Button btnBook;
        private Button btnBookAll;
        private Button btnStatus;
        private Label lblStats;
        public GroupBox GBConstrols;
        private Label lblMessage;
        public ToolTip toolTip1;
        public ListBox LBRows;
        public ListBox LBCols;
        public TextBox txtCustomerName;
        private Button btnCloseWaitlist;
        public GroupBox GBWaitlist;
        public RichTextBox RTXTWaitlist;
        private Button btnToShowWailist;
    }
}

using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Assinment_1
{
    public partial class BookSeatApp : Form
    {


        public BookSeatApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //
            // code co admin, enable to enter number of rows and columns
            //
            string rowInput = Interaction.InputBox("Enter Number of Rows you want to create in venue?", "Venue Creating", "5", 500, 300);
            string colInput = Interaction.InputBox("Enter Number of Columns you want to create in venue?", "Venue Creating", "6", 500, 300);

            int row = 5;
            int col = 6;
            if (int.TryParse(rowInput, out int value))
            {
                row = value;
            }
            if (int.TryParse(colInput, out value))
            {
                col = value;
            }

            // creating venue and adding it form
            //
            FlowLayoutPanel venue = Venue.CreateVenue(row, col, this);
            this.Controls.Add(venue);

            // setting up locations of other objects accotding to venue size
            //
            lblStats.Location = new System.Drawing.Point(venue.Left, 45);
            GBConstrols.Location = new Point(80 + venue.Width, 60);
            lblMessage.Location = new System.Drawing.Point(venue.Left, venue.Height + venue.Top + 10);
            lblMessage.MaximumSize = new System.Drawing.Size(venue.Width + 30, 0);
            this.Size = new System.Drawing.Size(venue.Width + 400, (venue.Height < 300) ? 500 : venue.Height + 200);
            GBWaitlist.Location = new System.Drawing.Point((this.Size.Width - GBWaitlist.Width) / 2, +(this.Size.Height - GBWaitlist.Height) / 2);

            // show statisctics about venue
            //
            lblStats.Text = Venue.ShowStats();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            string name = txtCustomerName.Text;
            lblMessage.Text = Venue.BookSeat(name, this);
            lblStats.Text = Venue.ShowStats();
        }



        private void btnStatus_Click(object sender, EventArgs e)
        {
            int row = LBRows.SelectedIndex;
            int col = LBCols.SelectedIndex;
            lblMessage.Text = Venue.StatusCheck(row, col, this);
            lblStats.Text = Venue.ShowStats();
        }
        private void btnWaitlist_Click(object sender, EventArgs e)
        {
            lblMessage.Text = Venue.AddToWaitlist(this);
            lblStats.Text = Venue.ShowStats();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            int row = LBRows.SelectedIndex;
            int col = LBCols.SelectedIndex;
            lblMessage.Text = Venue.CancelBooking(row, col, this);
            lblStats.Text = Venue.ShowStats();
        }

        private void btnBookAll_Click(object sender, EventArgs e)
        {
            string name = txtCustomerName.Text;
            lblMessage.Text = Venue.BookAllSeats(name);
            lblStats.Text = Venue.ShowStats();
        }

        private void btnCancelAll_Click(object sender, EventArgs e)
        {
            Venue.CancelAllBookings();
            lblMessage.Text = "All bookings have been canceled and wishList emptied";
            lblStats.Text = Venue.ShowStats();
        }

        //
        //method to show name or "availible" if seat is hovered
        //
        public void lblSeat_MouseHover(object sender, EventArgs e)
        {
            for (int i = 0; i < Venue.seats.GetLength(0); i++)
            {
                for (int j = 0; j < Venue.seats.GetLength(1); j++)
                {
                    if (Venue.seats[i, j].label == sender)
                    {
                        toolTip1.Show(Venue.seats[i, j].customer, Venue.seats[i, j].label);
                    }
                }
            }
        }

        private void btnToShowWailist_Click(object sender, EventArgs e)
        {
            lblMessage.Text = Venue.ShowWaitlist(this);
        }

        private void btnCloseWaitlist_Click(object sender, EventArgs e)
        {
            Venue.CloseWaitList(this);
        }
    }
}

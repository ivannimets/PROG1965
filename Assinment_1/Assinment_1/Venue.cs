using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assinment_1
{
    internal class Venue
    {
        private static List<string> waitlist = new List<string>(); // waitlist
        public static Seat[,] seats; // array for seats in venue
        public static FlowLayoutPanel FLPVenue = new FlowLayoutPanel();

        // method that creates venue Flow Layout Panel and fill it with seat lables
        //
        public static FlowLayoutPanel CreateVenue(int row, int col, BookSeatApp parent)
        {
            // initialise array for seats
            //
            seats = new Seat[row, col];



            //dictionary for converting row numbers to letters
            //
            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
            keyValuePairs.Add(0, "A");
            keyValuePairs.Add(1, "B");
            keyValuePairs.Add(2, "C");
            keyValuePairs.Add(3, "D");
            keyValuePairs.Add(4, "E");
            keyValuePairs.Add(5, "F");
            keyValuePairs.Add(6, "G");
            keyValuePairs.Add(7, "H");
            keyValuePairs.Add(8, "I");
            keyValuePairs.Add(9, "J");
            keyValuePairs.Add(10, "K");
            keyValuePairs.Add(11, "L");
            keyValuePairs.Add(12, "M");
            keyValuePairs.Add(13, "N");
            keyValuePairs.Add(14, "O");
            keyValuePairs.Add(15, "P");
            keyValuePairs.Add(16, "Q");
            keyValuePairs.Add(17, "R");
            keyValuePairs.Add(18, "S");
            keyValuePairs.Add(19, "T");
            keyValuePairs.Add(20, "U");

            // creating object for venue
            //
            FlowLayoutPanel venue = new FlowLayoutPanel();
            venue.Location = new Point(32, 70);
            venue.Size = new Size((50 * col + 2), (35 * row + 5));
            venue.Name = "FLPVenue";
            venue.FlowDirection = FlowDirection.LeftToRight;
            venue.BorderStyle = BorderStyle.FixedSingle;
            venue.Visible = true;
            venue.AutoSizeMode = AutoSizeMode.GrowOnly;
            FLPVenue = venue;


            // filling in the venue with seat labels
            //
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Label lblSeat = new Label();
                    lblSeat.Location = new Point(3, 3);
                    lblSeat.Size = new Size(40, 25);
                    lblSeat.BackColor = Color.Lime;
                    lblSeat.Text = keyValuePairs[i] + (j + 1);
                    lblSeat.Margin = new(5);
                    lblSeat.TextAlign = ContentAlignment.MiddleCenter;
                    lblSeat.MouseHover += parent.lblSeat_MouseHover;
                    venue.Controls.Add(lblSeat);
                    seats[i, j] = new Seat(keyValuePairs[i] + (j + 1), lblSeat); ;
                }
            }

            // Adding rows and cols to Lists
            //
            string[] rows = new string[row];
            string[] cols = new string[col];
            for (int i = 0; i < row; i++)
            {
                rows[i] = keyValuePairs[i];
            }
            for (int i = 1; i <= col; i++)
            {
                cols[i - 1] = i.ToString();
            }
            parent.LBRows.Items.AddRange(rows);
            parent.LBCols.Items.AddRange(cols);


            return venue;
        }

        //
        //method to show statistic about venue
        //
        public static string ShowStats()
        {
            float availible = 0;
            float capacity = seats.GetLength(0) * seats.GetLength(1);
            // calculate the number of empty seats
            for (int i = 0; i < seats.GetLength(0); i++)
            {
                for (int j = 0; j < seats.GetLength(1); j++)
                {
                    if (seats[i, j].availibility == true)
                    {
                        availible++;
                    }
                }
            }
            return "Total capacity: " + capacity + ". Seats availible: " + availible + " (i.e. at " + ((1 - (availible / capacity)) * 100).ToString("N") + "% capacity). " + waitlist.Count + " customers in waitlist.";
        }

        //
        // method to cancel all of bookings and empty waitlist
        //
        public static void CancelAllBookings()
        {
            //go through the venue and cancel all bookings
            for (int i = 0; i < seats.GetLength(0); i++)
            {
                for (int j = 0; j < seats.GetLength(1); j++)
                {
                    seats[i, j].customer = "availible";
                    seats[i, j].label.BackColor = Color.Lime;
                    seats[i, j].availibility = true;
                }
            }
            waitlist.Clear();
        }

        //
        // method to book all seats
        //
        public static string BookAllSeats(string name)
        {
            if (name.Length > 0) // check if name was entered
            {
                if (FreeSeatCheck()) // check if there are a free place in venue
                {
                    // starting to go through the venue and book seats if they are availible
                    for (int i = 0; i < seats.GetLength(0); i++)
                    {
                        for (int j = 0; j < seats.GetLength(1); j++)
                        {
                            if (seats[i, j].availibility == true) // check if seat is availible
                            {
                                seats[i, j].customer = name;
                                seats[i, j].label.BackColor = Color.Red;
                                seats[i, j].availibility = false;
                            }
                        }
                    }
                    return "All availible seats were booked successfully";
                }
                else
                {
                    return "There is no free seats";
                }
            }
            else
            {
                return "Enter your name to book all the seats";
            }
        }

        //method that check if venue has free plase, return false if full. Write error if it is true
        private static bool FreeSeatCheck()
        {
            for (int i = 0; i < seats.GetLength(0); i++)
            {
                for (int j = 0; j < seats.GetLength(1); j++)
                {
                    if (seats[i, j].availibility == true)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        //
        //method to cancel booking
        //
        public static string CancelBooking(int row, int col, BookSeatApp parent)
        {
            if (row != -1 && col != -1) //check if row and col was choosen
            {
                if (seats[row, col].availibility == false) // check if seat is booked
                {
                    if (DialogResult.Yes == MessageBox.Show("Are you sure you wanna cancel booking", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) // confirmation for canceling
                    {
                        if (!waitlist.Any()) // check if waitlist is empty
                        {
                            seats[row, col].availibility = true;
                            seats[row, col].customer = "availible";
                            seats[row, col].label.BackColor = Color.Lime;
                            ClearFields(parent);
                            return "Booking for seat " + seats[row, col].name + " has been canceled successfully";
                        }
                        else
                        {
                            seats[row, col].customer = waitlist[0];
                            waitlist.RemoveAt(0);
                            ClearFields(parent);
                            return "Booking for seat " + seats[row, col].name + " has been canceled successfully\n Seat " + seats[row, col].name + " was booked by " + seats[row, col].customer + " successfully";
                        }
                    }
                    else
                    {
                        return "";
                    }
                }
                else
                {
                    return "This seat is not booked";
                }
            }
            else
            {
                return "Choose row and column to cancel the seat";
            }
        }

        //
        // method to clear all input fields on the form after booking or canceling actions
        //
        private static void ClearFields(BookSeatApp parent)
        {
            parent.LBRows.SelectedItem = null;
            parent.LBCols.SelectedItem = null;
            parent.txtCustomerName.Text = string.Empty;
        }

        //
        //method that books seats and add to waitlist if seat is alredy booked
        //
        public static string BookSeat(string name, BookSeatApp parent)
        {
            if (name.Length > 0) // check if name was entered
            {
                if (FreeSeatCheck()) // check if there are a free place in venue
                {
                    int row = parent.LBRows.SelectedIndex;
                    int col = parent.LBCols.SelectedIndex;
                    if (row != -1 && col != -1) //check if row and col was choosen
                    {
                        if (seats[row, col].availibility == true) // check if seat is not already booked 
                        {
                            seats[row, col].customer = name;
                            seats[row, col].label.BackColor = Color.Red;
                            seats[row, col].availibility = false;
                            ClearFields(parent);
                            return "You successfuly booked seat " + seats[row, col].name;
                        }
                        else
                        {
                            return "This seat is already booked by " + seats[row, col].customer;
                        }
                    }
                    else
                    {
                        return "Choose row and column to book the seat";
                    }
                }
                else
                {
                    waitlist.Add(name);
                    ClearFields(parent);
                    return "You have been added to the waiting list until a seat becomes available";
                }
            }
            else
            {
                return "Enter your name to book the seat";
            }
        }

        //
        // method to check the status of seat
        //
        public static string StatusCheck(int row, int col, BookSeatApp parent)
        {
            if (row != -1 && col != -1) // check is col and row were checked
            {
                if (seats[row, col].availibility == false) //check if seat is booked
                {
                    ClearFields(parent);
                    return "Customer " + seats[row, col].customer + " booked " + seats[row, col].name + " seat";
                }
                else
                {
                    ClearFields(parent);
                    return "The " + seats[row, col].name + " seat is availible to book";
                }
            }
            else
            {
                return "Choose row and column to check the status of seat";
            }
        }

        //
        // method to add customer to waitlist if there are no free seats
        //
        public static string AddToWaitlist(BookSeatApp parent)
        {
            if (!FreeSeatCheck()) // check if there are no free seats
            {
                string name = parent.txtCustomerName.Text;
                if (name.Length > 0) // check if name was entered
                {
                    waitlist.Add(name);
                    ClearFields(parent);
                    return "You have been added to the waiting list until a seat becomes available";
                }
                else
                {
                    return "Enter your name to add you to waitlist";
                }
            }
            else
            {
                return "There are availible seats";
            }
        }

        //
        // method to show waitlist
        //
        public static string ShowWaitlist(BookSeatApp parent)
        {
            if (waitlist.Count == 0)
            {
                return "Waitlist is empty";
            }
            else
            {
                parent.GBConstrols.Enabled = false;
                FLPVenue.Enabled = false;
                parent.GBWaitlist.Visible = true;
                int index = 1;
                foreach (string record in waitlist)
                {
                    parent.RTXTWaitlist.Text += "  #" + index + " " + record + "\n";
                    index++;
                }
                return "";
            }
        }

        //
        // method to close waitlist
        //
        public static void CloseWaitList(BookSeatApp parent)
        {
            parent.GBConstrols.Enabled = true;
            FLPVenue.Enabled = true;
            parent.GBWaitlist.Visible = false;
            parent.RTXTWaitlist.Text = "";
        }
    }
}

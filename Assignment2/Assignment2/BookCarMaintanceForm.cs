

namespace Assignment2
{
    public partial class BookCarMaintanceForm : Form
    {
        public BookCarMaintanceForm()
        {
            InitializeComponent();
        }

        private void btnPrefill_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            txtCustomerName.Text = "Homer Simpson";
            txtAddress.Text = "742 Evergreen Terrace";
            txtCity.Text = "Springfield";
            txtPostalCode.Text = "N2M 5E6";
            txtProvince.Text = "Ontario";
            txtCellPhone.Text = "123-123-1234";
            txtEmail.Text = "gsimpson@gmail.com";
            txtMakeAndModel.Text = "Honda Civic";
            txtYear.Text = "2002";
            dateAppointmentDate.Value = new DateTime(2024, 8, 1);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            txtCustomerName.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtPostalCode.Text = "";
            txtProvince.Text = "";
            txtHomePhone.Text = "";
            txtCellPhone.Text = "";
            txtEmail.Text = "";
            txtMakeAndModel.Text = "";
            txtYear.Text = "";
            dateAppointmentDate.Value = date;
            txtProblem.Text = "";
            lblMessages.Text = "";
        }

        private void btnBookAppointment_Click(object sender, EventArgs e)
        {
            bool nonFocus = true;
            string message = "";
            bool numberProvided = false;

            //
            // check customer name is empty
            //
            if (!ValidationHelper.IsValidCustomerName(txtCustomerName.Text))
            {
                message += "The customer name is required and cannot be just blanks\n";
                if (nonFocus)
                {
                    nonFocus = false;
                    txtCustomerName.Focus();
                }
            }

            //
            // check if email or address, city, province code, and postal code are provided
            //
            if (String.IsNullOrEmpty(txtAddress.Text.Trim()))
            {
                if (String.IsNullOrEmpty(txtEmail.Text.Trim()))
                {
                    message += "Address is required if email is not provided\n";
                    if (nonFocus)
                    {
                        nonFocus = false;
                        txtAddress.Focus();
                    }
                }
            }
            if (String.IsNullOrEmpty(txtCity.Text.Trim()))
            {
                if (String.IsNullOrEmpty(txtEmail.Text.Trim()))
                {
                    message += "City is required if email is not provided\n";
                    if (nonFocus)
                    {
                        nonFocus = false;
                        txtCity.Focus();
                    }
                }
            }
            if (String.IsNullOrEmpty(txtPostalCode.Text.Trim()))
            {
                if (String.IsNullOrEmpty(txtEmail.Text.Trim()))
                {
                    message += "Postal Code is required if email is not provided\n";
                    if (nonFocus)
                    {
                        nonFocus = false;
                        txtPostalCode.Focus();
                    }
                }
            }
            else //if provided, validation check
            {
                if (!ValidationHelper.IsValidPostalCode(txtPostalCode.Text))
                {
                    message += "Postal Code doesn't match the Chanadin patern \"A2A 2A2\"\n";
                    if (nonFocus)
                    {
                        nonFocus = false;
                        txtPostalCode.Focus();
                    }
                }
            }
            if (String.IsNullOrEmpty(txtProvince.Text.Trim()))
            {
                if (String.IsNullOrEmpty(txtEmail.Text.Trim()))
                {
                    message += "Province is required if email is not provided\n";
                    if (nonFocus)
                    {
                        nonFocus = false;
                        txtProvince.Focus();
                    }
                }
            }
            else //if provided, validation check
            {
                if (!ValidationHelper.IsValidProvinceName(txtProvince.Text.ToLower()))
                {
                    message += "Proince Name were not found\n";
                    if (nonFocus)
                    {
                        nonFocus = false;
                        txtProvince.Focus();
                    }
                }
            }

            //
            // Phone numbers validation
            //
            if (!String.IsNullOrEmpty(txtCellPhone.Text.Trim()))
            {
                if (!ValidationHelper.IsValidPhoneNumber(txtCellPhone.Text))
                {
                    message += "Cell Phone Number is not match with pattern \"123-123-1234\"\n";
                    if (nonFocus)
                    {
                        nonFocus = false;
                        txtCellPhone.Focus();
                    }
                }
                numberProvided = true;
            }
            if (!String.IsNullOrEmpty(txtHomePhone.Text.Trim()))
            {
                if (!ValidationHelper.IsValidPhoneNumber(txtHomePhone.Text))
                {
                    message += "Home Phone Number is not match with pattern \"123-123-1234\"\n";
                    if (nonFocus)
                    {
                        nonFocus = false;
                        txtHomePhone.Focus();
                    }
                }
                numberProvided = true;
            }
            if (!numberProvided)
            {
                message += "At least one of home or cell phone numbers are requred\n";
                if (nonFocus)
                {
                    nonFocus = false;
                    txtCellPhone.Focus();
                }
            }
            //
            // Email validation
            //
            if (!String.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                if (!ValidationHelper.IsValidEmail(txtEmail.Text))
                {
                    message += "Email format is not matching to regular pattern of email address\n";
                    if (nonFocus)
                    {
                        nonFocus = false;
                        txtEmail.Focus();
                    }
                }
            }

            //
            // check make and model is empty
            //
            if (!ValidationHelper.IsValidMakeAndModel(txtMakeAndModel.Text))
            {
                message += "The make and model is required and cannot be just blanks\n";
                if (nonFocus)
                {
                    nonFocus = false;
                    txtMakeAndModel.Focus();
                }
            }

            //
            //check if year is valid
            //
            if (!String.IsNullOrEmpty(txtYear.Text.Trim()))
            {
                if (!ValidationHelper.IsValidYear(txtYear.Text))
                {
                    message += "Must be a valid integer value between 1900 and " + (DateTime.Now.Year + 1).ToString() + "\n";
                    if (nonFocus)
                    {
                        nonFocus = false;
                        txtYear.Focus();
                    }
                }
            }

            //
            // appointment date validation
            //
            if (!ValidationHelper.IsValidAppointmantDate(dateAppointmentDate.Value))
            {
                message += "The appintment date cannot be in the past\n";
                if (nonFocus)
                {
                    nonFocus = false;
                    dateAppointmentDate.Focus();
                }
            }

            //
            // Data conversion after checking for errors existing
            //
            if (message != "")
            {
                lblMessages.Text = message;
            } 
            else
            {
                lblMessages.Text = "";

                // remove all aside white spaces in all input fields
                txtCustomerName.Text = txtCustomerName.Text.Trim();
                txtAddress.Text = txtAddress.Text.Trim();
                txtCity.Text = txtCity.Text.Trim();
                txtPostalCode.Text = txtPostalCode.Text.Trim();
                txtProvince.Text = txtProvince.Text.Trim();
                txtHomePhone.Text = txtHomePhone.Text.Trim();
                txtCellPhone.Text = txtCellPhone.Text.Trim();
                txtEmail.Text = txtEmail.Text.Trim();
                txtMakeAndModel.Text = txtMakeAndModel.Text.Trim();
                txtYear.Text = txtYear.Text.Trim();
                txtProblem.Text = txtProblem.Text.Trim();

                // capitalising
                txtCustomerName.Text = ValidationHelper.Capitalize(txtCustomerName.Text);
                txtAddress.Text = ValidationHelper.Capitalize(txtAddress.Text);
                txtMakeAndModel.Text = ValidationHelper.Capitalize(txtMakeAndModel.Text);
                txtCity.Text = ValidationHelper.Capitalize(txtCity.Text);
                txtProvince.Text = ValidationHelper.Capitalize(txtProvince.Text);

                // postal code conversion
                txtPostalCode.Text = txtPostalCode.Text.Replace(" ", "").Insert(3, " ").ToUpper();

                // phone numbers conversion
                if (!String.IsNullOrEmpty(txtCellPhone.Text)) {
                    txtCellPhone.Text = txtCellPhone.Text.Replace(" ", "").Replace("-", "").Insert(6, "-").Insert(3, "-");
                }

                // email conversion
                txtEmail.Text = txtEmail.Text.ToLower();

                // writing to file
                string record = "";
                record += txtCustomerName.Text + "|";
                record += txtAddress.Text + "|";
                record += txtCity.Text + "|";
                record += txtPostalCode.Text + "|";
                record += txtProvince.Text + "|";
                record += txtHomePhone.Text + "|";
                record += txtCellPhone.Text + "|";
                record += txtEmail.Text + "|";
                record += txtMakeAndModel.Text + "|";
                record += txtYear.Text + "|";
                record += dateAppointmentDate.Value.Date.ToString() + "|";
                record += txtProblem.Text.Replace("\n", "*%*");

                StreamWriter writer = null;
                try
                {
                    writer = new StreamWriter(path: @"data.app", append: true);
                    writer.WriteLine(record);
                    lblMessages.Text = "Appointment for " + txtCustomerName.Text + " was booked successfully.";
                }
                catch (Exception ex)
                {
                    lblMessages.Text = $"Exception adding record: {ex.Message}";
                }
                finally
                {
                    if (writer != null)
                        writer.Dispose();
                }
            }
        }
    }
}

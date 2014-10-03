using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace MedSCAN.Boundary
{
    /*----------------------------------------------------------------------------
     * Author: J. Nobles
     * Date: 3/5/2014
     * Patient Lookup form -Boundary class
     *///-------------------------------------------------------------------------
    public partial class PatientLookup : Form
    {
        Entity.Patient patient = new Entity.Patient();
        public static TextBox pIDtxt = new TextBox();
        Control.Scanner scanner = new Control.Scanner();

        SqlCommand oSqlCmd;
        DataTable dt;

        bool ValidPatientID = false;
        bool INACTIVE = false;

        public PatientLookup()
        {
            InitializeComponent();
        }

        private void PatientLookUp_Load(object sender, EventArgs e)
        { 
        }

        //Clears the Patient ID text box
        public void CleartxtBox()
        {
            txtBoxPatientID.Clear();
        }

        //Checks to see if the scanned patient is in the database and is ACTIVE
        private bool setPatient()
        {
            string query = "SELECT * FROM tbl_Patients WHERE PatientID = '" + txtBoxPatientID.Text + "'";
            oSqlCmd = new SqlCommand(query);
            dt = Control.DatabaseConnection.GetDataTable(oSqlCmd);

            if (dt.Rows.Count > 0)
            {
                ValidPatientID = true;
                int X;
                string unknown = "??";

                patient.pID = dt.Rows[0]["PatientID"].ToString();
                patient.Status = dt.Rows[0]["Status"].ToString();
                if (dt.Rows[0]["Status"].ToString().ToUpper().Equals("INACTIVE"))
                    INACTIVE = true; // If patient is INACTIVE this bool will allow the wrong patient alert to trigger. (not used)

                patient.Firstname = dt.Rows[0]["Firstname"].ToString();
                patient.Lastname = dt.Rows[0]["Lastname"].ToString();
                patient.Mi = dt.Rows[0]["MI"].ToString();

                bool resultAge =int.TryParse(dt.Rows[0]["Age"].ToString(), out X);
                if (resultAge)
                    patient.age = X.ToString();
                else
                    patient.age = unknown;

                patient.height = dt.Rows[0]["Height"].ToString();
                patient.weight = dt.Rows[0]["Weight"].ToString();

                patient.dob = dt.Rows[0]["DOB"].ToString();
                patient.Gender = dt.Rows[0]["Gender"].ToString();
                patient.Pregnant = dt.Rows[0]["Pregnant"].ToString();

                patient.Physician = dt.Rows[0]["Physician"].ToString();

                patient.DRN = bool.Parse(dt.Rows[0]["DRN"].ToString());
                patient.FullCode = bool.Parse(dt.Rows[0]["FullCode"].ToString());
                patient.FallRisk = bool.Parse(dt.Rows[0]["FallRisk"].ToString());
                patient.LatexAllergy = bool.Parse(dt.Rows[0]["LatexAllergy"].ToString());
                patient.RestrictedExtremity = bool.Parse(dt.Rows[0]["RestrictedExtremity"].ToString());
                patient.Allergy = bool.Parse(dt.Rows[0]["Allergy"].ToString());

                patient.Allergies = dt.Rows[0]["Allergies"].ToString();
                patient.Comments = dt.Rows[0]["Comments"].ToString();

                DateTime resultST;
                if (String.IsNullOrEmpty(dt.Rows[0]["ScenarioTime"].ToString().Trim()))
                {
                    patient.ScenarioTime = DateTime.Today;  // .Now? || .Today?
                }
                else
                {
                    DateTime.TryParse(dt.Rows[0]["ScenarioTime"].ToString(), out resultST);
                    patient.ScenarioTime = resultST;
                }

            }
            else
            {
                // Not Found
            }

            return ValidPatientID;
        }

        //Will activate the 'Continue' button if the Enter key is pressed
        private void txtBoxPatientID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnContinue.PerformClick();
            }
        }

        //If the patient entered is valid, then the EMAR screen will be displayed
        private void btnContinue_Click(object sender, EventArgs e)
        {
            ValidPatientID = setPatient();

            if(ValidPatientID)
            {
                EMAR emar = new EMAR(patient);
                emar.getForm = this;
                //Hides the PAtient Lookup screen and displays the EMAR screen
                this.Hide();
                emar.Show();

               /* if(INACTIVE) //Column 8
                {
                //display "Wrong Patient" ERROR msg
                MessageBox.Show("Wrong Patient!/nThis Patient is INACTIVE.");
                } */
            }
          
            else
            {
                //display "Patient NOT Found" ERROR msg
                MessageBox.Show("Patient NOT Found.");
            }

            txtBoxPatientID.Text = "";
        }

        //Redirects to the Admin form when the 'Admin' button is clicked
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            //Show Admin Home Screen
            AdminForms adminForm = new AdminForms();
            adminForm.getForm = this;
            //Hides the Patient Lookup Screen and displays the Admin form
            this.Hide();
            adminForm.Show();
        }

        //
        private void patientIDtxtBox_TextChanged(object sender, EventArgs e)
        {
            txtBoxPatientID.ForeColor = Color.Black;
            string errorMSG = "Please enter valid Patient ID. (4-6) digits";

            //Accepts a string that is 4 to 6 digits long, and consists of the numbers 0-9
            string re = "^[0-9]{4,6}$";

            if (System.Text.RegularExpressions.Regex.IsMatch(txtBoxPatientID.Text, re))
            {
                // ID is Valid
                errorProvider.SetError(txtBoxPatientID, "");
                btnContinue.Enabled = true;
            }
            else
            {
                errorProvider.SetError(txtBoxPatientID, errorMSG);
                btnContinue.Enabled = false;
            }
        }

        //Displays whether the scanner is connected or disconnected
        private void btnScannerStatus_Click(object sender, EventArgs e)
        {
            bool scannerConnection_green = checkScannerConnectionStatus();
            //Signifies that the scanner is connected if scannerConnection returns true
            if (scannerConnection_green)
            {
                btnScannerStatus.BackColor = Color.Green;
                btnScannerStatus.Text = "Connected";
                btnScannerStatus.ForeColor = Color.White;
            }
            //signifies that the scanner is disconnected if scannerConnection returns false
            else
            {
                btnScannerStatus.BackColor = Color.White;
                btnScannerStatus.Text = "Disconnected";
                btnScannerStatus.ForeColor = Color.Red;
            }
        }

        public bool checkScannerConnectionStatus()
        {
            // For this particular BC scanner device look for the following string properties :
            // Device ID: USB\VID_1D57&PID_001C\6&116AFD6C&0&2, PNP Device ID: USB\VID_1D57&PID_001C\6&116AFD6C&0&2, Description: USB Input Device
            string deviceID = @"USB\VID_1D57&PID_001C\6&116AFD6C&0&2";
            string pnpDeviceID = @"USB\VID_1D57&PID_001C\6&116AFD6C&0&2";
            string description = "USB Input Device";

            deviceID.Remove(deviceID.Length - 15);
            pnpDeviceID.Remove(pnpDeviceID.Length - 15);

            bool scannerConnection_found;
            scannerConnection_found = scanner.GetScannerConnectionStatus(deviceID, pnpDeviceID, description);

            return scannerConnection_found;
        }

    }//Class
}//NS


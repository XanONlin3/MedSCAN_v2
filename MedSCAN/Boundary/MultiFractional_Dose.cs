using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MedSCAN.Boundary
{
    /*----------------------------------------------------------------------------
   * Author: J. Nobles
   * Date: 3/10/2014
   * Multi/Fractional-Dose Boundary class
   *///---------------------------------------------------------------------------
    public partial class MultiFractional_Dose : Form
    {
        public bool ReturnAns { get; set; }
        private string MedID="";
        Control.Scanner scanner = new Control.Scanner();

        public MultiFractional_Dose(Entity.Medications med, Entity.PatientMeds patientMed)
        {
            InitializeComponent();
            btnOK.Enabled = false;

            MedID = med.MedID;

            try
            {
                activeMedName_label.Text = patientMed.MedName;
                //txtBoxSpecialInstr.Text = patientMed.Notes;
                doseAmount_label.Text = med.Strength +" " +patientMed.UOM;
                unitspDoseAmount_label.Text = "{" + med.UnitAmt.ToString() + "}";

                //create txt for check box
                ckBoxMedication.Text = patientMed.MedName + " " + patientMed.dose+" "+patientMed.UOM+" "+ med.Form;

                txtBoxSpecialInstr.Text = AdministrationInstructions(med.Strength, patientMed.dose, patientMed.UOM);
                txtBoxDescription.Text = Description(med.Strength, patientMed.dose, med.UnitAmt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Indicates how the medication needs to be administered. Set by the Admnistrator
        private string AdministrationInstructions(float str, float dose, string uom)
        {
            //amount of medicine that needs to be thrown away and not administered to the patient
            float wasteAmount = (str - dose);
            string instructions = "The dose required for this patient is " + dose + " " + uom.ToUpper() +
                                  " you must WASTE " + wasteAmount.ToString("#.###") + uom.ToUpper() + 
                                  " to administer the correct dosage.";

            return instructions;
        }
        //Describes how the medicine needs to be divided before administering to the patient
        private string Description(float str, float dose, float units)
        {
            // ie 1 unit = 500mg (str) && req dose = 300mg
            float requiredAmount;
            if (str == 0) //dont wanna divide by zero! X.x
                requiredAmount = dose;
            else
                requiredAmount = (dose / str);   // ie 300mg / 500mg = 0.6 => 500mg tab
            int wholeUnits =(int)requiredAmount; // (int)0.6mg = 0 (whole tab)
            float partialUnits = requiredAmount - wholeUnits;   //0.6 - 0 = .6 => 500 mg (partial tab)

            string description = "Please administer: " + (int)(wholeUnits) + " unit(s) "+
                                 "and " + partialUnits.ToString("#.###") + " (Partial) units.";

            return description;
        }

        private void MultiFractional_Dose_Load(object sender, EventArgs e)
        {
            //btnOK.Enabled = false;
            btnGive.Enabled = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //send true to EMAR and mark as given
            this.ReturnAns = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.ReturnAns = false;
            this.Close();
        }

        //Text Field that holds the medication ID Barcode for when the medication is scanned
        private void txtBoxMedIDBC_TextChanged(object sender, EventArgs e)
        {
            txtBoxMedIDBC.ForeColor = Color.Black;

            //Accepts a string that is 8 to 15 digits long, and consists of the numbers 0-9
            string re = "^[0-9]{8,15}$"; 

            if (System.Text.RegularExpressions.Regex.IsMatch(txtBoxMedIDBC.Text, re))
            {
                // ID is Valid
                errorProviderMFD.SetError(txtBoxMedIDBC, "");
                btnGive.Enabled = true;
            }
            else
            {
                errorProviderMFD.SetError(txtBoxMedIDBC, "Please enter valid Medication ID. (8-15) digits");
                btnGive.Enabled = false;
            }
        }

        //Gives the medication to the patient if the Medication ID matches the barcode scanned
        private void btnGive_Click(object sender, EventArgs e)
        {
            if (MedID.Equals(txtBoxMedIDBC.Text))
            {
                ckBoxMedication.Checked = true;
                btnOK.Enabled = true;
            }
            //if the the medication does not match, display a message and does not allow the user to move forward
            else
                MessageBox.Show("Scanned Medication does NOT match. Please make sure you are scanning the correct medication.");
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
    }
}

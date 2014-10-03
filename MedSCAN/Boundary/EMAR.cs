using System;
using System.Windows.Forms;
using DGVPrinterHelper;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Drawing;

namespace MedSCAN.Boundary
{
     /*----------------------------------------------------------------------------
     * Author: J. Nobles
     * Date: 3/5/2014
     * EMAR form -Boundary class
     *///-------------------------------------------------------------------------
    public partial class EMAR : Form
    {
        string pInfo;

        SqlCommand oSqlCmd;
        DataTable dt;

        Control.Scanner scanner = new Control.Scanner();


        public EMAR(Entity.Patient patient)
        {
            InitializeComponent();

            // Load patient info passed from Patient Look-up Form.
            pInfo = CreatePatientInfoText(patient);
            FillProfile(patient);
        }

        // Create Form obj and method to set and get current form.
        private Form form =new Form();
        public Form getForm
        {
            get { return form; }
            set { form = value; }
        }

        private void EMAR_Load(object sender, EventArgs e)
        {
            txtBoxPatientInfo.Text = pInfo;
            patientMedsDGV.ClearSelection();

            txtBoxMedIDBC.Select();

        }
        //Fills the EMAR with the scanned patient's information
        public void FillProfile(Entity.Patient patient){

            txtBoxPatientID.Text = patient.pID;
            comboBoxStatus.Text = patient.Status;

            txtBoxFN.Text = patient.Firstname;
            txtBoxLN.Text = patient.Lastname.ToUpper();
            txtBoxMI.Text = patient.Mi;

            txtBoxDOB.Text = patient.dob;
            txtBoxAge.Text = patient.age;

            txtBoxHeight.Text = patient.height;
            txtBoxWeight.Text = patient.weight;

            if (patient.Gender == 'M'+"")
                genderRadioButtonM.Checked = true;
            else if (patient.Gender == 'F'+"")
                genderRadioButtonF.Checked = true;

            if (patient.Pregnant == 'Y'+"")
                pregRadioButtonY.Checked = true;
            else if (patient.Pregnant == 'N'+"")
                pregRadioButtonN.Checked = true;

            checkBoxDRN.Checked = patient.DRN;
            checkBoxFullCode.Checked = patient.FullCode;
            checkBoxFallRisk.Checked = patient.FallRisk;
            checkBoxLatexAllergy.Checked = patient.LatexAllergy;
            checkBoxAllergy.Checked = patient.Allergy;
            checkBoxRestrictedExtrem.Checked = patient.RestrictedExtremity;

            txtBoxComments.Text = patient.Comments;
            txtBoxScenarioTime.Text = patient.ScenarioTime.ToString("HH:mm"); // only want 24 hr time portion of DATETIME

            allergiesList_label.Text = patient.Allergies;

            //patientMedsDGV.RowTemplate.Height = 32;

            Fill_DGV();
        }

        //Fills the table displaying the medications with their assigned information in the database
        private void Fill_DGV()
        {
            string query = "SELECT Given, MedicationID, DrugName, Dose, UOM, Form, Route, Frequency AS Freq, Time AS TimeDue, MedType, TimeGiven AS ClassTime FROM tbl_PatientMedications WHERE PatientID = " + txtBoxPatientID.Text + "";
            oSqlCmd = new SqlCommand(query);
            dt = Control.DatabaseConnection.GetDataTable(oSqlCmd);

            patientMedsDGV.DataSource = dt;
            //setColumnWidth();
        }

        //Fills in the patient information on the Profile Screen with the scanned patients' information
        private String CreatePatientInfoText(Entity.Patient patient)
        {
            string pID, fn, ln, mi, dr="", sex = "", preg = "", age, dob;

            pID = patient.pID;
            fn = patient.Firstname;
            ln = patient.Lastname;
            mi = patient.Mi;
            dr = patient.Physician;
            dob = patient.dob;
            age = patient.age;

            if (patient.Pregnant == "Y")
                preg = "Pregnant";

            if (patient.Gender  == "F")
                sex = "F";
            else if (patient.Gender == "M")
                sex = "M";

            String label = ln.ToUpper()+", " + fn + " " + mi + "\n" +
                "<" + pID + ">\t" + dr + "\n" +
                dob + " \t" + age + "Y " + sex + " " + preg;

            return label;
        }

        //Returns the user to the Patient Lookup screen when the 'Done' text is clicked
        private void done_label_Click(object sender, System.EventArgs e)
        {
            // Ask if user would like to leave the page
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Are you sure you quit? (All changes will be reset)", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
                form.Visible = true; // load hidden patient Look-up form (Home Screen)
            } 
        }

        private void txtBoxMedIDBC_TextChanged(object sender, EventArgs e)
        {
            //Accepts a string that is 8 to 15 digits long, and consists of the numbers 0-9
            string re = "^[0-9]{8,15}$";

            if (System.Text.RegularExpressions.Regex.IsMatch(txtBoxMedIDBC.Text, re))
            {
                // ID is Valid
                errorProviderEMAR.SetError(txtBoxMedIDBC, "");

                string search = txtBoxMedIDBC.Text;

                for (int i = 0; i < patientMedsDGV.Rows.Count; i++)
                {
                    if (patientMedsDGV.Rows[i].Cells[1].Value.ToString().Equals(search))
                    {
                        patientMedsDGV.Rows[i].Selected = true;
                    }
                    else
                    {
                        patientMedsDGV.Rows[i].Selected = false;
                    }
                }
            }
            else
            {
                errorProviderEMAR.SetError(txtBoxMedIDBC, "Please enter valid Medication ID. (8-15) digits");
            }
        }

       //when one of the patients medications is scanned, check the 'Given' box
        private void txtBoxMedIDBC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnGive.PerformClick();
            }
        }

        //When the Give button (green check button) is clicked, get the selected medication and clear the Medication Notes text box
        private void btnGive_Click(object sender, EventArgs e)
        {
            // Need to make sure the medication is for THIS patient BEFORE retreaving the medication information.
            if (validateSelectedMedInfo(txtBoxMedIDBC.Text))
            {
                getSelectedMedInfo(txtBoxMedIDBC.Text);
                txtBoxMedNotes.Clear();
            }
            else
            {
                // Not found.
                MessageBox.Show("Medication NOT found");
            }

        }

        //Allows the user to specify the type of medications they wish to see by medication type
        private void comboBoxMedType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ((DataTable)this.patientMedsDGV.DataSource).DefaultView.RowFilter = "MedType = '" + comboBoxMedType.SelectedItem + "'";
  
            //setColumnWidth();
        }

        // Return true if the medication is listed for this Patient.
        private bool validateSelectedMedInfo(string medID)
        {
            string query = "SELECT * FROM tbl_PatientMedications WHERE MedicationID = '" + medID.Trim() + "' AND PatientID = '" + txtBoxPatientID.Text.Trim() + "'";
            oSqlCmd = new SqlCommand(query);
            dt = Control.DatabaseConnection.GetDataTable(oSqlCmd);

            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                //Not found.
                return false;
            }
        }

        //Retrieves the selected Medications' information
        private void getSelectedMedInfo(string medID)
        {
            string query = "SELECT * FROM tbl_Medications WHERE MedicationID = '" + medID.Trim() + "'";
            oSqlCmd = new SqlCommand(query);
            dt = Control.DatabaseConnection.GetDataTable(oSqlCmd);

            if (dt.Rows.Count > 0)
            {
                Entity.Medications med = new Entity.Medications();
                float u = 0.0f; float s = 0.0f;

                med.MedID = dt.Rows[0]["MedicationID"].ToString();
                med.Classification = dt.Rows[0]["Classification"].ToString();
                med.PregRiskCat = dt.Rows[0]["PregnancyRiskCategory"].ToString(); 
                med.Notes = dt.Rows[0]["Notes"].ToString();
                     txtBoxMedNotes.Text = med.Notes.ToString();
                if(!String.IsNullOrEmpty(dt.Rows[0]["UnitAmt"].ToString().Trim()))
                    u = float.Parse(dt.Rows[0]["UnitAmt"].ToString());
                if(!String.IsNullOrEmpty(dt.Rows[0]["Strength"].ToString().Trim()))
                    s = float.Parse(dt.Rows[0]["Strength"].ToString());

                med.UnitAmt = u;
                med.Strength =s;
                med.UOM = dt.Rows[0]["UnitOfMeasure"].ToString();

                performALLChecks(med, medID, txtBoxPatientID.Text);
            }
        }

        // Performs the requested checks on the medication before giving it.
        private void performALLChecks(Entity.Medications med, string medID, string pID)
        {
            string query = "SELECT Dose, UOM, DrugName, Time, ScenarioFlag, Notes, ScenarioMsg FROM tbl_PatientMedications WHERE MedicationID = '" + medID + "' AND PatientID = '" + pID + "'";
            oSqlCmd = new SqlCommand(query);
            dt = Control.DatabaseConnection.GetDataTable(oSqlCmd);

            bool flag = false;
            string name, time, notesPM, scenarioMsg, uom;
            float dose = 0.0f;

            name = dt.Rows[0]["DrugName"].ToString();
            time = dt.Rows[0]["Time"].ToString();
            notesPM = dt.Rows[0]["Notes"].ToString();
                 //txtBoxPatientMedsNotes.Text = notesPM.ToString();
            scenarioMsg = dt.Rows[0]["ScenarioMsg"].ToString();
            string f = dt.Rows[0]["ScenarioFlag"].ToString();
            string d = dt.Rows[0]["Dose"].ToString();

            if(!String.IsNullOrEmpty(f.Trim()))
                flag = bool.Parse(f);
            if (!String.IsNullOrEmpty(d.Trim()))
                dose = float.Parse(d);

            uom = dt.Rows[0]["UOM"].ToString(); 
            Entity.PatientMeds patientMeds = new Entity.PatientMeds();

            patientMeds.MedID = medID;
            patientMeds.MedName = name;
            patientMeds.PatientID = pID;
            patientMeds.dose = dose;
            patientMeds.UOM = uom;
            patientMeds.Notes = notesPM;

            //-------------------------------------------------------------------------------
            string classification, pregRiskCat, notes;
            float unitAmt, str;

            classification = med.Classification;
            pregRiskCat = med.PregRiskCat;
            notes = med.Notes;
            unitAmt = med.UnitAmt;
            str = med.Strength;
            //--------------------------------------------------------------------------------

            int timeGivenIndex = 10;
            // Check if given already!
            try
            {
                int index = patientMedsDGV.SelectedRows[0].Index;
                string selectedCell = patientMedsDGV[0, index].Value.ToString().ToLower();
                bool Given;
                if (String.IsNullOrEmpty(selectedCell.Trim()))
                {
                    selectedCell = false.ToString();
                }
                Given = bool.Parse(selectedCell);
                if (Given)
                {
                    DialogResult dr = new DialogResult();
                    dr = MessageBox.Show("STOP: This medication has already been given.\n" +
                                            "Administer the medication anyway? ", "Give Medication?", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    if (dr == DialogResult.Yes)
                    {
                        //If 'YES' is clicked mark as given.
                        patientMedsDGV[0, index].Value = true;
                        patientMedsDGV[timeGivenIndex, index].Value = DateTime.Now.ToString("@" + " HH:mm");
                    }
                    else
                    {
                        //Do Nothing.
                    }
                }

                // Check Patient ScenarioTime vs Patient Medication Administration Time.
                // Medication is 'on time' if it is given 60 minutes before until 60 minutes after the scheduled administration time.
                /*
                 * If ADMIN want's the time to be unchecked enter 00:00 for the scenario time -OR- enter 00:00 for the medication administration time.
                 */
                bool ok2give =false;
                string sTime = txtBoxScenarioTime.Text.ToString();
                if ((String.IsNullOrEmpty(sTime.Trim()) || sTime.Equals("00:00")))
                    { ok2give = true; }
                else
                {
                    if ((String.IsNullOrEmpty(time.Trim()) || time.Equals("00:00")))
                        { ok2give = true; }
                    else
                    {
                        DateTime scenarioTime = DateTime.Parse(txtBoxScenarioTime.Text);
                        DateTime scheduledAdminTime = DateTime.Parse(time);

                        DateTime acceptableRangeB = scenarioTime.Add(new TimeSpan(-1, 0, 0));
                        DateTime acceptableRangeA = scheduledAdminTime.Add(new TimeSpan(1, 0, 0));

                        if (scheduledAdminTime < acceptableRangeA && scheduledAdminTime > acceptableRangeB)
                            ok2give = true;
                        else
                        {
                            if (scheduledAdminTime < acceptableRangeB)
                            {
                                DialogResult dr = new DialogResult();
                                dr = MessageBox.Show("Warning: This medication is about to be administered too late! (Please check the administration time again)" +
                                    "\nAdminister the medication anyway? ", "Give Medication?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                if (dr == DialogResult.Yes)
                                {
                                    //If 'YES' is clicked mark as given.
                                    patientMedsDGV[0, index].Value = true;
                                    patientMedsDGV[timeGivenIndex, index].Value = DateTime.Now.ToString("@" + " HH:mm");
                                }
                                else
                                {
                                    //Do Nothing.
                                    ok2give = false;
                                }
                            }
                            else if (scheduledAdminTime > acceptableRangeA)
                            {
                                DialogResult dr = new DialogResult();
                                dr = MessageBox.Show("Warning: This medication is about to be administered too early! (Please check the administration time again)" +
                                    "\nAdminister the medication anyway? ", "Give Medication?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                if (dr == DialogResult.Yes)
                                {
                                    //If 'YES' is clicked mark as given.
                                    patientMedsDGV[0, index].Value = true;
                                    patientMedsDGV[timeGivenIndex, index].Value = DateTime.Now.ToString("@" + " HH:mm");
                                }
                                else
                                {
                                    //Do Nothing.
                                    ok2give = false;
                                }
                            }
                        }
                    }
                }
                
                // Check Pregnancy Risk Category.
                if (pregRadioButtonY.Checked)
                {
                    // C, D, X have risk, A and B have little to no risk, and N is an unclassified drug
                    //if (pregRiskCat.ToUpper().Equals('X' + ""))
                    //{
                    DialogResult dr = new DialogResult();
                    dr = MessageBox.Show("Warning: This medication's Pregnancy Risk Catagory is: " + pregRiskCat, "\nAdminister the Medication?",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        //If 'YES' is clicked mark as given.
                        patientMedsDGV[0, index].Value = true;
                        patientMedsDGV[timeGivenIndex, index].Value = DateTime.Now.ToString("@" + " HH:mm");
                    }
                    else
                    {
                        //Do Nothing.
                    }
                    //}
                }

                // Check Allergy - classification against allergies 
                if (checkBoxAllergy.Checked)
                {
                    string[] allergies = SplitWords(allergiesList_label.Text);
                    for (int i = 0; i < allergies.Length; i++)
                    {
                        if (allergies[i].Equals(classification))
                        {
                            DialogResult dr = new DialogResult();
                            dr = MessageBox.Show("Warning patient has allergy to this medication's classification: " + classification + "\n" +
                                                    "Administer the medication Anyway? ", "Give Medication?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (dr == DialogResult.Yes)
                            {
                                //If 'YES' is clicked mark as given.
                                patientMedsDGV[0, index].Value = true;
                                patientMedsDGV[timeGivenIndex, index].Value = DateTime.Now.ToString("@" + " HH:mm");
                            }
                            else
                            {
                                //Do Nothing.
                            }
                        }
                    }
                }

                // Check Med.Strength against PatientMed.Dose
                // If everything is equal
                if (dose == str && Given == false && flag == false && pregRadioButtonN.Checked && checkBoxAllergy.Checked == false && ok2give)
                {
                    // Mark medication as given
                    patientMedsDGV[0, index].Value = true;
                    patientMedsDGV[timeGivenIndex, index].Value = DateTime.Now.ToString("@" + " HH:mm");
                }

                // Check Med.str against PatientMed.dose.
                if (str < dose)
                {
                    // Multi-Dose screen.
                    using (var form = new Multi_Dose(med, patientMeds))
                    {
                        var result = form.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            // Mark medication as given.
                            patientMedsDGV[0, index].Value = true;
                            patientMedsDGV[timeGivenIndex, index].Value = DateTime.Now.ToString("@" + " HH:mm");
                        }
                    }
                }
                else if (str > dose)
                {
                    //Multi-Fractional Dose screen.
                    using (var form = new MultiFractional_Dose(med, patientMeds))
                    {
                        var result = form.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            // Mark medication as given
                            patientMedsDGV[0, index].Value = true;
                            patientMedsDGV[timeGivenIndex, index].Value = DateTime.Now.ToString("@" + " HH:mm");
                        }
                    }
                }
                

                // Check for Admin special scenario flag
                if (flag)
                {
                    DialogResult dr = new DialogResult();
                    dr = MessageBox.Show("STOP: " + scenarioMsg + "\nAdminister the medication anyway? ", "Give Medication?", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    if (dr == DialogResult.Yes)
                    {
                        //If 'YES' is clicked mark as given
                        patientMedsDGV[0, index].Value = true;
                        patientMedsDGV[timeGivenIndex, index].Value = DateTime.Now.ToString("@" + " HH:mm");
                    }
                    else
                    {
                        //Do Nothing
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Refresh the EMAR, and make sure the medication scanned/entered is visible on the patient's EMAR.");
            }
         /*   catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        public static string[] SplitWords(string s)
        {
            // Split on all non-word characters. 
            return System.Text.RegularExpressions.Regex.Split(s, @"\W+");
            // @      special verbatim string syntax
            // \W+    one or more non-word characters together
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            comboBoxMedType.Text = "Select an Option";

            ((DataTable)this.patientMedsDGV.DataSource).DefaultView.RowFilter = string.Empty;

            //setColumnWidth();
        }
       
        //Prints the results of the nursing students work within the EMAR
        private void btnPrint_Click(object sender, EventArgs e)
        {
            //Prevents the EMAR from being printed if no name has been entered in the text field
            if (String.IsNullOrEmpty(txtBoxStudentName.Text.Trim()))
            {
                MessageBox.Show("Enter the 'Student Nurse Name' located on the profile tab to print the EMAR.");
            }
            else
            {
                DGVPrinter print = new DGVPrinter();
                print.Title = "EMAR Report: " + txtBoxLN.Text + ", " + txtBoxFN.Text + " " + txtBoxMI.Text + "\t" + txtBoxPatientID.Text;
                print.SubTitle = "Medication Administration handeled by Nurse: " + txtBoxStudentName.Text;
                print.SubTitleFormatFlags = System.Drawing.StringFormatFlags.LineLimit |
                    System.Drawing.StringFormatFlags.NoClip;
                print.PageNumbers = true;
                print.PageNumberInHeader = false;
                print.PorportionalColumns = true;
                print.HeaderCellAlignment = System.Drawing.StringAlignment.Near;
                print.Footer = "MedSCAN";
                print.FooterSpacing = 15;

                print.PrintDataGridView(patientMedsDGV);
            }
        }

        //Sets the column widths for the table
        private void setColumnWidth()
        {
            //  0         1            2      3     4     5     6       7        8       9         10     
            //Given, MedicationID, DrugName, Dose, UOM, Form, Route, Frequency, Time, TimeGiven, MedType

            this.patientMedsDGV.Columns[0].Width = 50;
            this.patientMedsDGV.Columns[1].Width = 120;
            this.patientMedsDGV.Columns[2].Width = 225;
            this.patientMedsDGV.Columns[3].Width = 70;
            this.patientMedsDGV.Columns[4].Width = 85;
            this.patientMedsDGV.Columns[5].Width = 85;
            this.patientMedsDGV.Columns[6].Width = 100;
            this.patientMedsDGV.Columns[7].Width = 90;
            this.patientMedsDGV.Columns[8].Width = 80;
            this.patientMedsDGV.Columns[9].Width = 90;
            this.patientMedsDGV.Columns[10].Width = 95;

         
            this.patientMedsDGV.DefaultCellStyle.WrapMode =
                DataGridViewTriState.True;
        }
        //disables functions when either the Profile or Medications tab is selected
        private void tabControlEMAR_SelectedIndexChanged(object sender, EventArgs e)
        {
            //When the profile tab is selected, disable the Medication ID text box and the give (green check mark) button
            if (tabControlEMAR.SelectedTab == tabControlEMAR.TabPages["Profile_Tabpage"])
            {
                txtBoxMedIDBC.Enabled = false;
                btnGive.Enabled = false;
            }
            //When the Medications tab is selected, enable the Medication ID text box and the give (green check mark) button
            else if (tabControlEMAR.SelectedTab == tabControlEMAR.TabPages["Medications_Tabpage"])
            {
                txtBoxMedIDBC.Enabled = true;
                btnGive.Enabled = true;
            }
        }

        // Changes form informatio to match clicked datagridview info.
        private void patientMedsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)//<------------------------------------------
        {
            txtBoxMedIDBC.Text ="";

            if (patientMedsDGV.Rows[e.RowIndex].Cells[1].Value != null)
            {

                string query = "SELECT Notes FROM tbl_PatientMedications WHERE MedicationID = '" + (patientMedsDGV.Rows[e.RowIndex].Cells[1].Value.ToString()).Trim()+ "' AND PatientID = '"+txtBoxPatientID.Text+"'";
                oSqlCmd = new SqlCommand(query);
                dt = Control.DatabaseConnection.GetDataTable(oSqlCmd);

                if(dt.Rows.Count > 0)
                    txtBoxPatientMedsNotes.Text = dt.Rows[0]["Notes"].ToString();
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

        // Ladt part of Scanner ID changes everytime it's plugged in so this doesnt work.
        public bool checkScannerConnectionStatus()
        {
            // For this particular BC scanner device look for the following string properties :
            // Device ID: USB\VID_1D57&PID_001C\6&116AFD6C&0&2, PNP Device ID: USB\VID_1D57&PID_001C\6&116AFD6C&0&2, Description: USB Input Device
            string deviceID = @"USB\VID_1D57&PID_001C\6&116AFD6C&0&2"; //-last 15
            string pnpDeviceID = @"USB\VID_1D57&PID_001C\6&116AFD6C&0&2"; //-last 15
            string description = "USB Input Device";

            deviceID.Remove(deviceID.Length - 15);
            pnpDeviceID.Remove(pnpDeviceID.Length - 15);

            bool scannerConnection_found;
            scannerConnection_found = scanner.GetScannerConnectionStatus(deviceID, pnpDeviceID, description);

            return scannerConnection_found;
        }

        private void btnCalculateBMI_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtBoxHeight.Text.Trim()) || String.IsNullOrEmpty(txtBoxWeight.Text.Trim()))
            {
                MessageBox.Show("Please enter the patient's height and/or weight.");
            }
            else
            {
                double kg = double.Parse(txtBoxWeight.Text);
                double cm = double.Parse(txtBoxHeight.Text);

                BMI_label.Text = caluclateBMI(kg, cm);
            }
        }

        // Calculates the patients BMI
        public string caluclateBMI(double kg, double cm)
        {
            double BMI = 0;

            double value = cm / 100;
            double power = 2.0;
            BMI = (kg / (double)Math.Pow(value, power));

            return BMI.ToString("#.#");
        }

        //prevents the entering of any non-integer character when filling the Patient Height
        private void txtBoxHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
               && !char.IsDigit(e.KeyChar)
               && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            // don't allow decimal first
            if (e.KeyChar == '.')
            {
                if (txtBoxHeight.TextLength < 1)
                    e.Handled = true;
            }
        }

        //prevents the entering of any non-integer character when filling the Patient Weight
        private void txtBoxWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
               && !char.IsDigit(e.KeyChar)
               && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            // don't allow decimal first
            if (e.KeyChar == '.')
            {
                if (txtBoxWeight.TextLength < 1)
                    e.Handled = true;
            }
        }

        private void txtBoxWeight_TextChanged(object sender, EventArgs e)
        {
            string suffix = "lb";
            string weight = "0";

            if (String.IsNullOrEmpty(txtBoxWeight.Text.Trim()))
                weight = "0";
            else
                weight = txtBoxWeight.Text;

            lb_label.Text = convertWeight(weight) + " " + suffix;
        }

        private void txtBoxHeight_TextChanged(object sender, EventArgs e)
        {
            string suffix = "In";
            string height = "0";

            if (String.IsNullOrEmpty(txtBoxHeight.Text.Trim()))
                height = "0";
            else
                 height = txtBoxHeight.Text;

            in_label.Text = convertHeight(height) + " " + suffix;
        }

        public string convertHeight(string cm)
        {
            double conversionFactor = 0.39370;

            double _cm = double.Parse(cm);
            double height = _cm * conversionFactor;

            return height.ToString("#.##");
        }

        public string convertWeight(string kg)
        {
            double conversionFactor = 2.20462;

            double _kg = double.Parse(kg);
            double weight = _kg * conversionFactor;

            return weight.ToString("#.##");
        }
    }//Class
}//NS




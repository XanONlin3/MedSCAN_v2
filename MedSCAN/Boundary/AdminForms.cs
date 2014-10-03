using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MedSCAN.Boundary
{

    public partial class AdminForms : Form
    {
        /*----------------------------------------------------------------------------
        * Author: J. Nobles
        * Date: 3/6/2014
        * Admin -PatientForm Boundary class && -MedicationForm Boundary class
        *///-------------------------------------------------------------------------
        
        SqlCommand oSqlCmd;
        DataTable dt;

        BindingSource tbl_MedicationsBindingSource = new BindingSource();
        BindingSource tbl_PatientsBindingSource = new BindingSource();

        public static string oSqlconStr = Properties.Settings.Default.MedSCAN_DatabaseConnectionString;
       
        //Text box objects for the Patient and Medication IDs
        public static TextBox pIDtxt = new TextBox();
        public static TextBox mIDtxt = new TextBox();

        // Create Form obj and method to set and get current form.
        private Form form = new Form();
        public Form getForm
        {
            get { return form; }
            set { form = value; }
        }

        public AdminForms()
        {
            InitializeComponent();
        }

        private void AdminForms_Load(object sender, EventArgs e)
        {
            // Hides the gender and pregnancy textboxes.
            txtBoxGender.Visible = false;
            txtBoxPreg.Visible = false;

            SetMedicationDGV();
            SetPatientDGV();

            //Enables the Edit Meds button on the Patient View screen
            editMeds_btn.Enabled = true;

            //Sets all text fields to be read only
            SetAll2ReadOnly_M();
            SetAll2ReadOnly_P();

            // Set the Format type and the CustomFormat string.
            dtpScenarioTime.Format = DateTimePickerFormat.Custom;
            dtpScenarioTime.CustomFormat = "HH:mm";
     
        }

        //Displays the medications from the database in a DataGridView
        private void SetMedicationDGV()
        {
            string query1 = "SELECT * FROM tbl_Medications";

            oSqlCmd = new SqlCommand(query1);
            //dt = Control.DatabaseConnection.GetDataTable(oSqlCmd);
            tbl_MedicationsBindingSource.DataSource = Control.DatabaseConnection.GetDataTable(oSqlCmd);
            medicationsDGV.DataSource = tbl_MedicationsBindingSource;
            hideUnnecessaryMedicationDGVColumns();
            medicationsDGV.ClearSelection();

            //  Color of Alternate Rows in the DataGridView
            this.medicationsDGV.RowsDefaultCellStyle.BackColor = Color.White;
            this.medicationsDGV.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender;
        }
        //Displays the Patients from the database in a DataGridView
        public void SetPatientDGV()
        {
            string query2 = "SELECT * FROM tbl_Patients";

            oSqlCmd = new SqlCommand(query2);
            //dt = Control.DatabaseConnection.GetDataTable(oSqlCmd);
            tbl_PatientsBindingSource.DataSource = Control.DatabaseConnection.GetDataTable(oSqlCmd);
            patientsDGV.DataSource = tbl_PatientsBindingSource;
            hideUnnecessaryPatientDGVColumns();
            patientsDGV.ClearSelection();

            //  Color of Alternate Rows in the DataGridView
            this.patientsDGV.RowsDefaultCellStyle.BackColor = Color.White;
            this.patientsDGV.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender;
        }

        //VIEW, ADD, EDIT, and REMOVE radio buttons for the Medication Screen
        #region VIEW, ADD, EDIT REMOVE MEDs RBs

        //When the VIEW radio button on the Medication screen is selected...
        private void radioButtonVIEWmeds_CheckedChanged(object sender, EventArgs e)
        {
            // Set all fields to read-only
            SetAll2ReadOnly_M();
            medicationsDGV.Enabled = true;
            editMeds_btn.Enabled = true;
            // Change function and apperance of function_button
            btnFunction_Meds.BackColor = Color.DarkViolet;
            btnFunction_Meds.Text = "GENERATE BARCODE";
        }

        //When the ADD radio button on the Medication screen is selected...
        private void radioButtonADDmeds_CheckedChanged(object sender, EventArgs e)
        {
            // Clear all fields and set them to be editable
            medicationsDGV.ClearSelection();
            ClearAll_M();
            SetAll2Editable_M();
            medicationsDGV.Enabled = false;
            editMeds_btn.Enabled = false;
            // Change function and apperance of function_button
            btnFunction_Meds.BackColor = Color.Blue;
            btnFunction_Meds.Text = "ADD";
        }

        //When the EDIT radio button on the Medication screen is selected...
        private void radioButtonEDITmeds_CheckedChanged(object sender, EventArgs e)
        {
            // Set all fields edit-able
            SetAll2Editable_M();
            medicationsDGV.Enabled = true;
            editMeds_btn.Enabled = false;
            // Change function and apperance of function_button
            btnFunction_Meds.BackColor = Color.Green;
            btnFunction_Meds.Text = "SAVE";
        }

        //When the REMOVE radio button on the Medication screen is selected...
        private void radioButtonREMOVEmeds_CheckedChanged(object sender, EventArgs e)
        {
            // Set all fields to read-only
            SetAll2ReadOnly_M();
            medicationsDGV.Enabled = true;
            editMeds_btn.Enabled = false;
            // Change function and apperance of function_button
            btnFunction_Meds.BackColor = Color.Red;
            btnFunction_Meds.Text = "REMOVE";
        }
        #endregion

        //Checks to see if the medication ID entered is valid
        private bool medID_isValid()
        {
            string query = "SELECT MedicationID FROM tbl_Medications WHERE MedicationID = '" + txtBoxMedID.Text + "'";
            oSqlCmd = new SqlCommand(query);
            dt = Control.DatabaseConnection.GetDataTable(oSqlCmd);

            if (dt.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                // Not found
                return true;
            }
        }
        //Checks to see if the patient ID entered is valid
        private bool patientID_isValid()
        {
            string query = "SELECT PatientID FROM tbl_Patients WHERE PatientID = '" + txtBoxPatientID.Text + "'";
            oSqlCmd = new SqlCommand(query);
            dt = Control.DatabaseConnection.GetDataTable(oSqlCmd);

            if (dt.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                // Not found
                return true;
            }
        }

        #region VIEW, ADD, EDIT, REMOVE Meds FUNCTION btn
        private void btnFunction_MedsTab_Click(object sender, EventArgs e)
        {
            
            if (radioButtonVIEWmeds.Checked == true)
            {
                //Fills in the text fields when a medication is selected
                Entity.Medications med = new Entity.Medications();

                med.MedID = txtBoxMedID.Text;
                med.TradeName = txtBoxTrade.Text;
                med.GenericName = txtBoxGeneric.Text;
                if (String.IsNullOrEmpty(txtBoxStr.Text.Trim()))
                    med.Strength = 0.0f;
                else
                    med.Strength = float.Parse(txtBoxStr.Text);
                med.UOM = txtBoxUOM.Text;
                
                //When the Generate Barcode button is selected, redirect to the barcode Designer form
                BarcodeForm bcForm = new BarcodeForm(med);
                bcForm.getForm = this;
                //Hides the VIEW Medication screen and displays the barcode designer form
                this.Hide();
                bcForm.Show();

            }
            else if (radioButtonADDmeds.Checked == true)
            {
                // Add medication to database
                //this.tbl_MedicationsBindingSource.AddNew();
                if (medID_isValid())
                {
                    SqlConnection oSqlCon = new SqlConnection(oSqlconStr);
                    {
                        string query = "INSERT INTO tbl_Medications(MedicationID, Classification, PregnancyRiskCategory, GenericName, " +
                                                            "TradeName, PseudoName, UnitAmt, Form, Strength, UnitOfMeasure, Notes) " +
                                            "VALUES (@MedicationID, @Classification, @PregnancyRiskCategory, @GenericName, " +
                                                            "@TradeName, @PseudoName, @UnitAmt, @Form, @Strength, @UnitOfMeasure, @Notes)";
                        oSqlCmd = new SqlCommand();//query, oSqlCon);
                        oSqlCmd = oSqlCon.CreateCommand();
                        oSqlCmd.CommandText = query;

                        oSqlCmd.Parameters.AddWithValue("@MedicationID", txtBoxMedID.Text);
                        oSqlCmd.Parameters.AddWithValue("@Classification", txtBoxClassification.Text);
                        oSqlCmd.Parameters.AddWithValue("@PregnancyRiskCategory", comboBoxPRC.Text);
                        oSqlCmd.Parameters.AddWithValue("@GenericName", txtBoxGeneric.Text);
                        oSqlCmd.Parameters.AddWithValue("@TradeName", txtBoxTrade.Text);
                        oSqlCmd.Parameters.AddWithValue("@PseudoName", txtBoxPseudo.Text);
                        oSqlCmd.Parameters.AddWithValue("@UnitAmt", txtBoxUnitAmt.Text);
                        oSqlCmd.Parameters.AddWithValue("@Form", txtBoxForm.Text);
                        oSqlCmd.Parameters.AddWithValue("@Strength", txtBoxStr.Text);
                        oSqlCmd.Parameters.AddWithValue("@UnitOfMeasure", txtBoxUOM.Text);
                        oSqlCmd.Parameters.AddWithValue("@Notes", txtBoxNotes.Text);

                        try
                        {
                            oSqlCon.Open();
                            try
                            {
                                oSqlCmd.ExecuteNonQuery();
                                MessageBox.Show("New Medication Record Added.");
                            }
                            catch (Exception exc)
                            {
                                MessageBox.Show("Attempt to Add Data to the DB failed. " + exc.Message);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Attempt to open Connection failed. " + ex.Message);
                        }
                        finally
                        {
                            oSqlCon.Close();
                        }
                    }

                    SetMedicationDGV();
                }
                else
                {
                    MessageBox.Show("This Medication ID is already in use by another medication.");
                }
            }
            else if (radioButtonEDITmeds.Checked == true)
            {
                // Save changes to medication in database
                SqlConnection oSqlCon = new SqlConnection(oSqlconStr);
                {
                    string query = "Update tbl_Medications "+
                                     "set Classification = @Classification, PregnancyRiskCategory = @PregnancyRiskCategory, GenericName = @GenericName, TradeName = @TradeName, "+
                                                "PseudoName = @PseudoName, UnitAmt = @UnitAmt, Form = @Form, Strength = @Strength, UnitOfMeasure = @UnitOfMeasure, Notes = @Notes " +
                                   "where MedicationID = '"+txtBoxMedID.Text+"'";

                    oSqlCmd = new SqlCommand();//query, oSqlCon);
                    oSqlCmd = oSqlCon.CreateCommand();
                    oSqlCmd.CommandText = query;

                    //oSqlCmd.Parameters.AddWithValue("@MedicationID", txtBoxMedID.Text);
                    oSqlCmd.Parameters.AddWithValue("@Classification", txtBoxClassification.Text.Trim());
                    oSqlCmd.Parameters.AddWithValue("@PregnancyRiskCategory", comboBoxPRC.Text.Trim());
                    oSqlCmd.Parameters.AddWithValue("@GenericName", txtBoxGeneric.Text.Trim());
                    oSqlCmd.Parameters.AddWithValue("@TradeName", txtBoxTrade.Text.Trim());
                    oSqlCmd.Parameters.AddWithValue("@PseudoName", txtBoxPseudo.Text.Trim());
                    oSqlCmd.Parameters.AddWithValue("@UnitAmt", txtBoxUnitAmt.Text.Trim());
                    oSqlCmd.Parameters.AddWithValue("@Form", txtBoxForm.Text.Trim());
                    oSqlCmd.Parameters.AddWithValue("@Strength", txtBoxStr.Text.Trim());
                    oSqlCmd.Parameters.AddWithValue("@UnitOfMeasure", txtBoxUOM.Text.Trim());
                    oSqlCmd.Parameters.AddWithValue("@Notes", txtBoxNotes.Text.Trim());

                    try
                    {
                        oSqlCon.Open();
                        try
                        {
                            oSqlCmd.ExecuteNonQuery();
                            MessageBox.Show("Medication Record Updated.");
                        }
                        catch (Exception exc)
                        {
                            MessageBox.Show("Attempt to Add Data to the DB failed. " + exc.Message);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Attempt to open Connection failed. " + ex.Message);
                    }
                    finally
                    {
                        oSqlCon.Close();
                    }
                }

                SetMedicationDGV();
                this.Validate();
                this.tbl_MedicationsBindingSource.EndEdit();
                //this.tableAdapterManager.UpdateAll(this.ds_MedSCAN);

            }
            else if (radioButtonREMOVEmeds.Checked == true)
            {
                //displays a Message Box that prompts the user to decide whether they want to remove a medication or not. Selecting 'No' will close the message box
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Are you sure you want to delete this record? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                ///When 'Yes' is selected, attempt to remove the entry from the database
                ///If the attempt fails, display a message. The entry is not removed
                if (dr == DialogResult.Yes)
                {
                    // Remove medication from database
                    //this.tbl_MedicationsBindingSource.RemoveCurrent();
                    SqlConnection oSqlCon = new SqlConnection(oSqlconStr);
                    {
                        string query = "DELETE FROM tbl_Medications WHERE MedicationID = '" + txtBoxMedID.Text + "'";
                        oSqlCmd = new SqlCommand();//query, oSqlCon);
                        oSqlCmd = oSqlCon.CreateCommand();
                        oSqlCmd.CommandText = query;
                    }

                    try
                    {
                        oSqlCon.Open();
                        try
                        {
                            oSqlCmd.ExecuteNonQuery();
                            MessageBox.Show("Medication Record Removed.");
                        }
                        catch (Exception exc)
                        {
                            MessageBox.Show("Attempt to Remove Data from the DB failed. " + exc.Message);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Attempt to open Connection failed. " + ex.Message);
                    }
                    finally
                    {
                        oSqlCon.Close();
                    }
                
                }
            }
           SetMedicationDGV();
        }
        #endregion

        #region Cancel/Back btn

        /// <summary>
        /// The Cancel button logic to return a user to the Home (Patient Lookup) screen.
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Ask if user would like to leave the page
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Are you sure you want to leave the ADMIN - Medications page?" +
                                    "\n(Please make sure to save any relevant changes.)\nContinue Exiting?", "Leave page?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           
            //Returns the user to the Patient Lookup Screen if 'Yes' is selected
            if (dr == DialogResult.Yes)
            {
                this.Close();
                form.Visible = true; // load hidden admin patient form (Home Screen)
            } 
        }
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            // Ask if user would like to leave the page
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Are you sure you want to leave the ADMIN - Patients page?"+
                                    "\n(Please make sure to save any relevant changes.)\nContinue Exiting?", "Leave page?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           
            //Returns the user to the Patient Lookup Screen if 'Yes' is selected
            if (dr == DialogResult.Yes)
            {
                this.Close();
                form.Visible = true; // load hidden admin patient form (Home Screen)
            } 
        }
        #endregion

        #region Set - READ ONLY EDITABLE and CLEAR methods
       
        //When called, sets all text fields in the Medication screen to be Read Only, and disables the PRC combo box
        private void SetAll2ReadOnly_M()
        {
            txtBoxMedID.ReadOnly = true;
            txtBoxClassification.ReadOnly = true;
            comboBoxPRC.Enabled = false;
            txtBoxTrade.ReadOnly = true;
            txtBoxGeneric.ReadOnly = true;
            txtBoxPseudo.ReadOnly = true;
            txtBoxStr.ReadOnly = true;
            txtBoxForm.ReadOnly = true;
            txtBoxUnitAmt.ReadOnly = true;
            txtBoxUOM.ReadOnly = true;
            txtBoxNotes.ReadOnly = true;

        }
        //When called, sets all text fields in the Medications Screen to be editable
        private void SetAll2Editable_M()
        {
            txtBoxMedID.ReadOnly = false;
            txtBoxClassification.ReadOnly = false;
            comboBoxPRC.Enabled = true;
            txtBoxTrade.ReadOnly = false;
            txtBoxGeneric.ReadOnly = false;
            txtBoxPseudo.ReadOnly = false;
            txtBoxStr.ReadOnly = false;
            txtBoxForm.ReadOnly = false;
            txtBoxUnitAmt.ReadOnly = false;
            txtBoxUOM.ReadOnly = false;
            txtBoxNotes.ReadOnly = false;

        }
        //When called clears all entires that may be in the text fields, and resets the PRC combo box
        private void ClearAll_M()
        {
            txtBoxMedID.Clear();
            txtBoxClassification.Clear();
            comboBoxPRC.SelectedIndex = -1;
            txtBoxTrade.Clear();
            txtBoxGeneric.Clear();
            txtBoxPseudo.Clear();
            txtBoxStr.Clear();
            txtBoxForm.Clear();
            txtBoxUnitAmt.Clear();
            txtBoxUOM.Clear();
            txtBoxNotes.Clear();
            
        }
        //When called, sets all text fields in the Patients screen to be Read Only and disables the combo boxes, radio buttons, check boxes, and Scenario Time display
        private void SetAll2ReadOnly_P()
        {
            txtBoxPatientID.ReadOnly = true;
            comboBoxStatus.Enabled = false;
            txtBoxFN.ReadOnly = true;
            txtBoxLN.ReadOnly = true;
            txtBoxMI.ReadOnly = true;
            txtBoxMD.ReadOnly = true;
            txtBoxAge.ReadOnly = true;
            genderRadioButtonF.Enabled = false;
            genderRadioButtonM.Enabled = false;
            pregRadioButtonN.Enabled = false;
            pregRadioButtonY.Enabled = false;
            txtBoxDOB.ReadOnly = true;
            txtBoxAllergies.ReadOnly = true;
            txtBoxComments.ReadOnly = true;
            checkBoxDRN.Enabled = false;
            checkBoxFullCode.Enabled = false;
            checkBoxFallRisk.Enabled = false;
            checkBoxAllergy.Enabled = false;
            checkBoxLatexAllergy.Enabled = false;
            checkBoxRestrictedExtrem.Enabled = false;
            dtpScenarioTime.Enabled = false;
            txtBoxHeight.ReadOnly = true;
            txtBoxWeight.ReadOnly = true;
        }

        //When called, sets all text fields in the Patients Screen to be editable
        private void SetAll2Editable_P()
        {
            txtBoxPatientID.ReadOnly = false;
            comboBoxStatus.Enabled = true;
            txtBoxFN.ReadOnly = false;
            txtBoxLN.ReadOnly = false;
            txtBoxMI.ReadOnly = false;
            txtBoxMD.ReadOnly = false;
            txtBoxAge.ReadOnly = false;
            genderRadioButtonF.Enabled = true;
            genderRadioButtonM.Enabled = true;
            pregRadioButtonN.Enabled = true;
            pregRadioButtonY.Enabled = true;
            txtBoxDOB.ReadOnly = false;
            txtBoxAllergies.ReadOnly = false;
            txtBoxComments.ReadOnly = false;
            checkBoxDRN.Enabled = true;
            checkBoxFullCode.Enabled = true;
            checkBoxFallRisk.Enabled = true;
            checkBoxAllergy.Enabled = true;
            checkBoxLatexAllergy.Enabled = true;
            checkBoxRestrictedExtrem.Enabled = true;
            dtpScenarioTime.Enabled = true;
            txtBoxHeight.ReadOnly = false;
            txtBoxWeight.ReadOnly = false;
        }

        //When called clears all entires that may be in the text fields and disables the combo boxes, radio buttons, check boxes, and Scenario Time display
        private void ClearAll_P()
        {
            txtBoxPatientID.Clear();
            comboBoxStatus.SelectedIndex = -1;
            txtBoxFN.Clear();
            txtBoxLN.Clear();
            txtBoxMI.Clear();
            txtBoxMD.Clear();
            txtBoxAge.Clear();
            genderRadioButtonF.Checked = false;
            genderRadioButtonM.Checked = false;
            pregRadioButtonN.Checked = false;
            pregRadioButtonY.Checked = false;
            txtBoxDOB.Clear();
            txtBoxAllergies.Clear();
            txtBoxComments.Clear();
            checkBoxDRN.Checked = false;
            checkBoxFullCode.Checked = false;
            checkBoxFallRisk.Checked = false;
            checkBoxAllergy.Checked = false;
            checkBoxLatexAllergy.Checked = false;
            checkBoxRestrictedExtrem.Checked = false;
            txtBoxHeight.Clear();
            txtBoxWeight.Clear();
        }

        #endregion

        #region VEIW, ADD, EDIT, REMOVE Patients RBs && EDIT Patient's Meds btn

        //When the VIEW radio button on the Patients screen is selected...
        private void radioButtonVIEWpatients_CheckedChanged(object sender, EventArgs e)
        {
            // Set all fields to read-only
            SetAll2ReadOnly_P();
            //enables the edit Meds button
            editMeds_btn.Enabled = true;
            patientsDGV.Enabled = true;
            // Change function and apperance of function_button
            btnFunction_Patients.BackColor = Color.DarkViolet;
            btnFunction_Patients.Text = "GENERATE BARCODE";
        }
        //When the ADD radio button on the Patients screen is selected...
        private void radioButtonADDpatients_CheckedChanged(object sender, EventArgs e)
        {
            // Clear all fields and set editable
            patientsDGV.ClearSelection();
            ClearAll_P();
            SetAll2Editable_P();
            //disables the edit Meds button
            editMeds_btn.Enabled = false;
            patientsDGV.Enabled = false;
            // Change function and apperance of function_button
            btnFunction_Patients.BackColor = Color.Blue;
            btnFunction_Patients.Text = "ADD";
        }
        //When the EDIT radio button on the Patients screen is selected...
        private void radioButtonEDITpatients_CheckedChanged(object sender, EventArgs e)
        {
            // Set all fields edit-able
            SetAll2Editable_P();
            //disables the edit Meds button
            editMeds_btn.Enabled = false;
            patientsDGV.Enabled = true;
            // Change function and apperance of function_button
            btnFunction_Patients.BackColor = Color.Green;
            btnFunction_Patients.Text = "SAVE";
        }
        //When the REMOVE radio button on the Patients screen is selected...
        private void radioButtonREMOVEpatients_CheckedChanged(object sender, EventArgs e)
        {
            // Set all fields to read-only
            SetAll2ReadOnly_P();
            //disables the edit Meds button
            editMeds_btn.Enabled = false;
            patientsDGV.Enabled = true;
            // Change function and apperance of function_button
            btnFunction_Patients.BackColor = Color.Red;
            btnFunction_Patients.Text = "REMOVE";
        }
        //---------------------------------------------------------------------------------
        //Creates the edit Meds form when the edit Meds button is clicked
        private void editMeds_btn_Click(object sender, EventArgs e)
        {
            Entity.Patient patient = new Entity.Patient();
            patient.pID = txtBoxPatientID.Text;
            patient.Firstname = txtBoxFN.Text;
            patient.Lastname = txtBoxLN.Text;
            patient.Mi = txtBoxMI.Text;
            patient.ScenarioTime = DateTime.Parse(dtpScenarioTime.Text);
           
            
            //Load patientsMedicationsForm
            if(String.IsNullOrEmpty(txtBoxPatientID.Text.Trim()))
            {
                MessageBox.Show("Please Select/Enter the Patient's Information.");
            }
            else
            {
                PatientMedicationForm pMeds = new PatientMedicationForm(patient);
                pMeds.getForm = this;
                //Hides the Patients Screen and displays the PatientMedicationForm
                this.Hide();
                pMeds.Show();
            }
        }
        #endregion

        #region VIEW, ADD, EDIT, REMOVE Patients FUNCTION btn

        private void btnFunction_Patients_Click(object sender, EventArgs e)
        {

            if (radioButtonVIEWpatients.Checked == true)
            {
                //fill in the text fields when a patient is selected
                Entity.Patient patient = new Entity.Patient();

                patient.pID = txtBoxPatientID.Text;
                patient.Firstname = txtBoxFN.Text;
                patient.Mi = txtBoxMI.Text;
                patient.Lastname = txtBoxLN.Text;
                patient.dob = txtBoxDOB.Text;
                patient.Physician = txtBoxMD.Text;
                patient.Gender = txtBoxGender.Text;
                patient.Pregnant = txtBoxPreg.Text;
                patient.age = txtBoxAge.Text;
                patient.height = txtBoxHeight.Text;
                patient.weight = txtBoxWeight.Text;

                //when the generate barcode button is clicked, redirect to the barcode designer form
                BarcodeForm bcForm = new BarcodeForm(patient);

                bcForm.getForm = this;
                //hides the Patient View Screen and displays the barcode designer form
                this.Hide();
                bcForm.Show();

            }
            else if (radioButtonADDpatients.Checked == true)
            {
                // Add patient to database
                //this.tbl_PatientsBindingSource.AddNew();
                if (ValidatePatientID())
                {
                    if (patientID_isValid() && ValidatePatientID())
                    {
                        SqlConnection oSqlCon = new SqlConnection(oSqlconStr);
                        {
                            string query = "INSERT INTO tbl_Patients(PatientID, Lastname, Firstname, MI, Gender, Pregnant, DOB, Age, Height, Weight, Physician, Status, " +
                                                                    "DRN, FullCode, FallRisk, RestrictedExtremity, LatexAllergy, Allergy, Allergies, Comments, ScenarioTime) " +
                                                "VALUES (@PatientID, @Lastname, @Firstname, @MI, @Gender, @Pregnant, @DOB, @Age, @Height, @Weight, @Physician, @Status, " +
                                                                    "@DRN, @FullCode, @FallRisk, @RestrictedExtremity, @LatexAllergy, @Allergy, @Allergies, @Comments, @ScenarioTime)";
                            oSqlCmd = new SqlCommand();//query, oSqlCon);
                            oSqlCmd = oSqlCon.CreateCommand();
                            oSqlCmd.CommandText = query;

                            oSqlCmd.Parameters.AddWithValue("@PatientID", txtBoxPatientID.Text);
                            oSqlCmd.Parameters.AddWithValue("@Lastname", txtBoxLN.Text);
                            oSqlCmd.Parameters.AddWithValue("@Firstname", txtBoxFN.Text);
                            oSqlCmd.Parameters.AddWithValue("@MI", txtBoxMI.Text);
                            if (genderRadioButtonF.Checked == true)
                                oSqlCmd.Parameters.AddWithValue("@Gender", 'F' + "");
                            else
                                oSqlCmd.Parameters.AddWithValue("@Gender", 'M' + "");
                            if (pregRadioButtonY.Checked == true)
                                oSqlCmd.Parameters.AddWithValue("@Pregnant", 'Y' + "");
                            else
                                oSqlCmd.Parameters.AddWithValue("@Pregnant", 'N' + "");

                            oSqlCmd.Parameters.AddWithValue("@DOB", txtBoxDOB.Text);
                            oSqlCmd.Parameters.AddWithValue("@Age", txtBoxAge.Text);
                            oSqlCmd.Parameters.AddWithValue("@Height", txtBoxHeight.Text);
                            oSqlCmd.Parameters.AddWithValue("@Weight", txtBoxWeight.Text);
                            oSqlCmd.Parameters.AddWithValue("@Physician", txtBoxMD.Text);
                            oSqlCmd.Parameters.AddWithValue("@Status", comboBoxStatus.Text);

                            oSqlCmd.Parameters.AddWithValue("@DRN", checkBoxDRN.Checked);
                            oSqlCmd.Parameters.AddWithValue("@FullCode", checkBoxFullCode.Checked);
                            oSqlCmd.Parameters.AddWithValue("@FallRisk", checkBoxFallRisk.Checked);
                            oSqlCmd.Parameters.AddWithValue("@RestrictedExtremity", checkBoxRestrictedExtrem.Checked);
                            oSqlCmd.Parameters.AddWithValue("@LatexAllergy", checkBoxLatexAllergy.Checked);
                            oSqlCmd.Parameters.AddWithValue("@Allergy", checkBoxAllergy.Checked);

                            oSqlCmd.Parameters.AddWithValue("@Allergies", txtBoxAllergies.Text);
                            oSqlCmd.Parameters.AddWithValue("@Comments", txtBoxComments.Text);
                            oSqlCmd.Parameters.AddWithValue("@ScenarioTime", dtpScenarioTime.Text);

                            try
                            {
                                oSqlCon.Open();
                                try
                                {
                                    oSqlCmd.ExecuteNonQuery();
                                    MessageBox.Show("New Patient Record Added.");
                                }
                                catch (Exception exc)
                                {
                                    MessageBox.Show("Attempt to Add Data to the DB failed. " + exc.Message);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Attempt to open Connection failed. " + ex.Message);
                            }
                            finally
                            {
                                oSqlCon.Close();
                            }
                        }
                        SetPatientDGV();
                    }
                    else
                    {
                        MessageBox.Show("This Patient ID is already in use by another patient");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Patient ID.");
                }
                
            }
            else if (radioButtonEDITpatients.Checked == true)
            {
                // Save changes to patient in database
                SqlConnection oSqlCon = new SqlConnection(oSqlconStr);
                {
                    string query = "UPDATE tbl_Patients " +
                                   "SET Lastname = @Lastname, Firstname = @Firstname, MI = @MI, Gender = @Gender, Pregnant = @Pregnant, DOB = @DOB, Age = @Age, Height = @Height, Weight = @Weight, "+
                                        "Physician =@Physician, Status = @Status, DRN = @DRN, FullCode = @FullCode, FallRisk =@FallRisk, RestrictedExtremity = @RestrictedExtremity, "+
                                        "LatexAllergy = @LatexAllergy, Allergy = @Allergy, Allergies = @Allergies, Comments = @Comments, ScenarioTime =@ScenarioTime " +
                                   "WHERE PatientID = '"+txtBoxPatientID.Text +"'";

                    oSqlCmd = new SqlCommand();//query, oSqlCon);
                    oSqlCmd = oSqlCon.CreateCommand();
                    oSqlCmd.CommandText = query;

                    //oSqlCmd.Parameters.AddWithValue("@PatientID", txtBoxMedID.Text);
                    oSqlCmd.Parameters.AddWithValue("@Lastname", txtBoxLN.Text);
                    oSqlCmd.Parameters.AddWithValue("@Firstname", txtBoxFN.Text);
                    oSqlCmd.Parameters.AddWithValue("@MI", txtBoxMI.Text);
                    if(genderRadioButtonF.Checked == true)
                        oSqlCmd.Parameters.AddWithValue("@Gender", 'F' + "");
                    else
                        oSqlCmd.Parameters.AddWithValue("@Gender", 'M' + "");
                    if(pregRadioButtonY.Checked == true)
                        oSqlCmd.Parameters.AddWithValue("@Pregnant", 'Y' + "");
                    else
                        oSqlCmd.Parameters.AddWithValue("@Pregnant", 'N' + "");

                    oSqlCmd.Parameters.AddWithValue("@DOB", txtBoxDOB.Text);
                    oSqlCmd.Parameters.AddWithValue("@Age", txtBoxAge.Text);
                    oSqlCmd.Parameters.AddWithValue("@Height", txtBoxHeight.Text);
                    oSqlCmd.Parameters.AddWithValue("@Weight", txtBoxWeight.Text);
                    oSqlCmd.Parameters.AddWithValue("@Physician", txtBoxMD.Text);
                    oSqlCmd.Parameters.AddWithValue("@Status", comboBoxStatus.Text);

                    oSqlCmd.Parameters.AddWithValue("@DRN", checkBoxDRN.Checked);
                    oSqlCmd.Parameters.AddWithValue("@FullCode", checkBoxFullCode.Checked);
                    oSqlCmd.Parameters.AddWithValue("@FallRisk", checkBoxFallRisk.Checked);
                    oSqlCmd.Parameters.AddWithValue("@RestrictedExtremity", checkBoxRestrictedExtrem.Checked);
                    oSqlCmd.Parameters.AddWithValue("@LatexAllergy", checkBoxLatexAllergy.Checked);
                    oSqlCmd.Parameters.AddWithValue("@Allergy", checkBoxAllergy.Checked);

                    oSqlCmd.Parameters.AddWithValue("@Allergies", txtBoxAllergies.Text);
                    oSqlCmd.Parameters.AddWithValue("@Comments", txtBoxComments.Text);
                    oSqlCmd.Parameters.AddWithValue("@ScenarioTime", dtpScenarioTime.Text);

                    try
                    {
                        oSqlCon.Open();
                        try
                        {
                            oSqlCmd.ExecuteNonQuery();
                            MessageBox.Show("Patient Record Updated.");
                        }
                        catch (Exception exc)
                        {
                            MessageBox.Show("Attempt to Add Data to the DB failed. " + exc.Message);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Attempt to open Connection failed. " + ex.Message);
                    }
                    finally
                    {
                        oSqlCon.Close();
                    }
                }

                SetPatientDGV();

                //this.Validate();
                //this.tbl_PatientsBindingSource.EndEdit();
                //this.tableAdapterManager.UpdateAll(this.ds_MedSCAN);
               
            }
            else if (radioButtonREMOVEpatients.Checked == true)
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Are you sure you want to delete this record? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    // Remove Paitent from database
                    SqlConnection oSqlCon = new SqlConnection(oSqlconStr);
                    {
                        string query = "DELETE FROM tbl_Patients WHERE PatientID = '" + txtBoxPatientID.Text.Trim() + "'";
                        oSqlCmd = new SqlCommand();//query, oSqlCon);
                        oSqlCmd = oSqlCon.CreateCommand();
                        oSqlCmd.CommandText = query;
                    }

                    try
                    {
                        oSqlCon.Open();
                        try
                        {
                            oSqlCmd.ExecuteNonQuery();
                            MessageBox.Show("Patient Record Removed.");
                        }
                        catch (Exception exc)
                        {
                            MessageBox.Show("Attempt to Remove Data from the DB failed. " + exc.Message);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Attempt to open Connection failed. " + ex.Message);
                    }
                    finally
                    {
                        oSqlCon.Close();
                    }

                    //Remove the medications for the deleted patient from patientMedications database as well-------------------------------------------------------
                    SqlConnection oSqlCon2 = new SqlConnection(oSqlconStr);
                    {
                        string query2 = "DELETE FROM tbl_PatientMedications WHERE PatientID = '" + txtBoxPatientID.Text.Trim() + "'";
                        oSqlCmd = new SqlCommand();//query, oSqlCon);
                        oSqlCmd = oSqlCon2.CreateCommand();
                        oSqlCmd.CommandText = query2;
                    }

                    try
                    {
                        oSqlCon.Open();
                        try
                        {
                            oSqlCmd.ExecuteNonQuery();
                            MessageBox.Show("Patient's Medication Record(s) Removed.");
                        }
                        catch (Exception exc)
                        {
                            MessageBox.Show("Attempt to Remove Data from the DB failed. " + exc.Message);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Attempt to open Connection failed. " + ex.Message);
                    }
                    finally
                    {
                        oSqlCon.Close();
                    }
                } 
            }
            SetPatientDGV();
        }

        #endregion

        //When the M gender button is selected, assign the pregnancy button to N and disables its function
        private void genderRadioButtonM_CheckedChanged(object sender, EventArgs e)
        {
            pregRadioButtonN.Checked = true;
            pregRadioButtonN.Enabled = false;
            pregRadioButtonY.Enabled = false;
        }
        //When the F gender button is selected, enables the Pregnancy button (no option selected)
        private void genderRadioButtonF_CheckedChanged(object sender, EventArgs e)
        {
            pregRadioButtonN.Enabled = true;
            pregRadioButtonY.Enabled = true;
        }

        //Allows searching through the Medications table using partial terms
        private void txtBoxSearchMeds_TextChanged(object sender, EventArgs e)
        {
            //Assigns the fore color (text color) to black
            txtBoxPatientID.ForeColor = Color.Black;

            TextBox oTextBox = sender as TextBox;
            tbl_MedicationsBindingSource.Filter = "MedicationID LIKE '%" + oTextBox.Text + "%' OR GenericName LIKE '%" + oTextBox.Text + "%'";
        }
        //Allows searching through the Patients table using partial terms
        private void txtBoxSearchPatients_TextChanged(object sender, EventArgs e)
        {
            //Assigns the fore color (text color) to black
            txtBoxPatientID.ForeColor = Color.Black;

            TextBox oTextBox = sender as TextBox;
            tbl_PatientsBindingSource.Filter = "PatientID LIKE '%" + oTextBox.Text + "%' OR Lastname LIKE '%" + oTextBox.Text + "%'";
        }

        #region PatientsDGV cell clicked event

        private void patientsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //SetRadioButtons();
            txtBoxPatientID.Text = this.patientsDGV.CurrentRow.Cells["PatientID"].Value.ToString();
            txtBoxLN.Text = this.patientsDGV.CurrentRow.Cells["Lastname"].Value.ToString();
            txtBoxFN.Text = this.patientsDGV.CurrentRow.Cells["Firstname"].Value.ToString();
            txtBoxMI.Text = this.patientsDGV.CurrentRow.Cells["MI"].Value.ToString();

            txtBoxGender.Text = this.patientsDGV.CurrentRow.Cells["Gender"].Value.ToString();
            if (this.patientsDGV.CurrentRow.Cells["Gender"].Value.ToString().ToUpper().Equals('F' + ""))
                genderRadioButtonF.Checked = true;
            else
                genderRadioButtonM.Checked = true;
            txtBoxPreg.Text = this.patientsDGV.CurrentRow.Cells["Pregnant"].Value.ToString();
            if (this.patientsDGV.CurrentRow.Cells["Pregnant"].Value.ToString().ToUpper().Equals('Y' + ""))
                pregRadioButtonY.Checked = true;
            else
                pregRadioButtonN.Checked = true;

            txtBoxDOB.Text = this.patientsDGV.CurrentRow.Cells["DOB"].Value.ToString();
            txtBoxAge.Text = this.patientsDGV.CurrentRow.Cells["Age"].Value.ToString();
            txtBoxHeight.Text = this.patientsDGV.CurrentRow.Cells["Height"].Value.ToString();
            txtBoxWeight.Text = this.patientsDGV.CurrentRow.Cells["Weight"].Value.ToString();
            txtBoxMD.Text = this.patientsDGV.CurrentRow.Cells["Physician"].Value.ToString();
            comboBoxStatus.Text = this.patientsDGV.CurrentRow.Cells["Status"].Value.ToString();
            checkBoxDRN.Checked = bool.Parse(this.patientsDGV.CurrentRow.Cells["DRN"].Value.ToString());
            checkBoxFullCode.Checked = bool.Parse(this.patientsDGV.CurrentRow.Cells["FullCode"].Value.ToString());
            checkBoxFallRisk.Checked = bool.Parse(this.patientsDGV.CurrentRow.Cells["FallRisk"].Value.ToString());
            checkBoxRestrictedExtrem.Checked = bool.Parse(this.patientsDGV.CurrentRow.Cells["RestrictedExtremity"].Value.ToString());
            checkBoxLatexAllergy.Checked = bool.Parse(this.patientsDGV.CurrentRow.Cells["LatexAllergy"].Value.ToString());
            checkBoxAllergy.Checked = bool.Parse(this.patientsDGV.CurrentRow.Cells["Allergy"].Value.ToString());
            txtBoxAllergies.Text = this.patientsDGV.CurrentRow.Cells["Allergies"].Value.ToString();
            txtBoxComments.Text = this.patientsDGV.CurrentRow.Cells["Comments"].Value.ToString();
            dtpScenarioTime.Text = this.patientsDGV.CurrentRow.Cells["ScenarioTime"].Value.ToString();
        }
        #endregion

        #region MedicationsDGV cell clicked event

        private void medicationsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBoxMedID.Text = this.medicationsDGV.CurrentRow.Cells["MedicationID"].Value.ToString();
            txtBoxClassification.Text = this.medicationsDGV.CurrentRow.Cells["Classification"].Value.ToString();
            comboBoxPRC.Text = this.medicationsDGV.CurrentRow.Cells["PregnancyRiskCategory"].Value.ToString();
            txtBoxTrade.Text = this.medicationsDGV.CurrentRow.Cells["TradeName"].Value.ToString();
            txtBoxGeneric.Text = this.medicationsDGV.CurrentRow.Cells["GenericName"].Value.ToString();
            txtBoxPseudo.Text = this.medicationsDGV.CurrentRow.Cells["PseudoName"].Value.ToString();
            txtBoxUnitAmt.Text = this.medicationsDGV.CurrentRow.Cells["UnitAmt"].Value.ToString();
            txtBoxForm.Text = this.medicationsDGV.CurrentRow.Cells["Form"].Value.ToString();
            txtBoxStr.Text = this.medicationsDGV.CurrentRow.Cells["Strength"].Value.ToString();
            txtBoxUOM.Text = this.medicationsDGV.CurrentRow.Cells["UnitOfMeasure"].Value.ToString();
            txtBoxNotes.Text = this.medicationsDGV.CurrentRow.Cells["Notes"].Value.ToString();

        }

        #endregion

        #region HIDE unnecessary P and M DGV columns 

        private void hideUnnecessaryMedicationDGVColumns()
        {
            medicationsDGV.Columns["Classification"].Visible = false;
            medicationsDGV.Columns["PregnancyRiskCategory"].Visible = false;
            medicationsDGV.Columns["TradeName"].Visible = false;
            medicationsDGV.Columns["PseudoName"].Visible = false;
            medicationsDGV.Columns["UnitAmt"].Visible = false;
            medicationsDGV.Columns["Form"].Visible = false;
            medicationsDGV.Columns["Strength"].Visible = false;
            medicationsDGV.Columns["UnitOfMeasure"].Visible = false;
            medicationsDGV.Columns["Notes"].Visible = false;

        }

        public void hideUnnecessaryPatientDGVColumns()
        {
            patientsDGV.Columns["FirstName"].Visible = false;
            patientsDGV.Columns["MI"].Visible = false;
            patientsDGV.Columns["Gender"].Visible = false;
            patientsDGV.Columns["Pregnant"].Visible = false;
            patientsDGV.Columns["DOB"].Visible = false;
            patientsDGV.Columns["Age"].Visible = false;
            patientsDGV.Columns["Height"].Visible = false;
            patientsDGV.Columns["Weight"].Visible = false;
            patientsDGV.Columns["BMI"].Visible = false;
            patientsDGV.Columns["Physician"].Visible = false;
            patientsDGV.Columns["DRN"].Visible = false;
            patientsDGV.Columns["FullCode"].Visible = false;
            patientsDGV.Columns["FallRisk"].Visible = false;
            patientsDGV.Columns["RestrictedExtremity"].Visible = false;
            patientsDGV.Columns["LatexAllergy"].Visible = false;
            patientsDGV.Columns["Allergy"].Visible = false;
            patientsDGV.Columns["Allergies"].Visible = false;
            patientsDGV.Columns["Comments"].Visible = false;
            patientsDGV.Columns["ScenarioTime"].Visible = false;
        }

        #endregion

        //Allows entering of data into the Allergies text box
        private void txtBoxAllergies_TextChanged(object sender, EventArgs e)
        {
            //Will assign nothing to the allergies text box if NKDA, NKA, blank, or nothing is entered, otherwise the Allergy check box will be checked and display the entered allergy
            if (txtBoxAllergies.Text.ToUpper().Equals("NKDA") || txtBoxAllergies.Text.ToUpper().Equals("NKA") ||
                    txtBoxAllergies.Text.Equals("") || txtBoxAllergies.Text.Equals(null))
            {
                checkBoxAllergy.Checked = false;
            }
            else
            {
                checkBoxAllergy.Checked = true;
            }
        }

        // Needed b/c it wont work in the load form method for some reason.
        private void patientsDGV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            patientsDGV.ClearSelection();
        }

        private void medicationsDGV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            medicationsDGV.ClearSelection();
        }

        //prevents the entering of any non-integer character when filling the Medication Unit Amount
        private void txtBoxUnitAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        //prevents the entering of any non-integer character when filling the Medication Strength
        private void txtBoxStr_KeyPress(object sender, KeyPressEventArgs e)
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
        }

        //prevents the acceptance of an entry that fails to return true for ValidMedicationID
        private void txtBoxMedID_TextChanged(object sender, EventArgs e)
        {
            ValidMedicationID();
        }

        //prevents the acceptance of an entry that fails to return true for ValidPatientID
        private void txtBoxPatientID_TextChanged(object sender, EventArgs e)
        {
            ValidatePatientID();
        }

        //Checks to see if the Medication ID entry is Valid
        private bool ValidMedicationID()
        {
            bool valid = true;

            string errorMSG = "Please enter valid Medication ID. (8-15) digits"; 

            //Accepts a string 8 to 15 digits long, accepting numbers between 0 and 9
            string re = "^[0-9]{8,15}$";

            if (System.Text.RegularExpressions.Regex.IsMatch(txtBoxMedID.Text, re))
            {
                // ID is Valid
                errorProviderMedID.SetError(txtBoxMedID, "");
            }
            else
            {
                errorProviderMedID.SetError(txtBoxMedID, errorMSG);
                valid = false;
            }

            return valid;
        }
        
        //Checks to see if the Patient ID entry is Valid
        private bool ValidatePatientID()
        {
            bool valid = true;

            string errorMSG = "Please enter valid Patient ID. (4-6) digits";

            //Accepts a string 4 to 6 digits long, accepting numbers between 0 and 9
            string re = "^[0-9]{4,6}$"; 

            if (System.Text.RegularExpressions.Regex.IsMatch(txtBoxPatientID.Text, re))
            {
                // ID is Valid
                errorProviderPatientID.SetError(txtBoxPatientID, "");
            }
            else
            {
                errorProviderPatientID.SetError(txtBoxPatientID, errorMSG);
                valid = false;
            }

            return valid;
        }

        // Prevents special characters from being entered into Medications search box.
        private void txtBoxSearchMeds_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetterOrDigit(e.KeyChar) || Char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        // Prevents special characters from being entered into Patients search box.
        private void txtBoxSearchPatients_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetterOrDigit(e.KeyChar) || Char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        

        private void txtBoxWeight_TextChanged(object sender, EventArgs e)
        {
            string suffix = "";
            string weight = "0";

            if (String.IsNullOrEmpty(txtBoxWeight.Text.Trim()))
                weight = "0";
            else
                weight = txtBoxWeight.Text;

            lb_label.Text = convertWeight(weight) + " " + suffix;
        }

        private void txtBoxHeight_TextChanged(object sender, EventArgs e)
        {
            string suffix = "";
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

        //prevents the entering of any non-integer character when filling the Patient Height
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

        //prevents the entering of any non-integer character when filling the Patient Weight
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

    }//Class
}//NS

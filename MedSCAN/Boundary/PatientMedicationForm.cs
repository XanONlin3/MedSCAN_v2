using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using DGVPrinterHelper;

namespace MedSCAN.Boundary
{
    /*----------------------------------------------------------------------------
   * Author: J. Nobles
   * Date: 3/26/2014
   * Patient's Medication Form Boundary class
   *///---------------------------------------------------------------------------
    public partial class PatientMedicationForm : Form
    {
        SqlCommand oSqlCmd;
        DataTable dt;

        BindingSource tbl_PatientMedicationsBS = new BindingSource();

        public static string oSqlconStr = Properties.Settings.Default.MedSCAN_DatabaseConnectionString;
        
        private Form form = new Form();
        public Form getForm
        {
            get { return form; }
            set { form = value; }
        }

        private void PatientMedicationForm_Load(object sender, EventArgs e)
        {
            // Set the Format type and the CustomFormat string.
            dtpTime.Format = DateTimePickerFormat.Custom;
            dtpTime.CustomFormat = "HH:mm";

            txtBoxScenarioMsg.Enabled = false;
            txtBoxTimeGiven.Enabled = false;
        }

        public PatientMedicationForm(Entity.Patient patient)
        {
            InitializeComponent();
            txtBoxPatientID.Text = patient.pID;
            txtBoxPatientName.Text = patient.Lastname.ToUpper() + ", " + patient.Firstname + " " + patient.Mi;
            txtBoxScenarioTime.Text = patient.ScenarioTime.ToString("HH:mm");

            Fill_DGV();
        }

        private void Fill_DGV()
        {
            // MedicationID, DrugName, Time, MedType
            string query = "SELECT Given, MedicationID, DrugName, Dose, UOM, Form, Route, Frequency, Time, MedType, ScenarioFlag, Notes, ScenarioMsg, TimeGiven " +
                             "FROM tbl_PatientMedications WHERE PatientID = " + txtBoxPatientID.Text + "";
            oSqlCmd = new SqlCommand(query);
            //dt = Control.DatabaseConnection.GetDataTable(oSqlCmd);
            tbl_PatientMedicationsBS.DataSource = Control.DatabaseConnection.GetDataTable(oSqlCmd);
            MedicationsDGV.DataSource = tbl_PatientMedicationsBS;
            
            MedicationsDGV.ClearSelection();
            hideUnnecessaryMedicationDGVColumns();

            //  Color of Alternate Rows in the DataGridView
            this.MedicationsDGV.RowsDefaultCellStyle.BackColor = Color.White;
            this.MedicationsDGV.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender;
        }

        //Removes the selected medication from the Patient
        private void btnRemoveMarked_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    // Delete selected from db
                    string mID = this.MedicationsDGV.CurrentRow.Cells["MedicationID"].Value.ToString();
                    SqlConnection oSqlCon = new SqlConnection(oSqlconStr);
                    {
                        //string query = "DELETE FROM tbl_PatientMedications WHERE PatientID = '" + txtBoxPatientID.Text + "' AND MedicationID = '" + mID + "'";
                        string query = "DELETE FROM tbl_PatientMedications WHERE MedicationID = '" + mID + "'";
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
                            MessageBox.Show("Record Removed.");
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

                    Fill_DGV();
                }
        }

        //Adds the medication to the patient if the medication ID entered is valid
        private void btnFunction_Click(object sender, EventArgs e)
        {

            if (medID_isValid())
            {
                // Save data to the db. (Update)
                SqlConnection oSqlCon = new SqlConnection(oSqlconStr);
                {
                    string query = "UPDATE tbl_PatientMedications " +
                                      "SET Given = @Given, DrugName = @DrugName, Dose = @Dose, UOM = @UOM, Form =  @Form, Route = @Route, Frequency = @Frequency, "+
                                           "Time = @Time, MedType = @MedType, ScenarioFlag = @ScenarioFlag, Notes = @Notes, ScenarioMsg = @ScenarioMsg, TimeGiven = @TimeGiven " +
                                    "WHERE PatientID = '" + txtBoxPatientID.Text + "' AND MedicationID = '" + txtBoxMedID.Text + "'";
                    oSqlCmd = new SqlCommand(query, oSqlCon);

                    //oSqlCmd.Parameters.AddWithValue("@PatientID", txtBoxPatientID.Text);
                    //oSqlCmd.Parameters.AddWithValue("@MedicationID", txtBoxMedID.Text);
                    oSqlCmd.Parameters.AddWithValue("@Given", ckBoxMarkAsGiven.Checked);
                    oSqlCmd.Parameters.AddWithValue("@DrugName", txtBoxDrugName.Text);
                    oSqlCmd.Parameters.AddWithValue("@Dose", txtBoxDose.Text);
                    oSqlCmd.Parameters.AddWithValue("@UOM", txtBoxUOM.Text);
                    oSqlCmd.Parameters.AddWithValue("@Form", txtBoxForm.Text);
                    oSqlCmd.Parameters.AddWithValue("@Route", txtBoxRoute.Text);
                    oSqlCmd.Parameters.AddWithValue("@Frequency", txtBoxFreq.Text);
                    oSqlCmd.Parameters.AddWithValue("@Time", dtpTime.Text);
                    oSqlCmd.Parameters.AddWithValue("@MedType", comboBoxMedType.Text);
                    oSqlCmd.Parameters.AddWithValue("@ScenarioFlag", checkBoxTriggerFlag.Checked);
                    oSqlCmd.Parameters.AddWithValue("@Notes", txtBoxNotes.Text);
                    oSqlCmd.Parameters.AddWithValue("@ScenarioMsg", txtBoxScenarioMsg.Text);
                    oSqlCmd.Parameters.AddWithValue("@TimeGiven",txtBoxTimeGiven.Text);


                    try
                    {
                        oSqlCon.Open();
                        try
                        {
                            oSqlCmd.ExecuteNonQuery();
                            MessageBox.Show("Record Updated.");
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

                Fill_DGV();
            }
            else
            {
                MessageBox.Show("Medication ID: " + txtBoxMedID.Text + "was NOT found." +
                    "\nPlease make sure it has been first added to the Medications database."); 
            }
        }

        //Allows searching through the patient's assigned medications
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM tbl_Medications WHERE MedicationID = '" + txtBoxSearch.Text + "'";
            oSqlCmd = new SqlCommand(query);
            dt = Control.DatabaseConnection.GetDataTable(oSqlCmd);

            if (dt.Rows.Count > 0)
            {
                String mID, form, GN, TN, str, UOM;

                mID = dt.Rows[0]["MedicationID"].ToString();
                form = dt.Rows[0]["Form"].ToString();
                GN = dt.Rows[0]["GenericName"].ToString();
                TN = dt.Rows[0]["TradeName"].ToString();
                str = dt.Rows[0]["Strength"].ToString();
                UOM = dt.Rows[0]["UnitOfMeasure"].ToString();

                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Medication Found!\nFill form with medication: "+ txtBoxSearch.Text+" infomation?", "Fill Form?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {

                    txtBoxMedID.Text = mID;
                    txtBoxForm.Text = form;
                    txtBoxDrugName.Text = GN + " (" + TN + ")";
                    txtBoxDose.Text = str;
                    txtBoxUOM.Text = UOM;

                }
            }
            else
            {
                // Not found
                MessageBox.Show("Medication NOT found");
            }
        }

        //Refreshes the search field and medication table
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtBoxSearch.Text = "";
            Fill_DGV();
        }

        //Prompts the user with a warning before returning to the Patient View screen
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Ask if user would like to leave the page
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Are you sure you want to leave this page?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
                form.Visible = true; // load hidden admin patient form (Home Screen)
            } 
        }

        //Clears all text fields of information
        private void ClearAll()
        {
            txtBoxMedID.Clear();
            comboBoxMedType.SelectedIndex = -1;
            checkBoxTriggerFlag.Checked = false;
            txtBoxNotes.Clear();
            txtBoxDrugName.Clear();
            txtBoxDose.Clear();
            txtBoxForm.Clear();
            txtBoxUOM.Clear();
            //dtpTime.;
            txtBoxFreq.Clear();
            txtBoxRoute.Clear();
            txtBoxScenarioMsg.Clear();
        }

        private void txtBoxMedID_TextChanged(object sender, EventArgs e)
        {
            string re = "^[0-9]{8,15}$"; // #s 0-9 exactly 8 to 15 digits long

            if (System.Text.RegularExpressions.Regex.IsMatch(txtBoxMedID.Text, re))
            {
                // ID is Valid
                errorProviderMedID.SetError(txtBoxMedID, "");

                string search = txtBoxMedID.Text;

                for (int i = 0; i < MedicationsDGV.Rows.Count; i++)
                {
                    if (MedicationsDGV.Rows[i].Cells[1].Value.ToString() == search)
                    {
                        MedicationsDGV.Rows[i].Selected = true;
                    }
                    else
                    {
                        MedicationsDGV.Rows[i].Selected = false;
                    }
                }
            }
            else
            {
                errorProviderMedID.SetError(txtBoxMedID, "Please enter valid Medication ID. (8-15) digits");
            }
        }

        //if the Medication ID is valid, retrieves it's information from the database
        private bool medID_isValid()
        {
            string query = "SELECT MedicationID FROM tbl_Medications WHERE MedicationID = '" + txtBoxMedID.Text + "'";
            oSqlCmd = new SqlCommand(query);
            dt = Control.DatabaseConnection.GetDataTable(oSqlCmd);

            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                // Not found
                return false;
            }
        }

        //Checks to see if the entered medication ID has already been assigned to the patient
        private bool isUniqueMedID()
        {
            //Accepts a string that is 8 to 15 digits long, and consists of the numbers 0-9
             string re = "^[0-9]{8,15}$";

             if (System.Text.RegularExpressions.Regex.IsMatch(txtBoxMedID.Text, re))
             {
                 if (medID_isValid())
                 {
                     string query = "SELECT MedicationID FROM tbl_PatientMedications " +
                                     "WHERE PatientID = '" + txtBoxPatientID.Text + "' AND MedicationID = '" + txtBoxMedID.Text + "'";
                     oSqlCmd = new SqlCommand(query);
                     dt = Control.DatabaseConnection.GetDataTable(oSqlCmd);

                     if (dt.Rows.Count > 0)
                     {
                         MessageBox.Show("This medication is already listed for this patient.");
                         return false;
                     }
                     else
                     {
                         // Not found
                         return true;
                     }
                 }
                 else
                 {
                     MessageBox.Show("Medication NOT found. Please make sure to add it to the Medications database first.");
                     return false;
                 }
             }
             else
             {
                 MessageBox.Show("Please enter valid Medication ID. (8-15) digits");
                 return false;
             }
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            txtBoxPatientID.ForeColor = Color.Black;

            TextBox oTextBox = sender as TextBox;
            tbl_PatientMedicationsBS.Filter = "MedicationID LIKE '%" + oTextBox.Text + "%' OR DrugName LIKE '%" + oTextBox.Text + "%'";
        }

        //Prints a copy of the PatientMedicationForm
        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter print = new DGVPrinter();
            print.Title = "Patient Medication Report: " + txtBoxPatientName.Text + " ID No." + txtBoxPatientID.Text;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = System.Drawing.StringAlignment.Near;
            print.Footer = "MedSCAN";
            print.FooterSpacing = 15;

            print.PrintDataGridView(MedicationsDGV);
        }

        // Fills form with info from clicked datagridview cell.
        private void MedicationsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBoxMedID.Text = this.MedicationsDGV.CurrentRow.Cells["MedicationID"].Value.ToString();
            txtBoxDrugName.Text = this.MedicationsDGV.CurrentRow.Cells["DrugName"].Value.ToString();
            txtBoxDose.Text = this.MedicationsDGV.CurrentRow.Cells["Dose"].Value.ToString();
            txtBoxUOM.Text = this.MedicationsDGV.CurrentRow.Cells["UOM"].Value.ToString();
            txtBoxForm.Text = this.MedicationsDGV.CurrentRow.Cells["Form"].Value.ToString();
            txtBoxRoute.Text = this.MedicationsDGV.CurrentRow.Cells["Route"].Value.ToString();
            txtBoxFreq.Text = this.MedicationsDGV.CurrentRow.Cells["Frequency"].Value.ToString();
            if (String.IsNullOrEmpty(this.MedicationsDGV.CurrentRow.Cells["Time"].Value.ToString().Trim()))
                dtpTime.Text = "00:00";
            else
            {
                DateTime time = DateTime.Parse(this.MedicationsDGV.CurrentRow.Cells["Time"].Value.ToString());
                dtpTime.Text = time.ToString("HH:mm");
            }
            comboBoxMedType.Text = this.MedicationsDGV.CurrentRow.Cells["MedType"].Value.ToString();
            if (String.IsNullOrEmpty(this.MedicationsDGV.CurrentRow.Cells["ScenarioFlag"].Value.ToString().Trim())) 
                checkBoxTriggerFlag.Checked =false;
            else
                checkBoxTriggerFlag.Checked = bool.Parse(this.MedicationsDGV.CurrentRow.Cells["ScenarioFlag"].Value.ToString());
            txtBoxNotes.Text = this.MedicationsDGV.CurrentRow.Cells["Notes"].Value.ToString();
            txtBoxScenarioMsg.Text = this.MedicationsDGV.CurrentRow.Cells["ScenarioMsg"].Value.ToString();
            if (String.IsNullOrEmpty(this.MedicationsDGV.CurrentRow.Cells["Given"].Value.ToString().Trim()))
                ckBoxMarkAsGiven.Checked = false;
            else
                ckBoxMarkAsGiven.Checked = bool.Parse(this.MedicationsDGV.CurrentRow.Cells["Given"].Value.ToString());
            txtBoxTimeGiven.Text = this.MedicationsDGV.CurrentRow.Cells["TimeGiven"].Value.ToString();
        }

        private void hideUnnecessaryMedicationDGVColumns()
        {
            MedicationsDGV.Columns["Given"].Visible = false;
            MedicationsDGV.Columns["Dose"].Visible = false;
            MedicationsDGV.Columns["UOM"].Visible = false;
            MedicationsDGV.Columns["Form"].Visible = false;
            MedicationsDGV.Columns["Route"].Visible = false;
            MedicationsDGV.Columns["Frequency"].Visible = false;
            MedicationsDGV.Columns["ScenarioFlag"].Visible = false;
            MedicationsDGV.Columns["Notes"].Visible = false;
            MedicationsDGV.Columns["ScenarioMsg"].Visible = false;
            MedicationsDGV.Columns["TimeGiven"].Visible = false;
        }

        private void checkBoxTriggerFlag_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTriggerFlag.Checked == true)
            {
                txtBoxScenarioMsg.Enabled = true;
            }
            else
            {
                txtBoxScenarioMsg.Enabled = false;
                txtBoxScenarioMsg.Text = "";
            }
        }

        //adds a medication to the patient
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //First checks to see if the newly added medication does not share an ID with a medication already assigned to the patient
            if (isUniqueMedID())
            {
                SqlConnection oSqlCon = new SqlConnection(oSqlconStr);
                {
                    string query = "INSERT INTO tbl_PatientMedications(Given, PatientID, MedicationID, DrugName, Dose, UOM, Form," +
                                                                        "Route, Frequency, Time, MedType, ScenarioFlag, Notes, ScenarioMsg, TimeGiven) " +
                                        "VALUES (@Given, @PatientID, @MedicationID, @DrugName, @Dose, @UOM, @Form, " +
                                                                        "@Route, @Frequency, @Time, @MedType, @ScenarioFlag, @Notes, @ScenarioMsg, @TimeGiven) ";
                    oSqlCmd = new SqlCommand();//query, oSqlCon);
                    oSqlCmd = oSqlCon.CreateCommand();
                    oSqlCmd.CommandText = query;

                    oSqlCmd.Parameters.AddWithValue("@Given", ckBoxMarkAsGiven.Checked);
                    oSqlCmd.Parameters.AddWithValue("@PatientID", txtBoxPatientID.Text);
                    oSqlCmd.Parameters.AddWithValue("@MedicationID", txtBoxMedID.Text);
                    oSqlCmd.Parameters.AddWithValue("@DrugName", txtBoxDrugName.Text);
                    oSqlCmd.Parameters.AddWithValue("@Dose", txtBoxDose.Text);
                    oSqlCmd.Parameters.AddWithValue("@UOM", txtBoxUOM.Text);
                    oSqlCmd.Parameters.AddWithValue("@Form", txtBoxForm.Text);
                    oSqlCmd.Parameters.AddWithValue("@Route", txtBoxRoute.Text);
                    oSqlCmd.Parameters.AddWithValue("@Frequency", txtBoxFreq.Text);
                    oSqlCmd.Parameters.AddWithValue("@Time", dtpTime.Text);
                    oSqlCmd.Parameters.AddWithValue("@MedType", comboBoxMedType.Text);
                    oSqlCmd.Parameters.AddWithValue("@ScenarioFlag", checkBoxTriggerFlag.Checked);
                    oSqlCmd.Parameters.AddWithValue("@Notes", txtBoxNotes.Text);
                    oSqlCmd.Parameters.AddWithValue("@ScenarioMsg", txtBoxScenarioMsg.Text);
                    oSqlCmd.Parameters.AddWithValue("@TimeGiven", txtBoxTimeGiven.Text);


                    try
                    {
                        oSqlCon.Open();
                        try
                        {
                            oSqlCmd.ExecuteNonQuery();
                            MessageBox.Show("New Patient Medication Record Added.");
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

                Fill_DGV();
            }
            else
            {
                //MessageBox.Show("Invalid Medication ID. Please enter a unique Medication ID to add a NEW Medication.");
                //txtBoxMedID.Text = "";
            }
        }

        //Clears all information when clicked
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        //Assigns the medication to show that it has already been given in the EMAR screen
        private void ckBoxMarkAsGiven_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBoxMarkAsGiven.Checked == true)
            {
                txtBoxTimeGiven.Enabled = true;
            }
            else
            {
                txtBoxTimeGiven.Enabled = false;
                txtBoxTimeGiven.Text = "";
            }
        }

        //prevents non-integer characters from being entered into the Dose text box
        private void txtBoxDose_KeyPress(object sender, KeyPressEventArgs e)
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

        // Prevents special characters from being entered into search txtbox.
        private void txtBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}


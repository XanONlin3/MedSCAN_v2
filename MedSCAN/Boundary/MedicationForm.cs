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
    * Date: 3/6/2014
    * Admin -MedicationForm Boundary class
    *///-------------------------------------------------------------------------
    public partial class MedicationForm : Form
    {
        Control.DatabaseConnection dbCon;
        string conStr;

        DataSet ds;
        DataRow dRow;

        int maxRows;
        int selectedRow = 0;

        string tbl_Name = "tbl_Medications";

        public static TextBox pIDtxt = new TextBox();

        public MedicationForm()
        {
            InitializeComponent();
        }

        private void MedicationForm_Load(object sender, EventArgs e)
        {
            SetAll2ReadOnly();
            try
            {
                dbCon = new Control.DatabaseConnection();
                conStr = Properties.Settings.Default.MedSCAN_DatabaseConnectionString;

                dbCon.ConStr = conStr;
                dbCon.Sql = Properties.Settings.Default.SELECTallMeds;
                
                ds = dbCon.GetConnection;
                maxRows = ds.Tables[0].Rows.Count; // how many rows are in the dataset

                MessageBox.Show(maxRows.ToString());

                FillForm();
          
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        
        private void FillForm()
        {
            dRow = ds.Tables[0].Rows[selectedRow]; //row where medID match MedicationID 
            
            txtBoxMedID.Text = dRow.ItemArray.GetValue(0).ToString();
            txtBoxClassification.Text = dRow.ItemArray.GetValue(1).ToString();
            comboBoxPRC.SelectedItem = dRow.ItemArray.GetValue(2).ToString();
            txtBoxTrade.Text = dRow.ItemArray.GetValue(3).ToString();
            txtBoxGeneric.Text = dRow.ItemArray.GetValue(4).ToString();
            txtBoxPseudo.Text = dRow.ItemArray.GetValue(5).ToString();
            txtBoxUnitAmt.Text = dRow.ItemArray.GetValue(6).ToString();
            txtBoxForm.Text = dRow.ItemArray.GetValue(7).ToString();
            txtBoxStr.Text = dRow.ItemArray.GetValue(8).ToString();  
            txtBoxUOM.Text = dRow.ItemArray.GetValue(9).ToString();
            txtBoxNotes.Text = dRow.ItemArray.GetValue(10).ToString();
        }

        private void view_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Set all fields to read-only
            SetAll2ReadOnly();
            // Change function and apperance of function_button
            btnFunction.BackColor = Color.DarkViolet;
            btnFunction.Text = "GENERATE BARCODE";
        }

        private void add_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Clear all fields and set edit-able
            ClearAll();
            SetAll2Editable();
            // Change function and apperance of function_button
            btnFunction.BackColor = Color.Blue;
            btnFunction.Text = "ADD";
        }

        private void edit_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Set all fields edit-able
            SetAll2Editable();
            // Change function and apperance of function_button
            btnFunction.BackColor = Color.Green;
            btnFunction.Text = "SAVE";
        }

        private void remove_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Set all fields to read-only
            SetAll2ReadOnly();
            // Change function and apperance of function_button
            btnFunction.BackColor = Color.Red;
            btnFunction.Text ="REMOVE";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void function_button_Click(object sender, EventArgs e)
        {
            if (view_radioButton.Checked == true)
            {
                this.Close();
                // Load BarcodeForm
                BarcodeForm bcform = new BarcodeForm(); //send it the patient ID and information for that patient.
                bcform.Show();

            }
            else if (add_radioButton.Checked == true)
            {
                // Add medication to database
                DataRow newRow = ds.Tables[0].NewRow();

                newRow[0] = txtBoxMedID.Text;
                newRow[1] = txtBoxClassification.Text;
                newRow[2] = comboBoxPRC.SelectedItem;
                newRow[3] = txtBoxTrade.Text;
                newRow[4] = txtBoxGeneric.Text;
                newRow[5] = txtBoxPseudo.Text;
                newRow[6] = txtBoxUnitAmt.Text;
                newRow[7] = txtBoxForm.Text;
                newRow[8] = txtBoxStr.Text;
                newRow[9] = txtBoxUOM.Text;
                newRow[10] = txtBoxNotes.Text;

                ds.Tables[0].Rows.Add(newRow);
                
                try
                {
                   // dbCon.UpdateDB(, );
                    maxRows += 1;
                    selectedRow = maxRows -1;

                    MessageBox.Show("New Record Added.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (edit_radioButton.Checked == true)
            {
                // Save changes to medication in database
                DataRow row = ds.Tables[0].Rows[selectedRow];

                row[0] = txtBoxMedID.Text;
                row[1] = txtBoxClassification.Text;
                row[2] = comboBoxPRC.SelectedItem;
                row[3] = txtBoxTrade.Text;
                row[4] = txtBoxGeneric.Text;
                row[5] = txtBoxPseudo.Text;
                row[6] = txtBoxUnitAmt.Text;
                row[7] = txtBoxForm.Text;
                row[8] = txtBoxStr.Text;
                row[9] = txtBoxUOM.Text;
                row[10] = txtBoxNotes.Text;

                try
                {
                    dbCon.UpdateDB(ds);

                    MessageBox.Show("Record Updated.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (remove_radioButton.Checked == true)
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Are you sure you want to delete this record? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    // Remove medication from database
                    try
                    {
                        ds.Tables[0].Rows[selectedRow].Delete();
                        dbCon.UpdateDB(ds);

                        maxRows = ds.Tables[0].Rows.Count;
                        selectedRow--;
                        FillForm();

                        MessageBox.Show("Record Deleted.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            //Show message box and return user to HS
            //MessageBox.Show("Are you sure you want to cancel");
            
            Modify Mod = new Modify();
            Mod.Show();
        }

        private void SetAll2ReadOnly()
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

        private void SetAll2Editable()
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

        private void ClearAll()
        {
            txtBoxMedID.Clear();
            txtBoxClassification.Clear();
            comboBoxPRC.SelectedIndex =-1;
            txtBoxTrade.Clear();
            txtBoxGeneric.Clear();
            txtBoxPseudo.Clear();
            txtBoxStr.Clear();
            txtBoxForm.Clear();
            txtBoxUnitAmt.Clear();
            txtBoxUOM.Clear();
            txtBoxNotes.Clear();
        }
    }//Class
}//NS

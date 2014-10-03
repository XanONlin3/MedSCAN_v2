using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace MedSCAN.Boundary
{
    /*----------------------------------------------------------------------------
    * Author: J. Nobles
    * Date: 3/23/2014
    * Admin - Barcode Form class
    *///-------------------------------------------------------------------------
    public partial class BarcodeForm : Form
    {
        // Creates form object and Get and Set method for current form.
        private Form form = new Form();
        public Form getForm
        {
            get { return form; }
            set { form = value; }
        }

        // Load the form with the Medication obj info passed.
        public BarcodeForm(Entity.Medications med)
        {
            InitializeComponent();

            // Med Info.
            txtBoxMedID.Text = med.MedID;
            txtBoxTrade.Text = med.TradeName;
            txtBoxGeneric.Text = med.GenericName;
            txtBoxDose.Text = med.Strength.ToString();
            txtBoxUOM.Text = med.UOM;

            // Load on this tab.
            tabControl.SelectedTab = tabPage2;
        }

        // Load the form with the Patient obj info passed.
        public BarcodeForm(Entity.Patient patient)
        {
            InitializeComponent();

            // Patient Info.
            txtBoxPatientID.Text = patient.pID;
            txtBoxLN.Text = patient.Lastname;
            txtBoxFN.Text = patient.Firstname;
            txtBoxMI.Text = patient.Mi;
            txtBoxDOB.Text = patient.dob;
            txtBoxAge.Text = patient.age.ToString();
            txtBoxPhysician.Text = patient.Physician;

            // Handle gender radiobutton logic.
            if (patient.Gender == "M")
                genderRadioButtonM.Checked = true;
            else if (patient.Gender == "F")
                genderRadioButtonF.Checked = true;

            if (patient.Pregnant == "Y")
                pregRadioButtonY.Checked = true;
            else if(patient.Pregnant =="N")
                pregRadioButtonN.Checked = true;

            // Load this tab.
            tabControl.SelectedTab = tabPage1;
        }

        private void BarcodeForm_Load(object sender, EventArgs e)
        { 
        }
        
        // Generate barcode button. (patient)
        private void btnGeneratePBC_Click(object sender, System.EventArgs e)
        {
            if (txtBoxPatientID.Text != "")
            {
                // Call create barcode method. Save result as bitmap.
                Bitmap barcode = CreateBarcode("*" + txtBoxPatientID.Text.ToString().Trim() + "*", CreatePatientInfoText());
                previewPictureBox.Image = barcode;
            }
            else
                MessageBox.Show("Please enter an ID number.");
        }

        // Generate barcode button. (med)
        private void btnGenerateMBC_Click(object sender, System.EventArgs e)
        {

            if (txtBoxMedID.Text != "")
            {
                // Call create barcode method. Save result as bitmap.
                Bitmap barcode = CreateBarcode("*" + txtBoxMedID.Text.ToString().Trim() + "*", CreateMedicationInfoText());
                previewPictureBox.Image = barcode;
            }
            else
                MessageBox.Show("Please enter an ID number.");
        }

        // Print button method.
        private void function_button_Click(object sender, System.EventArgs e)
        {
            if (this.printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);
                printDocument1.Print();
            }
        }
        
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(previewPictureBox.Image, 0, 0);
        }

        // Save button method.
        private void btnSave_Click(object sender, System.EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Images|*.png;*.bmp;*.jpg";
            ImageFormat format = ImageFormat.Png;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(sfd.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }
                previewPictureBox.Image.Save(sfd.FileName, format);
            }
        }

        //When the cancel button is clicked, return the patient
        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
            //loads hidden Admin patients Form
            form.Visible = true;
        }

        // Creates the label for the patient barcode.
        private String CreatePatientInfoText()
        {
            string pID, fn, ln, mi, dr, sex="", preg="", dob, age="", hospital;
            string unknown = "??";

            pID = txtBoxPatientID.Text;
            fn = txtBoxFN.Text;
            ln = txtBoxLN.Text;
            mi = txtBoxMI.Text;
            dr = txtBoxPhysician.Text;
            dob = txtBoxDOB.Text;
            hospital =txtBoxLocation.Text;
            age = txtBoxAge.Text;
            if(String.IsNullOrEmpty(txtBoxAge.Text.Trim()))
                age = unknown;

            if (pregRadioButtonY.Checked == true)
                preg = "Pregnant";

            if (genderRadioButtonF.Checked == true)
                sex = "F";
            else if (genderRadioButtonM.Checked == true)
                sex = "M";

            String label = ln.ToUpper() + " " + ", " + fn + " " + mi + "\n" +
                "<"+pID + ">\t" + dr +"\n"+
                dob + " " + age+"Y "+ sex + " " + preg +" \n"+
                hospital;

            return label;           
        }
        //Fills in the Medication information into the text fields
        private String CreateMedicationInfoText()
        {
            string mID, tn, gn, dose, uom;
            string label ="";

            mID = txtBoxMedID.Text;
            tn = txtBoxTrade.Text;
            gn = txtBoxGeneric.Text;
            dose = txtBoxDose.Text;
            uom = txtBoxUOM.Text;

            //When the barcode is created, display the medications' trade name
            if (radioButtonTrade.Checked)
            {
                 label = mID + "\n" +
                               tn + " " + dose + "" + uom.ToUpper();
            }
            //When the barcode is created, display the medications' generic name
            else if (radioButtonGeneric.Checked)
            {
                 label = mID + "\n" +
                               gn + " " + dose + "" + uom.ToUpper();
            }

            return label;
            
        }
        //Creates a barcode from the entered data
        private Bitmap CreateBarcode(string data, string info)
        {
            String txt =data.Trim();
            // Create the bitmap.
            Bitmap bmp = new Bitmap(1, 1);

            // Get reference to the 3 of 9 font used to generate the barcode.
            Font threeOfNine =new Font("Free 3 of 9", 30,
                                System.Drawing.FontStyle.Regular,
                                System.Drawing.GraphicsUnit.Point);
            Font font = new Font("Arial", 15,
                FontStyle.Regular, GraphicsUnit.Pixel);

            // Graphic object
            Graphics graphics = Graphics.FromImage(bmp);

            // Get width and height of info + barcode.
            //int width = (int)graphics.MeasureString(info, font).Width;
            int width = (int)previewPictureBox.Width - 1;
            int height = (int)graphics.MeasureString(info, font).Height;

            int height2 = (int)graphics.MeasureString(txt, threeOfNine).Height;

            bmp = new Bitmap(bmp, new Size(width, height+height2));

            // Refresh graphic object with new bitmap.
            graphics = Graphics.FromImage(bmp);
            graphics.Clear(Color.White);
            
            // Set rendering hint to singleBitPerPixel.
            graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;

            // Draw the string onto the graphics object.
            graphics.DrawString(info, font, 
                new SolidBrush(Color.Black), 0, 0);
            graphics.DrawString(txt, threeOfNine,
                new SolidBrush(Color.Black), 0, height);

            // Finish & Cleanup.
            graphics.Flush();
            threeOfNine.Dispose();
            graphics.Dispose();
            
            // Return the finished barcode.
            return bmp;
        }

        //when the M gender button is selected, check the 'N' radio button for Pregnancy and disable its' function
        private void genderRadioButtonM_CheckedChanged(object sender, EventArgs e)
        {
            pregRadioButtonN.Checked = true;
            pregRadioButtonN.Enabled = false;
            pregRadioButtonY.Enabled = false;
        }

        //When the F gender button is selected, enable the pregnancy radio buttons
        private void genderRadioButtonF_CheckedChanged(object sender, EventArgs e)
        {
            pregRadioButtonN.Enabled = true;
            pregRadioButtonY.Enabled = true;
        }

        // Not used. (was for controlling barcode label size)
        private void txtBoxLabelFont_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        // Not used. (was for controlling barcode font size)
        private void txtBoxBCFont_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        //prevents the entering of any non-integer character into the Dose text box
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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MedSCAN.Control
{
    /*----------------------------------------------------------------------------
   * Author: J. Nobles
   * Date: 4/18/2014
   * Alert's control class (not in use)
   *///---------------------------------------------------------------------------
    class Alerts
    {
        SqlCommand oSqlCmd;
        DataTable dt_patient, dt_med, dt_patientMed;

        bool flag = false;
        string name, time, notesPM, scenarioMsg, uom;
        float dose = 0.0f; float unitAmtPM = 0.0f;
        //-----------------------------------------------------
        string classification, pregRiskCat, notes;
        float unitAmt, str;

        // Constructor
        public Alerts(Entity.Medications med, Entity.Patient patient, Entity.PatientMeds patientMeds){
    

            string query = "SELECT * FROM tbl_PatientMedications WHERE MedicationID = '" + med.MedID + "' AND PatientID = '" + patient.pID + "'";
            oSqlCmd = new SqlCommand(query);
            dt_patient = Control.DatabaseConnection.GetDataTable(oSqlCmd);

            name = dt_patient.Rows[0]["DrugName"].ToString();
            time = dt_patient.Rows[0]["Time"].ToString();
            notesPM = dt_patient.Rows[0]["Notes"].ToString();
            scenarioMsg = dt_patient.Rows[0]["ScenarioMsg"].ToString();
            uom = dt_patient.Rows[0]["UOM"].ToString(); 

            string f = dt_patient.Rows[0]["ScenarioFlag"].ToString();
            string d = dt_patient.Rows[0]["Dose"].ToString();
            string u = dt_patient.Rows[0]["UnitAmt"].ToString();

            if(!String.IsNullOrEmpty(f.Trim()))
                flag = bool.Parse(f);
            if (!String.IsNullOrEmpty(d.Trim()))
                dose = float.Parse(d);
            if (!String.IsNullOrEmpty(u.Trim()))
                unitAmtPM = float.Parse(u);

            classification = med.Classification;
            pregRiskCat = med.PregRiskCat;
            notes = med.Notes;
            unitAmt = med.UnitAmt;
            str = med.Strength;
 
        }

        // Check if Medication has already been given
     /*   public bool isGiven()
        {
            //string msg = "STOP: This medication has already been given.";
            //string caption = "Already Given";

            int index = patientMedsDGV.SelectedRows[0].Index;
            string selectedCell = patientMedsDGV[0, index].Value.ToString().ToLower();
            bool Given;
            if(String.IsNullOrEmpty(selectedCell.Trim()))
            {
                selectedCell = false.ToString();
            }
            Given = bool.Parse(selectedCell);
            //if (Given)
                //MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return Given;
        } */

        // Shouldn't be called is the patient scenario time is null
        public bool isOnTime(string st, string sat)
        {
            // medication is 'on time' if it is given 60 minutes before until 60 minutes after the scheduled administration time
            DateTime scenarioTime =DateTime.Parse(st);
            DateTime scheduledAdminTime = DateTime.Parse(sat);
                
            DateTime acceptableRangeB = scenarioTime.Add(new TimeSpan(-1,0,0));
            DateTime acceptableRangeA = scheduledAdminTime.Add(new TimeSpan(1,0,0));

            if(scheduledAdminTime < acceptableRangeB)
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Warning: This medication is about to be given too early! (Please check the administration time again)" +
                    "\nAdminister the medication anyway? ", "Give Medication?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    //If 'YES' is clicked mark as given
                    //patientMedsDGV[0, index].Value = true;
                    //patientMedsDGV[10, index].Value = DateTime.Now.ToString("@" + " HH:mm");
                    return true;
                }
                else
                {
                    //Do Nothing
                    return false;
                }
            }
            else if(scheduledAdminTime > acceptableRangeA)
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Warning: This medication is about to be given too early! (Please check the administration time again)" +
                    "\nAdminister the medication anyway? ", "Give Medication?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    //If 'YES' is clicked mark as given
                    //patientMedsDGV[0, index].Value = true;
                    //patientMedsDGV[10, index].Value = DateTime.Now.ToString("@" + " HH:mm");
                    return true;
                }
                else
                {
                    //Do Nothing
                    return false;
                }
            }
            else
            {
                return true;
            }
        }  
  
        // Shouldn't be called unless the checkBoxAllergy is checked
        public bool isAllergic(string allergiesList, string classificationList){
        
            bool allergy = false;

            string[] allergies = SplitWords(allergiesList);
            string[] classifications = SplitWords(classificationList);

            for(int i = 0; i < allergies.Length; i++)
            {
                for(int k = 0; k < classifications.Length; k++)
                {
                    if (allergies[i].Equals(classifications[k]))
                    {
                        DialogResult dr = new DialogResult();
                        dr =MessageBox.Show("Warning patient has allergy to this medication's classification: " + classifications[k], "Give Medication?",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dr == DialogResult.Yes)
                        {
                            //If 'YES' is clicked mark as given
                            //patientMedsDGV[0, index].Value = true;
                            //patientMedsDGV[10, index].Value = DateTime.Now.ToString("@" + " HH:mm");
                            allergy = true;
                        }
                        else
                        {
                            //Do Nothing
                            allergy = false;
                        }
                    }
                }
            }
            return allergy;
        }

        public bool isCorrectDose(Entity.Medications med, Entity.PatientMeds patientMeds, float dose, float str)
        {
            // check Med.str against PatientMed.dose
            if (str < dose)
            {
                //Multi-Dose screen
                using (var form = new Boundary.Multi_Dose(med, patientMeds))
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        // Mark medication as given
                        //patientMedsDGV[0, index].Value = true;
                        //patientMedsDGV[10, index].Value = DateTime.Now.ToString("@" + " HH:mm");
                        return true;
                    }
                }
            }
            else if (str > dose)
            {
                //Multi-Fractional Dose screen
                using (var form = new Boundary.Multi_Dose(med, patientMeds))
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        // Mark medication as given
                        //patientMedsDGV[0, index].Value = true;
                        //patientMedsDGV[10, index].Value = DateTime.Now.ToString("@" + " HH:mm");
                        return true;
                    }
                }
            }
            return true;
        }

        // Should only be called if the patient Medication is flagged to trigger event
        public bool isFlagged(string scenarioMsg)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("STOP: " + scenarioMsg+"\nAdminister the medication anyway? ", "Give Medication?", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (dr == DialogResult.Yes)
            {
                //If 'YES' is clicked mark as given
                //patientMedsDGV[0, index].Value = true;
                //patientMedsDGV[10, index].Value = DateTime.Now.ToString("@" + " HH:mm");
                return true;
            }
            else
            {
                //Do Nothing
                return false;
            }
        }

        // Should only be called if the patient is pregnant
        public bool isOKForPregnant(char pregnancyRiskCategory)
        {
            // C, D, X is not ok I think?
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Warning patient is pregnant, and this medication's Pregnancy Risk Catagory is: " + pregRiskCat, "Give Medication?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                //If 'YES' is clicked mark as given
                //patientMedsDGV[0, index].Value = true;
                //patientMedsDGV[10, index].Value = DateTime.Now.ToString("@" + " HH:mm");
                return true;
            }
            else
            {
                //Do Nothing
                return false;
            }
        }

        public static string[] SplitWords(string s)
        {
            // Split on all non-word characters. 
            return System.Text.RegularExpressions.Regex.Split(s, @"\W+");
            // @      special verbatim string syntax
            // \W+    one or more non-word characters together
        } 
    }//Class 
}//NS

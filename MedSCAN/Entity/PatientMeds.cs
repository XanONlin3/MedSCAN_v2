using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedSCAN.Entity
{
    /*----------------------------------------------------------------------------
     * Author: J. Nobles
     * Date: 4/05/2014
     * Patient -Entity class
     */ //-------------------------------------------------------------------------
    public class PatientMeds
    {
        // Patient Meds obj get and set methods.
        public string MedID { get; set; }  

        public string PatientID { get; set; }
        public string PatientName { get; set; }

        public string MedType { get; set; }
        public string MedName { get; set; }
   
        public string Form { get; set; }
        public float dose { get; set; }
        public string UOM { get; set; }
        public string Route { get; set; }
        public string Freq { get; set; }
        public DateTime time { get; set; }

        public string Notes { get; set; }

        public bool ScenarioFlag { get; set; }
        public string Msg { get; set; }

        //public static Medications singleton = new Medications();

        public string toString()
        {
            string medLabel = MedID +
                "\n Medtype" + MedType +
                "\nPatient Name: "+PatientName +" Medication Name: " + MedName + "\n" +
                "Unit Amount: " + " Form: " + Form + " Dose: "+dose + "UOM: " + UOM + " Notes: " + Notes;

            return medLabel;
        }

    }
}

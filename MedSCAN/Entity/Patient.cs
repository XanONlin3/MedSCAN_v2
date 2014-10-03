using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedSCAN.Entity
{
    /*----------------------------------------------------------------------------
     * Author: J. Nobles
     * Date: 3/15/2014
     * Patient -Entity class
     */ //-------------------------------------------------------------------------
    public class Patient
    {
        // Patient obj. get and set methods.
        public string pID { get; set; } 

        public string Lastname { get; set; }
        public string Firstname {get; set; } 
        public string Mi { get; set; }  

        public string Gender { get; set; }  // 'M'+"" || 'F'+""
        public string Pregnant { get; set; } //'Y'+"" || 'N'+""

        public string dob { get; set; }
        public string age { get; set; } // Calculate from dob

        public string height { get; set; }
        public string weight { get; set; }
        public string BMI { get; set; } // calculate from height and wwight

        public string Physician { get; set; }

        public string Status { get; set; } //"INACTIVE" || "ACTIVE"

        public bool DRN { get; set; }
        public bool FullCode { get; set; }
        public bool FallRisk { get; set; }
        public bool RestrictedExtremity { get; set; }
        public bool LatexAllergy { get; set; }
        public bool Allergy { get; set; }

        public string Allergies { get; set; }
        public string Comments { get; set; }

        public DateTime ScenarioTime { get; set; }

        //public static Patient singleton = new Patient();

        public string caluclateBMI(double kg, double cm)
        {
            double BMI = 0;

            BMI = kg / (double)Math.Pow((cm / 100), 2.0);

            return BMI.ToString("#.##");
        }

        public int calculateAge(DateTime dob)
        {
            DateTime today = DateTime.Now; // To avoid a race condition around midnight
            int age = today.Year - dob.Year;

            if (today.Month < dob.Month || (today.Month == dob.Month && today.Day < dob.Day))
                age--;

            return age;
        }

        public string toString()
        {
            string patientLabel = Lastname.ToUpper() + ", " + Firstname + " " + Mi + ". \n" +
                "<" + pID + ">\t" + Physician + "\n" +
                dob + " " + age + "Y " + Gender + " " + Pregnant +
                "\nDRN: " + DRN + " Full Code: " + FullCode + " FallRisk: " + FallRisk +
                "\nLatex Allergy: " + LatexAllergy + " Allergy: " + Allergy + " Restricted Extremity: " + RestrictedExtremity +
                "\nAllergies: " + Allergies +
                "\nComments: " + Comments;

            return patientLabel;
        }
    }

}

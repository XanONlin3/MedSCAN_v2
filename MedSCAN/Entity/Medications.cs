using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedSCAN.Entity
{
    /*----------------------------------------------------------------------------
    * Author: J. Nobles
    * Date: 3/15/2014
    * Medications -Entity class
    *///-------------------------------------------------------------------------
    public class Medications
    {
        // Medication obj get and set methods.
        public string MedID { get; set; }

        public string Classification { get; set; }
        public string PregRiskCat { get; set; } //'A' - 'D'+"" and N/A = 'N'+""

        public string GenericName { get; set; }
        public string TradeName { get; set; }
        public string PseudoName { get; set; }

        public float UnitAmt { get; set; }
        public string Form { get; set; }
        public float Strength { get; set; }
        public string UOM { get; set; }

        public string Notes { get; set; }

        //public static Medications singleton = new Medications();

        public string toString()
        {
            string medLabel = MedID +
                "\nClassification: :" + Classification + " Pregnancy Risk Catagory: " + PregRiskCat +
                "\nTrade Name: " + TradeName + " Generic Name: " + GenericName + " Pseudo Name: (" + PseudoName + ")\n" +
                "Unit Amount: " + UnitAmt + " Form: " + Form + " Strength: " + "UOM: " + UOM + " Notes: " + Notes;
            
            return medLabel;
        }
    }
}

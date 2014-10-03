using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MedSCAN
{
    /*----Date Began : 2/13/2014----------------------------------------------------
     *
     * 
     * MedSCAN ~ Designer and Author: Nicole J. Nobles
     * 
     */
    //------------------------------------------------------------------------------
    static class Program
    {
        /*--------------------------------------------------------------------------
         * MedSCAN is Barcode Medication Administration (BCMA) software that 
         * will provide the nursing department students with a more realistic 
         * approach to managing and caring for patients in a hospital setting. 
         * BCMA software’s main goal is to verify the "5 rights of patient care": 
         * right patient, right drug, right dose, right route, and right time. 
         * The students will be able see the patient’s medication(s), and scan 
         * both the patient and medication barcode to make sure they have the 
         * correct patient/medication. The professor will be able to add, remove, 
         * edit, and view patients and medication information from the database. 
         * The professor will also be able to print unique barcodes for the 
         * different patients and medications. 
         */ //-----------------------------------------------------------------------

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Boundary.PatientLookup());
        }
    }
}

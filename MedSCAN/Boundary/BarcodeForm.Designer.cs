namespace MedSCAN.Boundary
{
    partial class BarcodeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.top_panel = new System.Windows.Forms.Panel();
            this.bcDsgn_label = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.function_panel = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.preview_panel = new System.Windows.Forms.Panel();
            this.previewPictureBox = new System.Windows.Forms.PictureBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.selectedPatient_panel = new System.Windows.Forms.Panel();
            this.txtBoxDOB = new System.Windows.Forms.TextBox();
            this.txtBoxAge = new System.Windows.Forms.TextBox();
            this.age_label = new System.Windows.Forms.Label();
            this.hospitalName_label = new System.Windows.Forms.Label();
            this.txtBoxLocation = new System.Windows.Forms.TextBox();
            this.btnGeneratePatientBC = new System.Windows.Forms.Button();
            this.preg_panel = new System.Windows.Forms.Panel();
            this.pregRadioButtonY = new System.Windows.Forms.RadioButton();
            this.pregRadioButtonN = new System.Windows.Forms.RadioButton();
            this.pregnant_label = new System.Windows.Forms.Label();
            this.txtBoxPatientID = new System.Windows.Forms.TextBox();
            this.txtBoxFN = new System.Windows.Forms.TextBox();
            this.txtBoxLN = new System.Windows.Forms.TextBox();
            this.txtBoxMI = new System.Windows.Forms.TextBox();
            this.genderRadioButtonF = new System.Windows.Forms.RadioButton();
            this.genderRadioButtonM = new System.Windows.Forms.RadioButton();
            this.physician_label = new System.Windows.Forms.Label();
            this.middle_label = new System.Windows.Forms.Label();
            this.DOB_label = new System.Windows.Forms.Label();
            this.txtBoxPhysician = new System.Windows.Forms.TextBox();
            this.gender_label = new System.Windows.Forms.Label();
            this.fname_label = new System.Windows.Forms.Label();
            this.lname_label = new System.Windows.Forms.Label();
            this.pID_label = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.selectedMed_panel = new System.Windows.Forms.Panel();
            this.selectOne_label = new System.Windows.Forms.Label();
            this.radioButtonTrade = new System.Windows.Forms.RadioButton();
            this.radioButtonGeneric = new System.Windows.Forms.RadioButton();
            this.txtBoxUOM = new System.Windows.Forms.TextBox();
            this.uom_label = new System.Windows.Forms.Label();
            this.btnGenerateMedBC = new System.Windows.Forms.Button();
            this.txtBoxMedID = new System.Windows.Forms.TextBox();
            this.txtBoxTrade = new System.Windows.Forms.TextBox();
            this.txtBoxGeneric = new System.Windows.Forms.TextBox();
            this.txtBoxDose = new System.Windows.Forms.TextBox();
            this.dose_label = new System.Windows.Forms.Label();
            this.Generic_label = new System.Windows.Forms.Label();
            this.trade_label = new System.Windows.Forms.Label();
            this.medID_label = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.top_panel.SuspendLayout();
            this.function_panel.SuspendLayout();
            this.preview_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.selectedPatient_panel.SuspendLayout();
            this.preg_panel.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.selectedMed_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.top_panel.Controls.Add(this.bcDsgn_label);
            this.top_panel.Controls.Add(this.btnClose);
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(783, 69);
            this.top_panel.TabIndex = 1;
            // 
            // bcDsgn_label
            // 
            this.bcDsgn_label.AutoSize = true;
            this.bcDsgn_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcDsgn_label.Location = new System.Drawing.Point(3, 3);
            this.bcDsgn_label.Name = "bcDsgn_label";
            this.bcDsgn_label.Size = new System.Drawing.Size(272, 37);
            this.bcDsgn_label.TabIndex = 2;
            this.bcDsgn_label.Text = "Barcode Designer";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Firebrick;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.Location = new System.Drawing.Point(694, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(78, 28);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // function_panel
            // 
            this.function_panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.function_panel.Controls.Add(this.btnSave);
            this.function_panel.Controls.Add(this.btnPrint);
            this.function_panel.Location = new System.Drawing.Point(433, 75);
            this.function_panel.Name = "function_panel";
            this.function_panel.Size = new System.Drawing.Size(344, 59);
            this.function_panel.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(175, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 33);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.DarkViolet;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrint.Location = new System.Drawing.Point(19, 13);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(150, 33);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.function_button_Click);
            // 
            // preview_panel
            // 
            this.preview_panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.preview_panel.Controls.Add(this.previewPictureBox);
            this.preview_panel.Location = new System.Drawing.Point(433, 140);
            this.preview_panel.Name = "preview_panel";
            this.preview_panel.Size = new System.Drawing.Size(344, 355);
            this.preview_panel.TabIndex = 8;
            // 
            // previewPictureBox
            // 
            this.previewPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.previewPictureBox.Location = new System.Drawing.Point(18, 15);
            this.previewPictureBox.Name = "previewPictureBox";
            this.previewPictureBox.Size = new System.Drawing.Size(309, 324);
            this.previewPictureBox.TabIndex = 0;
            this.previewPictureBox.TabStop = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(6, 75);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(421, 420);
            this.tabControl.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.selectedPatient_panel);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(413, 389);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Patient";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // selectedPatient_panel
            // 
            this.selectedPatient_panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.selectedPatient_panel.Controls.Add(this.txtBoxDOB);
            this.selectedPatient_panel.Controls.Add(this.txtBoxAge);
            this.selectedPatient_panel.Controls.Add(this.age_label);
            this.selectedPatient_panel.Controls.Add(this.hospitalName_label);
            this.selectedPatient_panel.Controls.Add(this.txtBoxLocation);
            this.selectedPatient_panel.Controls.Add(this.btnGeneratePatientBC);
            this.selectedPatient_panel.Controls.Add(this.preg_panel);
            this.selectedPatient_panel.Controls.Add(this.txtBoxPatientID);
            this.selectedPatient_panel.Controls.Add(this.txtBoxFN);
            this.selectedPatient_panel.Controls.Add(this.txtBoxLN);
            this.selectedPatient_panel.Controls.Add(this.txtBoxMI);
            this.selectedPatient_panel.Controls.Add(this.genderRadioButtonF);
            this.selectedPatient_panel.Controls.Add(this.genderRadioButtonM);
            this.selectedPatient_panel.Controls.Add(this.physician_label);
            this.selectedPatient_panel.Controls.Add(this.middle_label);
            this.selectedPatient_panel.Controls.Add(this.DOB_label);
            this.selectedPatient_panel.Controls.Add(this.txtBoxPhysician);
            this.selectedPatient_panel.Controls.Add(this.gender_label);
            this.selectedPatient_panel.Controls.Add(this.fname_label);
            this.selectedPatient_panel.Controls.Add(this.lname_label);
            this.selectedPatient_panel.Controls.Add(this.pID_label);
            this.selectedPatient_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedPatient_panel.Location = new System.Drawing.Point(3, 3);
            this.selectedPatient_panel.Name = "selectedPatient_panel";
            this.selectedPatient_panel.Size = new System.Drawing.Size(407, 383);
            this.selectedPatient_panel.TabIndex = 3;
            // 
            // txtBoxDOB
            // 
            this.txtBoxDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDOB.Location = new System.Drawing.Point(104, 161);
            this.txtBoxDOB.Name = "txtBoxDOB";
            this.txtBoxDOB.Size = new System.Drawing.Size(135, 24);
            this.txtBoxDOB.TabIndex = 3;
            // 
            // txtBoxAge
            // 
            this.txtBoxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAge.Location = new System.Drawing.Point(310, 126);
            this.txtBoxAge.Name = "txtBoxAge";
            this.txtBoxAge.Size = new System.Drawing.Size(56, 24);
            this.txtBoxAge.TabIndex = 6;
            // 
            // age_label
            // 
            this.age_label.AutoSize = true;
            this.age_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age_label.Location = new System.Drawing.Point(262, 129);
            this.age_label.Name = "age_label";
            this.age_label.Size = new System.Drawing.Size(37, 18);
            this.age_label.TabIndex = 37;
            this.age_label.Text = "Age:";
            // 
            // hospitalName_label
            // 
            this.hospitalName_label.AutoSize = true;
            this.hospitalName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hospitalName_label.Location = new System.Drawing.Point(9, 292);
            this.hospitalName_label.Name = "hospitalName_label";
            this.hospitalName_label.Size = new System.Drawing.Size(110, 18);
            this.hospitalName_label.TabIndex = 36;
            this.hospitalName_label.Text = "Hospital Name:";
            // 
            // txtBoxLocation
            // 
            this.txtBoxLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLocation.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBoxLocation.Location = new System.Drawing.Point(12, 314);
            this.txtBoxLocation.Name = "txtBoxLocation";
            this.txtBoxLocation.Size = new System.Drawing.Size(354, 24);
            this.txtBoxLocation.TabIndex = 9;
            this.txtBoxLocation.Text = "Georgia College University Hopsital";
            // 
            // btnGeneratePatientBC
            // 
            this.btnGeneratePatientBC.BackColor = System.Drawing.Color.Navy;
            this.btnGeneratePatientBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneratePatientBC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGeneratePatientBC.Location = new System.Drawing.Point(10, 347);
            this.btnGeneratePatientBC.Name = "btnGeneratePatientBC";
            this.btnGeneratePatientBC.Size = new System.Drawing.Size(387, 31);
            this.btnGeneratePatientBC.TabIndex = 10;
            this.btnGeneratePatientBC.Text = "Generate Barcode";
            this.btnGeneratePatientBC.UseVisualStyleBackColor = false;
            this.btnGeneratePatientBC.Click += new System.EventHandler(this.btnGeneratePBC_Click);
            // 
            // preg_panel
            // 
            this.preg_panel.Controls.Add(this.pregRadioButtonY);
            this.preg_panel.Controls.Add(this.pregRadioButtonN);
            this.preg_panel.Controls.Add(this.pregnant_label);
            this.preg_panel.Location = new System.Drawing.Point(10, 257);
            this.preg_panel.Name = "preg_panel";
            this.preg_panel.Size = new System.Drawing.Size(178, 26);
            this.preg_panel.TabIndex = 26;
            // 
            // pregRadioButtonY
            // 
            this.pregRadioButtonY.AutoSize = true;
            this.pregRadioButtonY.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pregRadioButtonY.Location = new System.Drawing.Point(134, 2);
            this.pregRadioButtonY.Name = "pregRadioButtonY";
            this.pregRadioButtonY.Size = new System.Drawing.Size(35, 22);
            this.pregRadioButtonY.TabIndex = 1;
            this.pregRadioButtonY.Text = "Y";
            this.pregRadioButtonY.UseVisualStyleBackColor = true;
            // 
            // pregRadioButtonN
            // 
            this.pregRadioButtonN.AutoSize = true;
            this.pregRadioButtonN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pregRadioButtonN.Location = new System.Drawing.Point(91, 2);
            this.pregRadioButtonN.Name = "pregRadioButtonN";
            this.pregRadioButtonN.Size = new System.Drawing.Size(37, 22);
            this.pregRadioButtonN.TabIndex = 0;
            this.pregRadioButtonN.Text = "N";
            this.pregRadioButtonN.UseVisualStyleBackColor = true;
            // 
            // pregnant_label
            // 
            this.pregnant_label.AutoSize = true;
            this.pregnant_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pregnant_label.Location = new System.Drawing.Point(3, 4);
            this.pregnant_label.Name = "pregnant_label";
            this.pregnant_label.Size = new System.Drawing.Size(71, 18);
            this.pregnant_label.TabIndex = 34;
            this.pregnant_label.Text = "Pregnant:";
            // 
            // txtBoxPatientID
            // 
            this.txtBoxPatientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPatientID.Location = new System.Drawing.Point(10, 34);
            this.txtBoxPatientID.Name = "txtBoxPatientID";
            this.txtBoxPatientID.Size = new System.Drawing.Size(200, 24);
            this.txtBoxPatientID.TabIndex = 0;
            // 
            // txtBoxFN
            // 
            this.txtBoxFN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFN.Location = new System.Drawing.Point(104, 94);
            this.txtBoxFN.Name = "txtBoxFN";
            this.txtBoxFN.Size = new System.Drawing.Size(135, 24);
            this.txtBoxFN.TabIndex = 1;
            // 
            // txtBoxLN
            // 
            this.txtBoxLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLN.Location = new System.Drawing.Point(104, 127);
            this.txtBoxLN.Name = "txtBoxLN";
            this.txtBoxLN.Size = new System.Drawing.Size(135, 24);
            this.txtBoxLN.TabIndex = 2;
            // 
            // txtBoxMI
            // 
            this.txtBoxMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMI.Location = new System.Drawing.Point(310, 94);
            this.txtBoxMI.Name = "txtBoxMI";
            this.txtBoxMI.Size = new System.Drawing.Size(56, 24);
            this.txtBoxMI.TabIndex = 5;
            // 
            // genderRadioButtonF
            // 
            this.genderRadioButtonF.AutoSize = true;
            this.genderRadioButtonF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderRadioButtonF.Location = new System.Drawing.Point(144, 231);
            this.genderRadioButtonF.Name = "genderRadioButtonF";
            this.genderRadioButtonF.Size = new System.Drawing.Size(35, 22);
            this.genderRadioButtonF.TabIndex = 8;
            this.genderRadioButtonF.Text = "F";
            this.genderRadioButtonF.UseVisualStyleBackColor = true;
            this.genderRadioButtonF.CheckedChanged += new System.EventHandler(this.genderRadioButtonF_CheckedChanged);
            // 
            // genderRadioButtonM
            // 
            this.genderRadioButtonM.AutoSize = true;
            this.genderRadioButtonM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderRadioButtonM.Location = new System.Drawing.Point(100, 231);
            this.genderRadioButtonM.Name = "genderRadioButtonM";
            this.genderRadioButtonM.Size = new System.Drawing.Size(39, 22);
            this.genderRadioButtonM.TabIndex = 7;
            this.genderRadioButtonM.Text = "M";
            this.genderRadioButtonM.UseVisualStyleBackColor = true;
            this.genderRadioButtonM.CheckedChanged += new System.EventHandler(this.genderRadioButtonM_CheckedChanged);
            // 
            // physician_label
            // 
            this.physician_label.AutoSize = true;
            this.physician_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.physician_label.Location = new System.Drawing.Point(23, 198);
            this.physician_label.Name = "physician_label";
            this.physician_label.Size = new System.Drawing.Size(75, 18);
            this.physician_label.TabIndex = 11;
            this.physician_label.Text = "Physician:";
            // 
            // middle_label
            // 
            this.middle_label.AutoSize = true;
            this.middle_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middle_label.Location = new System.Drawing.Point(271, 97);
            this.middle_label.Name = "middle_label";
            this.middle_label.Size = new System.Drawing.Size(28, 18);
            this.middle_label.TabIndex = 9;
            this.middle_label.Text = "MI:";
            // 
            // DOB_label
            // 
            this.DOB_label.AutoSize = true;
            this.DOB_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOB_label.Location = new System.Drawing.Point(41, 164);
            this.DOB_label.Name = "DOB_label";
            this.DOB_label.Size = new System.Drawing.Size(57, 18);
            this.DOB_label.TabIndex = 8;
            this.DOB_label.Text = "D.O.B.:";
            // 
            // txtBoxPhysician
            // 
            this.txtBoxPhysician.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPhysician.Location = new System.Drawing.Point(104, 195);
            this.txtBoxPhysician.Name = "txtBoxPhysician";
            this.txtBoxPhysician.Size = new System.Drawing.Size(200, 24);
            this.txtBoxPhysician.TabIndex = 4;
            // 
            // gender_label
            // 
            this.gender_label.AutoSize = true;
            this.gender_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender_label.Location = new System.Drawing.Point(27, 233);
            this.gender_label.Name = "gender_label";
            this.gender_label.Size = new System.Drawing.Size(61, 18);
            this.gender_label.TabIndex = 5;
            this.gender_label.Text = "Gender:";
            // 
            // fname_label
            // 
            this.fname_label.AutoSize = true;
            this.fname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname_label.Location = new System.Drawing.Point(20, 97);
            this.fname_label.Name = "fname_label";
            this.fname_label.Size = new System.Drawing.Size(78, 18);
            this.fname_label.TabIndex = 4;
            this.fname_label.Text = "Firstname:";
            // 
            // lname_label
            // 
            this.lname_label.AutoSize = true;
            this.lname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname_label.ForeColor = System.Drawing.Color.Red;
            this.lname_label.Location = new System.Drawing.Point(21, 130);
            this.lname_label.Name = "lname_label";
            this.lname_label.Size = new System.Drawing.Size(77, 18);
            this.lname_label.TabIndex = 3;
            this.lname_label.Text = "Lastname:";
            // 
            // pID_label
            // 
            this.pID_label.AutoSize = true;
            this.pID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pID_label.ForeColor = System.Drawing.Color.Red;
            this.pID_label.Location = new System.Drawing.Point(11, 14);
            this.pID_label.Name = "pID_label";
            this.pID_label.Size = new System.Drawing.Size(75, 18);
            this.pID_label.TabIndex = 0;
            this.pID_label.Text = "Patient ID:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.selectedMed_panel);
            this.tabPage2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(413, 389);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Medication";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // selectedMed_panel
            // 
            this.selectedMed_panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.selectedMed_panel.Controls.Add(this.selectOne_label);
            this.selectedMed_panel.Controls.Add(this.radioButtonTrade);
            this.selectedMed_panel.Controls.Add(this.radioButtonGeneric);
            this.selectedMed_panel.Controls.Add(this.txtBoxUOM);
            this.selectedMed_panel.Controls.Add(this.uom_label);
            this.selectedMed_panel.Controls.Add(this.btnGenerateMedBC);
            this.selectedMed_panel.Controls.Add(this.txtBoxMedID);
            this.selectedMed_panel.Controls.Add(this.txtBoxTrade);
            this.selectedMed_panel.Controls.Add(this.txtBoxGeneric);
            this.selectedMed_panel.Controls.Add(this.txtBoxDose);
            this.selectedMed_panel.Controls.Add(this.dose_label);
            this.selectedMed_panel.Controls.Add(this.Generic_label);
            this.selectedMed_panel.Controls.Add(this.trade_label);
            this.selectedMed_panel.Controls.Add(this.medID_label);
            this.selectedMed_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedMed_panel.Location = new System.Drawing.Point(3, 3);
            this.selectedMed_panel.Name = "selectedMed_panel";
            this.selectedMed_panel.Size = new System.Drawing.Size(407, 383);
            this.selectedMed_panel.TabIndex = 3;
            // 
            // selectOne_label
            // 
            this.selectOne_label.AutoSize = true;
            this.selectOne_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectOne_label.ForeColor = System.Drawing.Color.Red;
            this.selectOne_label.Location = new System.Drawing.Point(11, 95);
            this.selectOne_label.Name = "selectOne_label";
            this.selectOne_label.Size = new System.Drawing.Size(85, 18);
            this.selectOne_label.TabIndex = 40;
            this.selectOne_label.Text = "Select One:";
            // 
            // radioButtonTrade
            // 
            this.radioButtonTrade.AutoSize = true;
            this.radioButtonTrade.Checked = true;
            this.radioButtonTrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTrade.Location = new System.Drawing.Point(119, 95);
            this.radioButtonTrade.Name = "radioButtonTrade";
            this.radioButtonTrade.Size = new System.Drawing.Size(104, 22);
            this.radioButtonTrade.TabIndex = 1;
            this.radioButtonTrade.TabStop = true;
            this.radioButtonTrade.Text = "TradeName";
            this.radioButtonTrade.UseVisualStyleBackColor = true;
            // 
            // radioButtonGeneric
            // 
            this.radioButtonGeneric.AutoSize = true;
            this.radioButtonGeneric.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonGeneric.Location = new System.Drawing.Point(250, 95);
            this.radioButtonGeneric.Name = "radioButtonGeneric";
            this.radioButtonGeneric.Size = new System.Drawing.Size(118, 22);
            this.radioButtonGeneric.TabIndex = 2;
            this.radioButtonGeneric.Text = "GenericName";
            this.radioButtonGeneric.UseVisualStyleBackColor = true;
            // 
            // txtBoxUOM
            // 
            this.txtBoxUOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUOM.Location = new System.Drawing.Point(271, 190);
            this.txtBoxUOM.Name = "txtBoxUOM";
            this.txtBoxUOM.Size = new System.Drawing.Size(122, 24);
            this.txtBoxUOM.TabIndex = 6;
            // 
            // uom_label
            // 
            this.uom_label.AutoSize = true;
            this.uom_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uom_label.Location = new System.Drawing.Point(216, 190);
            this.uom_label.Name = "uom_label";
            this.uom_label.Size = new System.Drawing.Size(48, 18);
            this.uom_label.TabIndex = 36;
            this.uom_label.Text = "UOM:";
            // 
            // btnGenerateMedBC
            // 
            this.btnGenerateMedBC.BackColor = System.Drawing.Color.DarkBlue;
            this.btnGenerateMedBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateMedBC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGenerateMedBC.Location = new System.Drawing.Point(9, 345);
            this.btnGenerateMedBC.Name = "btnGenerateMedBC";
            this.btnGenerateMedBC.Size = new System.Drawing.Size(388, 31);
            this.btnGenerateMedBC.TabIndex = 7;
            this.btnGenerateMedBC.Text = "Generate Barcode";
            this.btnGenerateMedBC.UseVisualStyleBackColor = false;
            this.btnGenerateMedBC.Click += new System.EventHandler(this.btnGenerateMBC_Click);
            // 
            // txtBoxMedID
            // 
            this.txtBoxMedID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMedID.Location = new System.Drawing.Point(10, 34);
            this.txtBoxMedID.Name = "txtBoxMedID";
            this.txtBoxMedID.Size = new System.Drawing.Size(200, 24);
            this.txtBoxMedID.TabIndex = 0;
            // 
            // txtBoxTrade
            // 
            this.txtBoxTrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTrade.Location = new System.Drawing.Point(88, 124);
            this.txtBoxTrade.Name = "txtBoxTrade";
            this.txtBoxTrade.Size = new System.Drawing.Size(305, 24);
            this.txtBoxTrade.TabIndex = 3;
            // 
            // txtBoxGeneric
            // 
            this.txtBoxGeneric.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxGeneric.Location = new System.Drawing.Point(88, 157);
            this.txtBoxGeneric.Name = "txtBoxGeneric";
            this.txtBoxGeneric.Size = new System.Drawing.Size(305, 24);
            this.txtBoxGeneric.TabIndex = 4;
            // 
            // txtBoxDose
            // 
            this.txtBoxDose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDose.Location = new System.Drawing.Point(88, 190);
            this.txtBoxDose.Name = "txtBoxDose";
            this.txtBoxDose.Size = new System.Drawing.Size(122, 24);
            this.txtBoxDose.TabIndex = 5;
            this.txtBoxDose.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxDose_KeyPress);
            // 
            // dose_label
            // 
            this.dose_label.AutoSize = true;
            this.dose_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dose_label.Location = new System.Drawing.Point(18, 193);
            this.dose_label.Name = "dose_label";
            this.dose_label.Size = new System.Drawing.Size(48, 18);
            this.dose_label.TabIndex = 8;
            this.dose_label.Text = "Dose:";
            // 
            // Generic_label
            // 
            this.Generic_label.AutoSize = true;
            this.Generic_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generic_label.ForeColor = System.Drawing.Color.Black;
            this.Generic_label.Location = new System.Drawing.Point(18, 160);
            this.Generic_label.Name = "Generic_label";
            this.Generic_label.Size = new System.Drawing.Size(64, 18);
            this.Generic_label.TabIndex = 4;
            this.Generic_label.Text = "Generic:";
            // 
            // trade_label
            // 
            this.trade_label.AutoSize = true;
            this.trade_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trade_label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.trade_label.Location = new System.Drawing.Point(18, 127);
            this.trade_label.Name = "trade_label";
            this.trade_label.Size = new System.Drawing.Size(50, 18);
            this.trade_label.TabIndex = 3;
            this.trade_label.Text = "Trade:";
            // 
            // medID_label
            // 
            this.medID_label.AutoSize = true;
            this.medID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medID_label.ForeColor = System.Drawing.Color.Red;
            this.medID_label.Location = new System.Drawing.Point(11, 14);
            this.medID_label.Name = "medID_label";
            this.medID_label.Size = new System.Drawing.Size(102, 18);
            this.medID_label.TabIndex = 0;
            this.medID_label.Text = "Medication ID:";
            // 
            // BarcodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 502);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.preview_panel);
            this.Controls.Add(this.function_panel);
            this.Controls.Add(this.top_panel);
            this.Name = "BarcodeForm";
            this.Text = "MedSCAN - ADMIN";
            this.Load += new System.EventHandler(this.BarcodeForm_Load);
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            this.function_panel.ResumeLayout(false);
            this.preview_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.selectedPatient_panel.ResumeLayout(false);
            this.selectedPatient_panel.PerformLayout();
            this.preg_panel.ResumeLayout(false);
            this.preg_panel.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.selectedMed_panel.ResumeLayout(false);
            this.selectedMed_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Label bcDsgn_label;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel function_panel;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel preview_panel;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PictureBox previewPictureBox;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel selectedPatient_panel;
        private System.Windows.Forms.Label hospitalName_label;
        private System.Windows.Forms.TextBox txtBoxLocation;
        private System.Windows.Forms.Button btnGeneratePatientBC;
        private System.Windows.Forms.Panel preg_panel;
        private System.Windows.Forms.RadioButton pregRadioButtonY;
        private System.Windows.Forms.RadioButton pregRadioButtonN;
        private System.Windows.Forms.Label pregnant_label;
        private System.Windows.Forms.TextBox txtBoxPatientID;
        private System.Windows.Forms.TextBox txtBoxFN;
        private System.Windows.Forms.TextBox txtBoxLN;
        private System.Windows.Forms.TextBox txtBoxMI;
        private System.Windows.Forms.RadioButton genderRadioButtonF;
        private System.Windows.Forms.RadioButton genderRadioButtonM;
        private System.Windows.Forms.Label physician_label;
        private System.Windows.Forms.Label middle_label;
        private System.Windows.Forms.Label DOB_label;
        private System.Windows.Forms.TextBox txtBoxPhysician;
        private System.Windows.Forms.Label gender_label;
        private System.Windows.Forms.Label fname_label;
        private System.Windows.Forms.Label lname_label;
        private System.Windows.Forms.Label pID_label;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel selectedMed_panel;
        private System.Windows.Forms.Button btnGenerateMedBC;
        private System.Windows.Forms.TextBox txtBoxMedID;
        private System.Windows.Forms.TextBox txtBoxTrade;
        private System.Windows.Forms.TextBox txtBoxGeneric;
        private System.Windows.Forms.TextBox txtBoxDose;
        private System.Windows.Forms.Label dose_label;
        private System.Windows.Forms.Label Generic_label;
        private System.Windows.Forms.Label trade_label;
        private System.Windows.Forms.Label medID_label;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txtBoxAge;
        private System.Windows.Forms.Label age_label;
        private System.Windows.Forms.TextBox txtBoxDOB;
        private System.Windows.Forms.TextBox txtBoxUOM;
        private System.Windows.Forms.Label uom_label;
        private System.Windows.Forms.Label selectOne_label;
        private System.Windows.Forms.RadioButton radioButtonTrade;
        private System.Windows.Forms.RadioButton radioButtonGeneric;
    }
}
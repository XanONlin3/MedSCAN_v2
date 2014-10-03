namespace MedSCAN.Boundary
{
    partial class PatientMedicationForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientMedicationForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.medID_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MedicationsDGV = new System.Windows.Forms.DataGridView();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.medications_panel = new System.Windows.Forms.Panel();
            this.timeGiven_label = new System.Windows.Forms.Label();
            this.txtBoxTimeGiven = new System.Windows.Forms.TextBox();
            this.ckBoxMarkAsGiven = new System.Windows.Forms.CheckBox();
            this.form_label = new System.Windows.Forms.Label();
            this.txtBoxForm = new System.Windows.Forms.TextBox();
            this.notes_label = new System.Windows.Forms.Label();
            this.UOM_label = new System.Windows.Forms.Label();
            this.txtBoxDrugName = new System.Windows.Forms.TextBox();
            this.txtBoxDose = new System.Windows.Forms.TextBox();
            this.txtBoxUOM = new System.Windows.Forms.TextBox();
            this.ScenarioMsg_label = new System.Windows.Forms.Label();
            this.txtBoxRoute = new System.Windows.Forms.TextBox();
            this.txtBoxFreq = new System.Windows.Forms.TextBox();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.time_label = new System.Windows.Forms.Label();
            this.checkBoxTriggerFlag = new System.Windows.Forms.CheckBox();
            this.freq_label = new System.Windows.Forms.Label();
            this.txtBoxNotes = new System.Windows.Forms.TextBox();
            this.route_label = new System.Windows.Forms.Label();
            this.txtBoxScenarioMsg = new System.Windows.Forms.TextBox();
            this.dose_label = new System.Windows.Forms.Label();
            this.drugName_label = new System.Windows.Forms.Label();
            this.medType_label = new System.Windows.Forms.Label();
            this.comboBoxMedType = new System.Windows.Forms.ComboBox();
            this.patient_panel = new System.Windows.Forms.Panel();
            this.txtBoxScenarioTime = new System.Windows.Forms.TextBox();
            this.ScenarioTime_label = new System.Windows.Forms.Label();
            this.patientName_label = new System.Windows.Forms.Label();
            this.txtBoxPatientID = new System.Windows.Forms.TextBox();
            this.txtBoxPatientName = new System.Windows.Forms.TextBox();
            this.pID_label = new System.Windows.Forms.Label();
            this.function_panel = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnFunction = new System.Windows.Forms.Button();
            this.top_panel = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.patientsMeds_label = new System.Windows.Forms.Label();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtBoxMedID = new System.Windows.Forms.TextBox();
            this.errorProviderMedID = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MedicationsDGV)).BeginInit();
            this.medications_panel.SuspendLayout();
            this.patient_panel.SuspendLayout();
            this.function_panel.SuspendLayout();
            this.top_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMedID)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.Location = new System.Drawing.Point(839, 148);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(24, 24);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // medID_label
            // 
            this.medID_label.AutoSize = true;
            this.medID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medID_label.ForeColor = System.Drawing.Color.Red;
            this.medID_label.Location = new System.Drawing.Point(49, 151);
            this.medID_label.Name = "medID_label";
            this.medID_label.Size = new System.Drawing.Size(111, 20);
            this.medID_label.TabIndex = 34;
            this.medID_label.Text = "Medication ID:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MedicationsDGV);
            this.panel1.Location = new System.Drawing.Point(483, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 319);
            this.panel1.TabIndex = 32;
            // 
            // MedicationsDGV
            // 
            this.MedicationsDGV.AllowUserToAddRows = false;
            this.MedicationsDGV.AllowUserToDeleteRows = false;
            this.MedicationsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.MedicationsDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MedicationsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MedicationsDGV.DefaultCellStyle = dataGridViewCellStyle1;
            this.MedicationsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MedicationsDGV.Location = new System.Drawing.Point(0, 0);
            this.MedicationsDGV.Name = "MedicationsDGV";
            this.MedicationsDGV.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MedicationsDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.MedicationsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MedicationsDGV.Size = new System.Drawing.Size(388, 319);
            this.MedicationsDGV.TabIndex = 1;
            this.MedicationsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MedicationsDGV_CellContentClick);
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.BackColor = System.Drawing.Color.Red;
            this.btnRemoveSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveSelected.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemoveSelected.Location = new System.Drawing.Point(483, 142);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(121, 33);
            this.btnRemoveSelected.TabIndex = 3;
            this.btnRemoveSelected.Text = "Delete Selected";
            this.btnRemoveSelected.UseVisualStyleBackColor = false;
            this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveMarked_Click);
            // 
            // medications_panel
            // 
            this.medications_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.medications_panel.Controls.Add(this.timeGiven_label);
            this.medications_panel.Controls.Add(this.txtBoxTimeGiven);
            this.medications_panel.Controls.Add(this.ckBoxMarkAsGiven);
            this.medications_panel.Controls.Add(this.form_label);
            this.medications_panel.Controls.Add(this.txtBoxForm);
            this.medications_panel.Controls.Add(this.notes_label);
            this.medications_panel.Controls.Add(this.UOM_label);
            this.medications_panel.Controls.Add(this.txtBoxDrugName);
            this.medications_panel.Controls.Add(this.txtBoxDose);
            this.medications_panel.Controls.Add(this.txtBoxUOM);
            this.medications_panel.Controls.Add(this.ScenarioMsg_label);
            this.medications_panel.Controls.Add(this.txtBoxRoute);
            this.medications_panel.Controls.Add(this.txtBoxFreq);
            this.medications_panel.Controls.Add(this.dtpTime);
            this.medications_panel.Controls.Add(this.time_label);
            this.medications_panel.Controls.Add(this.checkBoxTriggerFlag);
            this.medications_panel.Controls.Add(this.freq_label);
            this.medications_panel.Controls.Add(this.txtBoxNotes);
            this.medications_panel.Controls.Add(this.route_label);
            this.medications_panel.Controls.Add(this.txtBoxScenarioMsg);
            this.medications_panel.Controls.Add(this.dose_label);
            this.medications_panel.Controls.Add(this.drugName_label);
            this.medications_panel.Controls.Add(this.medType_label);
            this.medications_panel.Controls.Add(this.comboBoxMedType);
            this.medications_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medications_panel.Location = new System.Drawing.Point(6, 181);
            this.medications_panel.Name = "medications_panel";
            this.medications_panel.Size = new System.Drawing.Size(471, 319);
            this.medications_panel.TabIndex = 30;
            // 
            // timeGiven_label
            // 
            this.timeGiven_label.AutoSize = true;
            this.timeGiven_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeGiven_label.Location = new System.Drawing.Point(236, 195);
            this.timeGiven_label.Name = "timeGiven_label";
            this.timeGiven_label.Size = new System.Drawing.Size(87, 18);
            this.timeGiven_label.TabIndex = 68;
            this.timeGiven_label.Text = "Time Given:";
            // 
            // txtBoxTimeGiven
            // 
            this.txtBoxTimeGiven.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTimeGiven.Location = new System.Drawing.Point(331, 192);
            this.txtBoxTimeGiven.Name = "txtBoxTimeGiven";
            this.txtBoxTimeGiven.Size = new System.Drawing.Size(121, 24);
            this.txtBoxTimeGiven.TabIndex = 11;
            // 
            // ckBoxMarkAsGiven
            // 
            this.ckBoxMarkAsGiven.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckBoxMarkAsGiven.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ckBoxMarkAsGiven.Location = new System.Drawing.Point(9, 192);
            this.ckBoxMarkAsGiven.Name = "ckBoxMarkAsGiven";
            this.ckBoxMarkAsGiven.Size = new System.Drawing.Size(221, 24);
            this.ckBoxMarkAsGiven.TabIndex = 10;
            this.ckBoxMarkAsGiven.Text = "Mark Medication as given?";
            this.ckBoxMarkAsGiven.UseVisualStyleBackColor = true;
            this.ckBoxMarkAsGiven.CheckedChanged += new System.EventHandler(this.ckBoxMarkAsGiven_CheckedChanged);
            // 
            // form_label
            // 
            this.form_label.AutoSize = true;
            this.form_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form_label.Location = new System.Drawing.Point(268, 21);
            this.form_label.Name = "form_label";
            this.form_label.Size = new System.Drawing.Size(48, 18);
            this.form_label.TabIndex = 64;
            this.form_label.Text = "Form:";
            // 
            // txtBoxForm
            // 
            this.txtBoxForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxForm.Location = new System.Drawing.Point(331, 17);
            this.txtBoxForm.Name = "txtBoxForm";
            this.txtBoxForm.Size = new System.Drawing.Size(121, 24);
            this.txtBoxForm.TabIndex = 1;
            // 
            // notes_label
            // 
            this.notes_label.AutoSize = true;
            this.notes_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notes_label.Location = new System.Drawing.Point(7, 227);
            this.notes_label.Name = "notes_label";
            this.notes_label.Size = new System.Drawing.Size(187, 18);
            this.notes_label.TabIndex = 62;
            this.notes_label.Text = "Medication Last Given Log:";
            // 
            // UOM_label
            // 
            this.UOM_label.AutoSize = true;
            this.UOM_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UOM_label.Location = new System.Drawing.Point(158, 160);
            this.UOM_label.Name = "UOM_label";
            this.UOM_label.Size = new System.Drawing.Size(48, 18);
            this.UOM_label.TabIndex = 22;
            this.UOM_label.Text = "UOM:";
            // 
            // txtBoxDrugName
            // 
            this.txtBoxDrugName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDrugName.Location = new System.Drawing.Point(110, 87);
            this.txtBoxDrugName.Name = "txtBoxDrugName";
            this.txtBoxDrugName.Size = new System.Drawing.Size(342, 24);
            this.txtBoxDrugName.TabIndex = 4;
            // 
            // txtBoxDose
            // 
            this.txtBoxDose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDose.Location = new System.Drawing.Point(72, 157);
            this.txtBoxDose.Name = "txtBoxDose";
            this.txtBoxDose.Size = new System.Drawing.Size(80, 24);
            this.txtBoxDose.TabIndex = 7;
            this.txtBoxDose.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxDose_KeyPress);
            // 
            // txtBoxUOM
            // 
            this.txtBoxUOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUOM.Location = new System.Drawing.Point(208, 157);
            this.txtBoxUOM.Name = "txtBoxUOM";
            this.txtBoxUOM.Size = new System.Drawing.Size(119, 24);
            this.txtBoxUOM.TabIndex = 8;
            // 
            // ScenarioMsg_label
            // 
            this.ScenarioMsg_label.AutoSize = true;
            this.ScenarioMsg_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScenarioMsg_label.Location = new System.Drawing.Point(145, 55);
            this.ScenarioMsg_label.Name = "ScenarioMsg_label";
            this.ScenarioMsg_label.Size = new System.Drawing.Size(41, 18);
            this.ScenarioMsg_label.TabIndex = 19;
            this.ScenarioMsg_label.Text = "Msg:";
            // 
            // txtBoxRoute
            // 
            this.txtBoxRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxRoute.Location = new System.Drawing.Point(331, 122);
            this.txtBoxRoute.Name = "txtBoxRoute";
            this.txtBoxRoute.Size = new System.Drawing.Size(121, 24);
            this.txtBoxRoute.TabIndex = 6;
            // 
            // txtBoxFreq
            // 
            this.txtBoxFreq.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFreq.Location = new System.Drawing.Point(110, 122);
            this.txtBoxFreq.Name = "txtBoxFreq";
            this.txtBoxFreq.Size = new System.Drawing.Size(153, 24);
            this.txtBoxFreq.TabIndex = 5;
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "";
            this.dtpTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(388, 157);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(64, 24);
            this.dtpTime.TabIndex = 9;
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_label.Location = new System.Drawing.Point(337, 160);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(45, 18);
            this.time_label.TabIndex = 13;
            this.time_label.Text = "Time:";
            // 
            // checkBoxTriggerFlag
            // 
            this.checkBoxTriggerFlag.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTriggerFlag.ForeColor = System.Drawing.Color.Red;
            this.checkBoxTriggerFlag.Location = new System.Drawing.Point(10, 52);
            this.checkBoxTriggerFlag.Name = "checkBoxTriggerFlag";
            this.checkBoxTriggerFlag.Size = new System.Drawing.Size(129, 24);
            this.checkBoxTriggerFlag.TabIndex = 2;
            this.checkBoxTriggerFlag.Text = "Scenario Flag";
            this.checkBoxTriggerFlag.UseVisualStyleBackColor = true;
            this.checkBoxTriggerFlag.CheckedChanged += new System.EventHandler(this.checkBoxTriggerFlag_CheckedChanged);
            // 
            // freq_label
            // 
            this.freq_label.AutoSize = true;
            this.freq_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.freq_label.Location = new System.Drawing.Point(9, 128);
            this.freq_label.Name = "freq_label";
            this.freq_label.Size = new System.Drawing.Size(81, 18);
            this.freq_label.TabIndex = 12;
            this.freq_label.Text = "Frequency:";
            // 
            // txtBoxNotes
            // 
            this.txtBoxNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNotes.Location = new System.Drawing.Point(9, 250);
            this.txtBoxNotes.Multiline = true;
            this.txtBoxNotes.Name = "txtBoxNotes";
            this.txtBoxNotes.Size = new System.Drawing.Size(443, 57);
            this.txtBoxNotes.TabIndex = 12;
            // 
            // route_label
            // 
            this.route_label.AutoSize = true;
            this.route_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.route_label.Location = new System.Drawing.Point(269, 128);
            this.route_label.Name = "route_label";
            this.route_label.Size = new System.Drawing.Size(52, 18);
            this.route_label.TabIndex = 11;
            this.route_label.Text = "Route:";
            // 
            // txtBoxScenarioMsg
            // 
            this.txtBoxScenarioMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxScenarioMsg.Location = new System.Drawing.Point(193, 52);
            this.txtBoxScenarioMsg.Name = "txtBoxScenarioMsg";
            this.txtBoxScenarioMsg.Size = new System.Drawing.Size(259, 24);
            this.txtBoxScenarioMsg.TabIndex = 3;
            // 
            // dose_label
            // 
            this.dose_label.AutoSize = true;
            this.dose_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dose_label.Location = new System.Drawing.Point(9, 160);
            this.dose_label.Name = "dose_label";
            this.dose_label.Size = new System.Drawing.Size(48, 18);
            this.dose_label.TabIndex = 10;
            this.dose_label.Text = "Dose:";
            // 
            // drugName_label
            // 
            this.drugName_label.AutoSize = true;
            this.drugName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drugName_label.Location = new System.Drawing.Point(9, 92);
            this.drugName_label.Name = "drugName_label";
            this.drugName_label.Size = new System.Drawing.Size(88, 18);
            this.drugName_label.TabIndex = 9;
            this.drugName_label.Text = "Drug Name:";
            // 
            // medType_label
            // 
            this.medType_label.AutoSize = true;
            this.medType_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medType_label.Location = new System.Drawing.Point(15, 21);
            this.medType_label.Name = "medType_label";
            this.medType_label.Size = new System.Drawing.Size(77, 18);
            this.medType_label.TabIndex = 3;
            this.medType_label.Text = "Med Type:";
            // 
            // comboBoxMedType
            // 
            this.comboBoxMedType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMedType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxMedType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMedType.FormattingEnabled = true;
            this.comboBoxMedType.Items.AddRange(new object[] {
            "1TD",
            "Scheduled",
            "PRN",
            "IV Fluid"});
            this.comboBoxMedType.Location = new System.Drawing.Point(103, 17);
            this.comboBoxMedType.Name = "comboBoxMedType";
            this.comboBoxMedType.Size = new System.Drawing.Size(140, 26);
            this.comboBoxMedType.TabIndex = 0;
            // 
            // patient_panel
            // 
            this.patient_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.patient_panel.Controls.Add(this.txtBoxScenarioTime);
            this.patient_panel.Controls.Add(this.ScenarioTime_label);
            this.patient_panel.Controls.Add(this.patientName_label);
            this.patient_panel.Controls.Add(this.txtBoxPatientID);
            this.patient_panel.Controls.Add(this.txtBoxPatientName);
            this.patient_panel.Controls.Add(this.pID_label);
            this.patient_panel.Location = new System.Drawing.Point(10, 77);
            this.patient_panel.Name = "patient_panel";
            this.patient_panel.Size = new System.Drawing.Size(467, 59);
            this.patient_panel.TabIndex = 29;
            // 
            // txtBoxScenarioTime
            // 
            this.txtBoxScenarioTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxScenarioTime.Location = new System.Drawing.Point(346, 27);
            this.txtBoxScenarioTime.Name = "txtBoxScenarioTime";
            this.txtBoxScenarioTime.ReadOnly = true;
            this.txtBoxScenarioTime.Size = new System.Drawing.Size(112, 26);
            this.txtBoxScenarioTime.TabIndex = 39;
            // 
            // ScenarioTime_label
            // 
            this.ScenarioTime_label.AutoSize = true;
            this.ScenarioTime_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScenarioTime_label.ForeColor = System.Drawing.Color.Black;
            this.ScenarioTime_label.Location = new System.Drawing.Point(343, 7);
            this.ScenarioTime_label.Name = "ScenarioTime_label";
            this.ScenarioTime_label.Size = new System.Drawing.Size(114, 20);
            this.ScenarioTime_label.TabIndex = 38;
            this.ScenarioTime_label.Text = "Scenario Time:";
            // 
            // patientName_label
            // 
            this.patientName_label.AutoSize = true;
            this.patientName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientName_label.ForeColor = System.Drawing.Color.Red;
            this.patientName_label.Location = new System.Drawing.Point(131, 7);
            this.patientName_label.Name = "patientName_label";
            this.patientName_label.Size = new System.Drawing.Size(109, 20);
            this.patientName_label.TabIndex = 28;
            this.patientName_label.Text = "Patient Name:";
            // 
            // txtBoxPatientID
            // 
            this.txtBoxPatientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPatientID.Location = new System.Drawing.Point(6, 27);
            this.txtBoxPatientID.Name = "txtBoxPatientID";
            this.txtBoxPatientID.ReadOnly = true;
            this.txtBoxPatientID.Size = new System.Drawing.Size(103, 26);
            this.txtBoxPatientID.TabIndex = 37;
            // 
            // txtBoxPatientName
            // 
            this.txtBoxPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPatientName.Location = new System.Drawing.Point(134, 27);
            this.txtBoxPatientName.Name = "txtBoxPatientName";
            this.txtBoxPatientName.ReadOnly = true;
            this.txtBoxPatientName.Size = new System.Drawing.Size(190, 26);
            this.txtBoxPatientName.TabIndex = 27;
            // 
            // pID_label
            // 
            this.pID_label.AutoSize = true;
            this.pID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pID_label.ForeColor = System.Drawing.Color.Red;
            this.pID_label.Location = new System.Drawing.Point(3, 7);
            this.pID_label.Name = "pID_label";
            this.pID_label.Size = new System.Drawing.Size(84, 20);
            this.pID_label.TabIndex = 20;
            this.pID_label.Text = "Patient ID:";
            // 
            // function_panel
            // 
            this.function_panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.function_panel.Controls.Add(this.btnPrint);
            this.function_panel.Controls.Add(this.btnFunction);
            this.function_panel.Location = new System.Drawing.Point(483, 77);
            this.function_panel.Name = "function_panel";
            this.function_panel.Size = new System.Drawing.Size(388, 59);
            this.function_panel.TabIndex = 28;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Purple;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrint.Location = new System.Drawing.Point(202, 13);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(166, 33);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnFunction
            // 
            this.btnFunction.BackColor = System.Drawing.Color.Green;
            this.btnFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFunction.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFunction.Location = new System.Drawing.Point(21, 13);
            this.btnFunction.Name = "btnFunction";
            this.btnFunction.Size = new System.Drawing.Size(166, 33);
            this.btnFunction.TabIndex = 0;
            this.btnFunction.Text = "SAVE";
            this.btnFunction.UseVisualStyleBackColor = false;
            this.btnFunction.Click += new System.EventHandler(this.btnFunction_Click);
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.top_panel.Controls.Add(this.btnSearch);
            this.top_panel.Controls.Add(this.patientsMeds_label);
            this.top_panel.Controls.Add(this.txtBoxSearch);
            this.top_panel.Controls.Add(this.btnClose);
            this.top_panel.Location = new System.Drawing.Point(0, 2);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(873, 69);
            this.top_panel.TabIndex = 27;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.Location = new System.Drawing.Point(727, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(23, 24);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // patientsMeds_label
            // 
            this.patientsMeds_label.AutoSize = true;
            this.patientsMeds_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientsMeds_label.Location = new System.Drawing.Point(3, 3);
            this.patientsMeds_label.Name = "patientsMeds_label";
            this.patientsMeds_label.Size = new System.Drawing.Size(318, 37);
            this.patientsMeds_label.TabIndex = 2;
            this.patientsMeds_label.Text = "Patient\'s Medications";
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearch.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtBoxSearch.Location = new System.Drawing.Point(504, 24);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(204, 24);
            this.txtBoxSearch.TabIndex = 0;
            this.txtBoxSearch.Text = "Search Meds";
            this.txtBoxSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged);
            this.txtBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxSearch_KeyPress);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Firebrick;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.Location = new System.Drawing.Point(769, 22);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(78, 28);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtBoxMedID
            // 
            this.txtBoxMedID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMedID.Location = new System.Drawing.Point(167, 148);
            this.txtBoxMedID.Name = "txtBoxMedID";
            this.txtBoxMedID.Size = new System.Drawing.Size(169, 26);
            this.txtBoxMedID.TabIndex = 0;
            this.txtBoxMedID.TextChanged += new System.EventHandler(this.txtBoxMedID_TextChanged);
            // 
            // errorProviderMedID
            // 
            this.errorProviderMedID.ContainerControl = this;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Blue;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(357, 142);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 33);
            this.btnAdd.TabIndex = 35;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnClear.Location = new System.Drawing.Point(6, 144);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(30, 30);
            this.btnClear.TabIndex = 2;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // PatientMedicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 502);
            this.ControlBox = false;
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBoxMedID);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.medID_label);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRemoveSelected);
            this.Controls.Add(this.medications_panel);
            this.Controls.Add(this.patient_panel);
            this.Controls.Add(this.function_panel);
            this.Controls.Add(this.top_panel);
            this.Name = "PatientMedicationForm";
            this.Text = "MedSCAN - ADMIN - Patient\'s Medications";
            this.Load += new System.EventHandler(this.PatientMedicationForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MedicationsDGV)).EndInit();
            this.medications_panel.ResumeLayout(false);
            this.medications_panel.PerformLayout();
            this.patient_panel.ResumeLayout(false);
            this.patient_panel.PerformLayout();
            this.function_panel.ResumeLayout(false);
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMedID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label medID_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView MedicationsDGV;
        private System.Windows.Forms.Button btnRemoveSelected;
        private System.Windows.Forms.Panel medications_panel;
        private System.Windows.Forms.Label ScenarioMsg_label;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Label freq_label;
        private System.Windows.Forms.Label route_label;
        private System.Windows.Forms.Label dose_label;
        private System.Windows.Forms.Label drugName_label;
        private System.Windows.Forms.Label medType_label;
        private System.Windows.Forms.Panel patient_panel;
        private System.Windows.Forms.Label patientName_label;
        private System.Windows.Forms.TextBox txtBoxPatientName;
        private System.Windows.Forms.Label pID_label;
        private System.Windows.Forms.Panel function_panel;
        private System.Windows.Forms.Button btnFunction;
        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label patientsMeds_label;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label UOM_label;
        private System.Windows.Forms.TextBox txtBoxDrugName;
        private System.Windows.Forms.TextBox txtBoxDose;
        private System.Windows.Forms.TextBox txtBoxUOM;
        private System.Windows.Forms.TextBox txtBoxRoute;
        private System.Windows.Forms.TextBox txtBoxFreq;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.CheckBox checkBoxTriggerFlag;
        private System.Windows.Forms.TextBox txtBoxNotes;
        private System.Windows.Forms.TextBox txtBoxScenarioMsg;
        private System.Windows.Forms.ComboBox comboBoxMedType;
        private System.Windows.Forms.TextBox txtBoxPatientID;
        private System.Windows.Forms.TextBox txtBoxMedID;
        private System.Windows.Forms.Label notes_label;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ErrorProvider errorProviderMedID;
        private System.Windows.Forms.Label form_label;
        private System.Windows.Forms.TextBox txtBoxForm;
        private System.Windows.Forms.TextBox txtBoxScenarioTime;
        private System.Windows.Forms.Label ScenarioTime_label;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox ckBoxMarkAsGiven;
        private System.Windows.Forms.Label timeGiven_label;
        private System.Windows.Forms.TextBox txtBoxTimeGiven;
    }
}
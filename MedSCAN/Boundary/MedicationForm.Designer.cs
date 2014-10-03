namespace MedSCAN.Boundary
{
    partial class MedicationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicationForm));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.remove_radioButton = new System.Windows.Forms.RadioButton();
            this.edit_radioButton = new System.Windows.Forms.RadioButton();
            this.add_radioButton = new System.Windows.Forms.RadioButton();
            this.view_radioButton = new System.Windows.Forms.RadioButton();
            this.patientList_panel = new System.Windows.Forms.Panel();
            this.MedicationsDGV = new System.Windows.Forms.DataGridView();
            this.function_panel = new System.Windows.Forms.Panel();
            this.btnFunction = new System.Windows.Forms.Button();
            this.selectedMed_panel = new System.Windows.Forms.Panel();
            this.pregRisk_label = new System.Windows.Forms.Label();
            this.txtBoxMedID = new System.Windows.Forms.TextBox();
            this.txtBoxClassification = new System.Windows.Forms.TextBox();
            this.txtBoxTrade = new System.Windows.Forms.TextBox();
            this.txtBoxGeneric = new System.Windows.Forms.TextBox();
            this.txtBoxPseudo = new System.Windows.Forms.TextBox();
            this.txtBoxUnitAmt = new System.Windows.Forms.TextBox();
            this.comboBoxPRC = new System.Windows.Forms.ComboBox();
            this.txtBoxForm = new System.Windows.Forms.TextBox();
            this.txtBoxStr = new System.Windows.Forms.TextBox();
            this.txtBoxNotes = new System.Windows.Forms.TextBox();
            this.strength_label = new System.Windows.Forms.Label();
            this.txtBoxUOM = new System.Windows.Forms.TextBox();
            this.UOM_label = new System.Windows.Forms.Label();
            this.unitAmount_label = new System.Windows.Forms.Label();
            this.form_label = new System.Windows.Forms.Label();
            this.pseudo_label = new System.Windows.Forms.Label();
            this.notes_label = new System.Windows.Forms.Label();
            this.Generic_label = new System.Windows.Forms.Label();
            this.trade_label = new System.Windows.Forms.Label();
            this.classification_label = new System.Windows.Forms.Label();
            this.medID_label = new System.Windows.Forms.Label();
            this.top_panel = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.medications_label = new System.Windows.Forms.Label();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.patientList_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MedicationsDGV)).BeginInit();
            this.function_panel.SuspendLayout();
            this.selectedMed_panel.SuspendLayout();
            this.top_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.Location = new System.Drawing.Point(352, 77);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(24, 24);
            this.btnRefresh.TabIndex = 23;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // remove_radioButton
            // 
            this.remove_radioButton.AutoSize = true;
            this.remove_radioButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_radioButton.Location = new System.Drawing.Point(240, 78);
            this.remove_radioButton.Name = "remove_radioButton";
            this.remove_radioButton.Size = new System.Drawing.Size(97, 22);
            this.remove_radioButton.TabIndex = 22;
            this.remove_radioButton.Text = "REMOVE";
            this.remove_radioButton.UseVisualStyleBackColor = true;
            this.remove_radioButton.CheckedChanged += new System.EventHandler(this.remove_radioButton_CheckedChanged);
            // 
            // edit_radioButton
            // 
            this.edit_radioButton.AutoSize = true;
            this.edit_radioButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_radioButton.Location = new System.Drawing.Point(170, 78);
            this.edit_radioButton.Name = "edit_radioButton";
            this.edit_radioButton.Size = new System.Drawing.Size(64, 22);
            this.edit_radioButton.TabIndex = 21;
            this.edit_radioButton.Text = "EDIT";
            this.edit_radioButton.UseVisualStyleBackColor = true;
            this.edit_radioButton.CheckedChanged += new System.EventHandler(this.edit_radioButton_CheckedChanged);
            // 
            // add_radioButton
            // 
            this.add_radioButton.AutoSize = true;
            this.add_radioButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_radioButton.Location = new System.Drawing.Point(102, 78);
            this.add_radioButton.Name = "add_radioButton";
            this.add_radioButton.Size = new System.Drawing.Size(62, 22);
            this.add_radioButton.TabIndex = 20;
            this.add_radioButton.Text = "ADD";
            this.add_radioButton.UseVisualStyleBackColor = true;
            this.add_radioButton.CheckedChanged += new System.EventHandler(this.add_radioButton_CheckedChanged);
            // 
            // view_radioButton
            // 
            this.view_radioButton.AutoSize = true;
            this.view_radioButton.Checked = true;
            this.view_radioButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_radioButton.Location = new System.Drawing.Point(28, 78);
            this.view_radioButton.Name = "view_radioButton";
            this.view_radioButton.Size = new System.Drawing.Size(68, 22);
            this.view_radioButton.TabIndex = 19;
            this.view_radioButton.TabStop = true;
            this.view_radioButton.Text = "VIEW";
            this.view_radioButton.UseVisualStyleBackColor = true;
            this.view_radioButton.CheckedChanged += new System.EventHandler(this.view_radioButton_CheckedChanged);
            // 
            // patientList_panel
            // 
            this.patientList_panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.patientList_panel.Controls.Add(this.MedicationsDGV);
            this.patientList_panel.Location = new System.Drawing.Point(434, 143);
            this.patientList_panel.Name = "patientList_panel";
            this.patientList_panel.Size = new System.Drawing.Size(344, 356);
            this.patientList_panel.TabIndex = 18;
            // 
            // MedicationsDGV
            // 
            this.MedicationsDGV.AllowUserToAddRows = false;
            this.MedicationsDGV.AllowUserToDeleteRows = false;
            this.MedicationsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MedicationsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MedicationsDGV.Location = new System.Drawing.Point(0, 0);
            this.MedicationsDGV.Name = "MedicationsDGV";
            this.MedicationsDGV.ReadOnly = true;
            this.MedicationsDGV.Size = new System.Drawing.Size(344, 356);
            this.MedicationsDGV.TabIndex = 9;
            // 
            // function_panel
            // 
            this.function_panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.function_panel.Controls.Add(this.btnFunction);
            this.function_panel.Location = new System.Drawing.Point(434, 78);
            this.function_panel.Name = "function_panel";
            this.function_panel.Size = new System.Drawing.Size(344, 59);
            this.function_panel.TabIndex = 17;
            // 
            // btnFunction
            // 
            this.btnFunction.BackColor = System.Drawing.Color.DarkViolet;
            this.btnFunction.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFunction.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFunction.Location = new System.Drawing.Point(16, 13);
            this.btnFunction.Name = "btnFunction";
            this.btnFunction.Size = new System.Drawing.Size(312, 33);
            this.btnFunction.TabIndex = 0;
            this.btnFunction.Text = "GENERATE BARCODE";
            this.btnFunction.UseVisualStyleBackColor = false;
            this.btnFunction.Click += new System.EventHandler(this.function_button_Click);
            // 
            // selectedMed_panel
            // 
            this.selectedMed_panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.selectedMed_panel.Controls.Add(this.pregRisk_label);
            this.selectedMed_panel.Controls.Add(this.txtBoxMedID);
            this.selectedMed_panel.Controls.Add(this.txtBoxClassification);
            this.selectedMed_panel.Controls.Add(this.txtBoxTrade);
            this.selectedMed_panel.Controls.Add(this.txtBoxGeneric);
            this.selectedMed_panel.Controls.Add(this.txtBoxPseudo);
            this.selectedMed_panel.Controls.Add(this.txtBoxUnitAmt);
            this.selectedMed_panel.Controls.Add(this.comboBoxPRC);
            this.selectedMed_panel.Controls.Add(this.txtBoxForm);
            this.selectedMed_panel.Controls.Add(this.txtBoxStr);
            this.selectedMed_panel.Controls.Add(this.txtBoxNotes);
            this.selectedMed_panel.Controls.Add(this.strength_label);
            this.selectedMed_panel.Controls.Add(this.txtBoxUOM);
            this.selectedMed_panel.Controls.Add(this.UOM_label);
            this.selectedMed_panel.Controls.Add(this.unitAmount_label);
            this.selectedMed_panel.Controls.Add(this.form_label);
            this.selectedMed_panel.Controls.Add(this.pseudo_label);
            this.selectedMed_panel.Controls.Add(this.notes_label);
            this.selectedMed_panel.Controls.Add(this.Generic_label);
            this.selectedMed_panel.Controls.Add(this.trade_label);
            this.selectedMed_panel.Controls.Add(this.classification_label);
            this.selectedMed_panel.Controls.Add(this.medID_label);
            this.selectedMed_panel.Location = new System.Drawing.Point(7, 106);
            this.selectedMed_panel.Name = "selectedMed_panel";
            this.selectedMed_panel.Size = new System.Drawing.Size(419, 393);
            this.selectedMed_panel.TabIndex = 16;
            // 
            // pregRisk_label
            // 
            this.pregRisk_label.AutoSize = true;
            this.pregRisk_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pregRisk_label.Location = new System.Drawing.Point(6, 93);
            this.pregRisk_label.Name = "pregRisk_label";
            this.pregRisk_label.Size = new System.Drawing.Size(74, 17);
            this.pregRisk_label.TabIndex = 35;
            this.pregRisk_label.Text = "Preg RC:";
            // 
            // txtBoxMedID
            // 
            this.txtBoxMedID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMedID.Location = new System.Drawing.Point(7, 33);
            this.txtBoxMedID.Name = "txtBoxMedID";
            this.txtBoxMedID.Size = new System.Drawing.Size(136, 25);
            this.txtBoxMedID.TabIndex = 14;
            // 
            // txtBoxClassification
            // 
            this.txtBoxClassification.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxClassification.Location = new System.Drawing.Point(243, 33);
            this.txtBoxClassification.Name = "txtBoxClassification";
            this.txtBoxClassification.Size = new System.Drawing.Size(165, 25);
            this.txtBoxClassification.TabIndex = 16;
            // 
            // txtBoxTrade
            // 
            this.txtBoxTrade.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTrade.Location = new System.Drawing.Point(82, 120);
            this.txtBoxTrade.Name = "txtBoxTrade";
            this.txtBoxTrade.Size = new System.Drawing.Size(145, 25);
            this.txtBoxTrade.TabIndex = 18;
            // 
            // txtBoxGeneric
            // 
            this.txtBoxGeneric.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxGeneric.Location = new System.Drawing.Point(82, 151);
            this.txtBoxGeneric.Name = "txtBoxGeneric";
            this.txtBoxGeneric.Size = new System.Drawing.Size(145, 25);
            this.txtBoxGeneric.TabIndex = 20;
            // 
            // txtBoxPseudo
            // 
            this.txtBoxPseudo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPseudo.Location = new System.Drawing.Point(82, 182);
            this.txtBoxPseudo.Name = "txtBoxPseudo";
            this.txtBoxPseudo.Size = new System.Drawing.Size(145, 25);
            this.txtBoxPseudo.TabIndex = 22;
            // 
            // txtBoxUnitAmt
            // 
            this.txtBoxUnitAmt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUnitAmt.Location = new System.Drawing.Point(322, 93);
            this.txtBoxUnitAmt.Name = "txtBoxUnitAmt";
            this.txtBoxUnitAmt.Size = new System.Drawing.Size(86, 25);
            this.txtBoxUnitAmt.TabIndex = 24;
            // 
            // comboBoxPRC
            // 
            this.comboBoxPRC.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPRC.FormattingEnabled = true;
            this.comboBoxPRC.Items.AddRange(new object[] {
            "N",
            "A",
            "B",
            "C",
            "D",
            "X"});
            this.comboBoxPRC.Location = new System.Drawing.Point(82, 89);
            this.comboBoxPRC.Name = "comboBoxPRC";
            this.comboBoxPRC.Size = new System.Drawing.Size(72, 25);
            this.comboBoxPRC.TabIndex = 34;
            // 
            // txtBoxForm
            // 
            this.txtBoxForm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxForm.Location = new System.Drawing.Point(322, 123);
            this.txtBoxForm.Name = "txtBoxForm";
            this.txtBoxForm.Size = new System.Drawing.Size(86, 25);
            this.txtBoxForm.TabIndex = 26;
            // 
            // txtBoxStr
            // 
            this.txtBoxStr.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxStr.Location = new System.Drawing.Point(322, 153);
            this.txtBoxStr.Name = "txtBoxStr";
            this.txtBoxStr.Size = new System.Drawing.Size(86, 25);
            this.txtBoxStr.TabIndex = 28;
            // 
            // txtBoxNotes
            // 
            this.txtBoxNotes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNotes.Location = new System.Drawing.Point(9, 287);
            this.txtBoxNotes.Multiline = true;
            this.txtBoxNotes.Name = "txtBoxNotes";
            this.txtBoxNotes.Size = new System.Drawing.Size(399, 96);
            this.txtBoxNotes.TabIndex = 32;
            // 
            // strength_label
            // 
            this.strength_label.AutoSize = true;
            this.strength_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strength_label.Location = new System.Drawing.Point(240, 156);
            this.strength_label.Name = "strength_label";
            this.strength_label.Size = new System.Drawing.Size(76, 17);
            this.strength_label.TabIndex = 26;
            this.strength_label.Text = "Strength:";
            // 
            // txtBoxUOM
            // 
            this.txtBoxUOM.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUOM.Location = new System.Drawing.Point(322, 183);
            this.txtBoxUOM.Name = "txtBoxUOM";
            this.txtBoxUOM.Size = new System.Drawing.Size(86, 25);
            this.txtBoxUOM.TabIndex = 30;
            // 
            // UOM_label
            // 
            this.UOM_label.AutoSize = true;
            this.UOM_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UOM_label.Location = new System.Drawing.Point(265, 187);
            this.UOM_label.Name = "UOM_label";
            this.UOM_label.Size = new System.Drawing.Size(48, 17);
            this.UOM_label.TabIndex = 11;
            this.UOM_label.Text = "UOM:";
            // 
            // unitAmount_label
            // 
            this.unitAmount_label.AutoSize = true;
            this.unitAmount_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitAmount_label.Location = new System.Drawing.Point(214, 93);
            this.unitAmount_label.Name = "unitAmount_label";
            this.unitAmount_label.Size = new System.Drawing.Size(102, 17);
            this.unitAmount_label.TabIndex = 10;
            this.unitAmount_label.Text = "Unit Amount:";
            // 
            // form_label
            // 
            this.form_label.AutoSize = true;
            this.form_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form_label.Location = new System.Drawing.Point(265, 125);
            this.form_label.Name = "form_label";
            this.form_label.Size = new System.Drawing.Size(51, 17);
            this.form_label.TabIndex = 9;
            this.form_label.Text = "Form:";
            // 
            // pseudo_label
            // 
            this.pseudo_label.AutoSize = true;
            this.pseudo_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pseudo_label.Location = new System.Drawing.Point(4, 187);
            this.pseudo_label.Name = "pseudo_label";
            this.pseudo_label.Size = new System.Drawing.Size(67, 17);
            this.pseudo_label.TabIndex = 8;
            this.pseudo_label.Text = "Pseudo:";
            // 
            // notes_label
            // 
            this.notes_label.AutoSize = true;
            this.notes_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notes_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.notes_label.Location = new System.Drawing.Point(6, 267);
            this.notes_label.Name = "notes_label";
            this.notes_label.Size = new System.Drawing.Size(55, 17);
            this.notes_label.TabIndex = 7;
            this.notes_label.Text = "Notes:";
            // 
            // Generic_label
            // 
            this.Generic_label.AutoSize = true;
            this.Generic_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generic_label.ForeColor = System.Drawing.Color.Red;
            this.Generic_label.Location = new System.Drawing.Point(3, 156);
            this.Generic_label.Name = "Generic_label";
            this.Generic_label.Size = new System.Drawing.Size(72, 17);
            this.Generic_label.TabIndex = 4;
            this.Generic_label.Text = "Generic:";
            // 
            // trade_label
            // 
            this.trade_label.AutoSize = true;
            this.trade_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trade_label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.trade_label.Location = new System.Drawing.Point(3, 125);
            this.trade_label.Name = "trade_label";
            this.trade_label.Size = new System.Drawing.Size(56, 17);
            this.trade_label.TabIndex = 3;
            this.trade_label.Text = "Trade:";
            // 
            // classification_label
            // 
            this.classification_label.AutoSize = true;
            this.classification_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classification_label.Location = new System.Drawing.Point(240, 14);
            this.classification_label.Name = "classification_label";
            this.classification_label.Size = new System.Drawing.Size(111, 17);
            this.classification_label.TabIndex = 2;
            this.classification_label.Text = "Classification:";
            // 
            // medID_label
            // 
            this.medID_label.AutoSize = true;
            this.medID_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medID_label.ForeColor = System.Drawing.Color.Red;
            this.medID_label.Location = new System.Drawing.Point(11, 14);
            this.medID_label.Name = "medID_label";
            this.medID_label.Size = new System.Drawing.Size(112, 17);
            this.medID_label.TabIndex = 0;
            this.medID_label.Text = "Medication ID:";
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.top_panel.Controls.Add(this.btnSearch);
            this.top_panel.Controls.Add(this.medications_label);
            this.top_panel.Controls.Add(this.txtBoxSearch);
            this.top_panel.Controls.Add(this.btnCancel);
            this.top_panel.Location = new System.Drawing.Point(1, 3);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(783, 69);
            this.top_panel.TabIndex = 15;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.Location = new System.Drawing.Point(654, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(23, 24);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // medications_label
            // 
            this.medications_label.AutoSize = true;
            this.medications_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medications_label.Location = new System.Drawing.Point(3, 3);
            this.medications_label.Name = "medications_label";
            this.medications_label.Size = new System.Drawing.Size(205, 37);
            this.medications_label.TabIndex = 2;
            this.medications_label.Text = "Medications";
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBoxSearch.Location = new System.Drawing.Point(449, 22);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(199, 25);
            this.txtBoxSearch.TabIndex = 1;
            this.txtBoxSearch.Text = "Search Medications";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(694, 20);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 28);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // MedicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 502);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.remove_radioButton);
            this.Controls.Add(this.edit_radioButton);
            this.Controls.Add(this.add_radioButton);
            this.Controls.Add(this.view_radioButton);
            this.Controls.Add(this.patientList_panel);
            this.Controls.Add(this.function_panel);
            this.Controls.Add(this.selectedMed_panel);
            this.Controls.Add(this.top_panel);
            this.Name = "MedicationForm";
            this.Text = "MedSCAN- ADMIN - Medication";
            this.Load += new System.EventHandler(this.MedicationForm_Load);
            this.patientList_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MedicationsDGV)).EndInit();
            this.function_panel.ResumeLayout(false);
            this.selectedMed_panel.ResumeLayout(false);
            this.selectedMed_panel.PerformLayout();
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.RadioButton remove_radioButton;
        private System.Windows.Forms.RadioButton edit_radioButton;
        private System.Windows.Forms.RadioButton add_radioButton;
        private System.Windows.Forms.RadioButton view_radioButton;
        private System.Windows.Forms.Panel patientList_panel;
        private System.Windows.Forms.DataGridView MedicationsDGV;
        private System.Windows.Forms.Panel function_panel;
        private System.Windows.Forms.Button btnFunction;
        private System.Windows.Forms.Panel selectedMed_panel;
        private System.Windows.Forms.Label pregRisk_label;
        private System.Windows.Forms.TextBox txtBoxMedID;
        private System.Windows.Forms.TextBox txtBoxClassification;
        private System.Windows.Forms.TextBox txtBoxTrade;
        private System.Windows.Forms.TextBox txtBoxGeneric;
        private System.Windows.Forms.TextBox txtBoxPseudo;
        private System.Windows.Forms.TextBox txtBoxUnitAmt;
        private System.Windows.Forms.ComboBox comboBoxPRC;
        private System.Windows.Forms.TextBox txtBoxForm;
        private System.Windows.Forms.TextBox txtBoxStr;
        private System.Windows.Forms.TextBox txtBoxNotes;
        private System.Windows.Forms.Label strength_label;
        private System.Windows.Forms.TextBox txtBoxUOM;
        private System.Windows.Forms.Label UOM_label;
        private System.Windows.Forms.Label unitAmount_label;
        private System.Windows.Forms.Label form_label;
        private System.Windows.Forms.Label pseudo_label;
        private System.Windows.Forms.Label notes_label;
        private System.Windows.Forms.Label Generic_label;
        private System.Windows.Forms.Label trade_label;
        private System.Windows.Forms.Label classification_label;
        private System.Windows.Forms.Label medID_label;
        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label medications_label;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Button btnCancel;
    }
}
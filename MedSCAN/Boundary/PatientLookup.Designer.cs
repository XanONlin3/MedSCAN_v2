namespace MedSCAN.Boundary
{
    partial class PatientLookup
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
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.Instructions_label = new System.Windows.Forms.Label();
            this.ScannerStatusLabel = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnScannerStatus = new System.Windows.Forms.Button();
            this.notWorkingLabel = new System.Windows.Forms.Label();
            this.txtBoxPatientID = new System.Windows.Forms.TextBox();
            this.topPanel = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.bottomPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bottomPanel.Controls.Add(this.btnAdmin);
            this.bottomPanel.Controls.Add(this.Instructions_label);
            this.bottomPanel.Controls.Add(this.ScannerStatusLabel);
            this.bottomPanel.Controls.Add(this.btnContinue);
            this.bottomPanel.Controls.Add(this.btnScannerStatus);
            this.bottomPanel.Controls.Add(this.notWorkingLabel);
            this.bottomPanel.Controls.Add(this.txtBoxPatientID);
            this.bottomPanel.Location = new System.Drawing.Point(1, 116);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(783, 385);
            this.bottomPanel.TabIndex = 26;
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.White;
            this.btnAdmin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(690, 346);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(81, 31);
            this.btnAdmin.TabIndex = 2;
            this.btnAdmin.Text = "ADMIN?";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // Instructions_label
            // 
            this.Instructions_label.AutoSize = true;
            this.Instructions_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instructions_label.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.Instructions_label.Location = new System.Drawing.Point(106, 136);
            this.Instructions_label.Name = "Instructions_label";
            this.Instructions_label.Size = new System.Drawing.Size(570, 22);
            this.Instructions_label.TabIndex = 3;
            this.Instructions_label.Text = "Scan the barcode located on the patient\'s wristband to begin.";
            // 
            // ScannerStatusLabel
            // 
            this.ScannerStatusLabel.AutoSize = true;
            this.ScannerStatusLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScannerStatusLabel.Location = new System.Drawing.Point(11, 351);
            this.ScannerStatusLabel.Name = "ScannerStatusLabel";
            this.ScannerStatusLabel.Size = new System.Drawing.Size(137, 18);
            this.ScannerStatusLabel.TabIndex = 7;
            this.ScannerStatusLabel.Text = "Scanner Status:";
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnContinue.Enabled = false;
            this.btnContinue.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.Location = new System.Drawing.Point(343, 230);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(97, 30);
            this.btnContinue.TabIndex = 1;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnScannerStatus
            // 
            this.btnScannerStatus.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnScannerStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnScannerStatus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScannerStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnScannerStatus.Location = new System.Drawing.Point(154, 343);
            this.btnScannerStatus.Name = "btnScannerStatus";
            this.btnScannerStatus.Size = new System.Drawing.Size(97, 31);
            this.btnScannerStatus.TabIndex = 8;
            this.btnScannerStatus.Text = "Get Status";
            this.btnScannerStatus.UseVisualStyleBackColor = false;
            this.btnScannerStatus.Click += new System.EventHandler(this.btnScannerStatus_Click);
            // 
            // notWorkingLabel
            // 
            this.notWorkingLabel.AutoSize = true;
            this.notWorkingLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notWorkingLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.notWorkingLabel.Location = new System.Drawing.Point(316, 217);
            this.notWorkingLabel.Name = "notWorkingLabel";
            this.notWorkingLabel.Size = new System.Drawing.Size(0, 15);
            this.notWorkingLabel.TabIndex = 6;
            // 
            // txtBoxPatientID
            // 
            this.txtBoxPatientID.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPatientID.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtBoxPatientID.Location = new System.Drawing.Point(214, 185);
            this.txtBoxPatientID.Name = "txtBoxPatientID";
            this.txtBoxPatientID.Size = new System.Drawing.Size(354, 29);
            this.txtBoxPatientID.TabIndex = 0;
            this.txtBoxPatientID.Text = "Scan/Enter Patient\'s ID Number...";
            this.txtBoxPatientID.TextChanged += new System.EventHandler(this.patientIDtxtBox_TextChanged);
            this.txtBoxPatientID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxPatientID_KeyPress);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.topPanel.Controls.Add(this.TitleLabel);
            this.topPanel.Location = new System.Drawing.Point(1, 2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(783, 80);
            this.topPanel.TabIndex = 25;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(3, 3);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(248, 37);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Patient Lookup";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // PatientLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 502);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.topPanel);
            this.Name = "PatientLookup";
            this.Text = "MedSCAN - Patient Lookup";
            this.Load += new System.EventHandler(this.PatientLookUp_Load);
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Label Instructions_label;
        private System.Windows.Forms.Label ScannerStatusLabel;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnScannerStatus;
        private System.Windows.Forms.Label notWorkingLabel;
        private System.Windows.Forms.TextBox txtBoxPatientID;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
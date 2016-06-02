namespace MLDIS
{
    partial class PatientRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientRegistration));
            this.label1 = new System.Windows.Forms.Label();
            this.MobileTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SexComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BloodTypeComboBox = new System.Windows.Forms.ComboBox();
            this.DateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.ReportingDoctorTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TestsRequiredGroupBox = new System.Windows.Forms.GroupBox();
            this.RTCheckBox = new System.Windows.Forms.CheckBox();
            this.UrinalysisCheckBox = new System.Windows.Forms.CheckBox();
            this.BTCheckBox = new System.Windows.Forms.CheckBox();
            this.ECGTCheckBox = new System.Windows.Forms.CheckBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.AddressRichTextBox = new System.Windows.Forms.RichTextBox();
            this.TestsRequiredGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name:";
            // 
            // MobileTextBox
            // 
            this.MobileTextBox.Location = new System.Drawing.Point(194, 29);
            this.MobileTextBox.Name = "MobileTextBox";
            this.MobileTextBox.Size = new System.Drawing.Size(171, 22);
            this.MobileTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mobile:";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(16, 29);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(172, 22);
            this.FullNameTextBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sex:";
            // 
            // SexComboBox
            // 
            this.SexComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SexComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SexComboBox.FormattingEnabled = true;
            this.SexComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.SexComboBox.Location = new System.Drawing.Point(16, 157);
            this.SexComboBox.Name = "SexComboBox";
            this.SexComboBox.Size = new System.Drawing.Size(61, 21);
            this.SexComboBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Blood:";
            // 
            // BloodTypeComboBox
            // 
            this.BloodTypeComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BloodTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BloodTypeComboBox.FormattingEnabled = true;
            this.BloodTypeComboBox.Items.AddRange(new object[] {
            "O+",
            "O-",
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-"});
            this.BloodTypeComboBox.Location = new System.Drawing.Point(86, 157);
            this.BloodTypeComboBox.Name = "BloodTypeComboBox";
            this.BloodTypeComboBox.Size = new System.Drawing.Size(61, 21);
            this.BloodTypeComboBox.TabIndex = 4;
            // 
            // DateOfBirthDateTimePicker
            // 
            this.DateOfBirthDateTimePicker.Location = new System.Drawing.Point(165, 157);
            this.DateOfBirthDateTimePicker.MinDate = new System.DateTime(1850, 1, 1, 0, 0, 0, 0);
            this.DateOfBirthDateTimePicker.Name = "DateOfBirthDateTimePicker";
            this.DateOfBirthDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.DateOfBirthDateTimePicker.TabIndex = 5;
            this.DateOfBirthDateTimePicker.Value = new System.DateTime(1990, 1, 1, 12, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(162, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Date of Birth:";
            // 
            // ReportingDoctorTextBox
            // 
            this.ReportingDoctorTextBox.Location = new System.Drawing.Point(15, 197);
            this.ReportingDoctorTextBox.Name = "ReportingDoctorTextBox";
            this.ReportingDoctorTextBox.Size = new System.Drawing.Size(172, 22);
            this.ReportingDoctorTextBox.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Reporting Doctor";
            // 
            // TestsRequiredGroupBox
            // 
            this.TestsRequiredGroupBox.Controls.Add(this.ECGTCheckBox);
            this.TestsRequiredGroupBox.Controls.Add(this.RTCheckBox);
            this.TestsRequiredGroupBox.Controls.Add(this.UrinalysisCheckBox);
            this.TestsRequiredGroupBox.Controls.Add(this.BTCheckBox);
            this.TestsRequiredGroupBox.Location = new System.Drawing.Point(12, 225);
            this.TestsRequiredGroupBox.Name = "TestsRequiredGroupBox";
            this.TestsRequiredGroupBox.Size = new System.Drawing.Size(353, 68);
            this.TestsRequiredGroupBox.TabIndex = 7;
            this.TestsRequiredGroupBox.TabStop = false;
            this.TestsRequiredGroupBox.Text = "Tests Required";
            // 
            // RTCheckBox
            // 
            this.RTCheckBox.AutoSize = true;
            this.RTCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RTCheckBox.Location = new System.Drawing.Point(92, 21);
            this.RTCheckBox.Name = "RTCheckBox";
            this.RTCheckBox.Size = new System.Drawing.Size(101, 17);
            this.RTCheckBox.TabIndex = 1;
            this.RTCheckBox.Text = "Radiology Test";
            this.RTCheckBox.UseVisualStyleBackColor = true;
            // 
            // UrinalysisCheckBox
            // 
            this.UrinalysisCheckBox.AutoSize = true;
            this.UrinalysisCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UrinalysisCheckBox.Location = new System.Drawing.Point(6, 44);
            this.UrinalysisCheckBox.Name = "UrinalysisCheckBox";
            this.UrinalysisCheckBox.Size = new System.Drawing.Size(75, 17);
            this.UrinalysisCheckBox.TabIndex = 3;
            this.UrinalysisCheckBox.Text = "Urinalysis";
            this.UrinalysisCheckBox.UseVisualStyleBackColor = true;
            // 
            // BTCheckBox
            // 
            this.BTCheckBox.AutoSize = true;
            this.BTCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTCheckBox.Location = new System.Drawing.Point(6, 21);
            this.BTCheckBox.Name = "BTCheckBox";
            this.BTCheckBox.Size = new System.Drawing.Size(80, 17);
            this.BTCheckBox.TabIndex = 0;
            this.BTCheckBox.Text = "Blood Test";
            this.BTCheckBox.UseVisualStyleBackColor = true;
            // 
            // ECGTCheckBox
            // 
            this.ECGTCheckBox.AutoSize = true;
            this.ECGTCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ECGTCheckBox.Location = new System.Drawing.Point(199, 21);
            this.ECGTCheckBox.Name = "ECGTCheckBox";
            this.ECGTCheckBox.Size = new System.Drawing.Size(142, 17);
            this.ECGTCheckBox.TabIndex = 2;
            this.ECGTCheckBox.Text = "Electrocardiogram Test";
            this.ECGTCheckBox.UseVisualStyleBackColor = true;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterButton.Location = new System.Drawing.Point(12, 300);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(75, 23);
            this.RegisterButton.TabIndex = 8;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetButton.Location = new System.Drawing.Point(290, 300);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 9;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // AddressRichTextBox
            // 
            this.AddressRichTextBox.Location = new System.Drawing.Point(16, 70);
            this.AddressRichTextBox.Name = "AddressRichTextBox";
            this.AddressRichTextBox.Size = new System.Drawing.Size(349, 68);
            this.AddressRichTextBox.TabIndex = 2;
            this.AddressRichTextBox.Text = "";
            // 
            // PatientRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 333);
            this.Controls.Add(this.AddressRichTextBox);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.TestsRequiredGroupBox);
            this.Controls.Add(this.ReportingDoctorTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DateOfBirthDateTimePicker);
            this.Controls.Add(this.BloodTypeComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SexComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FullNameTextBox);
            this.Controls.Add(this.MobileTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PatientRegistration";
            this.Text = "MLDIS - Patient Registration";
            this.Load += new System.EventHandler(this.PatientRegistration_Load);
            this.TestsRequiredGroupBox.ResumeLayout(false);
            this.TestsRequiredGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MobileTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SexComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox BloodTypeComboBox;
        private System.Windows.Forms.DateTimePicker DateOfBirthDateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ReportingDoctorTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox TestsRequiredGroupBox;
        private System.Windows.Forms.CheckBox RTCheckBox;
        private System.Windows.Forms.CheckBox UrinalysisCheckBox;
        private System.Windows.Forms.CheckBox BTCheckBox;
        private System.Windows.Forms.CheckBox ECGTCheckBox;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.RichTextBox AddressRichTextBox;
    }
}
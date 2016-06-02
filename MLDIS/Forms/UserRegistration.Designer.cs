namespace MLDIS
{
    partial class UserRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRegistration));
            this.label1 = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.ShowPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.LoginCredentialGroupBox = new System.Windows.Forms.GroupBox();
            this.UsernameAvailabilityLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DesignationComboBox = new System.Windows.Forms.ComboBox();
            this.DetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.MobileTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BloodTypeTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SexTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.DiscountNumericBox = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TaxNumericBox = new System.Windows.Forms.NumericUpDown();
            this.ScheduleTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.LoginCredentialGroupBox.SuspendLayout();
            this.DetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiscountNumericBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaxNumericBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username:";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(73, 21);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(119, 22);
            this.UsernameTextBox.TabIndex = 7;
            this.UsernameTextBox.Leave += new System.EventHandler(this.UsernameTextBox_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password:";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(73, 49);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '•';
            this.PasswordTextBox.Size = new System.Drawing.Size(119, 22);
            this.PasswordTextBox.TabIndex = 9;
            // 
            // ShowPasswordCheckBox
            // 
            this.ShowPasswordCheckBox.AutoSize = true;
            this.ShowPasswordCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowPasswordCheckBox.Location = new System.Drawing.Point(198, 54);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.Size = new System.Drawing.Size(55, 17);
            this.ShowPasswordCheckBox.TabIndex = 10;
            this.ShowPasswordCheckBox.Text = "Show";
            this.ShowPasswordCheckBox.UseVisualStyleBackColor = true;
            this.ShowPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckBox_CheckedChanged);
            // 
            // LoginCredentialGroupBox
            // 
            this.LoginCredentialGroupBox.Controls.Add(this.UsernameAvailabilityLabel);
            this.LoginCredentialGroupBox.Controls.Add(this.label3);
            this.LoginCredentialGroupBox.Controls.Add(this.DesignationComboBox);
            this.LoginCredentialGroupBox.Controls.Add(this.ShowPasswordCheckBox);
            this.LoginCredentialGroupBox.Controls.Add(this.PasswordTextBox);
            this.LoginCredentialGroupBox.Controls.Add(this.label2);
            this.LoginCredentialGroupBox.Controls.Add(this.UsernameTextBox);
            this.LoginCredentialGroupBox.Controls.Add(this.label1);
            this.LoginCredentialGroupBox.Location = new System.Drawing.Point(13, 13);
            this.LoginCredentialGroupBox.Name = "LoginCredentialGroupBox";
            this.LoginCredentialGroupBox.Size = new System.Drawing.Size(259, 128);
            this.LoginCredentialGroupBox.TabIndex = 0;
            this.LoginCredentialGroupBox.TabStop = false;
            this.LoginCredentialGroupBox.Text = "Login Credential";
            // 
            // UsernameAvailabilityLabel
            // 
            this.UsernameAvailabilityLabel.AutoSize = true;
            this.UsernameAvailabilityLabel.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameAvailabilityLabel.Location = new System.Drawing.Point(199, 29);
            this.UsernameAvailabilityLabel.Name = "UsernameAvailabilityLabel";
            this.UsernameAvailabilityLabel.Size = new System.Drawing.Size(0, 12);
            this.UsernameAvailabilityLabel.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Designation:";
            // 
            // DesignationComboBox
            // 
            this.DesignationComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DesignationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DesignationComboBox.FormattingEnabled = true;
            this.DesignationComboBox.Items.AddRange(new object[] {
            "Administrator",
            "Doctor",
            "Technician",
            "Dispensary"});
            this.DesignationComboBox.Location = new System.Drawing.Point(11, 97);
            this.DesignationComboBox.Name = "DesignationComboBox";
            this.DesignationComboBox.Size = new System.Drawing.Size(181, 21);
            this.DesignationComboBox.TabIndex = 11;
            // 
            // DetailsGroupBox
            // 
            this.DetailsGroupBox.Controls.Add(this.ScheduleTextBox);
            this.DetailsGroupBox.Controls.Add(this.label12);
            this.DetailsGroupBox.Controls.Add(this.label11);
            this.DetailsGroupBox.Controls.Add(this.TaxNumericBox);
            this.DetailsGroupBox.Controls.Add(this.label10);
            this.DetailsGroupBox.Controls.Add(this.DiscountNumericBox);
            this.DetailsGroupBox.Controls.Add(this.MobileTextBox);
            this.DetailsGroupBox.Controls.Add(this.label9);
            this.DetailsGroupBox.Controls.Add(this.EmailTextBox);
            this.DetailsGroupBox.Controls.Add(this.label8);
            this.DetailsGroupBox.Controls.Add(this.BloodTypeTextBox);
            this.DetailsGroupBox.Controls.Add(this.label7);
            this.DetailsGroupBox.Controls.Add(this.SexTextBox);
            this.DetailsGroupBox.Controls.Add(this.label6);
            this.DetailsGroupBox.Controls.Add(this.AddressTextBox);
            this.DetailsGroupBox.Controls.Add(this.label5);
            this.DetailsGroupBox.Controls.Add(this.FullNameTextBox);
            this.DetailsGroupBox.Controls.Add(this.label4);
            this.DetailsGroupBox.Location = new System.Drawing.Point(12, 147);
            this.DetailsGroupBox.Name = "DetailsGroupBox";
            this.DetailsGroupBox.Size = new System.Drawing.Size(260, 280);
            this.DetailsGroupBox.TabIndex = 1;
            this.DetailsGroupBox.TabStop = false;
            this.DetailsGroupBox.Text = "Details";
            // 
            // MobileTextBox
            // 
            this.MobileTextBox.Location = new System.Drawing.Point(80, 161);
            this.MobileTextBox.Name = "MobileTextBox";
            this.MobileTextBox.Size = new System.Drawing.Size(174, 22);
            this.MobileTextBox.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Mobile:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(80, 133);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(174, 22);
            this.EmailTextBox.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Email:";
            // 
            // BloodTypeTextBox
            // 
            this.BloodTypeTextBox.Location = new System.Drawing.Point(80, 105);
            this.BloodTypeTextBox.Name = "BloodTypeTextBox";
            this.BloodTypeTextBox.Size = new System.Drawing.Size(174, 22);
            this.BloodTypeTextBox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Blood Type:";
            // 
            // SexTextBox
            // 
            this.SexTextBox.Location = new System.Drawing.Point(80, 77);
            this.SexTextBox.Name = "SexTextBox";
            this.SexTextBox.Size = new System.Drawing.Size(174, 22);
            this.SexTextBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sex:";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(80, 49);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(174, 22);
            this.AddressTextBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Address:";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(80, 21);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(174, 22);
            this.FullNameTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Full Name:";
            // 
            // RegisterButton
            // 
            this.RegisterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterButton.Location = new System.Drawing.Point(13, 433);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(75, 23);
            this.RegisterButton.TabIndex = 2;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetButton.Location = new System.Drawing.Point(197, 433);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 3;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // DiscountNumericBox
            // 
            this.DiscountNumericBox.Location = new System.Drawing.Point(80, 217);
            this.DiscountNumericBox.Name = "DiscountNumericBox";
            this.DiscountNumericBox.Size = new System.Drawing.Size(174, 22);
            this.DiscountNumericBox.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Discount:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(48, 247);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Tax:";
            // 
            // TaxNumericBox
            // 
            this.TaxNumericBox.Location = new System.Drawing.Point(80, 245);
            this.TaxNumericBox.Name = "TaxNumericBox";
            this.TaxNumericBox.Size = new System.Drawing.Size(174, 22);
            this.TaxNumericBox.TabIndex = 22;
            // 
            // ScheduleTextBox
            // 
            this.ScheduleTextBox.Location = new System.Drawing.Point(80, 189);
            this.ScheduleTextBox.Name = "ScheduleTextBox";
            this.ScheduleTextBox.Size = new System.Drawing.Size(174, 22);
            this.ScheduleTextBox.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 192);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Schedule:";
            // 
            // UserRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 465);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.DetailsGroupBox);
            this.Controls.Add(this.LoginCredentialGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserRegistration";
            this.Text = "MLDIS - User Registration";
            this.Load += new System.EventHandler(this.UserRegistration_Load);
            this.LoginCredentialGroupBox.ResumeLayout(false);
            this.LoginCredentialGroupBox.PerformLayout();
            this.DetailsGroupBox.ResumeLayout(false);
            this.DetailsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiscountNumericBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaxNumericBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.CheckBox ShowPasswordCheckBox;
        private System.Windows.Forms.GroupBox LoginCredentialGroupBox;
        private System.Windows.Forms.GroupBox DetailsGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DesignationComboBox;
        private System.Windows.Forms.TextBox MobileTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox BloodTypeTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SexTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label UsernameAvailabilityLabel;
        private System.Windows.Forms.TextBox ScheduleTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown TaxNumericBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown DiscountNumericBox;
    }
}
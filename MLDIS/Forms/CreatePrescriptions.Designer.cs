namespace MLDIS
{
    partial class CreatePrescriptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePrescriptions));
            this.PatientComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SynthroidNumericBox = new System.Windows.Forms.NumericUpDown();
            this.CrestorNumericBox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.NexiumNumericBox = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.VentolinHFANumericBox = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.AdvairDiskusNumericBox = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SynthroidNumericBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrestorNumericBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NexiumNumericBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentolinHFANumericBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdvairDiskusNumericBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PatientComboBox
            // 
            this.PatientComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PatientComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PatientComboBox.FormattingEnabled = true;
            this.PatientComboBox.Location = new System.Drawing.Point(12, 12);
            this.PatientComboBox.Name = "PatientComboBox";
            this.PatientComboBox.Size = new System.Drawing.Size(252, 21);
            this.PatientComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Synthroid:";
            // 
            // SynthroidNumericBox
            // 
            this.SynthroidNumericBox.Location = new System.Drawing.Point(98, 41);
            this.SynthroidNumericBox.Name = "SynthroidNumericBox";
            this.SynthroidNumericBox.Size = new System.Drawing.Size(166, 22);
            this.SynthroidNumericBox.TabIndex = 2;
            // 
            // CrestorNumericBox
            // 
            this.CrestorNumericBox.Location = new System.Drawing.Point(98, 69);
            this.CrestorNumericBox.Name = "CrestorNumericBox";
            this.CrestorNumericBox.Size = new System.Drawing.Size(166, 22);
            this.CrestorNumericBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Crestor:";
            // 
            // NexiumNumericBox
            // 
            this.NexiumNumericBox.Location = new System.Drawing.Point(98, 97);
            this.NexiumNumericBox.Name = "NexiumNumericBox";
            this.NexiumNumericBox.Size = new System.Drawing.Size(166, 22);
            this.NexiumNumericBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nexium:";
            // 
            // VentolinHFANumericBox
            // 
            this.VentolinHFANumericBox.Location = new System.Drawing.Point(98, 123);
            this.VentolinHFANumericBox.Name = "VentolinHFANumericBox";
            this.VentolinHFANumericBox.Size = new System.Drawing.Size(166, 22);
            this.VentolinHFANumericBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ventolin HFA:";
            // 
            // AdvairDiskusNumericBox
            // 
            this.AdvairDiskusNumericBox.Location = new System.Drawing.Point(98, 151);
            this.AdvairDiskusNumericBox.Name = "AdvairDiskusNumericBox";
            this.AdvairDiskusNumericBox.Size = new System.Drawing.Size(166, 22);
            this.AdvairDiskusNumericBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Advair Diskus:";
            // 
            // CreateButton
            // 
            this.CreateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateButton.Location = new System.Drawing.Point(12, 177);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 11;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // CreatePrescriptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 212);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.AdvairDiskusNumericBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.VentolinHFANumericBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NexiumNumericBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CrestorNumericBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SynthroidNumericBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PatientComboBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CreatePrescriptions";
            this.Text = "MLDIS - Create Prescriptions";
            this.Load += new System.EventHandler(this.CreatePrescriptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SynthroidNumericBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrestorNumericBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NexiumNumericBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentolinHFANumericBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdvairDiskusNumericBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PatientComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown SynthroidNumericBox;
        private System.Windows.Forms.NumericUpDown CrestorNumericBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NexiumNumericBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown VentolinHFANumericBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown AdvairDiskusNumericBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CreateButton;
    }
}
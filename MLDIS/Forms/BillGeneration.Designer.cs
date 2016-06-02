namespace MLDIS
{
    partial class BillGeneration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillGeneration));
            this.PatientComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BillDetailsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.TotalAmountNumericBox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TotalAmountNumericBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PatientComboBox
            // 
            this.PatientComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PatientComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PatientComboBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientComboBox.FormattingEnabled = true;
            this.PatientComboBox.Location = new System.Drawing.Point(12, 12);
            this.PatientComboBox.Name = "PatientComboBox";
            this.PatientComboBox.Size = new System.Drawing.Size(260, 21);
            this.PatientComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bill Details:";
            // 
            // BillDetailsRichTextBox
            // 
            this.BillDetailsRichTextBox.Location = new System.Drawing.Point(15, 52);
            this.BillDetailsRichTextBox.Name = "BillDetailsRichTextBox";
            this.BillDetailsRichTextBox.Size = new System.Drawing.Size(257, 177);
            this.BillDetailsRichTextBox.TabIndex = 3;
            this.BillDetailsRichTextBox.Text = "";
            // 
            // TotalAmountNumericBox
            // 
            this.TotalAmountNumericBox.Location = new System.Drawing.Point(97, 235);
            this.TotalAmountNumericBox.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.TotalAmountNumericBox.Name = "TotalAmountNumericBox";
            this.TotalAmountNumericBox.Size = new System.Drawing.Size(175, 22);
            this.TotalAmountNumericBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total Amount:";
            // 
            // CreateButton
            // 
            this.CreateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateButton.Location = new System.Drawing.Point(15, 263);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 21);
            this.CreateButton.TabIndex = 7;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // BillGeneration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 295);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TotalAmountNumericBox);
            this.Controls.Add(this.BillDetailsRichTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PatientComboBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BillGeneration";
            this.Text = "MLDIS - Bill Generation";
            this.Load += new System.EventHandler(this.BillGeneration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TotalAmountNumericBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PatientComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox BillDetailsRichTextBox;
        private System.Windows.Forms.NumericUpDown TotalAmountNumericBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CreateButton;
    }
}
namespace MLDIS
{
    partial class TestReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestReports));
            this.ReportsComboBox = new System.Windows.Forms.ComboBox();
            this.DetailsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ReportsComboBox
            // 
            this.ReportsComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReportsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ReportsComboBox.FormattingEnabled = true;
            this.ReportsComboBox.Location = new System.Drawing.Point(12, 12);
            this.ReportsComboBox.Name = "ReportsComboBox";
            this.ReportsComboBox.Size = new System.Drawing.Size(410, 21);
            this.ReportsComboBox.TabIndex = 0;
            this.ReportsComboBox.TabStop = false;
            this.ReportsComboBox.SelectedIndexChanged += new System.EventHandler(this.ReportsComboBox_SelectedIndexChanged);
            // 
            // DetailsRichTextBox
            // 
            this.DetailsRichTextBox.Location = new System.Drawing.Point(12, 39);
            this.DetailsRichTextBox.Name = "DetailsRichTextBox";
            this.DetailsRichTextBox.ReadOnly = true;
            this.DetailsRichTextBox.Size = new System.Drawing.Size(410, 283);
            this.DetailsRichTextBox.TabIndex = 2;
            this.DetailsRichTextBox.Text = "";
            // 
            // TestReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 334);
            this.Controls.Add(this.DetailsRichTextBox);
            this.Controls.Add(this.ReportsComboBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TestReports";
            this.Text = "MLDIS - Test Reports";
            this.Load += new System.EventHandler(this.TestReports_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ReportsComboBox;
        private System.Windows.Forms.RichTextBox DetailsRichTextBox;
    }
}
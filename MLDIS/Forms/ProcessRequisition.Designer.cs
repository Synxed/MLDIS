namespace MLDIS
{
    partial class ProcessRequisition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessRequisition));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ProcessAllButton = new System.Windows.Forms.Button();
            this.ProcessButton = new System.Windows.Forms.Button();
            this.RequisitionsComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AdvairDiskusLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.VentolinHFALabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NexiumLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CrestorLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SynthroidLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ProcessAllButton);
            this.groupBox1.Controls.Add(this.ProcessButton);
            this.groupBox1.Controls.Add(this.RequisitionsComboBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unprocessed Requisitions";
            // 
            // ProcessAllButton
            // 
            this.ProcessAllButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProcessAllButton.Location = new System.Drawing.Point(179, 48);
            this.ProcessAllButton.Name = "ProcessAllButton";
            this.ProcessAllButton.Size = new System.Drawing.Size(75, 23);
            this.ProcessAllButton.TabIndex = 2;
            this.ProcessAllButton.Text = "Process All";
            this.ProcessAllButton.UseVisualStyleBackColor = true;
            this.ProcessAllButton.Click += new System.EventHandler(this.ProcessAllButton_Click);
            // 
            // ProcessButton
            // 
            this.ProcessButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProcessButton.Location = new System.Drawing.Point(6, 48);
            this.ProcessButton.Name = "ProcessButton";
            this.ProcessButton.Size = new System.Drawing.Size(75, 23);
            this.ProcessButton.TabIndex = 1;
            this.ProcessButton.Text = "Process";
            this.ProcessButton.UseVisualStyleBackColor = true;
            this.ProcessButton.Click += new System.EventHandler(this.ProcessButton_Click);
            // 
            // RequisitionsComboBox
            // 
            this.RequisitionsComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RequisitionsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RequisitionsComboBox.FormattingEnabled = true;
            this.RequisitionsComboBox.Location = new System.Drawing.Point(6, 21);
            this.RequisitionsComboBox.Name = "RequisitionsComboBox";
            this.RequisitionsComboBox.Size = new System.Drawing.Size(248, 21);
            this.RequisitionsComboBox.TabIndex = 0;
            this.RequisitionsComboBox.SelectedIndexChanged += new System.EventHandler(this.RequisitionsComboBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AdvairDiskusLabel);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.VentolinHFALabel);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.NexiumLabel);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.CrestorLabel);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.SynthroidLabel);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 121);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details of Current Requesition";
            // 
            // AdvairDiskusLabel
            // 
            this.AdvairDiskusLabel.AutoSize = true;
            this.AdvairDiskusLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdvairDiskusLabel.Location = new System.Drawing.Point(123, 63);
            this.AdvairDiskusLabel.Name = "AdvairDiskusLabel";
            this.AdvairDiskusLabel.Size = new System.Drawing.Size(17, 19);
            this.AdvairDiskusLabel.TabIndex = 19;
            this.AdvairDiskusLabel.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(124, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Advair Diskus:";
            // 
            // VentolinHFALabel
            // 
            this.VentolinHFALabel.AutoSize = true;
            this.VentolinHFALabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentolinHFALabel.Location = new System.Drawing.Point(123, 31);
            this.VentolinHFALabel.Name = "VentolinHFALabel";
            this.VentolinHFALabel.Size = new System.Drawing.Size(17, 19);
            this.VentolinHFALabel.TabIndex = 17;
            this.VentolinHFALabel.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(124, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Ventolin HFA:";
            // 
            // NexiumLabel
            // 
            this.NexiumLabel.AutoSize = true;
            this.NexiumLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NexiumLabel.Location = new System.Drawing.Point(4, 95);
            this.NexiumLabel.Name = "NexiumLabel";
            this.NexiumLabel.Size = new System.Drawing.Size(17, 19);
            this.NexiumLabel.TabIndex = 15;
            this.NexiumLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nexium:";
            // 
            // CrestorLabel
            // 
            this.CrestorLabel.AutoSize = true;
            this.CrestorLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrestorLabel.Location = new System.Drawing.Point(5, 63);
            this.CrestorLabel.Name = "CrestorLabel";
            this.CrestorLabel.Size = new System.Drawing.Size(17, 19);
            this.CrestorLabel.TabIndex = 13;
            this.CrestorLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Crestor:";
            // 
            // SynthroidLabel
            // 
            this.SynthroidLabel.AutoSize = true;
            this.SynthroidLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SynthroidLabel.Location = new System.Drawing.Point(5, 31);
            this.SynthroidLabel.Name = "SynthroidLabel";
            this.SynthroidLabel.Size = new System.Drawing.Size(17, 19);
            this.SynthroidLabel.TabIndex = 11;
            this.SynthroidLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Synthroid:";
            // 
            // ProcessRequisition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 229);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProcessRequisition";
            this.Text = "MLDIS - Requisitions";
            this.Load += new System.EventHandler(this.Requisitions_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ProcessAllButton;
        private System.Windows.Forms.Button ProcessButton;
        private System.Windows.Forms.ComboBox RequisitionsComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label AdvairDiskusLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label VentolinHFALabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label NexiumLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CrestorLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label SynthroidLabel;
        private System.Windows.Forms.Label label1;
    }
}
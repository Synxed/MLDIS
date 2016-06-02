using System;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;
using MLDIS.Properties;

namespace MLDIS
{
    public partial class PatientBills : Form
    {
        public PatientBills()
        {
            InitializeComponent();
        }

        private void GetBillButton_Click(object sender, EventArgs e)
        {
            try
            {
                var billDetails = string.Empty;

                using (var connection = new OleDbConnection(Resources.ConnectionString))
                {
                    connection.Open();

                    using (var command = new OleDbCommand("SELECT * FROM Bills WHERE PatientID = @id", connection))
                    {
                        command.Parameters.AddWithValue("@id", IDTextBox.Text);

                        using (var reader = command.ExecuteReader())
                        {
                            reader.Read();

                            billDetails = reader["BillDetails"].ToString();
                        }
                    }
                }

                using (var saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    saveFileDialog.Filter = "Text Document (*.txt)|*.txt";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog.FileName, billDetails);
                        MessageBox.Show("Bill successfully exported to " + saveFileDialog.FileName,
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("No bill available for the given ID.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

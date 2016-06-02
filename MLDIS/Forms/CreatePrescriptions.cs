using System;
using System.Data.OleDb;
using System.Windows.Forms;
using MLDIS.Properties;

namespace MLDIS
{
    public partial class CreatePrescriptions : Form
    {
        public CreatePrescriptions()
        {
            InitializeComponent();
        }

        private void CreatePrescriptions_Load(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new OleDbConnection(Resources.ConnectionString))
                {
                    connection.Open();

                    using (var command = new OleDbCommand("SELECT * FROM Patients", connection))
                    {
                        using (var reader = command.ExecuteReader()) 
                        {
                            while (reader != null && reader.Read())
                            {
                                PatientComboBox.Items.Add(reader["PatientID"] + " - " + reader["FullName"]);
                            }
                        }
                    }
                }

                PatientComboBox.SelectedIndex = 0;
            }
            catch (Exception exception)
            {
                MessageBox.Show("An error occured!" + Environment.NewLine + Environment.NewLine + exception.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new OleDbConnection(Resources.ConnectionString))
                {
                    connection.Open();

                    var commandString = "INSERT INTO Prescriptions (PatientID, FullName, Synthroid, Crestor, Nexium, VentolinHFA, AdvairDiskus, Processed) " +
                                        "Values (@PatientID, @FullName, @Synthroid, @Crestor, @Nexium, @VentolinHFA, @AdvairDiskus, @Processed)";

                    using (var command = new OleDbCommand(commandString, connection))
                    {
                        command.Parameters.AddWithValue("@PatientID",
                            PatientComboBox.SelectedItem.ToString().Split('-')[0].Trim());
                        command.Parameters.AddWithValue("@FullName",
                            PatientComboBox.SelectedItem.ToString().Split('-')[1].Trim());

                        command.Parameters.AddWithValue("@Synthroid", SynthroidNumericBox.Value);
                        command.Parameters.AddWithValue("@Crestor", CrestorNumericBox.Value);
                        command.Parameters.AddWithValue("@Nexium", NexiumNumericBox.Value);
                        command.Parameters.AddWithValue("@VentolinHFA", VentolinHFANumericBox.Value);
                        command.Parameters.AddWithValue("@AdvairDiskus", AdvairDiskusNumericBox.Value);
                        command.Parameters.AddWithValue("@Processed", false);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Prescription created successfully.", "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show("An error occured!" + Environment.NewLine + Environment.NewLine + exception.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

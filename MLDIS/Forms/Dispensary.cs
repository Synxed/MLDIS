using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;
using MLDIS.Properties;

namespace MLDIS
{
    public partial class Dispensary : Form
    {
        public Dispensary()
        {
            InitializeComponent();
        }

        private void Dispensary_Load(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new OleDbConnection(Resources.ConnectionString))
                {
                    connection.Open();

                    using (var command = new OleDbCommand("SELECT * FROM Prescriptions WHERE Processed = 0", connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader != null && reader.Read())
                            {
                                PrescriptionsComboBox.Items.Add(string.Format("{0}. {1} - {2}", reader["PrescriptionID"],
                                    reader["PatientID"], reader["FullName"]));
                            }
                        }
                    }
                }

                CheckPrescriptionsAvailability();
                PrescriptionsComboBox.SelectedIndex = 0;
            }
            catch (Exception exception)
            {
                MessageBox.Show("An error occured." + Environment.NewLine + Environment.NewLine + exception.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProcessPrescriptionButton_Click(object sender, EventArgs e)
        {
            try
            {
                var getCurrentStock = Stock.GetCurrentStock();
                var insufficientDrugs = string.Empty;

                getCurrentStock["Synthroid"] -= int.Parse(SynthroidLabel.Text);
                getCurrentStock["Crestor"] -= int.Parse(CrestorLabel.Text);
                getCurrentStock["Nexium"] -= int.Parse(NexiumLabel.Text);
                getCurrentStock["VentolinHFA"] -= int.Parse(VentolinHFALabel.Text);
                getCurrentStock["AdvairDiskus"] -= int.Parse(AdvairDiskusLabel.Text);

                if (!IsSufficient(getCurrentStock, out insufficientDrugs))
                {
                    MessageBox.Show("The following drugs are not available in sufficient quantity: " + insufficientDrugs,
                    "Insufficient Drugs in Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }                  

                using (var connection = new OleDbConnection(Resources.ConnectionString))
                {
                    connection.Open();

                    using (var command = new OleDbCommand("UPDATE Stock SET Synthroid = ?, Crestor = ?, Nexium = ?, VentolinHFA = ?, AdvairDiskus = ?", connection))
                    {
                        command.Parameters.AddWithValue("@Synthroid", getCurrentStock["Synthroid"]);
                        command.Parameters.AddWithValue("@Crestor", getCurrentStock["Crestor"]);
                        command.Parameters.AddWithValue("@Nexium", getCurrentStock["Nexium"]);
                        command.Parameters.AddWithValue("@VentolinHFA", getCurrentStock["VentolinHFA"]);
                        command.Parameters.AddWithValue("@AdvairDiskus", getCurrentStock["AdvairDiskus"]);
                        command.Parameters.AddWithValue("@Processed", true);

                        command.ExecuteNonQuery();
                    }

                    using (var command =new OleDbCommand("UPDATE Prescriptions SET Processed = @processed WHERE PrescriptionID = @id", connection))
                    {
                        command.Parameters.AddWithValue("@processed", true);
                        command.Parameters.AddWithValue("@id",
                            PrescriptionsComboBox.SelectedItem.ToString().Split('.')[0]);

                        command.ExecuteNonQuery();
                    }
                }

                PrescriptionsComboBox.Items.Remove(PrescriptionsComboBox.SelectedItem);
                CheckPrescriptionsAvailability();
                PrescriptionsComboBox.SelectedIndex = 0;
            }
            catch (Exception exception)
            {
                MessageBox.Show("An error occured." + Environment.NewLine + Environment.NewLine + exception.Message,
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
                    var commandString =
                        "INSERT INTO Requisitions (Synthroid, Crestor, Nexium, VentolinHFA, AdvairDiskus, IssueDate, Processed)" +
                        "Values (@Synthroid, @Crestor, @Nexium, @VentolinHFA, @AdvairDiskus, @IssueDate, @Processed)";

                    using (var command = new OleDbCommand(commandString, connection))
                    {
                        command.Parameters.AddWithValue("@Synthroid", SynthroidNumericBox.Value);
                        command.Parameters.AddWithValue("@Crestor", CrestorNumericBox.Value);
                        command.Parameters.AddWithValue("@Nexium", NexiumNumericBox.Value);
                        command.Parameters.AddWithValue("@VentolinHFA", VentolinHFANumericBox.Value);
                        command.Parameters.AddWithValue("@AdvairDiskus", AdvairDiskusNumericBox.Value);
                        command.Parameters.AddWithValue("@IssueDate", DateTime.Today.ToShortDateString());
                        command.Parameters.AddWithValue("@Processed", false);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Requisition successfully created.", "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show("An error occured." + Environment.NewLine + Environment.NewLine + exception.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrescriptionsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (PrescriptionsComboBox.SelectedItem.ToString() == "No Unprocessed Prescriptions Avalaible")
                    return;

                var currentPrescriptionID = int.Parse(PrescriptionsComboBox.SelectedItem.ToString().Split('.')[0]);

                using (var connection = new OleDbConnection(Resources.ConnectionString))
                {
                    connection.Open();

                    using (var command = new OleDbCommand("SELECT * FROM Prescriptions WHERE PrescriptionID = @id", connection))
                    {
                        command.Parameters.AddWithValue("@id", currentPrescriptionID);

                        using (var reader = command.ExecuteReader())
                        {
                            reader.Read();

                            SynthroidLabel.Text = reader["Synthroid"].ToString();
                            CrestorLabel.Text = reader["Crestor"].ToString();
                            NexiumLabel.Text = reader["Nexium"].ToString();
                            VentolinHFALabel.Text = reader["VentolinHFA"].ToString();
                            AdvairDiskusLabel.Text = reader["AdvairDiskus"].ToString();
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("An error occured." + Environment.NewLine + Environment.NewLine + exception.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static bool IsSufficient(Dictionary<string, int> currentStock, out string insufficientDrugs)
        {
            bool isSufficientBool = true;
            List<string> insuffcientDrugsList = new List<string>();

            foreach (var drug in currentStock)
            {
                if (drug.Value < 0)
                {
                    isSufficientBool = false;
                    insuffcientDrugsList.Add(drug.Key);
                }
            }

            insufficientDrugs = String.Join(", ", insuffcientDrugsList.ToArray());

            return isSufficientBool;
        }

        private void CheckPrescriptionsAvailability()
        {
            if (PrescriptionsComboBox.Items.Count != 0) return;

            PrescriptionsComboBox.Items.Add("No Unprocessed Prescriptions Avalaible");
            PrescriptionsComboBox.SelectedIndex = 0;
            PrescriptionsComboBox.Enabled = false;
            ProcessPrescriptionButton.Enabled = false;
        }
    }
}

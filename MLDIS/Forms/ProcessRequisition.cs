using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;
using MLDIS.Properties;

namespace MLDIS
{
    public partial class ProcessRequisition : Form
    {
        public ProcessRequisition()
        {
            InitializeComponent();
        }

        private void Requisitions_Load(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new OleDbConnection(Resources.ConnectionString))
                {
                    connection.Open();
                    using (var command = new OleDbCommand("SELECT * FROM Requisitions WHERE Processed = 0", connection))
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader != null && reader.Read())
                        {
                            RequisitionsComboBox.Items.Add($"{((DateTime)reader["IssueDate"]).ToLongDateString()}");
                        }                         
                    }

                    CheckRequisitionsAvailability();
                    RequisitionsComboBox.SelectedIndex = 0;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("An error occured!" + Environment.NewLine + Environment.NewLine + exception.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RequisitionsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (RequisitionsComboBox.SelectedItem.ToString() == "No Unprocessed Requisitions Avalaible")
                {
                    SynthroidLabel.Text = "0";
                    CrestorLabel.Text = "0";
                    NexiumLabel.Text = "0";
                    VentolinHFALabel.Text = "0";
                    AdvairDiskusLabel.Text = "0";
                    return;
                }
                   
                using (var connection = new OleDbConnection(Resources.ConnectionString))
                {
                    connection.Open();
                    var commandString = "SELECT * FROM Requisitions WHERE IssueDate = @date";

                    using (var command = new OleDbCommand(commandString, connection))
                    {
                        command.Parameters.AddWithValue("@date", DateTime.Parse(RequisitionsComboBox.SelectedItem.ToString()).ToShortDateString());
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
                MessageBox.Show("An error occured!" + Environment.NewLine + Environment.NewLine + exception.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ProcessButton_Click(object sender, EventArgs e)
        {
            ProcessRequisitions(new[] {RequisitionsComboBox.SelectedItem.ToString()});
        }

        private void ProcessAllButton_Click(object sender, EventArgs e)
        {
            ProcessRequisitions((from object item in RequisitionsComboBox.Items select item.ToString()).ToArray());
        }

        private void ProcessRequisitions(string[] issueDates)
        {
            try
            {
                foreach (var date in issueDates)
                {
                    using (var connection = new OleDbConnection(Resources.ConnectionString))
                    {
                        connection.Open();
                        var drugsList = new List<int>();

                        var commandString = "SELECT * FROM Requisitions WHERE IssueDate = @date";
                        using (var command = new OleDbCommand(commandString, connection))
                        {
                            command.Parameters.AddWithValue("@date", DateTime.Parse(date).ToShortDateString());
                            using (var reader = command.ExecuteReader())
                            {
                                reader.Read();

                                drugsList.Add(int.Parse(reader["Synthroid"].ToString()));
                                drugsList.Add(int.Parse(reader["Crestor"].ToString()));
                                drugsList.Add(int.Parse(reader["Nexium"].ToString()));
                                drugsList.Add(int.Parse(reader["VentolinHFA"].ToString()));
                                drugsList.Add(int.Parse(reader["AdvairDiskus"].ToString()));
                            }
                        }

                        commandString = "UPDATE Requisitions SET Processed = @isProcessed WHERE IssueDate = @date";
                        using (var command = new OleDbCommand(commandString, connection))
                        {
                            command.Parameters.AddWithValue("@isProcessed", true);
                            command.Parameters.AddWithValue("@date", DateTime.Parse(date).ToShortDateString());
                            command.ExecuteNonQuery();
                        }

                       Stock.AddToStock(drugsList.ToArray());
                    }

                    RequisitionsComboBox.Items.Remove(date);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("An error occured!" + Environment.NewLine + Environment.NewLine + exception.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CheckRequisitionsAvailability();
                RequisitionsComboBox.SelectedIndex = 0;
            }   
        }

        private void  CheckRequisitionsAvailability()
        {
            if (RequisitionsComboBox.Items.Count != 0) return;

            RequisitionsComboBox.Items.Add("No Unprocessed Requisitions Avalaible");
            RequisitionsComboBox.SelectedIndex = 0;
            RequisitionsComboBox.Enabled = false;
            ProcessButton.Enabled = false;
            ProcessAllButton.Enabled = false;
        }
    }
}

using System;
using System.Data.OleDb;
using System.Windows.Forms;
using MLDIS.Properties;

namespace MLDIS
{
    public partial class CreateTestReports : Form
    {
        public CreateTestReports()
        {
            InitializeComponent();
        }

        private void CreateTestReports_Load(object sender, EventArgs e)
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

                    var commandString = 
                        "INSERT INTO Tests (PatientID, FullName, TestName, TestReport, TestDate) " +
                        "Values (@PatientID, @FullName, @TestName, @TestReport, @TestDate)";

                    using (var command = new OleDbCommand(commandString, connection))
                    {
                        command.Parameters.AddWithValue("@PatientID",
                            PatientComboBox.SelectedItem.ToString().Split('-')[0].Trim());
                        command.Parameters.AddWithValue("@FullName",
                            PatientComboBox.SelectedItem.ToString().Split('-')[1].Trim());

                        command.Parameters.AddWithValue("@TestName", NameTextBox.Text);
                        command.Parameters.AddWithValue("@TestReport", ReportRichTextBox.Text);
                        command.Parameters.AddWithValue("@TestDate", DateTime.Today.ToShortDateString());

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Test Report created successfully.", "Success", MessageBoxButtons.OK,
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

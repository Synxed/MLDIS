using System;
using System.Data.OleDb;
using System.Text;
using System.Windows.Forms;
using MLDIS.Properties;

namespace MLDIS
{
    public partial class BillGeneration : Form
    {
        public BillGeneration()
        {
            InitializeComponent();
        }

        private void BillGeneration_Load(object sender, EventArgs e)
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
                        "INSERT INTO Bills (PatientID, FullName, BillDetails, TotalAmount, IssueDate) " +
                        "Values (@PatientID, @FullName, @BillDetails, @TotalAmount, @IssueDate)";

                    using (var command = new OleDbCommand(commandString, connection))
                    {
                        command.Parameters.AddWithValue("@PatientID",
                            PatientComboBox.SelectedItem.ToString().Split('-')[0].Trim());
                        command.Parameters.AddWithValue("@FullName",
                            PatientComboBox.SelectedItem.ToString().Split('-')[1].Trim());

                        command.Parameters.AddWithValue("@BillDetails", GetFullBillDetails());
                        command.Parameters.AddWithValue("@TotalAmount", TotalAmountNumericBox.Value);
                        command.Parameters.AddWithValue("@IssueDate", DateTime.Today.ToShortDateString());

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Bill created successfully.", "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show("An error occured!" + Environment.NewLine + Environment.NewLine + exception.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetFullBillDetails()
        {
            try
            {
                var bill = new StringBuilder();

                bill.AppendLine("Medical Bill");
                bill.AppendLine(new string('=', "Medical Bill".Length) + Environment.NewLine);


                using (var connection = new OleDbConnection(Resources.ConnectionString))
                {
                    connection.Open();

                    using (var command = new OleDbCommand("SELECT * FROM Patients WHERE PatientID = @id", connection))
                    {
                        command.Parameters.AddWithValue("@id",
                            PatientComboBox.SelectedItem.ToString().Split('-')[0].Trim());

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader != null && reader.Read())
                            {
                                bill.AppendLine("Patient ID: " + reader["PatientID"]);
                                bill.AppendLine("Full Name: " + reader["FullName"]);
                                bill.AppendLine("Sex: " + reader["Sex"]);
                                bill.AppendLine("Address:" + reader["Address"]);
                                bill.AppendLine("Date of Birth: " + reader["DateOfBirth"]);
                                bill.AppendLine("Mobile: " + reader["Mobile"] + Environment.NewLine);

                                bill.AppendLine("Details:" + Environment.NewLine + BillDetailsRichTextBox.Text +
                                                Environment.NewLine);
                                bill.AppendLine("Total Amount to Pay: " +
                                                string.Format("{0:C}", TotalAmountNumericBox.Value));
                            }
                        }
                    }
                }
                return bill.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show("An error occured!" + Environment.NewLine + Environment.NewLine + exception.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }
        }
    }
}
